namespace OpenShop___Despacho
{
    partial class DatosCliente
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
            this.title2 = new System.Windows.Forms.Label();
            this.textDatosCliente = new System.Windows.Forms.ListView();
            this.Siguiente2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title2
            // 
            this.title2.AutoSize = true;
            this.title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title2.Location = new System.Drawing.Point(297, 47);
            this.title2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(275, 38);
            this.title2.TabIndex = 2;
            this.title2.Text = "Datos del cliente";
            // 
            // textDatosCliente
            // 
            this.textDatosCliente.BackColor = System.Drawing.Color.Silver;
            this.textDatosCliente.HideSelection = false;
            this.textDatosCliente.Location = new System.Drawing.Point(248, 146);
            this.textDatosCliente.Margin = new System.Windows.Forms.Padding(4);
            this.textDatosCliente.Name = "textDatosCliente";
            this.textDatosCliente.Size = new System.Drawing.Size(368, 137);
            this.textDatosCliente.TabIndex = 3;
            this.textDatosCliente.UseCompatibleStateImageBehavior = false;
            this.textDatosCliente.View = System.Windows.Forms.View.List;
            // 
            // Siguiente2
            // 
            this.Siguiente2.Location = new System.Drawing.Point(632, 348);
            this.Siguiente2.Margin = new System.Windows.Forms.Padding(4);
            this.Siguiente2.Name = "Siguiente2";
            this.Siguiente2.Size = new System.Drawing.Size(213, 60);
            this.Siguiente2.TabIndex = 4;
            this.Siguiente2.Text = "SIGUIENTE";
            this.Siguiente2.UseVisualStyleBackColor = true;
            this.Siguiente2.Click += new System.EventHandler(this.Siguiente2_Click);
            // 
            // DatosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(883, 455);
            this.Controls.Add(this.Siguiente2);
            this.Controls.Add(this.textDatosCliente);
            this.Controls.Add(this.title2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DatosCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open Shop";
            this.Load += new System.EventHandler(this.DatosCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title2;
        private System.Windows.Forms.ListView textDatosCliente;
        private System.Windows.Forms.Button Siguiente2;
    }
}