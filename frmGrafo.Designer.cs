namespace PryEdBarberoB
{
    partial class frmGrafo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrafo));
            this.grbListaYGrilla = new System.Windows.Forms.GroupBox();
            this.btnTodoViajes = new System.Windows.Forms.Button();
            this.lblHasta = new System.Windows.Forms.Label();
            this.btnListarDestinos = new System.Windows.Forms.Button();
            this.cmbHasta = new System.Windows.Forms.ComboBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.cmbListaSimple = new System.Windows.Forms.ComboBox();
            this.dgvGrafo = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trámite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SantaFe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuenosAires = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbElementoEliminado = new System.Windows.Forms.GroupBox();
            this.cmbDestino2 = new System.Windows.Forms.ComboBox();
            this.cmbOrigen2 = new System.Windows.Forms.ComboBox();
            this.txtPrecio2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.grbNuevoElemento = new System.Windows.Forms.GroupBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.pcbImagen = new System.Windows.Forms.PictureBox();
            this.grbListaYGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafo)).BeginInit();
            this.grbElementoEliminado.SuspendLayout();
            this.grbNuevoElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // grbListaYGrilla
            // 
            this.grbListaYGrilla.Controls.Add(this.btnTodoViajes);
            this.grbListaYGrilla.Controls.Add(this.lblHasta);
            this.grbListaYGrilla.Controls.Add(this.btnListarDestinos);
            this.grbListaYGrilla.Controls.Add(this.cmbHasta);
            this.grbListaYGrilla.Controls.Add(this.lblDesde);
            this.grbListaYGrilla.Controls.Add(this.btnListar);
            this.grbListaYGrilla.Controls.Add(this.cmbListaSimple);
            this.grbListaYGrilla.Controls.Add(this.dgvGrafo);
            this.grbListaYGrilla.Location = new System.Drawing.Point(88, 224);
            this.grbListaYGrilla.Name = "grbListaYGrilla";
            this.grbListaYGrilla.Size = new System.Drawing.Size(672, 268);
            this.grbListaYGrilla.TabIndex = 12;
            this.grbListaYGrilla.TabStop = false;
            this.grbListaYGrilla.Text = "Listar Viaje";
            this.grbListaYGrilla.Enter += new System.EventHandler(this.grbListaYGrilla_Enter);
            // 
            // btnTodoViajes
            // 
            this.btnTodoViajes.Location = new System.Drawing.Point(544, 35);
            this.btnTodoViajes.Name = "btnTodoViajes";
            this.btnTodoViajes.Size = new System.Drawing.Size(105, 25);
            this.btnTodoViajes.TabIndex = 12;
            this.btnTodoViajes.Text = "Ver todo los viajes";
            this.btnTodoViajes.UseVisualStyleBackColor = true;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(297, 41);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(35, 13);
            this.lblHasta.TabIndex = 9;
            this.lblHasta.Text = "Hasta";
            // 
            // btnListarDestinos
            // 
            this.btnListarDestinos.Location = new System.Drawing.Point(445, 35);
            this.btnListarDestinos.Name = "btnListarDestinos";
            this.btnListarDestinos.Size = new System.Drawing.Size(93, 25);
            this.btnListarDestinos.TabIndex = 10;
            this.btnListarDestinos.Text = "Listar Destinos";
            this.btnListarDestinos.UseVisualStyleBackColor = true;
            // 
            // cmbHasta
            // 
            this.cmbHasta.FormattingEnabled = true;
            this.cmbHasta.Location = new System.Drawing.Point(337, 37);
            this.cmbHasta.Margin = new System.Windows.Forms.Padding(2);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(103, 21);
            this.cmbHasta.TabIndex = 11;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(23, 41);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 7;
            this.lblDesde.Text = "Desde:";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(177, 35);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(93, 25);
            this.btnListar.TabIndex = 7;
            this.btnListar.Text = "Listar Destinos";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // cmbListaSimple
            // 
            this.cmbListaSimple.FormattingEnabled = true;
            this.cmbListaSimple.Location = new System.Drawing.Point(69, 37);
            this.cmbListaSimple.Margin = new System.Windows.Forms.Padding(2);
            this.cmbListaSimple.Name = "cmbListaSimple";
            this.cmbListaSimple.Size = new System.Drawing.Size(103, 21);
            this.cmbListaSimple.TabIndex = 8;
            // 
            // dgvGrafo
            // 
            this.dgvGrafo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrafo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nombre,
            this.Trámite,
            this.SantaFe,
            this.BuenosAires,
            this.Salta});
            this.dgvGrafo.Location = new System.Drawing.Point(8, 82);
            this.dgvGrafo.Name = "dgvGrafo";
            this.dgvGrafo.Size = new System.Drawing.Size(641, 157);
            this.dgvGrafo.TabIndex = 1;
            // 
            // Código
            // 
            this.Código.HeaderText = "Origen";
            this.Código.Name = "Código";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Córdoba";
            this.Nombre.Name = "Nombre";
            // 
            // Trámite
            // 
            this.Trámite.HeaderText = "Mendoza";
            this.Trámite.Name = "Trámite";
            // 
            // SantaFe
            // 
            this.SantaFe.HeaderText = "Santa Fe";
            this.SantaFe.Name = "SantaFe";
            // 
            // BuenosAires
            // 
            this.BuenosAires.HeaderText = "Buenos Aires";
            this.BuenosAires.Name = "BuenosAires";
            // 
            // Salta
            // 
            this.Salta.HeaderText = "Salta";
            this.Salta.Name = "Salta";
            // 
            // grbElementoEliminado
            // 
            this.grbElementoEliminado.Controls.Add(this.cmbDestino2);
            this.grbElementoEliminado.Controls.Add(this.cmbOrigen2);
            this.grbElementoEliminado.Controls.Add(this.txtPrecio2);
            this.grbElementoEliminado.Controls.Add(this.label1);
            this.grbElementoEliminado.Controls.Add(this.label2);
            this.grbElementoEliminado.Controls.Add(this.label3);
            this.grbElementoEliminado.Controls.Add(this.btnBorrar);
            this.grbElementoEliminado.Controls.Add(this.btnConsulta);
            this.grbElementoEliminado.Location = new System.Drawing.Point(512, 0);
            this.grbElementoEliminado.Name = "grbElementoEliminado";
            this.grbElementoEliminado.Size = new System.Drawing.Size(180, 194);
            this.grbElementoEliminado.TabIndex = 11;
            this.grbElementoEliminado.TabStop = false;
            this.grbElementoEliminado.Text = "Elemento Eliminado";
            // 
            // cmbDestino2
            // 
            this.cmbDestino2.FormattingEnabled = true;
            this.cmbDestino2.Location = new System.Drawing.Point(57, 68);
            this.cmbDestino2.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDestino2.Name = "cmbDestino2";
            this.cmbDestino2.Size = new System.Drawing.Size(112, 21);
            this.cmbDestino2.TabIndex = 24;
            // 
            // cmbOrigen2
            // 
            this.cmbOrigen2.FormattingEnabled = true;
            this.cmbOrigen2.Location = new System.Drawing.Point(57, 31);
            this.cmbOrigen2.Margin = new System.Windows.Forms.Padding(2);
            this.cmbOrigen2.Name = "cmbOrigen2";
            this.cmbOrigen2.Size = new System.Drawing.Size(112, 21);
            this.cmbOrigen2.TabIndex = 23;
            // 
            // txtPrecio2
            // 
            this.txtPrecio2.Location = new System.Drawing.Point(57, 102);
            this.txtPrecio2.Name = "txtPrecio2";
            this.txtPrecio2.Size = new System.Drawing.Size(112, 20);
            this.txtPrecio2.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Destino:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Origen";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(91, 144);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(83, 32);
            this.btnBorrar.TabIndex = 18;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(3, 144);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(83, 32);
            this.btnConsulta.TabIndex = 17;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            // 
            // grbNuevoElemento
            // 
            this.grbNuevoElemento.Controls.Add(this.btnCargar);
            this.grbNuevoElemento.Controls.Add(this.cmbDestino);
            this.grbNuevoElemento.Controls.Add(this.cmbOrigen);
            this.grbNuevoElemento.Controls.Add(this.btnBorrarTodo);
            this.grbNuevoElemento.Controls.Add(this.txtPrecio);
            this.grbNuevoElemento.Controls.Add(this.lblPrecio);
            this.grbNuevoElemento.Controls.Add(this.lblDestino);
            this.grbNuevoElemento.Controls.Add(this.lblOrigen);
            this.grbNuevoElemento.Location = new System.Drawing.Point(302, 0);
            this.grbNuevoElemento.Name = "grbNuevoElemento";
            this.grbNuevoElemento.Size = new System.Drawing.Size(188, 194);
            this.grbNuevoElemento.TabIndex = 10;
            this.grbNuevoElemento.TabStop = false;
            this.grbNuevoElemento.Text = "Nuevo Elemento";
            this.grbNuevoElemento.Enter += new System.EventHandler(this.grbNuevoElemento_Enter);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(97, 144);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(83, 32);
            this.btnCargar.TabIndex = 16;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(57, 71);
            this.cmbDestino.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(112, 21);
            this.cmbDestino.TabIndex = 15;
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(57, 34);
            this.cmbOrigen.Margin = new System.Windows.Forms.Padding(2);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(112, 21);
            this.cmbOrigen.TabIndex = 14;
            this.cmbOrigen.SelectedIndexChanged += new System.EventHandler(this.cmbOrigen_SelectedIndexChanged);
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.Location = new System.Drawing.Point(9, 144);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(83, 32);
            this.btnBorrarTodo.TabIndex = 6;
            this.btnBorrarTodo.Text = "Borrar Todo";
            this.btnBorrarTodo.UseVisualStyleBackColor = true;
            this.btnBorrarTodo.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(57, 105);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(112, 20);
            this.txtPrecio.TabIndex = 5;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(6, 108);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(6, 74);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(46, 13);
            this.lblDestino.TabIndex = 1;
            this.lblDestino.Text = "Destino:";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(6, 37);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(38, 13);
            this.lblOrigen.TabIndex = 0;
            this.lblOrigen.Text = "Origen";
            // 
            // pcbImagen
            // 
            this.pcbImagen.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pcbImagen.ErrorImage")));
            this.pcbImagen.Image = global::PryEdBarberoB.Properties.Resources.images;
            this.pcbImagen.InitialImage = ((System.Drawing.Image)(resources.GetObject("pcbImagen.InitialImage")));
            this.pcbImagen.Location = new System.Drawing.Point(114, 0);
            this.pcbImagen.Name = "pcbImagen";
            this.pcbImagen.Size = new System.Drawing.Size(177, 194);
            this.pcbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImagen.TabIndex = 13;
            this.pcbImagen.TabStop = false;
            // 
            // frmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.pcbImagen);
            this.Controls.Add(this.grbListaYGrilla);
            this.Controls.Add(this.grbElementoEliminado);
            this.Controls.Add(this.grbNuevoElemento);
            this.Name = "frmGrafo";
            this.Text = "frmGrafo";
            this.grbListaYGrilla.ResumeLayout(false);
            this.grbListaYGrilla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafo)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvGrafo;
        private System.Windows.Forms.GroupBox grbElementoEliminado;
        private System.Windows.Forms.GroupBox grbNuevoElemento;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trámite;
        private System.Windows.Forms.DataGridViewTextBoxColumn SantaFe;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuenosAires;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ComboBox cmbListaSimple;
        private System.Windows.Forms.Button btnTodoViajes;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Button btnListarDestinos;
        private System.Windows.Forms.ComboBox cmbHasta;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.ComboBox cmbDestino2;
        private System.Windows.Forms.ComboBox cmbOrigen2;
        private System.Windows.Forms.TextBox txtPrecio2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}