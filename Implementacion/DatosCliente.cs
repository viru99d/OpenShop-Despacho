using Newtonsoft.Json;
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

        private void DatosCliente_Load(object sender, EventArgs e)
        {
            rellenarDatosCliente();
        }
        void rellenarDatosCliente()
        {
            if (System.IO.File.Exists("Carrito.json"))
            {
                string ArchivoCarrito = System.IO.File.ReadAllText("Carrito.json");
                List<Venta> carritoJson = JsonConvert.DeserializeObject<List<Venta>>(ArchivoCarrito);
               
                foreach (var carrito in carritoJson)
                {
                    textDatosCliente.Items.Add("Usuario: " + carrito.cliente.usuario);
                    textDatosCliente.Items.Add("Nombre y apellido: "+ carrito.cliente.nombre +" " +carrito.cliente.apellido);
                    textDatosCliente.Items.Add("DNI: " + carrito.cliente.dni);
                    textDatosCliente.Items.Add("Domicilio: " + carrito.cliente.domicilio);
                    textDatosCliente.Items.Add("Teléfono: " + carrito.cliente.telefono);
                    textDatosCliente.Items.Add("Email: " + carrito.cliente.mail);


                }
            }
        }

        
    }
}
