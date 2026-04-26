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
    public partial class FormListadoMarcas : Form
    {
        public FormListadoMarcas()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregarMarca formAgregarMarca = new FormAgregarMarca();
            formAgregarMarca.ShowDialog();
            Cargar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormListadoMarcas_Load(object sender, EventArgs e)
        {
            Cargar();
            cboCampoMarca.Items.Add("Descripcion");
            cboCampoMarca.SelectedIndex = 0;

        }

        private void Cargar()
        {
            dgvMarcas.RowHeadersVisible = false;
            MarcaNegocio negocio = new MarcaNegocio();
            dgvMarcas.DataSource = negocio.Listar();
            dgvMarcas.Columns["Id"].Visible = false;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.CurrentRow != null)
            {
                Marca marcaSeleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                FormAgregarMarca form = new FormAgregarMarca(marcaSeleccionada);
                form.ShowDialog();
                Cargar();
            }
            else
            {
                MessageBox.Show("Seleccione una marca para editar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná una marca primero.");
                return;
            }

            Marca marca = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro que querés eliminar la marca?", "Eliminar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    negocio.eliminar(marca.Id);
                    MessageBox.Show("Marca eliminada correctamente.");
                    Cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboCampoMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampoMarca.SelectedItem.ToString();
            if (opcion == "Numero")
            {
                cboCriterioMarca.Items.Clear();
                cboCriterioMarca.Items.Add("Mayor a");
                cboCriterioMarca.Items.Add("Menor a");
                cboCriterioMarca.Items.Add("Igual a");
            }
            else
            {
                cboCriterioMarca.Items.Clear();
                cboCriterioMarca.Items.Add("Comienza con");
                cboCriterioMarca.Items.Add("Termina con");
                cboCriterioMarca.Items.Add("Contiene");
            }
        }

        private void btnFiltrarMarca_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                string campo = cboCampoMarca.SelectedItem?.ToString();
                string criterio = cboCriterioMarca.SelectedItem?.ToString();
                string filtro = txtFiltrarMarca.Text.Trim();

                dgvMarcas.DataSource = negocio.Filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
