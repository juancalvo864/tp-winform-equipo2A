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
                dgvResultados.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }
    }
}
