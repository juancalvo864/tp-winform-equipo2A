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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.SS1 = new System.Windows.Forms.StatusStrip();
            this.tssl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSML1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.MS1.SuspendLayout();
            this.SS1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MS1
            // 
            this.MS1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(211)))));
            this.MS1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MS1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artículosToolStripMenuItem,
            this.marcasToolStripMenuItem,
            this.categoríasToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.MS1.Location = new System.Drawing.Point(0, 0);
            this.MS1.Name = "MS1";
            this.MS1.Size = new System.Drawing.Size(1040, 24);
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
            this.artículosToolStripMenuItem.Text = "&Artículos";
            // 
            // agregarArtículoToolStripMenuItem
            // 
            this.agregarArtículoToolStripMenuItem.Image = global::TPWinForm_equipo_2A.Properties.Resources.add;
            this.agregarArtículoToolStripMenuItem.Name = "agregarArtículoToolStripMenuItem";
            this.agregarArtículoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.agregarArtículoToolStripMenuItem.Size = new System.Drawing.Size(219, 30);
            this.agregarArtículoToolStripMenuItem.Text = "Agregar artículo";
            this.agregarArtículoToolStripMenuItem.Click += new System.EventHandler(this.agregarArtículoToolStripMenuItem_Click);
            // 
            // buscarArtículoToolStripMenuItem
            // 
            this.buscarArtículoToolStripMenuItem.Image = global::TPWinForm_equipo_2A.Properties.Resources.preview;
            this.buscarArtículoToolStripMenuItem.Name = "buscarArtículoToolStripMenuItem";
            this.buscarArtículoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.buscarArtículoToolStripMenuItem.Size = new System.Drawing.Size(219, 30);
            this.buscarArtículoToolStripMenuItem.Text = "Buscar artículo";
            this.buscarArtículoToolStripMenuItem.Click += new System.EventHandler(this.buscarArtículoToolStripMenuItem_Click);
            // 
            // verListadoDeArtículosToolStripMenuItem
            // 
            this.verListadoDeArtículosToolStripMenuItem.Image = global::TPWinForm_equipo_2A.Properties.Resources.data;
            this.verListadoDeArtículosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.verListadoDeArtículosToolStripMenuItem.Name = "verListadoDeArtículosToolStripMenuItem";
            this.verListadoDeArtículosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.verListadoDeArtículosToolStripMenuItem.Size = new System.Drawing.Size(219, 30);
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
            this.marcasToolStripMenuItem.Text = "&Marcas";
            // 
            // agregaMarcaToolStripMenuItem
            // 
            this.agregaMarcaToolStripMenuItem.Image = global::TPWinForm_equipo_2A.Properties.Resources.add;
            this.agregaMarcaToolStripMenuItem.Name = "agregaMarcaToolStripMenuItem";
            this.agregaMarcaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.agregaMarcaToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.agregaMarcaToolStripMenuItem.Text = "Agrega marca";
            this.agregaMarcaToolStripMenuItem.Click += new System.EventHandler(this.agregaMarcaToolStripMenuItem_Click);
            // 
            // verListadoDeMarcasToolStripMenuItem
            // 
            this.verListadoDeMarcasToolStripMenuItem.Image = global::TPWinForm_equipo_2A.Properties.Resources.data;
            this.verListadoDeMarcasToolStripMenuItem.Name = "verListadoDeMarcasToolStripMenuItem";
            this.verListadoDeMarcasToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.verListadoDeMarcasToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
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
            this.categoríasToolStripMenuItem.Text = "&Categorías";
            // 
            // agregarCategoríaToolStripMenuItem
            // 
            this.agregarCategoríaToolStripMenuItem.Image = global::TPWinForm_equipo_2A.Properties.Resources.add;
            this.agregarCategoríaToolStripMenuItem.Name = "agregarCategoríaToolStripMenuItem";
            this.agregarCategoríaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.agregarCategoríaToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.agregarCategoríaToolStripMenuItem.Text = "Agregar categoría";
            this.agregarCategoríaToolStripMenuItem.Click += new System.EventHandler(this.agregarCategoríaToolStripMenuItem_Click);
            // 
            // verListadoDeCategoríasToolStripMenuItem
            // 
            this.verListadoDeCategoríasToolStripMenuItem.Image = global::TPWinForm_equipo_2A.Properties.Resources.data;
            this.verListadoDeCategoríasToolStripMenuItem.Name = "verListadoDeCategoríasToolStripMenuItem";
            this.verListadoDeCategoríasToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.verListadoDeCategoríasToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.verListadoDeCategoríasToolStripMenuItem.Text = "Ver listado de categorías";
            this.verListadoDeCategoríasToolStripMenuItem.Click += new System.EventHandler(this.verListadoDeCategoríasToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "Abou&t";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // SS1
            // 
            this.SS1.BackColor = System.Drawing.SystemColors.Window;
            this.SS1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl1,
            this.TSML1,
            this.tsslFecha});
            this.SS1.Location = new System.Drawing.Point(0, 516);
            this.SS1.Name = "SS1";
            this.SS1.Size = new System.Drawing.Size(1040, 22);
            this.SS1.SizingGrip = false;
            this.SS1.Stretch = false;
            this.SS1.TabIndex = 2;
            this.SS1.Text = "statusStrip1";
            // 
            // tssl1
            // 
            this.tssl1.Name = "tssl1";
            this.tssl1.Size = new System.Drawing.Size(0, 17);
            // 
            // TSML1
            // 
            this.TSML1.Name = "TSML1";
            this.TSML1.Size = new System.Drawing.Size(82, 17);
            this.TSML1.Text = "Fecha y Hora: ";
            // 
            // tsslFecha
            // 
            this.tsslFecha.Name = "tsslFecha";
            this.tsslFecha.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(211)))));
            this.BackgroundImage = global::TPWinForm_equipo_2A.Properties.Resources.cube256;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1040, 538);
            this.Controls.Add(this.SS1);
            this.Controls.Add(this.MS1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM - Productos";
            this.MS1.ResumeLayout(false);
            this.MS1.PerformLayout();
            this.SS1.ResumeLayout(false);
            this.SS1.PerformLayout();
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
        private System.Windows.Forms.StatusStrip SS1;
        private System.Windows.Forms.ToolStripStatusLabel tssl1;
        private System.Windows.Forms.ToolStripStatusLabel TSML1;
        private System.Windows.Forms.ToolStripStatusLabel tsslFecha;
        private System.Windows.Forms.Timer timer;
    }
}

