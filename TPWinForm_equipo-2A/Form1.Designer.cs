namespace TPWinForm_equipo_2A
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MS1 = new System.Windows.Forms.MenuStrip();
            this.artículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarArtículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarArtículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verListadoDeArtículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregaMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verListadoDeMarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCategoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verListadoDeCategoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.MS1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MS1
            // 
            this.MS1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MS1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artículosToolStripMenuItem,
            this.marcasToolStripMenuItem,
            this.categoríasToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.MS1.Location = new System.Drawing.Point(0, 0);
            this.MS1.Name = "MS1";
            this.MS1.Size = new System.Drawing.Size(925, 24);
            this.MS1.TabIndex = 1;
            this.MS1.Text = "menuStrip1";
            // 
            // artículosToolStripMenuItem
            // 
            this.artículosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarArtículoToolStripMenuItem,
            this.buscarArtículoToolStripMenuItem,
            this.verListadoDeArtículosToolStripMenuItem});
            this.artículosToolStripMenuItem.Name = "artículosToolStripMenuItem";
            this.artículosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.artículosToolStripMenuItem.Text = "Artículos";
            // 
            // agregarArtículoToolStripMenuItem
            // 
            this.agregarArtículoToolStripMenuItem.Name = "agregarArtículoToolStripMenuItem";
            this.agregarArtículoToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.agregarArtículoToolStripMenuItem.Text = "Agregar artículo";
            this.agregarArtículoToolStripMenuItem.Click += new System.EventHandler(this.agregarArtículoToolStripMenuItem_Click);
            // 
            // buscarArtículoToolStripMenuItem
            // 
            this.buscarArtículoToolStripMenuItem.Name = "buscarArtículoToolStripMenuItem";
            this.buscarArtículoToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.buscarArtículoToolStripMenuItem.Text = "Buscar artículo";
            this.buscarArtículoToolStripMenuItem.Click += new System.EventHandler(this.buscarArtículoToolStripMenuItem_Click);
            // 
            // verListadoDeArtículosToolStripMenuItem
            // 
            this.verListadoDeArtículosToolStripMenuItem.Name = "verListadoDeArtículosToolStripMenuItem";
            this.verListadoDeArtículosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.verListadoDeArtículosToolStripMenuItem.Text = "Ver listado de artículos";
            this.verListadoDeArtículosToolStripMenuItem.Click += new System.EventHandler(this.verListadoDeArtículosToolStripMenuItem_Click);
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregaMarcaToolStripMenuItem,
            this.verListadoDeMarcasToolStripMenuItem});
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.marcasToolStripMenuItem.Text = "Marcas";
            // 
            // agregaMarcaToolStripMenuItem
            // 
            this.agregaMarcaToolStripMenuItem.Name = "agregaMarcaToolStripMenuItem";
            this.agregaMarcaToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.agregaMarcaToolStripMenuItem.Text = "Agrega marca";
            this.agregaMarcaToolStripMenuItem.Click += new System.EventHandler(this.agregaMarcaToolStripMenuItem_Click);
            // 
            // verListadoDeMarcasToolStripMenuItem
            // 
            this.verListadoDeMarcasToolStripMenuItem.Name = "verListadoDeMarcasToolStripMenuItem";
            this.verListadoDeMarcasToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.verListadoDeMarcasToolStripMenuItem.Text = "Ver listado de marcas";
            this.verListadoDeMarcasToolStripMenuItem.Click += new System.EventHandler(this.verListadoDeMarcasToolStripMenuItem_Click);
            // 
            // categoríasToolStripMenuItem
            // 
            this.categoríasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCategoríaToolStripMenuItem,
            this.verListadoDeCategoríasToolStripMenuItem});
            this.categoríasToolStripMenuItem.Name = "categoríasToolStripMenuItem";
            this.categoríasToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.categoríasToolStripMenuItem.Text = "Categorías";
            this.categoríasToolStripMenuItem.Click += new System.EventHandler(this.categoríasToolStripMenuItem_Click);
            // 
            // agregarCategoríaToolStripMenuItem
            // 
            this.agregarCategoríaToolStripMenuItem.Name = "agregarCategoríaToolStripMenuItem";
            this.agregarCategoríaToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.agregarCategoríaToolStripMenuItem.Text = "Agregar categoría";
            this.agregarCategoríaToolStripMenuItem.Click += new System.EventHandler(this.agregarCategoríaToolStripMenuItem_Click);
            // 
            // verListadoDeCategoríasToolStripMenuItem
            // 
            this.verListadoDeCategoríasToolStripMenuItem.Name = "verListadoDeCategoríasToolStripMenuItem";
            this.verListadoDeCategoríasToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.verListadoDeCategoríasToolStripMenuItem.Text = "Ver listado de categorías";
            this.verListadoDeCategoríasToolStripMenuItem.Click += new System.EventHandler(this.verListadoDeCategoríasToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(925, 521);
            this.Controls.Add(this.MS1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM";
            this.MS1.ResumeLayout(false);
            this.MS1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MS1;
        private System.Windows.Forms.ToolStripMenuItem artículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarArtículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarArtículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verListadoDeArtículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregaMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verListadoDeMarcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoríasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCategoríaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verListadoDeCategoríasToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

