namespace PryEdBarberoB
{
    partial class frmDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatos));
            this.lblNombre = new System.Windows.Forms.Label();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pcbPaloma = new System.Windows.Forms.PictureBox();
            this.btnPagina = new System.Windows.Forms.Button();
            this.btnCONTACTO = new System.Windows.Forms.Button();
            this.grbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPaloma)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblNombre.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(34, 223);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(339, 46);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Paloma Ottonello";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.btnCONTACTO);
            this.grbDatos.Controls.Add(this.btnPagina);
            this.grbDatos.Controls.Add(this.pcbPaloma);
            this.grbDatos.Controls.Add(this.lblDescripcion);
            this.grbDatos.Controls.Add(this.lblNombre);
            this.grbDatos.Location = new System.Drawing.Point(213, 30);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(382, 422);
            this.grbDatos.TabIndex = 1;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos de la Programadora";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(102, 269);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(196, 20);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Junior Software Developer";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pcbPaloma
            // 
            this.pcbPaloma.Image = global::PryEdBarberoB.Properties.Resources.Diseño_sin_título;
            this.pcbPaloma.InitialImage = ((System.Drawing.Image)(resources.GetObject("pcbPaloma.InitialImage")));
            this.pcbPaloma.Location = new System.Drawing.Point(62, 25);
            this.pcbPaloma.Name = "pcbPaloma";
            this.pcbPaloma.Size = new System.Drawing.Size(271, 202);
            this.pcbPaloma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbPaloma.TabIndex = 2;
            this.pcbPaloma.TabStop = false;
            this.pcbPaloma.Click += new System.EventHandler(this.pcbPaloma_Click_1);
            // 
            // btnPagina
            // 
            this.btnPagina.Location = new System.Drawing.Point(42, 327);
            this.btnPagina.Name = "btnPagina";
            this.btnPagina.Size = new System.Drawing.Size(133, 45);
            this.btnPagina.TabIndex = 3;
            this.btnPagina.Text = "Volver al Inicio";
            this.btnPagina.UseVisualStyleBackColor = true;
            this.btnPagina.Click += new System.EventHandler(this.btnPagina_Click);
            // 
            // btnCONTACTO
            // 
            this.btnCONTACTO.Location = new System.Drawing.Point(200, 327);
            this.btnCONTACTO.Name = "btnCONTACTO";
            this.btnCONTACTO.Size = new System.Drawing.Size(133, 45);
            this.btnCONTACTO.TabIndex = 4;
            this.btnCONTACTO.Text = "Contactar";
            this.btnCONTACTO.UseVisualStyleBackColor = true;
            // 
            // frmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbDatos);
            this.Name = "frmDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDatos";
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPaloma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.PictureBox pcbPaloma;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnCONTACTO;
        private System.Windows.Forms.Button btnPagina;
    }
}