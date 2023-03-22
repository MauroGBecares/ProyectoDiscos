using Dominio;
using NegocioDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace ProyectoConConexionDB
{
    public partial class AltaDisco : Form
    {
        private Discos disco = null;
        private OpenFileDialog archivo = null;
        public AltaDisco()
        {
            InitializeComponent();
        }
        public AltaDisco(Discos disco)
        {
            InitializeComponent();
            this.disco = disco;
            Text = "Modificar Disco";
        }

        private void AltaDisco_Load(object sender, EventArgs e)
        {
            DatosEdiciones datosEdiciones = new DatosEdiciones(); 
            DatosEstilos datosEstilos = new DatosEstilos();
            try
            {
                cboEstilo.DataSource = datosEstilos.listarEstilos();
                cboEstilo.ValueMember = "Id";
                cboEstilo.DisplayMember = "Descripcion";
                cboFormato.DataSource = datosEdiciones.listaEdiciones();
                cboFormato.ValueMember = "Id";
                cboFormato.DisplayMember = "Descripcion";
                if (disco != null)
                {
                    txtTitulo.Text = disco.Titulo;
                    dtpLanzamiento.Value = disco.FechaLanzamiento;
                    txtCantCanciones.Text = disco.CantidadCanciones.ToString();
                    txtUrlImagen.Text = disco.UrlImagen;
                    CargarImagen(disco.UrlImagen);
                    cboEstilo.SelectedValue = disco.Estilo.Id;
                    cboFormato.SelectedValue = disco.Formato.Id;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DatosDiscos discos = new DatosDiscos();

            try
            {
                if (disco == null)
                    disco = new Discos();

                DateTime fechaSeleccionada = dtpLanzamiento.Value;
                DateTime fechaSinHora = new DateTime(fechaSeleccionada.Year, fechaSeleccionada.Month, fechaSeleccionada.Day);

                disco.Titulo = txtTitulo.Text;
                disco.FechaLanzamiento = fechaSinHora;
                disco.CantidadCanciones = int.Parse(txtCantCanciones.Text);
                disco.UrlImagen = txtUrlImagen.Text;
                disco.Estilo = (Estilos)cboEstilo.SelectedItem;
                disco.Formato = (TiposEdicion)cboFormato.SelectedItem;
                if(disco.Id != 0)
                {
                    discos.ModificarDisco(disco);
                    MessageBox.Show("Disco modificado exitosamente !");
                }
                else
                {
                    discos.AgregarDisco(disco);
                    MessageBox.Show("Disco agregado exitosamente !");
                }
                if (archivo != null && !(txtUrlImagen.Text.ToUpper().Contains("HTTP")))
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
                
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            CargarImagen(disco.UrlImagen);
        }
        private void CargarImagen(string imagen)
        {
            try
            {
                pbxAltaImagen.Load(imagen);
            }
            catch (Exception)
            {
                pbxAltaImagen.Load("https://media.istockphoto.com/id/1147544807/vector/thumbnail-image-vector-graphic.jpg?s=612x612&w=0&k=20&c=rnCKVbdxqkjlcs3xH87-9gocETqpspHFXu5dIGB4wuM=");
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
                txtUrlImagen.Text = archivo.FileName;
            CargarImagen(archivo.FileName);
        }

        private void txtCantCanciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
