﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OpenShop___Despacho
{
    public partial class ProductosVendidos : Form
    {
        public ProductosVendidos()
        {
            InitializeComponent();
        }

        private void Siguiente1_Click(object sender, System.EventArgs e)
        {
            using (DatosCliente ventanaDatosCliente = new DatosCliente())
                ventanaDatosCliente.ShowDialog();
           
        }

        private void ProductosVendidos_Load(object sender, System.EventArgs e)
        {
            rellenarCampoProductosVendidos();
        }

        void rellenarCampoProductosVendidos()
        {
            if (System.IO.File.Exists("Cobranza.json"))
            {
                string ArchivoCarrito = System.IO.File.ReadAllText("Cobranza.json");
                List<Venta> ArchivoCobranza = JsonConvert.DeserializeObject<List<Venta>>(ArchivoCarrito);

                int venta = 1;
               
                foreach (var archivoCobranza in ArchivoCobranza)
                {

                    if(archivoCobranza.idVenta == venta)
                    {
                        dataProductosVendidos.Rows.Add(archivoCobranza.productos.nombre, archivoCobranza.productos.marca, archivoCobranza.productos.descripcion);
                        Producto.Productos.Add(new Producto(archivoCobranza.productos.idProducto, archivoCobranza.productos.nombre, archivoCobranza.productos.marca, archivoCobranza.productos.descripcion));
                    }
                    
                }

                venta++;
            }
        }

     
    }
}
