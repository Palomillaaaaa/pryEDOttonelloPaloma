namespace PryEdBarberoB
{
    partial class frmConsultadeUna
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
            this.cmbTablaBd = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblTabla = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTablaBd
            // 
            this.cmbTablaBd.FormattingEnabled = true;
            this.cmbTablaBd.Items.AddRange(new object[] {
            "Autor",
            "Idioma",
            "Libro",
            "Pais"});
            this.cmbTablaBd.Location = new System.Drawing.Point(440, 405);
            this.cmbTablaBd.Name = "cmbTablaBd";
            this.cmbTablaBd.Size = new System.Drawing.Size(155, 21);
            this.cmbTablaBd.TabIndex = 7;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(615, 405);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(113, 23);
            this.btnListar.TabIndex = 6;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // lblTabla
            // 
            this.lblTabla.AutoSize = true;
            this.lblTabla.Location = new System.Drawing.Point(301, 413);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(133, 13);
            this.lblTabla.TabIndex = 5;
            this.lblTabla.Text = "Tabla de la base de datos:";
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(58, 23);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(685, 364);
            this.dgvDatos.TabIndex = 4;
            // 
            // frmConsultadeUna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbTablaBd);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblTabla);
            this.Controls.Add(this.dgvDatos);
            this.Name = "frmConsultadeUna";
            this.Text = "frmConsultadeUnaTabla";
            this.Load += new System.EventHandler(this.frmConsultadeUna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTablaBd;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblTabla;
        private System.Windows.Forms.DataGridView dgvDatos;
    }
}