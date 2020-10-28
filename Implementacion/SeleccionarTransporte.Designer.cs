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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Siguiente2
            // 
            this.Siguiente2.Location = new System.Drawing.Point(464, 407);
            this.Siguiente2.Name = "Siguiente2";
            this.Siguiente2.Size = new System.Drawing.Size(160, 49);
            this.Siguiente2.TabIndex = 5;
            this.Siguiente2.Text = "SIGUIENTE";
            this.Siguiente2.UseVisualStyleBackColor = true;
            this.Siguiente2.Click += new System.EventHandler(this.Siguiente2_Click);
            // 
            // Atras2
            // 
            this.Atras2.Location = new System.Drawing.Point(40, 407);
            this.Atras2.Name = "Atras2";
            this.Atras2.Size = new System.Drawing.Size(160, 49);
            this.Atras2.TabIndex = 6;
            this.Atras2.Text = "ATRAS";
            this.Atras2.UseVisualStyleBackColor = true;
            this.Atras2.Click += new System.EventHandler(this.Atras2_Click);
            // 
            // title2
            // 
            this.title2.AutoSize = true;
            this.title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title2.Location = new System.Drawing.Point(176, 71);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(327, 25);
            this.title2.TabIndex = 7;
            this.title2.Text = "Seleccione la empresa de correo";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Andreani",
            "Oca",
            "Ocasa",
            "Correo Argentino"});
            this.comboBox1.Location = new System.Drawing.Point(217, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(247, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // SeleccionarTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(662, 493);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.title2);
            this.Controls.Add(this.Atras2);
            this.Controls.Add(this.Siguiente2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SeleccionarTransporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Siguiente2;
        private System.Windows.Forms.Button Atras2;
        private System.Windows.Forms.Label title2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}