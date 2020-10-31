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
            string usuario ="";
            string nombreyApellido ="";
            string dni = "";
            string domicilio ="";
            string telefono ="";
            string email ="";

            if (System.IO.File.Exists("Carrito.json"))
            {
                string ArchivoCarrito = System.IO.File.ReadAllText("Carrito.json");
                List<Venta> carritoJson = JsonConvert.DeserializeObject<List<Venta>>(ArchivoCarrito);

                foreach (var carrito in carritoJson)
                {
                    usuario = carrito.cliente.usuario;
                    nombreyApellido = carrito.cliente.nombre + " " + carrito.cliente.apellido;
                    dni = carrito.cliente.dni;
                    domicilio = carrito.cliente.domicilio;
                    telefono = carrito.cliente.telefono;
                    email = carrito.cliente.mail;
                }

                textDatosCliente.Items.Add("Usuario: " + usuario);
                textDatosCliente.Items.Add("Nombre y apellido: " + nombreyApellido);
                textDatosCliente.Items.Add("DNI: " + dni);
                textDatosCliente.Items.Add("Domicilio: " + domicilio);
                textDatosCliente.Items.Add("Teléfono: " + telefono);
                textDatosCliente.Items.Add("Email: " + email);

            }
        }
    }
}
