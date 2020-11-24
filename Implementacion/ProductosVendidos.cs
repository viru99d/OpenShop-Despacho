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
            Producto.Productos.Clear();
            rellenarCampoProductosVendidos();
        }

        void rellenarCampoProductosVendidos()
        {
            if (System.IO.File.Exists("Cobranza.json"))
            {
                string ArchivoCarrito = System.IO.File.ReadAllText("Cobranza.json");
                List<Venta> ArchivoCobranza = JsonConvert.DeserializeObject<List<Venta>>(ArchivoCarrito);

                int venta = 1;
               
                foreach (var archivoCobranza in ArchivoCobranza)
                {

                    if(archivoCobranza.idVenta == venta && archivoCobranza.confirmacionPago ==true)
                    {
                        dataProductosVendidos.Rows.Add(archivoCobranza.productos.nombre, archivoCobranza.productos.marca, archivoCobranza.productos.descripcion);
                        Producto.Productos.Add(new Producto(archivoCobranza.productos.idProducto, archivoCobranza.productos.nombre, archivoCobranza.productos.marca, archivoCobranza.productos.descripcion));

                        var productosJson = JsonConvert.SerializeObject(Producto.Productos, Formatting.Indented);
                        System.IO.File.WriteAllText("ProductosVendidos.Json", productosJson);


                    }
                    
                }

                venta++;
            }
            else
            {
                MessageBox.Show("No hay articulos vendidos o se produjo un error inesperado, por favor contactese con Open Shop al numero que figura en el sitio web, disculpe las molestias ocasionadas");
                this.Close();
            }
        }

     
    }
}
