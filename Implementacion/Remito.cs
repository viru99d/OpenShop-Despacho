using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenShop___Despacho
{
    class Remito
    {
        public int idRemito { get; set; }
        public DateTime fecha { get; set; }

        public string numero { get; set; }
        public Pedido pedido { get; set; }

        public Remito(int idRemito, DateTime fecha, string numero, Pedido pedido)
        {
            this.idRemito = idRemito;
            this.fecha = fecha;
            this.numero = numero;
            this.pedido = pedido;
        }
    }
}
