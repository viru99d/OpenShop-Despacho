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
            int venta = 1;
            int idCliente = 0;
            string nombre ="";
            string apellido = "";
            string domicilio ="";
            string codigoPostal ="";
            string localidad = "";
            

            if (System.IO.File.Exists("Cobranza.json"))
            {
                string ArchivoCarrito = System.IO.File.ReadAllText("Cobranza.json");
                List<Venta> ArchivoCobranza = JsonConvert.DeserializeObject<List<Venta>>(ArchivoCarrito);

                foreach (var archivoCobranza in ArchivoCobranza)
                {
                    if(archivoCobranza.idVenta == venta)
                    {
                        idCliente = archivoCobranza.cliente.idCliente;
                        nombre = archivoCobranza.cliente.nombre;
                        apellido= archivoCobranza.cliente.apellido;
                        codigoPostal = archivoCobranza.cliente.codigoPostal;
                        domicilio = archivoCobranza.cliente.domicilio;
                        localidad = archivoCobranza.cliente.localidad;
                   
                        
                    }
                   
                }

                textDatosCliente.Items.Add("Nombre y apellido: " + nombre +" " + apellido);
                textDatosCliente.Items.Add("Localidad: "  + localidad);
                textDatosCliente.Items.Add("Domicilio: " + domicilio);
                textDatosCliente.Items.Add("Código Postal: " + codigoPostal);

                Cliente.Clientes.Add(new Cliente(idCliente, nombre, apellido, codigoPostal, domicilio, localidad));

                venta++;
            }
            else
            {
                MessageBox.Show("Se produjo un error al cargar los datos del cliente, por favor contactese con Open Shop al numero que figura en el sitio web, disculpe las molestias ocasionadas");
                this.Close();
            }
        }

        
    }
}
