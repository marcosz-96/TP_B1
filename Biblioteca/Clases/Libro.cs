using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Clases
{
    public class Libro : MaterialBibliografico
    {
        public Autor Autor { get; set; }
        public int cantidadPaginas {  get; set; }

        public Libro(Autor autor, string titulo, int anio, int cantidadPagians) : base(titulo, anio)
        {
            this.Autor = autor;
            this.cantidadPaginas = cantidadPaginas;
        }
        public Libro()
        {
        }
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"{Autor}");
            Console.WriteLine($"Cantidad de páginas: {cantidadPaginas}");
        }
    }
}
