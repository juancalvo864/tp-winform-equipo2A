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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregarArt formAgregarArt = new FormAgregarArt();
            if (formAgregarArt.ShowDialog() == DialogResult.OK)
                Cargar();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                FormDetalleArt formDetalles = new FormDetalleArt(seleccionado);
                formDetalles.ShowDialog();
            }
        }

        private void FormListadoArt_Load(object sender, EventArgs e)
        {
            Cargar();
            dgvArticulos.RowHeadersVisible = false;
            dgvArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "0.##";
            cbCampo.Items.Add("Nombre");
            cbCampo.Items.Add("Marca");
            cbCampo.Items.Add("Categoria");
            cbCampo.Items.Add("Precio");
        }

        private void Cargar()
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
                picbArtiuclos.Image = TPWinForm_equipo_2A.Properties.Resources.placeholder;
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
                else
                    picbArtiuclos.Image = TPWinForm_equipo_2A.Properties.Resources.placeholder;

                ActualizarVisibilidadBotones();
            }
        }


        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (urlsImagenes.Count == 0) return;
            indiceImagenActual = (indiceImagenActual - 1 + urlsImagenes.Count) % urlsImagenes.Count;
            CargarImagen(urlsImagenes[indiceImagenActual]);
            ActualizarVisibilidadBotones();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (urlsImagenes.Count == 0) return;

            indiceImagenActual = (indiceImagenActual + 1) % urlsImagenes.Count;
            CargarImagen(urlsImagenes[indiceImagenActual]);
            ActualizarVisibilidadBotones();
        }

        private void ActualizarVisibilidadBotones()
        {
            bool hayVariasImagenes = urlsImagenes.Count > 1;
            btnPrev.Enabled = hayVariasImagenes;
            btnNext.Enabled = hayVariasImagenes;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvArticulos.CurrentRow == null)
                {
                    MessageBox.Show("Seleccioná un artículo primero.");
                    return;
                }

                ArticuloNegocio negocio = new ArticuloNegocio();
                Articulo articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;    

                DialogResult respuesta = MessageBox.Show("¿Seguro que querés eliminar el artículo?","Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    negocio.Eliminar(articulo.Id);
                    MessageBox.Show("Artículo eliminado correctamente.");
                    Cargar(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Cargar(); 
        }

   
    }
}
