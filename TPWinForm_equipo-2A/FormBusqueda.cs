using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_2A
{
    public partial class FormBusqueda : Form
    {
        public FormBusqueda()
        {
            InitializeComponent();
        }

        private void FormBusqueda_Load(object sender, EventArgs e)
        {
            CargarCombos();
            ConfigurarGrilla();
        }

        private void CargarCombos()
        {
            MarcaNegocio marcaNeg = new MarcaNegocio();
            List<Marca> marcas = marcaNeg.Listar();
            marcas.Insert(0, new Marca { Id = 0, Descripcion = "Todas" });
            cbMarca.DataSource = marcas;
            cbMarca.DisplayMember = "Descripcion";
            cbMarca.ValueMember = "Id";

            CategoriaNegocio catNeg = new CategoriaNegocio();
            List<Categoria> categorias = catNeg.Listar();
            categorias.Insert(0, new Categoria { Id = 0, Descripcion = "Todas" });
            cbCategoria.DataSource = categorias;
            cbCategoria.DisplayMember = "Descripcion";
            cbCategoria.ValueMember = "Id";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string texto = txtBuscar.Text;
                int? idMarca = (int)cbMarca.SelectedValue == 0 ? (int?)null : (int)cbMarca.SelectedValue;
                int? idCategoria = (int)cbCategoria.SelectedValue == 0 ? (int?)null : (int)cbCategoria.SelectedValue;

                ArticuloNegocio negocio = new ArticuloNegocio();
                List<Articulo> resultados = negocio.Buscar(texto, idMarca, idCategoria);

                if (resultados.Count == 0)
                {
                    MessageBox.Show("No se encontraron artículos con esos criterios.");
                }

                dgvResultados.DataSource = resultados;
                ConfigurarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            cbMarca.SelectedIndex = 0;
            cbCategoria.SelectedIndex = 0;
            dgvResultados.DataSource = null;
        }

        private void dgvResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Articulo seleccionado = (Articulo)dgvResultados.Rows[e.RowIndex].DataBoundItem;
                FormDetalleArt formDetalle = new FormDetalleArt(seleccionado);
                formDetalle.ShowDialog();
            }
        }

        private void ConfigurarGrilla()
        {
            dgvResultados.RowHeadersVisible = false;
            dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvResultados.Columns["Id"] != null)
                dgvResultados.Columns["Id"].Visible = false;

            if (dgvResultados.Columns["Imagen"] != null)
                dgvResultados.Columns["Imagen"].Visible = false;

            if (dgvResultados.Columns["Precio"] != null)
                dgvResultados.Columns["Precio"].DefaultCellStyle.Format = "0.##";
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

    }
}
