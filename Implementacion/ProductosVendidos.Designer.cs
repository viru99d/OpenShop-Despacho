namespace OpenShop___Despacho
{
    partial class ProductosVendidos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Siguiente1 = new System.Windows.Forms.Button();
            this.title1 = new System.Windows.Forms.Label();
            this.dataProductosVendidos = new System.Windows.Forms.DataGridView();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductosVendidos)).BeginInit();
            this.SuspendLayout();
            // 
            // Siguiente1
            // 
            this.Siguiente1.Location = new System.Drawing.Point(490, 309);
            this.Siguiente1.Name = "Siguiente1";
            this.Siguiente1.Size = new System.Drawing.Size(160, 49);
            this.Siguiente1.TabIndex = 0;
            this.Siguiente1.Text = "Siguiente";
            this.Siguiente1.UseVisualStyleBackColor = true;
            this.Siguiente1.Click += new System.EventHandler(this.Siguiente1_Click);
            // 
            // title1
            // 
            this.title1.AutoSize = true;
            this.title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title1.Location = new System.Drawing.Point(203, 9);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(289, 31);
            this.title1.TabIndex = 1;
            this.title1.Text = "Productos adquiridos";
            // 
            // dataProductosVendidos
            // 
            this.dataProductosVendidos.AllowUserToAddRows = false;
            this.dataProductosVendidos.AllowUserToDeleteRows = false;
            this.dataProductosVendidos.AllowUserToOrderColumns = true;
            this.dataProductosVendidos.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataProductosVendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProductosVendidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreProducto,
            this.MarcaProducto,
            this.PrecioProducto,
            this.DescripcionProducto});
            this.dataProductosVendidos.GridColor = System.Drawing.Color.DarkGray;
            this.dataProductosVendidos.Location = new System.Drawing.Point(93, 52);
            this.dataProductosVendidos.Name = "dataProductosVendidos";
            this.dataProductosVendidos.ReadOnly = true;
            this.dataProductosVendidos.Size = new System.Drawing.Size(469, 241);
            this.dataProductosVendidos.TabIndex = 2;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            // 
            // MarcaProducto
            // 
            this.MarcaProducto.HeaderText = "Marca";
            this.MarcaProducto.Name = "MarcaProducto";
            this.MarcaProducto.ReadOnly = true;
            // 
            // PrecioProducto
            // 
            this.PrecioProducto.HeaderText = "Precio";
            this.PrecioProducto.Name = "PrecioProducto";
            this.PrecioProducto.ReadOnly = true;
            // 
            // DescripcionProducto
            // 
            this.DescripcionProducto.HeaderText = "Descripción";
            this.DescripcionProducto.Name = "DescripcionProducto";
            this.DescripcionProducto.ReadOnly = true;
            // 
            // ProductosVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(662, 370);
            this.Controls.Add(this.dataProductosVendidos);
            this.Controls.Add(this.title1);
            this.Controls.Add(this.Siguiente1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductosVendidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open shop";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.Load += new System.EventHandler(this.ProductosVendidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProductosVendidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Siguiente1;
        private System.Windows.Forms.Label title1;
        private System.Windows.Forms.DataGridView dataProductosVendidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionProducto;
    }
}

