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
            cboCampoCat.Items.Add("Descripcion");
            cboCampoCat.SelectedIndex = 0;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Cargar();
        }
        private void Cargar()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            dgvCategorias.DataSource = negocio.Listar();
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná una categoría primero.");
                return;
            }

            Categoria categoriaSeleccionada = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
            FormAgregarCat form = new FormAgregarCat(categoriaSeleccionada);
            form.ShowDialog();
            Cargar();
        }

        private void cboCampoCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampoCat.SelectedItem.ToString();
            if (opcion == "Numero")
            {
                cboCriterioCat.Items.Clear();
                cboCriterioCat.Items.Add("Mayor a");
                cboCriterioCat.Items.Add("Menor a");
                cboCriterioCat.Items.Add("Igual a");
            }
            else
            {
                cboCriterioCat.Items.Clear();
                cboCriterioCat.Items.Add("Comienza con");
                cboCriterioCat.Items.Add("Termina con");
                cboCriterioCat.Items.Add("Contiene");
            }

        }

        private void btnFiltrarCat_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                string campo = cboCampoCat.SelectedItem?.ToString();
                string criterio = cboCriterioCat.SelectedItem?.ToString();
                string filtro = txtFiltrarCat.Text.Trim();

                dgvCategorias.DataSource = negocio.Filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnRefrescar_Click_1(object sender, EventArgs e)
        {
            Cargar();

        }
    }
}
