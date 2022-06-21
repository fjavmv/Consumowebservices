using ServicioClientePublico.ServiceReference2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioClientePublico.modelo
{
    public class UsuarioC
    {
        public string nombre { get; set; }
        public string apellidoP { get; set; }
        public string apellidoM { get; set; }
        

        public UsuarioC(string nombre, string apellidoP, string apellidoM)
        {
            this.nombre = nombre;
            this.apellidoP = apellidoP;
            this.apellidoM = apellidoM;
        }

        public UsuarioC()
        {

        }

        public override string ToString()
        {
            return "Nombre: " + nombre + "\n" + "Apellido Paterno: " + apellidoP + "\n" + "Apellido Materno: " + apellidoM;
        }

    }
}