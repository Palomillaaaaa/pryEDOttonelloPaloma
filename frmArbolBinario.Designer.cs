namespace PryEdBarberoB
{
    partial class frmArbolBinario
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
            this.grbListaYGrilla = new System.Windows.Forms.GroupBox();
            this.rdbPostOrden = new System.Windows.Forms.RadioButton();
            this.rdbPreOrden = new System.Windows.Forms.RadioButton();
            this.rdbInOrden = new System.Windows.Forms.RadioButton();
            this.dgvListaDoble = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trámite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbElementoEliminado = new System.Windows.Forms.GroupBox();
            this.cmbListaDoble = new System.Windows.Forms.ComboBox();
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
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.trvArbol = new System.Windows.Forms.TreeView();
            this.grbListaYGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDoble)).BeginInit();
            this.grbElementoEliminado.SuspendLayout();
            this.grbNuevoElemento.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbListaYGrilla
            // 
            this.grbListaYGrilla.Controls.Add(this.rdbPostOrden);
            this.grbListaYGrilla.Controls.Add(this.rdbPreOrden);
            this.grbListaYGrilla.Controls.Add(this.rdbInOrden);
            this.grbListaYGrilla.Controls.Add(this.dgvListaDoble);
            this.grbListaYGrilla.Location = new System.Drawing.Point(162, 358);
            this.grbListaYGrilla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbListaYGrilla.Name = "grbListaYGrilla";
            this.grbListaYGrilla.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbListaYGrilla.Size = new System.Drawing.Size(1020, 372);
            this.grbListaYGrilla.TabIndex = 22;
            this.grbListaYGrilla.TabStop = false;
            this.grbListaYGrilla.Text = "Listado en una Lista y una Grilla";
            // 
            // rdbPostOrden
            // 
            this.rdbPostOrden.AutoSize = true;
            this.rdbPostOrden.Location = new System.Drawing.Point(32, 251);
            this.rdbPostOrden.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbPostOrden.Name = "rdbPostOrden";
            this.rdbPostOrden.Size = new System.Drawing.Size(115, 24);
            this.rdbPostOrden.TabIndex = 4;
            this.rdbPostOrden.TabStop = true;
            this.rdbPostOrden.Text = "Post-Orden";
            this.rdbPostOrden.UseVisualStyleBackColor = true;
            // 
            // rdbPreOrden
            // 
            this.rdbPreOrden.AutoSize = true;
            this.rdbPreOrden.Location = new System.Drawing.Point(32, 168);
            this.rdbPreOrden.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbPreOrden.Name = "rdbPreOrden";
            this.rdbPreOrden.Size = new System.Drawing.Size(107, 24);
            this.rdbPreOrden.TabIndex = 3;
            this.rdbPreOrden.TabStop = true;
            this.rdbPreOrden.Text = "Pre-Orden";
            this.rdbPreOrden.UseVisualStyleBackColor = true;
            // 
            // rdbInOrden
            // 
            this.rdbInOrden.AutoSize = true;
            this.rdbInOrden.Location = new System.Drawing.Point(32, 94);
            this.rdbInOrden.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbInOrden.Name = "rdbInOrden";
            this.rdbInOrden.Size = new System.Drawing.Size(97, 24);
            this.rdbInOrden.TabIndex = 2;
            this.rdbInOrden.TabStop = true;
            this.rdbInOrden.Text = "In-Orden";
            this.rdbInOrden.UseVisualStyleBackColor = true;
            // 
            // dgvListaDoble
            // 
            this.dgvListaDoble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDoble.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nombre,
            this.Trámite});
            this.dgvListaDoble.Location = new System.Drawing.Point(304, 29);
            this.dgvListaDoble.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvListaDoble.Name = "dgvListaDoble";
            this.dgvListaDoble.RowHeadersWidth = 62;
            this.dgvListaDoble.Size = new System.Drawing.Size(706, 334);
            this.dgvListaDoble.TabIndex = 1;
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
            // grbElementoEliminado
            // 
            this.grbElementoEliminado.Controls.Add(this.cmbListaDoble);
            this.grbElementoEliminado.Controls.Add(this.btnEliminar);
            this.grbElementoEliminado.Controls.Add(this.lblCodigoE);
            this.grbElementoEliminado.Location = new System.Drawing.Point(768, 0);
            this.grbElementoEliminado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbElementoEliminado.Name = "grbElementoEliminado";
            this.grbElementoEliminado.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbElementoEliminado.Size = new System.Drawing.Size(270, 186);
            this.grbElementoEliminado.TabIndex = 21;
            this.grbElementoEliminado.TabStop = false;
            this.grbElementoEliminado.Text = "Elemento Eliminado";
            // 
            // cmbListaDoble
            // 
            this.cmbListaDoble.FormattingEnabled = true;
            this.cmbListaDoble.Location = new System.Drawing.Point(80, 54);
            this.cmbListaDoble.Name = "cmbListaDoble";
            this.cmbListaDoble.Size = new System.Drawing.Size(170, 28);
            this.cmbListaDoble.TabIndex = 7;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(14, 114);
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
            this.grbNuevoElemento.Size = new System.Drawing.Size(270, 328);
            this.grbNuevoElemento.TabIndex = 20;
            this.grbNuevoElemento.TabStop = false;
            this.grbNuevoElemento.Text = "Nuevo Elemento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(14, 249);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(248, 49);
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
            // btnEquilibrar
            // 
            this.btnEquilibrar.Location = new System.Drawing.Point(768, 249);
            this.btnEquilibrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(270, 49);
            this.btnEquilibrar.TabIndex = 8;
            this.btnEquilibrar.Text = "Equilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            // 
            // trvArbol
            // 
            this.trvArbol.Location = new System.Drawing.Point(162, 14);
            this.trvArbol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trvArbol.Name = "trvArbol";
            this.trvArbol.Size = new System.Drawing.Size(259, 312);
            this.trvArbol.TabIndex = 5;
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 865);
            this.Controls.Add(this.trvArbol);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.grbListaYGrilla);
            this.Controls.Add(this.grbElementoEliminado);
            this.Controls.Add(this.grbNuevoElemento);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmArbolBinario";
            this.Text = "frmArbolBinario";
            this.Load += new System.EventHandler(this.frmArbolBinario_Load);
            this.grbListaYGrilla.ResumeLayout(false);
            this.grbListaYGrilla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDoble)).EndInit();
            this.grbElementoEliminado.ResumeLayout(false);
            this.grbElementoEliminado.PerformLayout();
            this.grbNuevoElemento.ResumeLayout(false);
            this.grbNuevoElemento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbListaYGrilla;
        private System.Windows.Forms.DataGridView dgvListaDoble;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trámite;
        private System.Windows.Forms.GroupBox grbElementoEliminado;
        private System.Windows.Forms.ComboBox cmbListaDoble;
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
        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.RadioButton rdbPostOrden;
        private System.Windows.Forms.RadioButton rdbPreOrden;
        private System.Windows.Forms.RadioButton rdbInOrden;
        private System.Windows.Forms.TreeView trvArbol;
    }
}