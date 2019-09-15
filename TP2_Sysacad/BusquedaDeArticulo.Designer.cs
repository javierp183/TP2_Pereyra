namespace TP2_Sysacad
{
    partial class BusquedaDeArticulo
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblArtCode = new System.Windows.Forms.Label();
            this.dgvDetalleArticulo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(380, 33);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // lblArtCode
            // 
            this.lblArtCode.AutoSize = true;
            this.lblArtCode.Location = new System.Drawing.Point(180, 36);
            this.lblArtCode.Name = "lblArtCode";
            this.lblArtCode.Size = new System.Drawing.Size(174, 17);
            this.lblArtCode.TabIndex = 1;
            this.lblArtCode.Text = "Ingrese Codigo de Articulo";
            // 
            // dgvDetalleArticulo
            // 
            this.dgvDetalleArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleArticulo.Location = new System.Drawing.Point(50, 93);
            this.dgvDetalleArticulo.Name = "dgvDetalleArticulo";
            this.dgvDetalleArticulo.RowTemplate.Height = 24;
            this.dgvDetalleArticulo.Size = new System.Drawing.Size(706, 238);
            this.dgvDetalleArticulo.TabIndex = 4;
            // 
            // BusquedaDeArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDetalleArticulo);
            this.Controls.Add(this.lblArtCode);
            this.Controls.Add(this.txtCodigo);
            this.Name = "BusquedaDeArticulo";
            this.Text = "BusquedaDeArticulo";
            this.Load += new System.EventHandler(this.BusquedaDeArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblArtCode;
        private System.Windows.Forms.DataGridView dgvDetalleArticulo;
    }
}