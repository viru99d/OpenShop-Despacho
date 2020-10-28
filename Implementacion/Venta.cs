using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenShop___Despacho
{
    class Venta
    { 
        public int idVenta { get; set; }
        public DateTime fecha { get; set; }
        public float precio { get; set; }
        public Producto productos { get; set; }
        public Vendedor vendedor { get; set; }
        public Cliente cliente { get; set; }


        public Venta(int idVenta, DateTime fecha, float precio, Producto productos, Vendedor vendedor, Cliente cliente)
        {
            this.idVenta = idVenta;
            this.fecha = fecha;
            this.precio = precio;
            this.productos = productos;
            this.vendedor = vendedor;
            this.cliente = cliente;
        }

        public static List<Venta> Ventas = new List<Venta>();


        public static void MostrarVenta()
        {
            int pos = 1;
            Console.WriteLine("\nLISTA DE VENTAS:");

            if (System.IO.File.Exists("JSON - Carrito.json"))
            {
                string ArchivoVenta = System.IO.File.ReadAllText("JSON - Carrito.json");
                List<Venta> ventasRecibidasJson = JsonConvert.DeserializeObject<List<Venta>>(ArchivoVenta);


                foreach (var ventas in ventasRecibidasJson)
                {
                    Console.WriteLine("-" + pos + "\n");
                    Console.WriteLine(ventas.idVenta);
                    Console.WriteLine(ventas.cliente.apellido);
                    Console.WriteLine(ventas.cliente.mail);
                    Console.WriteLine(ventas.cliente.usuario);
                    Console.WriteLine(ventas.cliente.contrasena);
                    Console.WriteLine(ventas.cliente.dni);
                    Console.WriteLine(ventas.cliente.domicilio);


                }
                pos++;
            }
        }

    }
}
