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
    public partial class FormAgregarArt : Form
    {
        private Articulo articulo = null;
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
            Close();
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
    }
}
