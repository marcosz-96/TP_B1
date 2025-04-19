using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Clases
{
    public class Revista : MaterialBibliografico
    {
        public Autor Autor { get; set; }
        public int volumen {  get; set; }
        public Revista(Autor autor, string titulo, int anio, int volumen) : base(autor, titulo, anio)
        {
            this.Autor = autor;
            this.volumen = volumen;
        }
        public Revista()
        {
        }
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"{Autor}");
            Console.WriteLine($"Volumen: {volumen}");
        }
    }
}
