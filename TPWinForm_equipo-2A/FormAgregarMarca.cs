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
        public FormAgregarMarca()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Marca nuevaMarca = new Marca(); 
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

                if (negocio.ExisteMarca(txtDescripcion.Text.Trim()))
                {
                    MessageBox.Show("Ya existe una marca con ese código.");
                    txtDescripcion.Clear();
                    txtDescripcion.Focus();
                    return;
                }

                nuevaMarca.Descripcion = txtDescripcion.Text.Trim();

                negocio.Agregar(nuevaMarca);

                MessageBox.Show("Artículo agregado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); 
            }
            

        }   
    }
}
