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
        private List<string> rutasImagenesSeleccionadas = new List<string>();
        private int indiceImagenActual = 0;

        public FormAgregarArt()
        {
            InitializeComponent();
        }

        public FormAgregarArt(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Artículo";    
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
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
                
 
                if(articulo == null)
                {
                    articulo = new Articulo();

                }

                if (negocio.ExisteCodigo(txtCodArt.Text.Trim(), articulo.Id))
                {
                    MessageBox.Show("Ya existe un artículo con ese código.");
                    txtCodArt.Clear();
                    txtCodArt.Focus();
                    return;
                }

                articulo.Codigo = txtCodArt.Text.Trim();
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text; 
                articulo.Precio = precio;
                articulo.Marca = new Marca();
                articulo.Marca.Id = (int)cboxMarca.SelectedValue;
                articulo.Categoria = new Categoria();
                articulo.Categoria.Id = (int)cboxCategoria.SelectedValue;

                if(articulo.Id != 0)
                {
                    negocio.Modificar(articulo);
                    MessageBox.Show("Artículo modificado exitosamente.");
                }
                else
                {
                    int idArticulo = negocio.Agregar(articulo);
                    GuardarImagenesSeleccionadas(idArticulo);
                    MessageBox.Show("Artículo agregado exitosamente.");
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); 
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

                if(articulo != null)
                {
                    txtCodArt.Text = articulo.Codigo;   
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion; 
                    txtPrecio.Text = articulo.Precio.ToString("0.##");  
                    cboxMarca.SelectedValue = articulo.Marca.Id;  
                    cboxCategoria.SelectedValue = articulo.Categoria.Id;
               
                }
            
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Seleccionar imagenes del articulo";
                openFileDialog.Filter = "Imagenes|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Todos los archivos|*.*";
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    AgregarImagenesSeleccionadas(openFileDialog.FileNames);
                    indiceImagenActual = rutasImagenesSeleccionadas.Count - 1;
                    ActualizarTextoImagenes();
                    MostrarVistaPrevia(rutasImagenesSeleccionadas[indiceImagenActual]);
                    ActualizarBotonesImagen();
                }
            }
        }

        private void MostrarVistaPrevia(string rutaImagen)
        {
            try
            {
                if (pictureBoxImagen.Image != null)
                {
                    pictureBoxImagen.Image.Dispose();
                    pictureBoxImagen.Image = null;
                }

                using (Image imagen = Image.FromFile(rutaImagen))
                {
                    pictureBoxImagen.Image = new Bitmap(imagen);
                }
            }
            catch (Exception)
            {
                pictureBoxImagen.Image = TPWinForm_equipo_2A.Properties.Resources.placeholder;
            }
        }

        private void GuardarImagenesSeleccionadas(int idArticulo)
        {
            if (rutasImagenesSeleccionadas.Count == 0)
                return;

            string carpetaImagenes = ImagenesHelper.ObtenerCarpetaImagenes();
            Directory.CreateDirectory(carpetaImagenes);
            ImagenNegocio imagenNegocio = new ImagenNegocio();

            foreach (string rutaImagenSeleccionada in rutasImagenesSeleccionadas)
            {
                string extension = Path.GetExtension(rutaImagenSeleccionada);
                string nombreArchivo = LimpiarNombreArchivo(txtCodArt.Text.Trim()) + "_" + Guid.NewGuid().ToString("N") + extension;
                string rutaDestino = Path.Combine(carpetaImagenes, nombreArchivo);

                File.Copy(rutaImagenSeleccionada, rutaDestino);

                Imagen imagen = new Imagen();
                imagen.IdArticulo = idArticulo;
                imagen.ImagenUrl = nombreArchivo;
                imagenNegocio.Agregar(imagen);
            }
        }

        private string LimpiarNombreArchivo(string nombre)
        {
            foreach (char caracterInvalido in Path.GetInvalidFileNameChars())
            {
                nombre = nombre.Replace(caracterInvalido, '_');
            }

            return nombre;
        }

        private void btnPrevImagen_Click(object sender, EventArgs e)
        {
            if (rutasImagenesSeleccionadas.Count == 0) return;

            indiceImagenActual = (indiceImagenActual - 1 + rutasImagenesSeleccionadas.Count) % rutasImagenesSeleccionadas.Count;
            MostrarVistaPrevia(rutasImagenesSeleccionadas[indiceImagenActual]);
        }

        private void btnNextImagen_Click(object sender, EventArgs e)
        {
            if (rutasImagenesSeleccionadas.Count == 0) return;

            indiceImagenActual = (indiceImagenActual + 1) % rutasImagenesSeleccionadas.Count;
            MostrarVistaPrevia(rutasImagenesSeleccionadas[indiceImagenActual]);
        }

        private void ActualizarBotonesImagen()
        {
            bool hayVariasImagenes = rutasImagenesSeleccionadas.Count > 1;
            btnPrevImagen.Enabled = hayVariasImagenes;
            btnNextImagen.Enabled = hayVariasImagenes;
        }

        private void AgregarImagenesSeleccionadas(string[] rutasImagenes)
        {
            foreach (string rutaImagen in rutasImagenes)
            {
                if (!rutasImagenesSeleccionadas.Contains(rutaImagen))
                    rutasImagenesSeleccionadas.Add(rutaImagen);
            }
        }

        private void ActualizarTextoImagenes()
        {
            if (rutasImagenesSeleccionadas.Count == 0)
            {
                txtUrlImagen.Clear();
                return;
            }

            txtUrlImagen.Text = rutasImagenesSeleccionadas.Count == 1
                ? Path.GetFileName(rutasImagenesSeleccionadas[0])
                : rutasImagenesSeleccionadas.Count + " imagenes seleccionadas";
        }
    }
}
