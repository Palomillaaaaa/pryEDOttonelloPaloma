namespace PryEdBarberoB
{
    partial class frmEstructuraListaDoble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstructuraListaDoble));
            this.pcbImagen = new System.Windows.Forms.PictureBox();
            this.grbListaYGrilla = new System.Windows.Forms.GroupBox();
            this.dvgCola = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trámite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstCola = new System.Windows.Forms.ListView();
            this.grbElementoEliminado = new System.Windows.Forms.GroupBox();
            this.lblDatoCodigo = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCodigoE = new System.Windows.Forms.Label();
            this.grbNuevoElemento = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.rbAscendente = new System.Windows.Forms.RadioButton();
            this.rbDescendente = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).BeginInit();
            this.grbListaYGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCola)).BeginInit();
            this.grbElementoEliminado.SuspendLayout();
            this.grbNuevoElemento.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbImagen
            // 
            this.pcbImagen.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pcbImagen.ErrorImage")));
            this.pcbImagen.Image = global::PryEdBarberoB.Properties.Resources.listadoble;
            this.pcbImagen.InitialImage = ((System.Drawing.Image)(resources.GetObject("pcbImagen.InitialImage")));
            this.pcbImagen.Location = new System.Drawing.Point(162, 0);
            this.pcbImagen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pcbImagen.Name = "pcbImagen";
            this.pcbImagen.Size = new System.Drawing.Size(274, 298);
            this.pcbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImagen.TabIndex = 17;
            this.pcbImagen.TabStop = false;
            // 
            // grbListaYGrilla
            // 
            this.grbListaYGrilla.Controls.Add(this.dvgCola);
            this.grbListaYGrilla.Controls.Add(this.lstCola);
            this.grbListaYGrilla.Location = new System.Drawing.Point(162, 322);
            this.grbListaYGrilla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbListaYGrilla.Name = "grbListaYGrilla";
            this.grbListaYGrilla.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbListaYGrilla.Size = new System.Drawing.Size(876, 372);
            this.grbListaYGrilla.TabIndex = 16;
            this.grbListaYGrilla.TabStop = false;
            this.grbListaYGrilla.Text = "Listado en una Lista y una Grilla";
            // 
            // dvgCola
            // 
            this.dvgCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nombre,
            this.Trámite});
            this.dvgCola.Location = new System.Drawing.Point(304, 29);
            this.dvgCola.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dvgCola.Name = "dvgCola";
            this.dvgCola.RowHeadersWidth = 62;
            this.dvgCola.Size = new System.Drawing.Size(552, 334);
            this.dvgCola.TabIndex = 1;
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
            // lstCola
            // 
            this.lstCola.HideSelection = false;
            this.lstCola.Location = new System.Drawing.Point(9, 29);
            this.lstCola.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(264, 332);
            this.lstCola.TabIndex = 0;
            this.lstCola.UseCompatibleStateImageBehavior = false;
            // 
            // grbElementoEliminado
            // 
            this.grbElementoEliminado.Controls.Add(this.lblDatoCodigo);
            this.grbElementoEliminado.Controls.Add(this.btnEliminar);
            this.grbElementoEliminado.Controls.Add(this.lblCodigoE);
            this.grbElementoEliminado.Location = new System.Drawing.Point(768, 0);
            this.grbElementoEliminado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbElementoEliminado.Name = "grbElementoEliminado";
            this.grbElementoEliminado.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbElementoEliminado.Size = new System.Drawing.Size(270, 186);
            this.grbElementoEliminado.TabIndex = 15;
            this.grbElementoEliminado.TabStop = false;
            this.grbElementoEliminado.Text = "Elemento Eliminado";
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
            this.btnEliminar.Location = new System.Drawing.Point(13, 114);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(240, 49);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
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
            this.grbNuevoElemento.Location = new System.Drawing.Point(453, 0);
            this.grbNuevoElemento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbNuevoElemento.Name = "grbNuevoElemento";
            this.grbNuevoElemento.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbNuevoElemento.Size = new System.Drawing.Size(270, 298);
            this.grbNuevoElemento.TabIndex = 14;
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
            // rbAscendente
            // 
            this.rbAscendente.AutoSize = true;
            this.rbAscendente.Location = new System.Drawing.Point(768, 222);
            this.rbAscendente.Name = "rbAscendente";
            this.rbAscendente.Size = new System.Drawing.Size(120, 24);
            this.rbAscendente.TabIndex = 8;
            this.rbAscendente.TabStop = true;
            this.rbAscendente.Text = "Ascendente";
            this.rbAscendente.UseVisualStyleBackColor = true;
            // 
            // rbDescendente
            // 
            this.rbDescendente.AutoSize = true;
            this.rbDescendente.Location = new System.Drawing.Point(768, 263);
            this.rbDescendente.Name = "rbDescendente";
            this.rbDescendente.Size = new System.Drawing.Size(130, 24);
            this.rbDescendente.TabIndex = 18;
            this.rbDescendente.TabStop = true;
            this.rbDescendente.Text = "Descendente";
            this.rbDescendente.UseVisualStyleBackColor = true;
            this.rbDescendente.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // frmEstructuraListaDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.rbDescendente);
            this.Controls.Add(this.rbAscendente);
            this.Controls.Add(this.pcbImagen);
            this.Controls.Add(this.grbListaYGrilla);
            this.Controls.Add(this.grbElementoEliminado);
            this.Controls.Add(this.grbNuevoElemento);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEstructuraListaDoble";
            this.Text = "frmEstructuraListaDoble";
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).EndInit();
            this.grbListaYGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCola)).EndInit();
            this.grbElementoEliminado.ResumeLayout(false);
            this.grbElementoEliminado.PerformLayout();
            this.grbNuevoElemento.ResumeLayout(false);
            this.grbNuevoElemento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbImagen;
        private System.Windows.Forms.GroupBox grbListaYGrilla;
        private System.Windows.Forms.DataGridView dvgCola;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trámite;
        private System.Windows.Forms.ListView lstCola;
        private System.Windows.Forms.GroupBox grbElementoEliminado;
        private System.Windows.Forms.Label lblDatoCodigo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCodigoE;
        private System.Windows.Forms.GroupBox grbNuevoElemento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.RadioButton rbAscendente;
        private System.Windows.Forms.RadioButton rbDescendente;
    }
}