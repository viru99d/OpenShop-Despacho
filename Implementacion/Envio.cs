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
        public Vendedor vendedor { get; set; }
        public Cliente cliente { get; set; }

        public Envio(int idEnvio, DateTime fecha, string destino, Vendedor vendedor, Cliente cliente)
        {
            this.idEnvio = idEnvio;
            this.fecha = fecha;
            this.destino = destino;
            this.vendedor = vendedor;
            this.cliente = cliente;

        }

    }
}
