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
    public partial class FormAgregarCat : Form
    {
        private Categoria categoria = null;
        public FormAgregarCat()
        {
            InitializeComponent();
        }

        public FormAgregarCat(Categoria categoriaEditar)
        {
            InitializeComponent();
            categoria = categoriaEditar;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                if (string.IsNullOrWhiteSpace(txtbCategoria.Text))
                {
                    MessageBox.Show("Ingrese una descripción.");
                    txtbCategoria.Focus();
                    return;
                }

                if (categoria == null)
                {
                    
                    if (negocio.ExisteCategoria(txtbCategoria.Text.Trim()))
                    {
                        MessageBox.Show("Ya existe una categoría con ese nombre.");
                        txtbCategoria.Clear();
                        txtbCategoria.Focus();
                        return;
                    }

                    Categoria nueva = new Categoria();
                    nueva.Descripcion = txtbCategoria.Text.Trim();
                    negocio.agregar(nueva);
                    MessageBox.Show("Categoría agregada exitosamente.");
                    Close();
                }
                else
                {
                    
                    if (negocio.ExisteCategoria(txtbCategoria.Text.Trim())
                        && txtbCategoria.Text.Trim().ToUpper() != categoria.Descripcion.ToUpper())
                    {
                        MessageBox.Show("Ya existe una categoría con ese nombre.");
                        txtbCategoria.Clear();
                        txtbCategoria.Focus();
                        return;
                    }

                    DialogResult respuesta = MessageBox.Show("¿Desea editar la categoría?", "Editando",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes)
                    {
                        categoria.Descripcion = txtbCategoria.Text.Trim();
                        negocio.editar(categoria);
                        MessageBox.Show("Categoría editada exitosamente.");
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void FormAgregarCat_Load(object sender, EventArgs e)
        {
            if (categoria != null)
            {
                Text = "Editar categoría";
                btnAgregar.Text = "EDITAR";
                txtbCategoria.Text = categoria.Descripcion;
            }
        }
    }
}
