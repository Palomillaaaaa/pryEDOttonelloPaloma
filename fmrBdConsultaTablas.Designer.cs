namespace PryEdBarberoB
{
    partial class fmrBdConsultaTablas
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
            this.cmbTablaBd.Location = new System.Drawing.Point(728, 592);
            this.cmbTablaBd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTablaBd.Name = "cmbTablaBd";
            this.cmbTablaBd.Size = new System.Drawing.Size(230, 28);
            this.cmbTablaBd.TabIndex = 7;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(991, 592);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(170, 35);
            this.btnListar.TabIndex = 6;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblTabla
            // 
            this.lblTabla.AutoSize = true;
            this.lblTabla.Location = new System.Drawing.Point(519, 604);
            this.lblTabla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(195, 20);
            this.lblTabla.TabIndex = 5;
            this.lblTabla.Text = "Tabla de la base de datos:";
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(137, 4);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 62;
            this.dgvDatos.Size = new System.Drawing.Size(1028, 560);
            this.dgvDatos.TabIndex = 4;
            // 
            // fmrBdConsultaTablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 630);
            this.Controls.Add(this.cmbTablaBd);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblTabla);
            this.Controls.Add(this.dgvDatos);
            this.Name = "fmrBdConsultaTablas";
            this.Text = "fmrBdConsultaTablas";
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