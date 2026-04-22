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
    public partial class FormAgregarMarca : Form
    {
        private Marca marca = null;
        public FormAgregarMarca()
        {
            InitializeComponent();
        }

        public FormAgregarMarca(Marca marcaEditar)
        {
            InitializeComponent();
            marca = marcaEditar;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Para agregar ingrese una descripción.");
                    txtDescripcion.Clear();
                    txtDescripcion.Focus();
                    return;
                }

                if (marca == null)
                {                  
                    if (negocio.ExisteMarca(txtDescripcion.Text.Trim()))
                    {
                        MessageBox.Show("Ya existe una marca con ese nombre.");
                        txtDescripcion.Clear();
                        txtDescripcion.Focus();
                        return;
                    }

                    Marca nuevaMarca = new Marca();
                    nuevaMarca.Descripcion = txtDescripcion.Text.Trim();
                    negocio.Agregar(nuevaMarca);
                    MessageBox.Show("Marca agregada exitosamente.");
                    Close();
                }
                else
                {                 
                    if (negocio.ExisteMarca(txtDescripcion.Text.Trim())
                        && txtDescripcion.Text.Trim().ToUpper() != marca.Descripcion.ToUpper())
                    {
                        MessageBox.Show("Ya existe una marca con ese nombre.");
                        txtDescripcion.Clear();
                        txtDescripcion.Focus();
                        return;
                    }

                    DialogResult respuesta = MessageBox.Show("¿Desea editar la marca?", "Editando",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes)
                    {
                        marca.Descripcion = txtDescripcion.Text.Trim();
                        negocio.editar(marca);
                        MessageBox.Show("Marca editada exitosamente.");
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }

        }

        private void FormAgregarMarca_Load(object sender, EventArgs e)
        {
            if (marca != null)
            {
                Text = "Editar marca";
                btnAgregar.Text = "EDITAR";
                txtDescripcion.Text = marca.Descripcion;
            }
        }
    }
}
