namespace OpenShop___Despacho
{
    partial class SeleccionarTransporte
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
            this.Siguiente2 = new System.Windows.Forms.Button();
            this.Atras2 = new System.Windows.Forms.Button();
            this.title2 = new System.Windows.Forms.Label();
            this.transporte = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Siguiente2
            // 
            this.Siguiente2.Location = new System.Drawing.Point(617, 351);
            this.Siguiente2.Margin = new System.Windows.Forms.Padding(4);
            this.Siguiente2.Name = "Siguiente2";
            this.Siguiente2.Size = new System.Drawing.Size(213, 60);
            this.Siguiente2.TabIndex = 5;
            this.Siguiente2.Text = "SIGUIENTE";
            this.Siguiente2.UseVisualStyleBackColor = true;
            this.Siguiente2.Click += new System.EventHandler(this.Siguiente2_Click);
            // 
            // Atras2
            // 
            this.Atras2.Location = new System.Drawing.Point(49, 351);
            this.Atras2.Margin = new System.Windows.Forms.Padding(4);
            this.Atras2.Name = "Atras2";
            this.Atras2.Size = new System.Drawing.Size(213, 60);
            this.Atras2.TabIndex = 6;
            this.Atras2.Text = "ATRAS";
            this.Atras2.UseVisualStyleBackColor = true;
            this.Atras2.Click += new System.EventHandler(this.Atras2_Click);
            // 
            // title2
            // 
            this.title2.AutoSize = true;
            this.title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title2.Location = new System.Drawing.Point(198, 85);
            this.title2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(545, 39);
            this.title2.TabIndex = 7;
            this.title2.Text = "Seleccione la empresa de correo";
            // 
            // transporte
            // 
            this.transporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transporte.FormattingEnabled = true;
            this.transporte.Items.AddRange(new object[] {
            "Andreani",
            "Oca",
            "Ocasa",
            "Correo Argentino"});
            this.transporte.Location = new System.Drawing.Point(281, 186);
            this.transporte.Margin = new System.Windows.Forms.Padding(4);
            this.transporte.Name = "transporte";
            this.transporte.Size = new System.Drawing.Size(337, 24);
            this.transporte.TabIndex = 8;
            // 
            // SeleccionarTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(879, 454);
            this.Controls.Add(this.transporte);
            this.Controls.Add(this.title2);
            this.Controls.Add(this.Atras2);
            this.Controls.Add(this.Siguiente2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SeleccionarTransporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SeleccionarTransporte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Siguiente2;
        private System.Windows.Forms.Button Atras2;
        private System.Windows.Forms.Label title2;
        private System.Windows.Forms.ComboBox transporte;
    }
}