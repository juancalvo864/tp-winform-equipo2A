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
        }

        private void Cargar()
        {
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
    }
}
