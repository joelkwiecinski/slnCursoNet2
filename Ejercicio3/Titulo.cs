using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Titulo
    {

        public string NombreAutor { get; set; }
        public string TituloTitulo { get; set; }
        public string Categoria { get; set; }
        public int Precio { get; set; }
        public string Notas { get; set; }

        public Titulo(string nombreAutor, string tituloTitulo, string categoria, int precio, string notas)
        {
            NombreAutor = nombreAutor;
            TituloTitulo = tituloTitulo;
            Categoria = categoria;
            Precio = precio;
            Notas = notas;
        }

        public Titulo() { }
    }
}
