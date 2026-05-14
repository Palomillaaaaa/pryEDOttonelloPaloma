namespace PryEdBarberoB
{
    partial class frmPILA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPILA));
            this.grbListaYGrilla = new System.Windows.Forms.GroupBox();
            this.dgvPila = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trámite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstPila = new System.Windows.Forms.ListView();
            this.grbElementoEliminado = new System.Windows.Forms.GroupBox();
            this.lblDatoTramite = new System.Windows.Forms.Label();
            this.lblDatoNombre = new System.Windows.Forms.Label();
            this.lblDatoCodigo = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblTramiteE = new System.Windows.Forms.Label();
            this.lblNombreE = new System.Windows.Forms.Label();
            this.lblCodigoE = new System.Windows.Forms.Label();
            this.grbNuevoElemento = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pcbImagen = new System.Windows.Forms.PictureBox();
            this.grbListaYGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPila)).BeginInit();
            this.grbElementoEliminado.SuspendLayout();
            this.grbNuevoElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // grbListaYGrilla
            // 
            this.grbListaYGrilla.Controls.Add(this.dgvPila);
            this.grbListaYGrilla.Controls.Add(this.lstPila);
            this.grbListaYGrilla.Location = new System.Drawing.Point(159, 381);
            this.grbListaYGrilla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbListaYGrilla.Name = "grbListaYGrilla";
            this.grbListaYGrilla.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbListaYGrilla.Size = new System.Drawing.Size(876, 372);
            this.grbListaYGrilla.TabIndex = 12;
            this.grbListaYGrilla.TabStop = false;
            this.grbListaYGrilla.Text = "Listado en una Lista y una Grilla";
            // 
            // dgvPila
            // 
            this.dgvPila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nombre,
            this.Trámite});
            this.dgvPila.Location = new System.Drawing.Point(304, 29);
            this.dgvPila.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPila.Name = "dgvPila";
            this.dgvPila.RowHeadersWidth = 62;
            this.dgvPila.Size = new System.Drawing.Size(552, 334);
            this.dgvPila.TabIndex = 1;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.MinimumWidth = 8;
            this.Código.Name = "Código";
            this.Código.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // Trámite
            // 
            this.Trámite.HeaderText = "Trámite";
            this.Trámite.MinimumWidth = 8;
            this.Trámite.Name = "Trámite";
            this.Trámite.Width = 150;
            // 
            // lstPila
            // 
            this.lstPila.HideSelection = false;
            this.lstPila.Location = new System.Drawing.Point(9, 29);
            this.lstPila.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstPila.Name = "lstPila";
            this.lstPila.Size = new System.Drawing.Size(264, 332);
            this.lstPila.TabIndex = 0;
            this.lstPila.UseCompatibleStateImageBehavior = false;
            this.lstPila.SelectedIndexChanged += new System.EventHandler(this.lstPila_SelectedIndexChanged);
            // 
            // grbElementoEliminado
            // 
            this.grbElementoEliminado.Controls.Add(this.lblDatoTramite);
            this.grbElementoEliminado.Controls.Add(this.lblDatoNombre);
            this.grbElementoEliminado.Controls.Add(this.lblDatoCodigo);
            this.grbElementoEliminado.Controls.Add(this.btnEliminar);
            this.grbElementoEliminado.Controls.Add(this.lblTramiteE);
            this.grbElementoEliminado.Controls.Add(this.lblNombreE);
            this.grbElementoEliminado.Controls.Add(this.lblCodigoE);
            this.grbElementoEliminado.Location = new System.Drawing.Point(765, 59);
            this.grbElementoEliminado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbElementoEliminado.Name = "grbElementoEliminado";
            this.grbElementoEliminado.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbElementoEliminado.Size = new System.Drawing.Size(270, 298);
            this.grbElementoEliminado.TabIndex = 11;
            this.grbElementoEliminado.TabStop = false;
            this.grbElementoEliminado.Text = "Elemento Eliminado";
            // 
            // lblDatoTramite
            // 
            this.lblDatoTramite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDatoTramite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDatoTramite.Location = new System.Drawing.Point(86, 165);
            this.lblDatoTramite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatoTramite.Name = "lblDatoTramite";
            this.lblDatoTramite.Size = new System.Drawing.Size(165, 32);
            this.lblDatoTramite.TabIndex = 9;
            // 
            // lblDatoNombre
            // 
            this.lblDatoNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDatoNombre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDatoNombre.Location = new System.Drawing.Point(88, 114);
            this.lblDatoNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatoNombre.Name = "lblDatoNombre";
            this.lblDatoNombre.Size = new System.Drawing.Size(165, 32);
            this.lblDatoNombre.TabIndex = 8;
            // 
            // lblDatoCodigo
            // 
            this.lblDatoCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDatoCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDatoCodigo.Location = new System.Drawing.Point(122, 52);
            this.lblDatoCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatoCodigo.Name = "lblDatoCodigo";
            this.lblDatoCodigo.Size = new System.Drawing.Size(132, 32);
            this.lblDatoCodigo.TabIndex = 7;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(14, 222);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(240, 49);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblTramiteE
            // 
            this.lblTramiteE.AutoSize = true;
            this.lblTramiteE.Location = new System.Drawing.Point(9, 166);
            this.lblTramiteE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramiteE.Name = "lblTramiteE";
            this.lblTramiteE.Size = new System.Drawing.Size(66, 20);
            this.lblTramiteE.TabIndex = 2;
            this.lblTramiteE.Text = "Trámite:";
            // 
            // lblNombreE
            // 
            this.lblNombreE.AutoSize = true;
            this.lblNombreE.Location = new System.Drawing.Point(9, 114);
            this.lblNombreE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreE.Name = "lblNombreE";
            this.lblNombreE.Size = new System.Drawing.Size(69, 20);
            this.lblNombreE.TabIndex = 1;
            this.lblNombreE.Text = "Nombre:";
            // 
            // lblCodigoE
            // 
            this.lblCodigoE.AutoSize = true;
            this.lblCodigoE.Location = new System.Drawing.Point(9, 57);
            this.lblCodigoE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoE.Name = "lblCodigoE";
            this.lblCodigoE.Size = new System.Drawing.Size(63, 20);
            this.lblCodigoE.TabIndex = 0;
            this.lblCodigoE.Text = "Código:";
            // 
            // grbNuevoElemento
            // 
            this.grbNuevoElemento.Controls.Add(this.btnAgregar);
            this.grbNuevoElemento.Controls.Add(this.txtTramite);
            this.grbNuevoElemento.Controls.Add(this.txtNombre);
            this.grbNuevoElemento.Controls.Add(this.txtCodigo);
            this.grbNuevoElemento.Controls.Add(this.lblTramite);
            this.grbNuevoElemento.Controls.Add(this.lblNombre);
            this.grbNuevoElemento.Controls.Add(this.lblCodigo);
            this.grbNuevoElemento.Location = new System.Drawing.Point(450, 59);
            this.grbNuevoElemento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbNuevoElemento.Name = "grbNuevoElemento";
            this.grbNuevoElemento.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbNuevoElemento.Size = new System.Drawing.Size(270, 298);
            this.grbNuevoElemento.TabIndex = 10;
            this.grbNuevoElemento.TabStop = false;
            this.grbNuevoElemento.Text = "Nuevo Elemento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(14, 222);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(240, 49);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(86, 162);
            this.txtTramite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(166, 26);
            this.txtTramite.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(88, 105);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(163, 26);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(140, 49);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(112, 26);
            this.txtCodigo.TabIndex = 3;
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(9, 166);
            this.lblTramite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(66, 20);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Trámite:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(9, 114);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(9, 57);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(63, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // pcbImagen
            // 
            this.pcbImagen.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pcbImagen.ErrorImage")));
            this.pcbImagen.Image = ((System.Drawing.Image)(resources.GetObject("pcbImagen.Image")));
            this.pcbImagen.InitialImage = ((System.Drawing.Image)(resources.GetObject("pcbImagen.InitialImage")));
            this.pcbImagen.Location = new System.Drawing.Point(168, 59);
            this.pcbImagen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pcbImagen.Name = "pcbImagen";
            this.pcbImagen.Size = new System.Drawing.Size(266, 298);
            this.pcbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImagen.TabIndex = 13;
            this.pcbImagen.TabStop = false;
            // 
            // frmPILA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 834);
            this.Controls.Add(this.pcbImagen);
            this.Controls.Add(this.grbListaYGrilla);
            this.Controls.Add(this.grbElementoEliminado);
            this.Controls.Add(this.grbNuevoElemento);
            this.Name = "frmPILA";
            this.Text = "frmPILA";
            this.grbListaYGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPila)).EndInit();
            this.grbElementoEliminado.ResumeLayout(false);
            this.grbElementoEliminado.PerformLayout();
            this.grbNuevoElemento.ResumeLayout(false);
            this.grbNuevoElemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbImagen;
        private System.Windows.Forms.GroupBox grbListaYGrilla;
        private System.Windows.Forms.DataGridView dgvPila;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trámite;
        private System.Windows.Forms.ListView lstPila;
        private System.Windows.Forms.GroupBox grbElementoEliminado;
        private System.Windows.Forms.Label lblDatoTramite;
        private System.Windows.Forms.Label lblDatoNombre;
        private System.Windows.Forms.Label lblDatoCodigo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTramiteE;
        private System.Windows.Forms.Label lblNombreE;
        private System.Windows.Forms.Label lblCodigoE;
        private System.Windows.Forms.GroupBox grbNuevoElemento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
    }
}