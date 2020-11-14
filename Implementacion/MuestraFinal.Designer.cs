namespace OpenShop___Despacho
{
    partial class MuestraFinal
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
            this.title1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textDetallesPedido = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title1
            // 
            this.title1.AutoSize = true;
            this.title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title1.Location = new System.Drawing.Point(297, 36);
            this.title1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(312, 38);
            this.title1.TabIndex = 2;
            this.title1.Text = "Detalles del pedido";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(628, 338);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 60);
            this.button1.TabIndex = 8;
            this.button1.Text = "TERMINAR ENVÍO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textDetallesPedido
            // 
            this.textDetallesPedido.BackColor = System.Drawing.Color.Silver;
            this.textDetallesPedido.HideSelection = false;
            this.textDetallesPedido.Location = new System.Drawing.Point(197, 101);
            this.textDetallesPedido.Margin = new System.Windows.Forms.Padding(4);
            this.textDetallesPedido.Name = "textDetallesPedido";
            this.textDetallesPedido.Size = new System.Drawing.Size(528, 142);
            this.textDetallesPedido.TabIndex = 10;
            this.textDetallesPedido.UseCompatibleStateImageBehavior = false;
            this.textDetallesPedido.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Recuerde que el costo de envio se abona cuando se entrega el pedido";
            // 
            // MuestraFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(880, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textDetallesPedido);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.title1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MuestraFinal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open shop";
            this.Load += new System.EventHandler(this.MuestraFinal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView textDetallesPedido;
        private System.Windows.Forms.Label label1;
    }
}