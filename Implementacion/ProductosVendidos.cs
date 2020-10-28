using System.Windows.Forms;

namespace OpenShop___Despacho
{
    public partial class ProductosVendidos : Form
    {
        public ProductosVendidos()
        {
            InitializeComponent();
        }

        private void Siguiente1_Click(object sender, System.EventArgs e)
        {
            using (DatosCliente ventanaDatosCliente = new DatosCliente())
                ventanaDatosCliente.ShowDialog();
            this.Close();
        }
    }
}
