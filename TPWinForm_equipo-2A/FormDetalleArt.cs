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
    public partial class FormDetalleArt : Form
    {
        private Articulo articulo = null;
        List<string> urlsImagenes = new List<string>();
        int indiceImagenActual = 0;
        public FormDetalleArt()
        {
            InitializeComponent();
        }

        public FormDetalleArt(Articulo seleccionado)
        {
            InitializeComponent();
            articulo = seleccionado;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormDetalleArt_Load(object sender, EventArgs e)
        {
            if (articulo != null)
            {
                lblCodArt2.Text = articulo.Codigo;
                lblNombre2.Text = articulo.Nombre;
                lblMarca2.Text = articulo.Marca.Descripcion;
                lblCategoria2.Text = articulo.Categoria.Descripcion;
                lblPrecio2.Text = articulo.Precio.ToString("0.##");
                lblDescripcion.Text = articulo.Descripcion;
                ImagenNegocio imagenNegocio = new ImagenNegocio();
                urlsImagenes = imagenNegocio.Listar(articulo.Id).Select(i => i.ImagenUrl).ToList();
                indiceImagenActual = 0;

                if (urlsImagenes.Count > 0)
                    CargarImagen(urlsImagenes[0]);
                else
                    pictureBox.Image = TPWinForm_equipo_2A.Properties.Resources.placeholder;

                ActualizarVisibilidadBotones();
            }
        }
        private void CargarImagen(string imagen)
        {
            try
            {
                pictureBox.Load(imagen);
            }
            catch (Exception)
            {
                pictureBox.Image = TPWinForm_equipo_2A.Properties.Resources.placeholder;
            }
        }

        private void ActualizarVisibilidadBotones()
        {
            bool hayVariasImagenes = urlsImagenes.Count > 1;
            btnPrev.Enabled = hayVariasImagenes;
            btnNext.Enabled = hayVariasImagenes;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (urlsImagenes.Count == 0) return;
            indiceImagenActual = (indiceImagenActual + 1) % urlsImagenes.Count;
            CargarImagen(urlsImagenes[indiceImagenActual]);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (urlsImagenes.Count == 0) return;
            indiceImagenActual = (indiceImagenActual - 1 + urlsImagenes.Count) % urlsImagenes.Count;
            CargarImagen(urlsImagenes[indiceImagenActual]);
        }
    }
}
