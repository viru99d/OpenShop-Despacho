using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenShop___Despacho
{
    public partial class SeleccionarTransporte : Form
    {
        public SeleccionarTransporte()
        {
            InitializeComponent();
        }

        private void Atras2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Siguiente2_Click(object sender, EventArgs e)
        {
            using (MuestraFinal ventanaMuestraFinal = new MuestraFinal())
                ventanaMuestraFinal.ShowDialog();
        }
    }
}
