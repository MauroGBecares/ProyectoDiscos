using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using NegocioDatos;

namespace ProyectoConConexionDB
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnMostrarResultado_Click(object sender, EventArgs e)
        {
            int edad, CantidadDiscos;
            string nombre, textoRecital, textoInstrumento, textoArtista, listaEstilos;
            DateTime fecHoy = DateTime.Now;
            DateTime fecNac = dtpFechaNacimiento.Value;
            //TextBoxNombre
            nombre = txtNombre.Text;
            //DateTimePicker
            edad = fecHoy.Year - fecNac.Year;
            if (fecHoy < fecNac.AddYears(edad))
                edad--;
            //ComboBox
            
            listaEstilos = cbxEstilo.SelectedItem.ToString();
            //CheckBox
            if (cbxRecital.Checked)
                textoRecital = "Fue a un recital";
            else
                textoRecital = "Nunca fue a un recital";
            //RadioButton
            if (rdbNinguno.Checked && txtOtros.Text == "")
                textoInstrumento = "No toca ningun instrumento";
            else if (rdbGuitarra.Checked && txtOtros.Text == "")
                textoInstrumento = "Utiliza la guitarra como instrumento";
            else if (rdbPiano.Checked && txtOtros.Text == "")
                textoInstrumento = "Utiliza el piano como instrumento";
            else if (rdbBateria.Checked && txtOtros.Text == "")
                textoInstrumento = "Utiliza la bateria como instrumento";
            else
                textoInstrumento = "El instrumento que utiliza es: " + txtOtros.Text;
            //TextBox Banda/Artista
            textoArtista = "Su Banda/Artista favorito es: " + txtArtista.Text;
            //NumericUpDown
            CantidadDiscos = (int)nupCantidadDiscos.Value;

            txtResultado.Lines = new string[]
            {
            "Nombre y Apellido: " + nombre,
            "Edad: " + edad,
            "Su estilo favorito es: " + listaEstilos,
            textoRecital,
            textoInstrumento,
            textoArtista,
            "La cantidad de disco que tiene del mismo es: " + CantidadDiscos.ToString()
            };
        }

        private void discosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDiscos ventana = new frmDiscos();
            ventana.ShowDialog();
        }

        private void txtOtros_TextChanged(object sender, EventArgs e)
        {
            rdbOtros.Checked = true;
            
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            DatosEstilos VEstilos = new DatosEstilos();
            try
            {
                cbxEstilo.DataSource = VEstilos.listarEstilos();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
