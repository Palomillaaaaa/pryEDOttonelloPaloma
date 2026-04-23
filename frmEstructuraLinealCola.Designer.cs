namespace PryEdBarberoB
{
    partial class frmEstructuraLinealCola
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstructuraLinealCola));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.grbNuevoElemento = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.grbElementoEliminado = new System.Windows.Forms.GroupBox();
            this.lblDatoTramite = new System.Windows.Forms.Label();
            this.lblDatoNombre = new System.Windows.Forms.Label();
            this.lblDatoCodigo = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblTramiteE = new System.Windows.Forms.Label();
            this.lblNombreE = new System.Windows.Forms.Label();
            this.lblCodigoE = new System.Windows.Forms.Label();
            this.grbListaYGrilla = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trámite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listView1 = new System.Windows.Forms.ListView();
            this.pcbImagen = new System.Windows.Forms.PictureBox();
            this.grbNuevoElemento.SuspendLayout();
            this.grbElementoEliminado.SuspendLayout();
            this.grbListaYGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
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
            this.grbNuevoElemento.Location = new System.Drawing.Point(206, 32);
            this.grbNuevoElemento.Name = "grbNuevoElemento";
            this.grbNuevoElemento.Size = new System.Drawing.Size(180, 194);
            this.grbNuevoElemento.TabIndex = 0;
            this.grbNuevoElemento.TabStop = false;
            this.grbNuevoElemento.Text = "Nuevo Elemento";
            this.grbNuevoElemento.Enter += new System.EventHandler(this.grbNuevoElemento_Enter);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(9, 144);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(160, 32);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(57, 105);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(112, 20);
            this.txtTramite.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(59, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(110, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(93, 32);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(76, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(6, 108);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(45, 13);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Trámite:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 74);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 37);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
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
            this.grbElementoEliminado.Location = new System.Drawing.Point(416, 32);
            this.grbElementoEliminado.Name = "grbElementoEliminado";
            this.grbElementoEliminado.Size = new System.Drawing.Size(180, 194);
            this.grbElementoEliminado.TabIndex = 7;
            this.grbElementoEliminado.TabStop = false;
            this.grbElementoEliminado.Text = "Elemento Eliminado";
            // 
            // lblDatoTramite
            // 
            this.lblDatoTramite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDatoTramite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDatoTramite.Location = new System.Drawing.Point(57, 107);
            this.lblDatoTramite.Name = "lblDatoTramite";
            this.lblDatoTramite.Size = new System.Drawing.Size(110, 21);
            this.lblDatoTramite.TabIndex = 9;
            // 
            // lblDatoNombre
            // 
            this.lblDatoNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDatoNombre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDatoNombre.Location = new System.Drawing.Point(59, 74);
            this.lblDatoNombre.Name = "lblDatoNombre";
            this.lblDatoNombre.Size = new System.Drawing.Size(110, 21);
            this.lblDatoNombre.TabIndex = 8;
            // 
            // lblDatoCodigo
            // 
            this.lblDatoCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDatoCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDatoCodigo.Location = new System.Drawing.Point(81, 34);
            this.lblDatoCodigo.Name = "lblDatoCodigo";
            this.lblDatoCodigo.Size = new System.Drawing.Size(88, 21);
            this.lblDatoCodigo.TabIndex = 7;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(9, 144);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(160, 32);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblTramiteE
            // 
            this.lblTramiteE.AutoSize = true;
            this.lblTramiteE.Location = new System.Drawing.Point(6, 108);
            this.lblTramiteE.Name = "lblTramiteE";
            this.lblTramiteE.Size = new System.Drawing.Size(45, 13);
            this.lblTramiteE.TabIndex = 2;
            this.lblTramiteE.Text = "Trámite:";
            // 
            // lblNombreE
            // 
            this.lblNombreE.AutoSize = true;
            this.lblNombreE.Location = new System.Drawing.Point(6, 74);
            this.lblNombreE.Name = "lblNombreE";
            this.lblNombreE.Size = new System.Drawing.Size(47, 13);
            this.lblNombreE.TabIndex = 1;
            this.lblNombreE.Text = "Nombre:";
            // 
            // lblCodigoE
            // 
            this.lblCodigoE.AutoSize = true;
            this.lblCodigoE.Location = new System.Drawing.Point(6, 37);
            this.lblCodigoE.Name = "lblCodigoE";
            this.lblCodigoE.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoE.TabIndex = 0;
            this.lblCodigoE.Text = "Código:";
            // 
            // grbListaYGrilla
            // 
            this.grbListaYGrilla.Controls.Add(this.dataGridView1);
            this.grbListaYGrilla.Controls.Add(this.listView1);
            this.grbListaYGrilla.Location = new System.Drawing.Point(12, 241);
            this.grbListaYGrilla.Name = "grbListaYGrilla";
            this.grbListaYGrilla.Size = new System.Drawing.Size(584, 242);
            this.grbListaYGrilla.TabIndex = 8;
            this.grbListaYGrilla.TabStop = false;
            this.grbListaYGrilla.Text = "Listado en una Lista y una Grilla";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nombre,
            this.Trámite});
            this.dataGridView1.Location = new System.Drawing.Point(203, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(368, 217);
            this.dataGridView1.TabIndex = 1;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Trámite
            // 
            this.Trámite.HeaderText = "Trámite";
            this.Trámite.Name = "Trámite";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(177, 217);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // pcbImagen
            // 
            this.pcbImagen.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pcbImagen.ErrorImage")));
            this.pcbImagen.Image = global::PryEdBarberoB.Properties.Resources.b10;
            this.pcbImagen.InitialImage = ((System.Drawing.Image)(resources.GetObject("pcbImagen.InitialImage")));
            this.pcbImagen.Location = new System.Drawing.Point(18, 32);
            this.pcbImagen.Name = "pcbImagen";
            this.pcbImagen.Size = new System.Drawing.Size(177, 194);
            this.pcbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImagen.TabIndex = 9;
            this.pcbImagen.TabStop = false;
            this.pcbImagen.Click += new System.EventHandler(this.pcbImagen_Click);
            // 
            // frmEstructuraLinealCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 507);
            this.Controls.Add(this.pcbImagen);
            this.Controls.Add(this.grbListaYGrilla);
            this.Controls.Add(this.grbElementoEliminado);
            this.Controls.Add(this.grbNuevoElemento);
            this.Name = "frmEstructuraLinealCola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEstructuraLinealCola";
            this.grbNuevoElemento.ResumeLayout(false);
            this.grbNuevoElemento.PerformLayout();
            this.grbElementoEliminado.ResumeLayout(false);
            this.grbElementoEliminado.PerformLayout();
            this.grbListaYGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox grbNuevoElemento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox grbElementoEliminado;
        private System.Windows.Forms.Label lblDatoCodigo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTramiteE;
        private System.Windows.Forms.Label lblNombreE;
        private System.Windows.Forms.Label lblCodigoE;
        private System.Windows.Forms.Label lblDatoTramite;
        private System.Windows.Forms.Label lblDatoNombre;
        private System.Windows.Forms.GroupBox grbListaYGrilla;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trámite;
        private System.Windows.Forms.PictureBox pcbImagen;
    }
}