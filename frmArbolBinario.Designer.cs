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
            this.rdbInOrden = new System.Windows.Forms.RadioButton();
            this.rdbPreOrden = new System.Windows.Forms.RadioButton();
            this.rdbPostOrden = new System.Windows.Forms.RadioButton();
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
            this.grbListaYGrilla.Location = new System.Drawing.Point(108, 233);
            this.grbListaYGrilla.Name = "grbListaYGrilla";
            this.grbListaYGrilla.Size = new System.Drawing.Size(680, 242);
            this.grbListaYGrilla.TabIndex = 22;
            this.grbListaYGrilla.TabStop = false;
            this.grbListaYGrilla.Text = "Listado en una Lista y una Grilla";
            // 
            // dgvListaDoble
            // 
            this.dgvListaDoble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDoble.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nombre,
            this.Trámite});
            this.dgvListaDoble.Location = new System.Drawing.Point(203, 19);
            this.dgvListaDoble.Name = "dgvListaDoble";
            this.dgvListaDoble.RowHeadersWidth = 62;
            this.dgvListaDoble.Size = new System.Drawing.Size(471, 217);
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
            this.grbElementoEliminado.Location = new System.Drawing.Point(512, 0);
            this.grbElementoEliminado.Name = "grbElementoEliminado";
            this.grbElementoEliminado.Size = new System.Drawing.Size(180, 121);
            this.grbElementoEliminado.TabIndex = 21;
            this.grbElementoEliminado.TabStop = false;
            this.grbElementoEliminado.Text = "Elemento Eliminado";
            // 
            // cmbListaDoble
            // 
            this.cmbListaDoble.FormattingEnabled = true;
            this.cmbListaDoble.Location = new System.Drawing.Point(53, 35);
            this.cmbListaDoble.Margin = new System.Windows.Forms.Padding(2);
            this.cmbListaDoble.Name = "cmbListaDoble";
            this.cmbListaDoble.Size = new System.Drawing.Size(115, 21);
            this.cmbListaDoble.TabIndex = 7;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(9, 74);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(160, 32);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
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
            // grbNuevoElemento
            // 
            this.grbNuevoElemento.Controls.Add(this.btnAgregar);
            this.grbNuevoElemento.Controls.Add(this.txtTramite);
            this.grbNuevoElemento.Controls.Add(this.txtNombre);
            this.grbNuevoElemento.Controls.Add(this.txtCodigo);
            this.grbNuevoElemento.Controls.Add(this.lblTramite);
            this.grbNuevoElemento.Controls.Add(this.lblNombre);
            this.grbNuevoElemento.Controls.Add(this.lblCodigo);
            this.grbNuevoElemento.Location = new System.Drawing.Point(302, 0);
            this.grbNuevoElemento.Name = "grbNuevoElemento";
            this.grbNuevoElemento.Size = new System.Drawing.Size(180, 213);
            this.grbNuevoElemento.TabIndex = 20;
            this.grbNuevoElemento.TabStop = false;
            this.grbNuevoElemento.Text = "Nuevo Elemento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(9, 162);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(165, 32);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
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
            // btnEquilibrar
            // 
            this.btnEquilibrar.Location = new System.Drawing.Point(512, 162);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(180, 32);
            this.btnEquilibrar.TabIndex = 8;
            this.btnEquilibrar.Text = "Equilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            // 
            // rdbInOrden
            // 
            this.rdbInOrden.AutoSize = true;
            this.rdbInOrden.Location = new System.Drawing.Point(21, 61);
            this.rdbInOrden.Name = "rdbInOrden";
            this.rdbInOrden.Size = new System.Drawing.Size(66, 17);
            this.rdbInOrden.TabIndex = 2;
            this.rdbInOrden.TabStop = true;
            this.rdbInOrden.Text = "In-Orden";
            this.rdbInOrden.UseVisualStyleBackColor = true;
            // 
            // rdbPreOrden
            // 
            this.rdbPreOrden.AutoSize = true;
            this.rdbPreOrden.Location = new System.Drawing.Point(21, 109);
            this.rdbPreOrden.Name = "rdbPreOrden";
            this.rdbPreOrden.Size = new System.Drawing.Size(73, 17);
            this.rdbPreOrden.TabIndex = 3;
            this.rdbPreOrden.TabStop = true;
            this.rdbPreOrden.Text = "Pre-Orden";
            this.rdbPreOrden.UseVisualStyleBackColor = true;
            // 
            // rdbPostOrden
            // 
            this.rdbPostOrden.AutoSize = true;
            this.rdbPostOrden.Location = new System.Drawing.Point(21, 163);
            this.rdbPostOrden.Name = "rdbPostOrden";
            this.rdbPostOrden.Size = new System.Drawing.Size(78, 17);
            this.rdbPostOrden.TabIndex = 4;
            this.rdbPostOrden.TabStop = true;
            this.rdbPostOrden.Text = "Post-Orden";
            this.rdbPostOrden.UseVisualStyleBackColor = true;
            // 
            // trvArbol
            // 
            this.trvArbol.Location = new System.Drawing.Point(108, 9);
            this.trvArbol.Name = "trvArbol";
            this.trvArbol.Size = new System.Drawing.Size(174, 204);
            this.trvArbol.TabIndex = 5;
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.trvArbol);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.grbListaYGrilla);
            this.Controls.Add(this.grbElementoEliminado);
            this.Controls.Add(this.grbNuevoElemento);
            this.Name = "frmArbolBinario";
            this.Text = "frmArbolBinario";
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