using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenShop___Despacho
{
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
}
