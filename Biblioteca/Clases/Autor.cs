using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Clases
{
    public class Autor
    {
        string name {  get; set; }
        int age {  get; set; }
        string nationality {  get; set; }

        public Autor(string name, int age, string nationality)
        {
            this.name = name;
            this.age = age;   
            this.nationality = nationality;
        }

        public Autor()
        {
        }
       
        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre del autor: {name}");
            Console.WriteLine($"Edad: {age}");
            Console.WriteLine($"Nacionalidad: {nationality}");
        }
       
    }
}
