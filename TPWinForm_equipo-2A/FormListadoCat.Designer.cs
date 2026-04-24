namespace TPWinForm_equipo_2A
{
    partial class FormListadoCat
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
            this.lblCriterioCategoria = new System.Windows.Forms.Label();
            this.lblCampoCategoria = new System.Windows.Forms.Label();
            this.btnFiltrarCat = new System.Windows.Forms.Button();
            this.txtFiltrarCat = new System.Windows.Forms.TextBox();
            this.cboCriterioCat = new System.Windows.Forms.ComboBox();
            this.cboCampoCat = new System.Windows.Forms.ComboBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCriterioCategoria
            // 
            this.lblCriterioCategoria.AutoSize = true;
            this.lblCriterioCategoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterioCategoria.Location = new System.Drawing.Point(113, 318);
            this.lblCriterioCategoria.Name = "lblCriterioCategoria";
            this.lblCriterioCategoria.Size = new System.Drawing.Size(73, 25);
            this.lblCriterioCategoria.TabIndex = 46;
            this.lblCriterioCategoria.Text = "Criterio:";
            // 
            // lblCampoCategoria
            // 
            this.lblCampoCategoria.AutoSize = true;
            this.lblCampoCategoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampoCategoria.Location = new System.Drawing.Point(12, 318);
            this.lblCampoCategoria.Name = "lblCampoCategoria";
            this.lblCampoCategoria.Size = new System.Drawing.Size(74, 25);
            this.lblCampoCategoria.TabIndex = 45;
            this.lblCampoCategoria.Text = "Campo:";
            // 
            // btnFiltrarCat
            // 
            this.btnFiltrarCat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFiltrarCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrarCat.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFiltrarCat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnFiltrarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarCat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarCat.Location = new System.Drawing.Point(229, 327);
            this.btnFiltrarCat.Name = "btnFiltrarCat";
            this.btnFiltrarCat.Size = new System.Drawing.Size(135, 34);
            this.btnFiltrarCat.TabIndex = 44;
            this.btnFiltrarCat.Text = "BUSCAR";
            this.btnFiltrarCat.UseVisualStyleBackColor = false;
            this.btnFiltrarCat.Click += new System.EventHandler(this.btnFiltrarCat_Click);
            // 
            // txtFiltrarCat
            // 
            this.txtFiltrarCat.Location = new System.Drawing.Point(11, 376);
            this.txtFiltrarCat.Name = "txtFiltrarCat";
            this.txtFiltrarCat.Size = new System.Drawing.Size(204, 26);
            this.txtFiltrarCat.TabIndex = 43;
            // 
            // cboCriterioCat
            // 
            this.cboCriterioCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterioCat.FormattingEnabled = true;
            this.cboCriterioCat.Location = new System.Drawing.Point(118, 346);
            this.cboCriterioCat.Name = "cboCriterioCat";
            this.cboCriterioCat.Size = new System.Drawing.Size(97, 28);
            this.cboCriterioCat.TabIndex = 42;
            // 
            // cboCampoCat
            // 
            this.cboCampoCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampoCat.FormattingEnabled = true;
            this.cboCampoCat.Location = new System.Drawing.Point(11, 346);
            this.cboCampoCat.Name = "cboCampoCat";
            this.cboCampoCat.Size = new System.Drawing.Size(94, 28);
            this.cboCampoCat.TabIndex = 41;
            this.cboCampoCat.SelectedIndexChanged += new System.EventHandler(this.cboCampoCat_SelectedIndexChanged);
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
            this.btnRefrescar.Size = new System.Drawing.Size(135, 33);
            this.btnRefrescar.TabIndex = 39;
            this.btnRefrescar.Text = "REFRESCAR";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click_1);
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
            this.btnAgregar.Size = new System.Drawing.Size(135, 33);
            this.btnAgregar.TabIndex = 38;
            this.btnAgregar.Text = "AGREGAR";
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
            this.btnEliminar.Size = new System.Drawing.Size(135, 33);
            this.btnEliminar.TabIndex = 37;
            this.btnEliminar.Text = "ELIMINAR";
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
            this.btnEditar.Size = new System.Drawing.Size(135, 33);
            this.btnEditar.TabIndex = 36;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(11, 12);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.RowHeadersWidth = 62;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(204, 299);
            this.dgvCategorias.TabIndex = 35;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(229, 365);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(135, 34);
            this.btnSalir.TabIndex = 47;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormListadoCat
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(375, 407);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblCriterioCategoria);
            this.Controls.Add(this.lblCampoCategoria);
            this.Controls.Add(this.btnFiltrarCat);
            this.Controls.Add(this.txtFiltrarCat);
            this.Controls.Add(this.cboCriterioCat);
            this.Controls.Add(this.cboCampoCat);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvCategorias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormListadoCat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de categorías";
            this.Load += new System.EventHandler(this.FormListadoCat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCriterioCategoria;
        private System.Windows.Forms.Label lblCampoCategoria;
        private System.Windows.Forms.Button btnFiltrarCat;
        private System.Windows.Forms.TextBox txtFiltrarCat;
        private System.Windows.Forms.ComboBox cboCriterioCat;
        private System.Windows.Forms.ComboBox cboCampoCat;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Button btnSalir;
    }
}