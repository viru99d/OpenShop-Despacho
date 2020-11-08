using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenShop___Despacho
{
    class Producto
    {
        public int idProducto { get; set; }
        public string nombre { get; set; }
        public string marca { get; set; }
        public string descripcion { get; set; }
        
        public Producto(int idProducto, string nombre, string marca, string descripcion)
        {
            this.idProducto = idProducto;
            this.nombre = nombre;
            this.marca = marca;
            this.descripcion = descripcion;
           
        }

        public static List<Producto> Productos = new List<Producto>();

    }
}
