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
    public partial class FormListadoArt : Form
    {
        public FormListadoArt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregarArt formAgregarArt = new FormAgregarArt();
            formAgregarArt.ShowDialog();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            FormDetalleArt formDetalles = new FormDetalleArt();
            formDetalles.ShowDialog();
        }
    }
}
