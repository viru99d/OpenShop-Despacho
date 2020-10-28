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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Siguiente2 = new System.Windows.Forms.Button();
            this.Atras2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title2
            // 
            this.title2.AutoSize = true;
            this.title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title2.Location = new System.Drawing.Point(231, 71);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(172, 25);
            this.title2.TabIndex = 2;
            this.title2.Text = "Datos del cliente";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(179, 115);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(277, 229);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Siguiente2
            // 
            this.Siguiente2.Location = new System.Drawing.Point(472, 405);
            this.Siguiente2.Name = "Siguiente2";
            this.Siguiente2.Size = new System.Drawing.Size(160, 49);
            this.Siguiente2.TabIndex = 4;
            this.Siguiente2.Text = "SIGUIENTE";
            this.Siguiente2.UseVisualStyleBackColor = true;
            this.Siguiente2.Click += new System.EventHandler(this.Siguiente2_Click);
            // 
            // Atras2
            // 
            this.Atras2.Location = new System.Drawing.Point(32, 405);
            this.Atras2.Name = "Atras2";
            this.Atras2.Size = new System.Drawing.Size(160, 49);
            this.Atras2.TabIndex = 5;
            this.Atras2.Text = "ATRAS";
            this.Atras2.UseVisualStyleBackColor = true;
            this.Atras2.Click += new System.EventHandler(this.Atras2_Click);
            // 
            // DatosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(662, 493);
            this.Controls.Add(this.Atras2);
            this.Controls.Add(this.Siguiente2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.title2);
            this.Name = "DatosCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button Siguiente2;
        private System.Windows.Forms.Button Atras2;
    }
}