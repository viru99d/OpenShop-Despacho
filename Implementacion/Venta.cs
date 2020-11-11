﻿using Newtonsoft.Json;
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
        public Cliente cliente { get; set; }


        public Venta(int idVenta, DateTime fecha, float precio, Producto productos, Cliente cliente)
        {
            this.idVenta = idVenta;
            this.fecha = fecha;
            this.precio = precio;
            this.productos = productos;
            this.cliente = cliente;
        }

        public static List<Venta> Ventas = new List<Venta>();

    }
}
