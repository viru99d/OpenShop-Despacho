using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenShop___Despacho
{ 
    class Pedido
    {
        public int idPedido { get; set; }
        public List<Producto> productos { get; set; }
        public float peso { get; set; }
        public Transporte transporte { get; set; }

        public Pedido(int idPedido, List<Producto> productos, float peso, Transporte transporte)
        {
            this.idPedido = idPedido;
            this.productos = productos;
            this.peso = peso;
            this.transporte = transporte;
        }

        public static List<Pedido> Pedidos = new List<Pedido>();

    }
}
