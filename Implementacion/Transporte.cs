using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenShop___Despacho
{
    public class Transporte
    {
        public int idTransporte { get; set; }
        public string nombre { get; set; }
        public string domicilio { get; set; }
        public int precio { get; set; }

        public Transporte(int idTransporte, string nombre, string domicilio, int precio)
        {
            this.idTransporte = idTransporte;
            this.nombre = nombre;
            this.domicilio = domicilio;
            this.precio = precio;
        }

        public static List<Transporte> Transportes = new List<Transporte>();

        static public void RegistrarTransporte()
        {
            Transportes.Add(new Transporte(1, "Correo Argentino", "Juan B Alberdi 198", 900));
            Transportes.Add(new Transporte(2, "Ocasa", "Av. Juan de Garay 1294", 800));
            Transportes.Add(new Transporte(3, "Oca", "Av. Urquiza 874", 750));
            Transportes.Add(new Transporte(4, "Andreani", "Bv. 9 de Julio 1852", 1000));
            
            var TransporteJson = JsonConvert.SerializeObject(Transportes, Formatting.Indented);
            System.IO.File.WriteAllText("Transportes.Json", TransporteJson);

        }

    }
}
