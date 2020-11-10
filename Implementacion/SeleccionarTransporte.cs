using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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

        private void SeleccionarTransporte_Load(object sender, EventArgs e)
        {
            if (transporte.Items.Count == 4)
            {
                transporte.Items.Clear();
                rellenarComboBoxTransporte();
            }
                

        }

        public void rellenarComboBoxTransporte()
        {
            if (System.IO.File.Exists("Transportes.json"))
            {
                string ArchivoTransporte = System.IO.File.ReadAllText("Transportes.json");
                List<Transporte> transportesJson = JsonConvert.DeserializeObject<List<Transporte>>(ArchivoTransporte);

                foreach (var transportes in transportesJson)
                {
                    transporte.Items.Add(transportes.nombre+" $" + transportes.precio);
                }
            }
        }

        private void transporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            string correoElegido = this.transporte.SelectedItem.ToString();
            string correoArgentino = "Correo Argentino $900";
            string ocasa = "Ocasa $800";
            string oca = "Oca $750";
            string andreani = "Andreani $1000";
            int indice = 0;
            int idPedido = 1;

            if (correoElegido == correoArgentino)
            {
                indice = 1;
            }

            if (correoElegido == ocasa)
            {
                indice = 2;
            }

            if (correoElegido == oca)
            {
                indice = 3;
            }

            if (correoElegido == andreani)
            {
                indice = 4;
            }

            Pedido.Pedidos.Add(new Pedido(idPedido, Producto.Productos, 9.543f, Transporte.Transportes[indice]));
            idPedido++;

            completarEnvio();
        }

        public void completarEnvio()
        {
            int contadorDeEnvios = 1;
            Envio.Envios.Add(new Envio(contadorDeEnvios, DateTime.Now, "Guemes 779", Pedido.Pedidos[0], Cliente.Clientes[0]));

            contadorDeEnvios++;
        }
    }
}
