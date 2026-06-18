namespace PryEdBarberoB
{
    partial class frmBdConsultasSql
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
            this.dgvConsultaSQL = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.txtConsultaSQL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaSQL)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaSQL
            // 
            this.dgvConsultaSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaSQL.Location = new System.Drawing.Point(18, 315);
            this.dgvConsultaSQL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvConsultaSQL.Name = "dgvConsultaSQL";
            this.dgvConsultaSQL.RowHeadersWidth = 62;
            this.dgvConsultaSQL.Size = new System.Drawing.Size(1164, 358);
            this.dgvConsultaSQL.TabIndex = 7;
            this.dgvConsultaSQL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaSQL_CellContentClick);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(988, 274);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(194, 35);
            this.btnListar.TabIndex = 6;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // txtConsultaSQL
            // 
            this.txtConsultaSQL.Location = new System.Drawing.Point(18, 45);
            this.txtConsultaSQL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConsultaSQL.Multiline = true;
            this.txtConsultaSQL.Name = "txtConsultaSQL";
            this.txtConsultaSQL.Size = new System.Drawing.Size(1162, 218);
            this.txtConsultaSQL.TabIndex = 5;
            this.txtConsultaSQL.TextChanged += new System.EventHandler(this.txtConsultaSQL_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Consulta en SQL:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmBdConsultasSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.dgvConsultaSQL);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txtConsultaSQL);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBdConsultasSql";
            this.Text = "frmBdConsultasSql";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaSQL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaSQL;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox txtConsultaSQL;
        private System.Windows.Forms.Label label1;
    }
}