using Newtonsoft.Json;
using OpenShop___Despacho;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace testOpenShop
{
    public class TestOpenShopDespacho
    {

        [Fact] 
        public void TransportesBienCargadosEnLista()
        {
            Transporte.Transportes.Add(new Transporte(1, "Correo Argentino", "Juan B Alberdi 198", 900));
            Transporte.Transportes.Add(new Transporte(2, "Ocasa", "Av. Juan de Garay 1294", 800));
            Transporte.Transportes.Add(new Transporte(3, "Oca", "Av. Urquiza 874", 750));
            Transporte.Transportes.Add(new Transporte(4, "Andreani", "Bv. 9 de Julio 1852", 1000));

            Assert.Equal(4, Transporte.Transportes.Count);
        }

        [Fact]
        public void ProductosDeserializadosYCargadosCorrectamente()
        {
             Producto.Productos.Clear();
             int cantidadDeProductos = 0;

                string ArchivoCarrito = System.IO.File.ReadAllText("Cobranza.json");
                List<Venta> ArchivoCobranza = JsonConvert.DeserializeObject<List<Venta>>(ArchivoCarrito);

                int venta = 1;
                
                foreach (var archivoCobranza in ArchivoCobranza)
                {
                    if (archivoCobranza.idVenta == venta)
                    {
                        Producto.Productos.Add(new Producto(archivoCobranza.productos.idProducto, archivoCobranza.productos.nombre, archivoCobranza.productos.marca, archivoCobranza.productos.descripcion));
                        cantidadDeProductos++;
                    }
                }
                venta++;

            Assert.Equal(cantidadDeProductos, Producto.Productos.Count);
        }

        [Fact]
        public void CorrectaDeserializacionDeTransportes()
        {
            Transporte.Transportes.Clear();
            int cantidadDeTransportes = 0;

                string ArchivoTransporte = System.IO.File.ReadAllText("Transportes.json");
                List<Transporte> transportesJson = JsonConvert.DeserializeObject<List<Transporte>>(ArchivoTransporte);

                foreach (var transportes in transportesJson)
                {
                    Transporte.Transportes.Add(new Transporte(transportes.idTransporte, transportes.nombre, transportes.domicilio, transportes.precio));
                    cantidadDeTransportes++;
                }
            

            Assert.Equal(cantidadDeTransportes, Transporte.Transportes.Count);
        }

        [Fact]
        public void CorrectaSerializacionDeTransportes()
        {
            bool ExisteArchivoJson =false;

            var TransporteJson = JsonConvert.SerializeObject(Transporte.Transportes, Formatting.Indented);
            System.IO.File.WriteAllText("Transportes.Json", TransporteJson);

            if (System.IO.File.Exists("Transportes.json"))
            {
                ExisteArchivoJson = true;
            }
                Assert.True(ExisteArchivoJson);
        }

        [Fact]
        public void NombreProductoValido()
        {
            int venta = 1;
            bool nombreValido = false;

            string ArchivoCarrito = System.IO.File.ReadAllText("Cobranza.json");
            List<Venta> ArchivoCobranza = JsonConvert.DeserializeObject<List<Venta>>(ArchivoCarrito);

            foreach (var archivoCobranza in ArchivoCobranza)
            {
                if (archivoCobranza.idVenta == venta)
                {
                    if(archivoCobranza.productos.nombre != null)
                    {
                        nombreValido = true;
                    }
                    Assert.True(nombreValido);
                    nombreValido = false;
                }
            }
            venta++;
        }

        [Fact]
        public void MarcaProductoValida()
        {
            int venta = 1;
            bool MarcaValido = false;

            string ArchivoCarrito = System.IO.File.ReadAllText("Cobranza.json");
            List<Venta> ArchivoCobranza = JsonConvert.DeserializeObject<List<Venta>>(ArchivoCarrito);

            foreach (var archivoCobranza in ArchivoCobranza)
            {
                if (archivoCobranza.idVenta == venta)
                {
                    if (archivoCobranza.productos.marca != null)
                    {
                        MarcaValido = true;
                    }
                    Assert.True(MarcaValido);
                    MarcaValido = false;
                }
            }
            venta++;
        }

        [Fact]
        public void PrecioEnvioValido()
        {
            bool PrecioValido = false;

            string ArchivoTransporte = System.IO.File.ReadAllText("Transportes.json");
            List<Transporte> transportesJson = JsonConvert.DeserializeObject<List<Transporte>>(ArchivoTransporte);

            foreach (var transportes in transportesJson)
            {
                if(transportes.precio >0 && transportes.precio.ToString() != null)
                {
                    PrecioValido = true;
                }
                Assert.True(PrecioValido);
            }

        }

        [Fact]
        public void DatosParaEnvioValidos()
        {
            int venta = 1;
            bool datosParaEnvioValidos = false;

            string ArchivoCarrito = System.IO.File.ReadAllText("Cobranza.json");
            List<Venta> ArchivoCobranza = JsonConvert.DeserializeObject<List<Venta>>(ArchivoCarrito);

            foreach (var archivoCobranza in ArchivoCobranza)
            {
                if (archivoCobranza.idVenta == venta)
                {
                    if (archivoCobranza.cliente.nombre != null && 
                           archivoCobranza.cliente.apellido != null && 
                           archivoCobranza.cliente.domicilio != null &&
                           archivoCobranza.cliente.codigoPostal != null &&
                           archivoCobranza.cliente.localidad != null)
                    {
                        datosParaEnvioValidos = true;
                    }
                    Assert.True(datosParaEnvioValidos);
                    datosParaEnvioValidos = false;
                }
            }
            venta++;

        }
    }
}
