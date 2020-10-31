using Newtonsoft.Json;
using System.Collections.Generic;
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

        private void ProductosVendidos_Load(object sender, System.EventArgs e)
        {
            rellenarCampoProductosVendidos();
        }

        void rellenarCampoProductosVendidos()
        {
            if (System.IO.File.Exists("Carrito.json"))
            {
                string ArchivoCarrito = System.IO.File.ReadAllText("Carrito.json");
                List<Venta> carritoJson = JsonConvert.DeserializeObject<List<Venta>>(ArchivoCarrito);

                foreach (var carrito in carritoJson)
                {
                    dataProductosVendidos.Rows.Add(carrito.productos.nombre, carrito.productos.marca, carrito.productos.precio, carrito.productos.descripcion);
                }
            }


            
        }
    }
}
