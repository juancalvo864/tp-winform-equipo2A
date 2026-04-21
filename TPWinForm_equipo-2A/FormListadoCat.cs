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
    public partial class FormListadoCat : Form
    {
        public FormListadoCat()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregarCat formAgregarCat = new FormAgregarCat();
            formAgregarCat.ShowDialog();
            Cargar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormListadoCat_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Cargar();
        }
        private void Cargar()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            dgvCategorias.DataSource = negocio.Listar();
            dgvCategorias.Columns["Id"].Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná una categoría primero.");
                return;
            }

            Categoria categoria = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro que querés eliminar la categoría?", "Eliminar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    negocio.eliminar(categoria.Id);
                    MessageBox.Show("Categoría eliminada correctamente.");
                    Cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
