using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Entidades
{
    public class Vendedor: Persona
    {
        public string DNI { get; set; }

        public Vendedor(string nombre, string apellido, string email, string telefono, string direccion, string dni):base(nombre, apellido, email, telefono, direccion)
        {
            DNI = nombre;
        }

        public Vendedor() { }

    }
}
