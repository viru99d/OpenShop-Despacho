using System;
using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace openShop_despacho
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Transporte
    {
        public int idTransporte { get; set; }
        public string nombre { get; set; }
        public string domicilio { get; set; }
        public string precioPeso { get; set; }

        public Transporte(int idTransporte, string nombre, string domicilio, string precioPeso)
        {
            this.idTransporte = idTransporte;
            this.nombre = nombre;
            this.domicilio = domicilio;
            this.precioPeso = precioPeso;
        }
    }

    class Pedido
    {
        public int idPedido { get; set; }
        public Producto productos { get; set; }
        public float peso { get; set; }
        public Transporte transporte { get; set; }

        public Pedido(int idPedido, Producto productos, float peso, Transporte transporte)
        {
            this.idPedido = idPedido;
            this.productos = productos;
            this.peso = peso;
            this.transporte = transporte;
        }
    }

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

    class Cliente
    {
        public int idCliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string mail { get; set; }
        public string usuario { get; set; }
        public string contraseña{ get; set; }
        public string dni { get; set; }
        public string domicilio { get; set; }
        public string telefono { get; set; }

        public Cliente(int idCliente, string nombre, string apellido, string mail, string usuario, string contraseña, string dni, string domicilio, string telefono)
        {
            this.idCliente = idCliente;
            this.nombre = nombre;
            this.apellido = apellido;
            this.mail = mail;
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.dni = dni;
            this.domicilio = domicilio;
            this.telefono = telefono;
        }
    }

    class Vendedor
    {
        public int idVendedor { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string mail { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public string dni { get; set; }
        public string domicilio { get; set; }
        public string telefono { get; set; }

        public Vendedor(int idVendedor, string nombre, string apellido, string mail, string usuario, string contraseña, string dni, string domicilio, string telefono)
        {
            this.idVendedor = idVendedor;
            this.nombre = nombre;
            this.apellido = apellido;
            this.mail = mail;
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.dni = dni;
            this.domicilio = domicilio;
            this.telefono = telefono;
        }
    }

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
    }




}
