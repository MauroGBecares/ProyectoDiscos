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
    public partial class frmDiscos : Form
    {
        private List<Discos> listaDiscos;
        public frmDiscos()
        {
            InitializeComponent();
        }

        private void frmDiscos_Load(object sender, EventArgs e)
        {
            cboFiltroAvanzado.Items.Add("Titulo");
            cboFiltroAvanzado.Items.Add("Fecha de lanzamiento");
            cboFiltroAvanzado.Items.Add("Cantidad de canciones");
            cboFiltroAvanzado.Items.Add("Estilo");
            cboFiltroAvanzado.Items.Add("Formato");
            dtpFiltroAvanzado.Visible = false;
            cargar();
        }
        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDiscos.CurrentRow != null)
            {
                Discos seleccionado = (Discos)dgvDiscos.CurrentRow.DataBoundItem;
                CargarImagen(seleccionado.UrlImagen);
            }
        }
        public void ocultarColumnas()
        {
            dgvDiscos.Columns["UrlImagen"].Visible = false;
            dgvDiscos.Columns["Id"].Visible = false;
        }
        public void CargarImagen(string imagen)
        {
            try
            {
                pbxDiscos.Load(imagen);
            }
            catch (Exception)
            {
                pbxDiscos.Load("https://media.istockphoto.com/id/1147544807/vector/thumbnail-image-vector-graphic.jpg?s=612x612&w=0&k=20&c=rnCKVbdxqkjlcs3xH87-9gocETqpspHFXu5dIGB4wuM=");
            }
        }
        public void cargar()
        {
            DatosDiscos dDiscos = new DatosDiscos();
            try
            {
                listaDiscos = dDiscos.listarDiscos();
                dgvDiscos.DataSource = listaDiscos;
                ocultarColumnas();
                CargarImagen(listaDiscos[0].UrlImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public bool ValidarFiltro()
        {
            if(cboFiltroAvanzado.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione que quiere filtrar", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (cboFiltroAvanzado.SelectedIndex == 2)
            {
                if (string.IsNullOrEmpty(txtFiltroAvanzado.Text))
                {
                    MessageBox.Show("Ingrese números por favor");
                    return true;
                }               
                if (!(SoloNumeros(txtFiltroAvanzado.Text)))
                {
                    MessageBox.Show("Ingrese solo números por favor");
                    return true;
                }
            }

            return false;
        }
        public bool SoloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if(!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }
        private void btnAgregarDisco_Click(object sender, EventArgs e)
        {
            AltaDisco window = new AltaDisco();
            window.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Discos seleccionado = (Discos)dgvDiscos.CurrentRow.DataBoundItem;
            AltaDisco altaDisco = new AltaDisco(seleccionado);
            altaDisco.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DatosDiscos disco = new DatosDiscos();
            Discos seleccionado;
            try
            {
                DialogResult resultado = MessageBox.Show("Seguro que quiere eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    seleccionado = (Discos)dgvDiscos.CurrentRow.DataBoundItem;
                    disco.Eliminar(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Discos> listaFiltrada;
            string filtro = txtFiltro.Text;

            if (filtro.Length > 2)
                listaFiltrada = listaDiscos.FindAll(x => x.Titulo.ToUpper().Contains(filtro.ToUpper()));
            else
                listaFiltrada = listaDiscos;

            dgvDiscos.DataSource = null;
            dgvDiscos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void cboFiltroAvanzado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboFiltroAvanzado.SelectedItem.ToString();
            if (opcion == "Fecha de lanzamiento")
            {
                dtpFiltroAvanzado.Visible = true;
                txtFiltroAvanzado.Visible = false;
            }
            else
            {
                txtFiltroAvanzado.Visible = true;
                dtpFiltroAvanzado.Visible = false;
            }
            
            
        }

        private void btnFiltroAvanzado_Click(object sender, EventArgs e)
        {
            DatosDiscos disco = new DatosDiscos();
            try
            {
                if (ValidarFiltro())
                    return;

                string filtro = txtFiltroAvanzado.Text;
                string seleccion = cboFiltroAvanzado.SelectedItem.ToString();
                string fecha = dtpFiltroAvanzado.Value.ToString("yyyy-MM-dd");
                dgvDiscos.DataSource = disco.FiltroAvanzado(filtro, seleccion, fecha);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
