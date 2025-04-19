using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Clases
{
    public class Ebook : MaterialBibliografico
    {
        public Autor Autor { get; set; }
        public int pesoMB {  get; set; }
        public Ebook(Autor autor, string titulo, int anio, int pesoMB) : base(autor, titulo, anio)
        {
            this.Autor = autor;
            this.pesoMB = pesoMB;
        }
        public Ebook()
        {
        }
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"{Autor}");
            Console.WriteLine($"Pesa: {pesoMB}MB");
        }
    }
}
