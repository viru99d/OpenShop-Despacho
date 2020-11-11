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
    public partial class MuestraFinal : Form
    {
        public MuestraFinal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             using (PantallaFinal ventanaPantallaFinal = new PantallaFinal())
                ventanaPantallaFinal.ShowDialog();
        }

        private void MuestraFinal_Load(object sender, EventArgs e)
        {
            completarDetallesDelEnvio();
        }

        public void completarDetallesDelEnvio()
        {
            string nombreYApellidoCliente = "";
            string direccion = "";
            string transporte = "";
            string costoEnvio ="";
            string localidad = "";

            int envio = 1;

            if (System.IO.File.Exists("Cobranza.json"))
            {
                string ArchivoEnvio = System.IO.File.ReadAllText("Envios.json");
                List<Envio> Envio = JsonConvert.DeserializeObject<List<Envio>>(ArchivoEnvio);

                foreach (var DatosEnvio in Envio)
                {
                    if (DatosEnvio.idEnvio == envio)
                    {
                        nombreYApellidoCliente = DatosEnvio.cliente.nombre + " " + DatosEnvio.cliente.apellido;
                        direccion = DatosEnvio.cliente.domicilio;
                        localidad = DatosEnvio.cliente.localidad;
                        transporte = DatosEnvio.pedido.transporte.nombre;
                        costoEnvio = DatosEnvio.pedido.transporte.precio.ToString();
                    }

                }

                textDetallesPedido.Items.Add("Nombre y apellido: " + nombreYApellidoCliente + "/n");
                textDetallesPedido.Items.Add("Domicilio: " + direccion);
                textDetallesPedido.Items.Add("Localidad: " + localidad);
                textDetallesPedido.Items.Add("Empresa de transporte: " + transporte);
                textDetallesPedido.Items.Add("Costo del envio $:" + costoEnvio);

                envio++;
            }



        }
      


    }
}
