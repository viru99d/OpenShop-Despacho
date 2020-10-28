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
    public partial class DatosCliente : Form
    {
        public DatosCliente()
        {
            InitializeComponent();
        }

        private void Atras2_Click(object sender, EventArgs e)
        {
            using (ProductosVendidos ventanaProductosVendidos = new ProductosVendidos())
                ventanaProductosVendidos.ShowDialog();
            this.Close();
        }

        private void Siguiente2_Click(object sender, EventArgs e)
        {
            using (SeleccionarTransporte ventanaSeleccionarTransporte = new SeleccionarTransporte())
                ventanaSeleccionarTransporte.ShowDialog();
            this.Close();
        }
    }
}
