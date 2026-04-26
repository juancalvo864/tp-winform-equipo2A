namespace TPWinForm_equipo_2A
{
    partial class FormListadoMarcas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListadoMarcas));
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblCriterioMarca = new System.Windows.Forms.Label();
            this.lblCampoMarca = new System.Windows.Forms.Label();
            this.btnFiltrarMarca = new System.Windows.Forms.Button();
            this.txtFiltrarMarca = new System.Windows.Forms.TextBox();
            this.cboCriterioMarca = new System.Windows.Forms.ComboBox();
            this.cboCampoMarca = new System.Windows.Forms.ComboBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(229, 364);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(135, 32);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "&SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblCriterioMarca
            // 
            this.lblCriterioMarca.AutoSize = true;
            this.lblCriterioMarca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterioMarca.Location = new System.Drawing.Point(118, 327);
            this.lblCriterioMarca.Name = "lblCriterioMarca";
            this.lblCriterioMarca.Size = new System.Drawing.Size(54, 17);
            this.lblCriterioMarca.TabIndex = 58;
            this.lblCriterioMarca.Text = "Criterio:";
            // 
            // lblCampoMarca
            // 
            this.lblCampoMarca.AutoSize = true;
            this.lblCampoMarca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampoMarca.Location = new System.Drawing.Point(11, 326);
            this.lblCampoMarca.Name = "lblCampoMarca";
            this.lblCampoMarca.Size = new System.Drawing.Size(53, 17);
            this.lblCampoMarca.TabIndex = 57;
            this.lblCampoMarca.Text = "Campo:";
            // 
            // btnFiltrarMarca
            // 
            this.btnFiltrarMarca.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFiltrarMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrarMarca.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFiltrarMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnFiltrarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarMarca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarMarca.Image = global::TPWinForm_equipo_2A.Properties.Resources.lupa;
            this.btnFiltrarMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrarMarca.Location = new System.Drawing.Point(229, 326);
            this.btnFiltrarMarca.Name = "btnFiltrarMarca";
            this.btnFiltrarMarca.Size = new System.Drawing.Size(135, 32);
            this.btnFiltrarMarca.TabIndex = 8;
            this.btnFiltrarMarca.Text = "&BUSCAR";
            this.btnFiltrarMarca.UseVisualStyleBackColor = false;
            this.btnFiltrarMarca.Click += new System.EventHandler(this.btnFiltrarMarca_Click);
            // 
            // txtFiltrarMarca
            // 
            this.txtFiltrarMarca.Location = new System.Drawing.Point(11, 376);
            this.txtFiltrarMarca.Name = "txtFiltrarMarca";
            this.txtFiltrarMarca.Size = new System.Drawing.Size(204, 20);
            this.txtFiltrarMarca.TabIndex = 7;
            // 
            // cboCriterioMarca
            // 
            this.cboCriterioMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterioMarca.FormattingEnabled = true;
            this.cboCriterioMarca.Location = new System.Drawing.Point(118, 346);
            this.cboCriterioMarca.Name = "cboCriterioMarca";
            this.cboCriterioMarca.Size = new System.Drawing.Size(97, 21);
            this.cboCriterioMarca.TabIndex = 6;
            // 
            // cboCampoMarca
            // 
            this.cboCampoMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampoMarca.FormattingEnabled = true;
            this.cboCampoMarca.Location = new System.Drawing.Point(11, 346);
            this.cboCampoMarca.Name = "cboCampoMarca";
            this.cboCampoMarca.Size = new System.Drawing.Size(94, 21);
            this.cboCampoMarca.TabIndex = 5;
            this.cboCampoMarca.SelectedIndexChanged += new System.EventHandler(this.cboCampoMarca_SelectedIndexChanged);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRefrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefrescar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRefrescar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.Location = new System.Drawing.Point(229, 126);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(135, 32);
            this.btnRefrescar.TabIndex = 4;
            this.btnRefrescar.Text = "&REFRESCAR";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(229, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(135, 32);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "&AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(229, 88);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(135, 32);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "&ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(229, 50);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(135, 32);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "EDI&TAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.AllowUserToResizeRows = false;
            this.dgvMarcas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Location = new System.Drawing.Point(11, 12);
            this.dgvMarcas.MultiSelect = false;
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.ReadOnly = true;
            this.dgvMarcas.RowHeadersWidth = 62;
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(204, 299);
            this.dgvMarcas.TabIndex = 0;
            // 
            // FormListadoMarcas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(375, 407);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblCriterioMarca);
            this.Controls.Add(this.lblCampoMarca);
            this.Controls.Add(this.btnFiltrarMarca);
            this.Controls.Add(this.txtFiltrarMarca);
            this.Controls.Add(this.cboCriterioMarca);
            this.Controls.Add(this.cboCampoMarca);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvMarcas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormListadoMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de marcas";
            this.Load += new System.EventHandler(this.FormListadoMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblCriterioMarca;
        private System.Windows.Forms.Label lblCampoMarca;
        private System.Windows.Forms.Button btnFiltrarMarca;
        private System.Windows.Forms.TextBox txtFiltrarMarca;
        private System.Windows.Forms.ComboBox cboCriterioMarca;
        private System.Windows.Forms.ComboBox cboCampoMarca;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvMarcas;
    }
}