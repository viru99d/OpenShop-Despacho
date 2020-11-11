using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenShop___Despacho
{
    class Envio
    {
        public int idEnvio { get; set; }
        public string fecha { get; set; }
        public Pedido pedido { get; set; }
        public Cliente cliente { get; set; }

        public Envio(int idEnvio, string fecha, Pedido pedido, Cliente cliente)
        {
            this.idEnvio = idEnvio;
            this.fecha = fecha;
            this.pedido = pedido;
            this.cliente = cliente;
        }

        public static List<Envio> Envios = new List<Envio>();

        
    }
}
