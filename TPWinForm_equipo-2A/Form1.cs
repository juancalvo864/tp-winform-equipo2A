using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_2A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void categoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarArtículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregarArt formAgregarArt = new FormAgregarArt();
            formAgregarArt.ShowDialog();
        }

        private void agregaMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregarMarca formAgregarMarca = new FormAgregarMarca();
            formAgregarMarca.ShowDialog();
        }

        private void agregarCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregarCat formAgregarCat = new FormAgregarCat();
            formAgregarCat.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/juancalvo864/tp-winform-equipo2A.git";

            Process.Start(url);
        }

        private void verListadoDeArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListadoArt formListadoArt = new FormListadoArt();
            formListadoArt.ShowDialog();
        }

        private void verListadoDeMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListadoMarcas formListadoMarcas = new FormListadoMarcas();
            formListadoMarcas.ShowDialog();
        }

        private void verListadoDeCategoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListadoCat formListadoCat = new FormListadoCat();
            formListadoCat.ShowDialog();
        }
    }
}
