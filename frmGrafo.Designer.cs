namespace PryEdBarberoB
{
    partial class frmGrafo
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

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
            this.grbListaYGrilla.Location = new System.Drawing.Point(132, 345);
            this.grbListaYGrilla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbListaYGrilla.Name = "grbListaYGrilla";
            this.grbListaYGrilla.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbListaYGrilla.Size = new System.Drawing.Size(1008, 412);
            this.grbListaYGrilla.TabIndex = 12;
            this.grbListaYGrilla.TabStop = false;
            this.grbListaYGrilla.Text = "Listar Viaje";
            // 
            // btnTodoViajes
            // 
            this.btnTodoViajes.Location = new System.Drawing.Point(816, 54);
            this.btnTodoViajes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTodoViajes.Name = "btnTodoViajes";
            this.btnTodoViajes.Size = new System.Drawing.Size(158, 38);
            this.btnTodoViajes.TabIndex = 12;
            this.btnTodoViajes.Text = "Ver todo los viajes";
            this.btnTodoViajes.UseVisualStyleBackColor = true;
            this.btnTodoViajes.Click += new System.EventHandler(this.btnTodoViajes_Click); // ✅
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(446, 63);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(52, 20);
            this.lblHasta.TabIndex = 9;
            this.lblHasta.Text = "Hasta";
            // 
            // btnListarDestinos
            // 
            this.btnListarDestinos.Location = new System.Drawing.Point(668, 54);
            this.btnListarDestinos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListarDestinos.Name = "btnListarDestinos";
            this.btnListarDestinos.Size = new System.Drawing.Size(140, 38);
            this.btnListarDestinos.TabIndex = 10;
            this.btnListarDestinos.Text = "Listar Destinos";
            this.btnListarDestinos.UseVisualStyleBackColor = true;
            this.btnListarDestinos.Click += new System.EventHandler(this.btnListarDestinos_Click); // ✅
            // 
            // cmbHasta
            // 
            this.cmbHasta.FormattingEnabled = true;
            this.cmbHasta.Location = new System.Drawing.Point(506, 57);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(152, 28);
            this.cmbHasta.TabIndex = 11;
            this.cmbHasta.SelectedIndexChanged += new System.EventHandler(this.cmbHasta_SelectedIndexChanged); // ✅
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(34, 63);
            this.lblDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(60, 20);
            this.lblDesde.TabIndex = 7;
            this.lblDesde.Text = "Desde:";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(266, 54);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(140, 38);
            this.btnListar.TabIndex = 7;
            this.btnListar.Text = "Listar Origenes";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click); // ✅
            // 
            // cmbListaSimple
            // 
            this.cmbListaSimple.FormattingEnabled = true;
            this.cmbListaSimple.Location = new System.Drawing.Point(104, 57);
            this.cmbListaSimple.Name = "cmbListaSimple";
            this.cmbListaSimple.Size = new System.Drawing.Size(152, 28);
            this.cmbListaSimple.TabIndex = 8;
            this.cmbListaSimple.SelectedIndexChanged += new System.EventHandler(this.cmbListaSimple_SelectedIndexChanged); // ✅
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
            this.dgvGrafo.Location = new System.Drawing.Point(12, 126);
            this.dgvGrafo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvGrafo.Name = "dgvGrafo";
            this.dgvGrafo.RowHeadersWidth = 62;
            this.dgvGrafo.Size = new System.Drawing.Size(962, 242);
            this.dgvGrafo.TabIndex = 1;
            // 
            // Código
            // 
            this.Código.HeaderText = "Origen";
            this.Código.MinimumWidth = 8;
            this.Código.Name = "Código";
            this.Código.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Córdoba";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // Trámite
            // 
            this.Trámite.HeaderText = "Mendoza";
            this.Trámite.MinimumWidth = 8;
            this.Trámite.Name = "Trámite";
            this.Trámite.Width = 150;
            // 
            // SantaFe
            // 
            this.SantaFe.HeaderText = "Santa Fe";
            this.SantaFe.MinimumWidth = 8;
            this.SantaFe.Name = "SantaFe";
            this.SantaFe.Width = 150;
            // 
            // BuenosAires
            // 
            this.BuenosAires.HeaderText = "Buenos Aires";
            this.BuenosAires.MinimumWidth = 8;
            this.BuenosAires.Name = "BuenosAires";
            this.BuenosAires.Width = 150;
            // 
            // Salta
            // 
            this.Salta.HeaderText = "Salta";
            this.Salta.MinimumWidth = 8;
            this.Salta.Name = "Salta";
            this.Salta.Width = 150;
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
            this.grbElementoEliminado.Location = new System.Drawing.Point(768, 0);
            this.grbElementoEliminado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbElementoEliminado.Name = "grbElementoEliminado";
            this.grbElementoEliminado.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbElementoEliminado.Size = new System.Drawing.Size(270, 298);
            this.grbElementoEliminado.TabIndex = 11;
            this.grbElementoEliminado.TabStop = false;
            this.grbElementoEliminado.Text = "Elemento Eliminado";
            // 
            // cmbDestino2
            // 
            this.cmbDestino2.FormattingEnabled = true;
            this.cmbDestino2.Location = new System.Drawing.Point(86, 105);
            this.cmbDestino2.Name = "cmbDestino2";
            this.cmbDestino2.Size = new System.Drawing.Size(166, 28);
            this.cmbDestino2.TabIndex = 24;
            this.cmbDestino2.SelectedIndexChanged += new System.EventHandler(this.cmbDestino2_SelectedIndexChanged); // ✅
            // 
            // cmbOrigen2
            // 
            this.cmbOrigen2.FormattingEnabled = true;
            this.cmbOrigen2.Location = new System.Drawing.Point(86, 48);
            this.cmbOrigen2.Name = "cmbOrigen2";
            this.cmbOrigen2.Size = new System.Drawing.Size(166, 28);
            this.cmbOrigen2.TabIndex = 23;
            this.cmbOrigen2.SelectedIndexChanged += new System.EventHandler(this.cmbOrigen2_SelectedIndexChanged); // ✅
            // 
            // txtPrecio2
            // 
            this.txtPrecio2.Location = new System.Drawing.Point(86, 157);
            this.txtPrecio2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecio2.Name = "txtPrecio2";
            this.txtPrecio2.Size = new System.Drawing.Size(166, 26);
            this.txtPrecio2.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Destino:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Origen";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(136, 222);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(124, 49);
            this.btnBorrar.TabIndex = 18;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click); // ✅ ya estaba
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(4, 222);
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(124, 49);
            this.btnConsulta.TabIndex = 17;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click); // ✅
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
            this.grbNuevoElemento.Location = new System.Drawing.Point(453, 0);
            this.grbNuevoElemento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbNuevoElemento.Name = "grbNuevoElemento";
            this.grbNuevoElemento.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbNuevoElemento.Size = new System.Drawing.Size(282, 298);
            this.grbNuevoElemento.TabIndex = 10;
            this.grbNuevoElemento.TabStop = false;
            this.grbNuevoElemento.Text = "Nuevo Elemento";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(146, 222);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(124, 49);
            this.btnCargar.TabIndex = 16;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click); // ✅ era button3_Click
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(86, 109);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(166, 28);
            this.cmbDestino.TabIndex = 15;
            this.cmbDestino.SelectedIndexChanged += new System.EventHandler(this.cmbDestino_SelectedIndexChanged); // ✅
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(86, 52);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(166, 28);
            this.cmbOrigen.TabIndex = 14;
            this.cmbOrigen.SelectedIndexChanged += new System.EventHandler(this.cmbOrigen_SelectedIndexChanged); // ✅ ya estaba
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.Location = new System.Drawing.Point(14, 222);
            this.btnBorrarTodo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(124, 49);
            this.btnBorrarTodo.TabIndex = 6;
            this.btnBorrarTodo.Text = "Borrar Todo";
            this.btnBorrarTodo.UseVisualStyleBackColor = true;
            this.btnBorrarTodo.Click += new System.EventHandler(this.btnBorrarTodo_Click); // ✅ era btnAgregar_Click
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(86, 162);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(166, 26);
            this.txtPrecio.TabIndex = 5;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged); // ✅
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress); // ✅
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(9, 166);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(57, 20);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(9, 114);
            this.lblDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(68, 20);
            this.lblDestino.TabIndex = 1;
            this.lblDestino.Text = "Destino:";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(9, 57);
            this.lblOrigen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(56, 20);
            this.lblOrigen.TabIndex = 0;
            this.lblOrigen.Text = "Origen";
            // 
            // pcbImagen
            // 
            this.pcbImagen.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pcbImagen.ErrorImage")));
            this.pcbImagen.Image = global::PryEdBarberoB.Properties.Resources.images;
            this.pcbImagen.InitialImage = ((System.Drawing.Image)(resources.GetObject("pcbImagen.InitialImage")));
            this.pcbImagen.Location = new System.Drawing.Point(171, 0);
            this.pcbImagen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pcbImagen.Name = "pcbImagen";
            this.pcbImagen.Size = new System.Drawing.Size(266, 298);
            this.pcbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImagen.TabIndex = 13;
            this.pcbImagen.TabStop = false;
            // 
            // frmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 818);
            this.Controls.Add(this.pcbImagen);
            this.Controls.Add(this.grbListaYGrilla);
            this.Controls.Add(this.grbElementoEliminado);
            this.Controls.Add(this.grbNuevoElemento);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmGrafo";
            this.Text = "frmGrafo";
            this.Load += new System.EventHandler(this.frmGrafo_Load); // ✅
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