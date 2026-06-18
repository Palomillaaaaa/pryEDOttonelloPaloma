namespace PryEdBarberoB
{
    partial class frmBasedatoRepaso
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
            this.dgvOperacionesBD = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.cmbOperacionesBD = new System.Windows.Forms.ComboBox();
            this.lblOperacionesBD = new System.Windows.Forms.Label();
            this.lblOperaciones = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperacionesBD)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOperacionesBD
            // 
            this.dgvOperacionesBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperacionesBD.Location = new System.Drawing.Point(18, 228);
            this.dgvOperacionesBD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvOperacionesBD.Name = "dgvOperacionesBD";
            this.dgvOperacionesBD.RowHeadersWidth = 62;
            this.dgvOperacionesBD.Size = new System.Drawing.Size(970, 325);
            this.dgvOperacionesBD.TabIndex = 9;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(786, 12);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(202, 35);
            this.btnListar.TabIndex = 8;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // cmbOperacionesBD
            // 
            this.cmbOperacionesBD.FormattingEnabled = true;
            this.cmbOperacionesBD.Location = new System.Drawing.Point(392, 12);
            this.cmbOperacionesBD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbOperacionesBD.Name = "cmbOperacionesBD";
            this.cmbOperacionesBD.Size = new System.Drawing.Size(360, 28);
            this.cmbOperacionesBD.TabIndex = 7;
            // 
            // lblOperacionesBD
            // 
            this.lblOperacionesBD.BackColor = System.Drawing.SystemColors.Control;
            this.lblOperacionesBD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOperacionesBD.Location = new System.Drawing.Point(20, 69);
            this.lblOperacionesBD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOperacionesBD.Name = "lblOperacionesBD";
            this.lblOperacionesBD.Size = new System.Drawing.Size(969, 140);
            this.lblOperacionesBD.TabIndex = 6;
            // 
            // lblOperaciones
            // 
            this.lblOperaciones.AutoSize = true;
            this.lblOperaciones.Location = new System.Drawing.Point(32, 20);
            this.lblOperaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOperaciones.Name = "lblOperaciones";
            this.lblOperaciones.Size = new System.Drawing.Size(326, 20);
            this.lblOperaciones.TabIndex = 5;
            this.lblOperaciones.Text = "Operaciones a Realizar en la Base de Datos:";
            // 
            // frmBasedatoRepaso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 571);
            this.Controls.Add(this.dgvOperacionesBD);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.cmbOperacionesBD);
            this.Controls.Add(this.lblOperacionesBD);
            this.Controls.Add(this.lblOperaciones);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBasedatoRepaso";
            this.Text = "frmBasedatoRepaso";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperacionesBD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOperacionesBD;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ComboBox cmbOperacionesBD;
        private System.Windows.Forms.Label lblOperacionesBD;
        private System.Windows.Forms.Label lblOperaciones;
    }
}