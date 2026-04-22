using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_2A
{
    public partial class FormAgregarArt : Form
    {
        private Articulo articulo = null;
        private string rutaImagenSeleccionada = "";

        public FormAgregarArt()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Articulo nuevoArt = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                decimal precio;

                if (string.IsNullOrWhiteSpace(txtCodArt.Text))
                {
                    MessageBox.Show("Para continuar ingrese un código.");
                    txtCodArt.Clear();
                    txtCodArt.Focus();
                    return;
                }

                if (!decimal.TryParse(txtPrecio.Text, out precio))
                {
                    MessageBox.Show("Ingresá un precio válido.");
                    txtPrecio.Clear();
                    txtPrecio.Focus();
                    return;
                }

                if (negocio.ExisteCodigo(txtCodArt.Text.Trim()))
                {
                    MessageBox.Show("Ya existe un artículo con ese código.");
                    txtCodArt.Clear();
                    txtCodArt.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(rutaImagenSeleccionada))
                {
                    MessageBox.Show("Por favor selecciona una imagen para el producto.");
                    return;
                }

                nuevoArt.Codigo = txtCodArt.Text.Trim();
                nuevoArt.Nombre = txtNombre.Text;
                nuevoArt.Descripcion = txtDescripcion.Text; 
                nuevoArt.Precio = precio;
                nuevoArt.Marca = new Marca();
                nuevoArt.Marca.Id = (int)cboxMarca.SelectedValue;
                nuevoArt.Categoria = new Categoria();
                nuevoArt.Categoria.Id = (int)cboxCategoria.SelectedValue;
                nuevoArt.Imagen = new Imagen();
                nuevoArt.Imagen.ImagenUrl = GuardarImagen(rutaImagenSeleccionada);

                negocio.Agregar(nuevoArt);  

                MessageBox.Show("Artículo agregado exitosamente.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); 
            }
        }

        private void FormAgregarArt_Load(object sender, EventArgs e)
        {
            MarcaNegocio marNeg = new MarcaNegocio();
            CategoriaNegocio catNeg = new CategoriaNegocio();

            try
            {

                cboxMarca.DataSource = marNeg.Listar();
                cboxMarca.ValueMember = "Id";
                cboxMarca.DisplayMember = "Descripcion";
                cboxMarca.SelectedIndex = -1;

                cboxCategoria.DataSource = catNeg.Listar();
                cboxCategoria.ValueMember = "Id";
                cboxCategoria.DisplayMember = "Descripcion";
                cboxCategoria.SelectedIndex = -1;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp|Todos los archivos|*.*";
                ofd.Title = "Selecciona una imagen para el producto";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    rutaImagenSeleccionada = ofd.FileName;
                    txtUrlImagen.Text = Path.GetFileName(ofd.FileName);
                    pictureBoxImagen.ImageLocation = ofd.FileName;
                }
            }
        }

        private string GuardarImagen(string rutaOrigen)
        {
            try
            {
                string carpetaImagenes = Path.Combine(Application.StartupPath, "Imagenes");
                if (!Directory.Exists(carpetaImagenes))
                {
                    Directory.CreateDirectory(carpetaImagenes);
                }

                string nombreImagen = Path.GetFileNameWithoutExtension(rutaOrigen) + "_" + DateTime.Now.Ticks + Path.GetExtension(rutaOrigen);
                string rutaDestino = Path.Combine(carpetaImagenes, nombreImagen);

                File.Copy(rutaOrigen, rutaDestino, true);

                return Path.Combine("Imagenes", nombreImagen);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar la imagen: " + ex.Message);
            }
        }
    }
}

