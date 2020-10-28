using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenShop___Despacho
{
    class Cliente
    {
        public int idCliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string mail { get; set; }
        public string usuario { get; set; }
        public string contrasena { get; set; }
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
            this.contrasena = contraseña;
            this.dni = dni;
            this.domicilio = domicilio;
            this.telefono = telefono;
        }

    }
}
