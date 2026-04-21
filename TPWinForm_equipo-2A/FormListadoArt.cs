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
    public partial class FormListadoArt : Form
    {
        private List<Articulo> listaArticulos;
        List<String> urlsImagenes = new List<String>();

        int indiceImagenActual = 0;
        public FormListadoArt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregarArt formAgregarArt = new FormAgregarArt();
            formAgregarArt.ShowDialog();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            FormDetalleArt formDetalles = new FormDetalleArt();
            formDetalles.ShowDialog();
        }

        private void FormListadoArt_Load(object sender, EventArgs e)
        {
            cargar();
            dgvArticulos.RowHeadersVisible = false;
            dgvArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "0.##";
            cbCampo.Items.Add("Nombre");
            cbCampo.Items.Add("Marca");
            cbCampo.Items.Add("Categoria");
            cbCampo.Items.Add("Precio");
        }

        private void cargar()
        {
            ArticuloNegocio artNegocio = new ArticuloNegocio();
            listaArticulos = artNegocio.Listar();
            dgvArticulos.DataSource = listaArticulos;
            dgvArticulos.Columns["Imagen"].Visible = false;           
        }
        private void CargarImagen(string imagen)
        {
            try
            {
                picbArtiuclos.Load(imagen);
            }
            catch (Exception)
            {
                picbArtiuclos.Load("https://t4.ftcdn.net/jpg/06/57/37/01/360_F_657370150_pdNeG5pjI976ZasVbKN9VqH1rfoykdYU.jpg");
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                ImagenNegocio imagenNegocio = new ImagenNegocio();
                List<Imagen> imagenes = imagenNegocio.Listar(seleccionado.Id);

                urlsImagenes = imagenes.Select(i => i.ImagenUrl).ToList();
                indiceImagenActual = 0;

                if (urlsImagenes.Count > 0)
                    CargarImagen(urlsImagenes[0]);
            }
        }

        private List<string> ObtenerUrlsImagenesPorArticulo(int idArticulo)
        {
            List<string> urls = new List<string>();

            foreach (DataGridViewRow fila in dgvArticulos.Rows)
            {
                int id = Convert.ToInt32(fila.Cells["Id"].Value);
                string urlImagen = fila.Cells["Imagen"].Value.ToString();

                if (id == idArticulo && !string.IsNullOrEmpty(urlImagen))
                {
                    urls.Add(urlImagen);
                }
            }

            return urls;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
