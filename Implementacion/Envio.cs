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
        public DateTime fecha { get; set; }
        public string destino { get; set; }
        public Pedido pedido { get; set; }
        public Cliente cliente { get; set; }

        public Envio(int idEnvio, DateTime fecha, string destino, Pedido pedido, Cliente cliente)
        {
            this.idEnvio = idEnvio;
            this.fecha = fecha;
            this.destino = destino;
            this.pedido = pedido;
            this.cliente = cliente;
        }

        public static List<Envio> Envios = new List<Envio>();

        
    }
}
