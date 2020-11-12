using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenShop___Despacho
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string codigoPostal { get; set; }
        public string domicilio { get; set; }
        public string localidad { get; set; }

        public Cliente(int idCliente, string nombre, string apellido, string codigoPostal, string domicilio, string localidad)
        {
            this.idCliente = idCliente;
            this.nombre = nombre;
            this.apellido = apellido;
            this.codigoPostal = codigoPostal;
            this.domicilio = domicilio;
            this.localidad = localidad;
        }
        public static List<Cliente> Clientes = new List<Cliente>();
    }

}
