using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio3;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEjercicio3_Click(object sender, EventArgs e)
        {
            Autor autor1 = new Autor() { Nombre = "Julian", Apellido = "Alvarez", FechaNacimiento = new DateTime(1999,11,05), Domicilio = "Calle Falsa 123", Ciudad = "Junin", Pais = "Alemania" };
            Autor autor2 = new Autor() { Nombre = "Pepe", Apellido = "Rodriguez", FechaNacimiento = new DateTime(1850,06,20), Domicilio = "Avenida Siempre Viva 3234", Ciudad = "Abdul", Pais = "Hungría" };

            Empleado empleado1 = new Empleado() { Nombre = "Jorge", Apellido = "Bustos", Titulo = "Ingeniero electromecánico", FechaIngreso = new DateTime(1997, 05, 04) };
            Empleado empleado2 = new Empleado() { Nombre = "Sergio", Apellido = "Pereyra", Titulo = "Abogado", FechaIngreso = new DateTime(2008, 01, 28) };

            Venta venta1 = new Venta() { Tienda = "Leon", NumeroOrden = 324842, Fecha = new DateTime(2022, 11, 01), Cantidad = 3, Titulo = "Venta mil" };
            Venta venta2 = new Venta() { Tienda = "Hard", NumeroOrden = 2414, Fecha = new DateTime(2022, 10, 20), Cantidad = 10, Titulo = "Venta dos mil" };

            Publicador publicador1 = new Publicador() { Nombre = "Agustin", Ciudad = "Santa Fe", Domicilio = "España 472", Contacto = "34273184", Pais = "Argentina" };
            Publicador publicador2 = new Publicador() { Nombre = "Matias", Ciudad = "La Rioja", Domicilio = "Mitre 1934", Contacto = "275821924", Pais = "Argentina" };

            Titulo titulo1 = new Titulo() { NombreAutor = "Jorge Castañeda", TituloTitulo = "Mi libro", Categoria = "Autobiografía", Precio = 3247, Notas = "Una autobiografía de Jorge." };
            Titulo titulo2 = new Titulo() { NombreAutor = "Arturo Gualeguaychu", TituloTitulo = "Cuentos que no son cuentos", Categoria = "Historias reales", Precio = 100, Notas = "Leelo y sabrás." };

            MessageBox.Show("Objetos creados.");
        }
    }
}
