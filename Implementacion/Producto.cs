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
        public float precio { get; set; }
        public string descripcion { get; set; }
        public int stock { get; set; }

        public Producto(int idProducto, string nombre, string marca, float precio, string descripcion, int stock)
        {
            this.idProducto = idProducto;
            this.nombre = nombre;
            this.marca = marca;
            this.precio = precio;
            this.descripcion = descripcion;
            this.stock = stock;
        }

    }
}
