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
            this.dvgCola = new System.Windows.Forms.DataGridView();
            this.grbElementoEliminado = new System.Windows.Forms.GroupBox();
            this.grbNuevoElemento = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.pcbImagen = new System.Windows.Forms.PictureBox();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trámite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SantaFe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuenosAires = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbListaSimple = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnTodoViajes = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grbListaYGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCola)).BeginInit();
            this.grbElementoEliminado.SuspendLayout();
            this.grbNuevoElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // grbListaYGrilla
            // 
            this.grbListaYGrilla.Controls.Add(this.btnTodoViajes);
            this.grbListaYGrilla.Controls.Add(this.lblHasta);
            this.grbListaYGrilla.Controls.Add(this.button2);
            this.grbListaYGrilla.Controls.Add(this.comboBox1);
            this.grbListaYGrilla.Controls.Add(this.lblDesde);
            this.grbListaYGrilla.Controls.Add(this.button1);
            this.grbListaYGrilla.Controls.Add(this.cmbListaSimple);
            this.grbListaYGrilla.Controls.Add(this.dvgCola);
            this.grbListaYGrilla.Location = new System.Drawing.Point(88, 224);
            this.grbListaYGrilla.Name = "grbListaYGrilla";
            this.grbListaYGrilla.Size = new System.Drawing.Size(672, 268);
            this.grbListaYGrilla.TabIndex = 12;
            this.grbListaYGrilla.TabStop = false;
            this.grbListaYGrilla.Text = "Listar Viaje";
            this.grbListaYGrilla.Enter += new System.EventHandler(this.grbListaYGrilla_Enter);
            // 
            // dvgCola
            // 
            this.dvgCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nombre,
            this.Trámite,
            this.SantaFe,
            this.BuenosAires,
            this.Salta});
            this.dvgCola.Location = new System.Drawing.Point(8, 82);
            this.dvgCola.Name = "dvgCola";
            this.dvgCola.Size = new System.Drawing.Size(641, 157);
            this.dvgCola.TabIndex = 1;
            // 
            // grbElementoEliminado
            // 
            this.grbElementoEliminado.Controls.Add(this.comboBox4);
            this.grbElementoEliminado.Controls.Add(this.comboBox5);
            this.grbElementoEliminado.Controls.Add(this.textBox1);
            this.grbElementoEliminado.Controls.Add(this.label1);
            this.grbElementoEliminado.Controls.Add(this.label2);
            this.grbElementoEliminado.Controls.Add(this.label3);
            this.grbElementoEliminado.Controls.Add(this.button4);
            this.grbElementoEliminado.Controls.Add(this.button5);
            this.grbElementoEliminado.Location = new System.Drawing.Point(512, 0);
            this.grbElementoEliminado.Name = "grbElementoEliminado";
            this.grbElementoEliminado.Size = new System.Drawing.Size(180, 194);
            this.grbElementoEliminado.TabIndex = 11;
            this.grbElementoEliminado.TabStop = false;
            this.grbElementoEliminado.Text = "Elemento Eliminado";
            // 
            // grbNuevoElemento
            // 
            this.grbNuevoElemento.Controls.Add(this.button3);
            this.grbNuevoElemento.Controls.Add(this.comboBox3);
            this.grbNuevoElemento.Controls.Add(this.comboBox2);
            this.grbNuevoElemento.Controls.Add(this.btnAgregar);
            this.grbNuevoElemento.Controls.Add(this.txtTramite);
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
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(9, 144);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(83, 32);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Borrar Todo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(57, 105);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(112, 20);
            this.txtTramite.TabIndex = 5;
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
            // cmbListaSimple
            // 
            this.cmbListaSimple.FormattingEnabled = true;
            this.cmbListaSimple.Location = new System.Drawing.Point(69, 37);
            this.cmbListaSimple.Margin = new System.Windows.Forms.Padding(2);
            this.cmbListaSimple.Name = "cmbListaSimple";
            this.cmbListaSimple.Size = new System.Drawing.Size(103, 21);
            this.cmbListaSimple.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "Listar Destinos";
            this.button1.UseVisualStyleBackColor = true;
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
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(297, 41);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(35, 13);
            this.lblHasta.TabIndex = 9;
            this.lblHasta.Text = "Hasta";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(445, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 25);
            this.button2.TabIndex = 10;
            this.button2.Text = "Listar Destinos";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(337, 37);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(103, 21);
            this.comboBox1.TabIndex = 11;
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
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(57, 34);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(112, 21);
            this.comboBox2.TabIndex = 14;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(57, 71);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(112, 21);
            this.comboBox3.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(97, 144);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 32);
            this.button3.TabIndex = 16;
            this.button3.Text = "Cargar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(91, 144);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 32);
            this.button4.TabIndex = 18;
            this.button4.Text = "Borrar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 144);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 32);
            this.button5.TabIndex = 17;
            this.button5.Text = "Consultar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(57, 68);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(112, 21);
            this.comboBox4.TabIndex = 24;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(57, 31);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(112, 21);
            this.comboBox5.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 20);
            this.textBox1.TabIndex = 22;
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
            ((System.ComponentModel.ISupportInitialize)(this.dvgCola)).EndInit();
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
        private System.Windows.Forms.DataGridView dvgCola;
        private System.Windows.Forms.GroupBox grbElementoEliminado;
        private System.Windows.Forms.GroupBox grbNuevoElemento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramite;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbListaSimple;
        private System.Windows.Forms.Button btnTodoViajes;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}