using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Clases
{
    public class MaterialBibliografico
    {
        protected string titulo { get; set; }
        protected int anio { get; set; }

        private List<Libro> libros;
        private List<Ebook> ebooks;
        private List<Revista> revistas;

        public void AgregarBibliografia()
        {
            /*en la primera parte de la función "AgregarLibros" solicitamos los datos generales con los que estamos
            trabajando, luego creamos un submenú de opciones donde se pediran los datos especificos de las 
            subclases para guardar los datos*/
            Console.WriteLine(" Seleccione el tipo de libro que desea agregar");
            Console.WriteLine("<--------------------------------------------->");
            Console.WriteLine("1. Libros Físicos");
            Console.WriteLine("2. Libros virtuales (ebooks)");
            Console.WriteLine("3. Revistas");
            Console.Write("Opcion: ");
            string opcion = Console.ReadLine();

            //datos de la clase padre 
            Console.Write("Ingrese el título del libro: ");
            string titulo = Console.ReadLine();
            Console.Write("Ingrese el año de publicación: ");
            int anio = int.Parse(Console.ReadLine());

            //datos de la clase autor
            Console.Write("Ingrese el nombre del autor: ");
            string name = Console.ReadLine();
            Console.Write("Ingrese la edad del autor: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la nacionalidad del autor: ");
            string nationality = Console.ReadLine();

            //instanciamos la clase autor y guardamos los datos solicitados en una lista 
            Autor autor = new Autor(name, age, nationality);

            //en el submenú seleccionaremos en cuales de los tipos de libros se guardaran los datos
            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese la cantidad de páginas del libro: ");
                    int cantidadPaginas = int.Parse(Console.ReadLine());
                    Libro libro = new Libro(autor, titulo, anio, cantidadPaginas);
                    libros.Add(libro);
                    Console.WriteLine("Libro agregado exitosamente!");
                    break;
                case "2":
                    Console.Write("Ingrese cuantos MBs pesa el ebook: ");
                    int pesoMB = int.Parse(Console.ReadLine());
                    Ebook ebook = new Ebook(autor, titulo, anio, pesoMB);
                    ebooks.Add(ebook);
                    Console.WriteLine("Ebook agregado exitosamente!");
                    break;
                case "3":
                    Console.Write("Ingrese el volumen de la revista: ");
                    int volumen = int.Parse(Console.ReadLine());
                    Revista revista = new Revista(autor, titulo, anio, volumen);
                    revistas.Add(revista);
                    Console.WriteLine("Revista agregada exitosamente!");
                    break;
                default:
                    Console.WriteLine("Opción incorrecta, seleccione una opción del menú.");
                    break;
            }
        }

        public void EliminarBibliografia()
        {
            /*Esta es una función general con un submenu que llama a las funciones de eliminar según 
            el tipo de bibliografía que se deseé eliminar*/
            Console.WriteLine(" Seleccione el tipo de libro que desea eliminar");
            Console.WriteLine("<---------------------------------------------->");
            Console.WriteLine("1. Libros Físicos");
            Console.WriteLine("2. Libros virtuales (ebooks)");
            Console.WriteLine("3. Revistas");
            Console.Write("Opcion: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    //la siguiente función recorre y compara el título ingresado para luego eliminarlo de la lista
                    Console.Write("Ingrese el título del Libro que desea eliminar de la lista: ");
                    string eliminarLibro = Console.ReadLine();

                    bool existeLibro = true;
                    
                    List<Libro> libros = new List<Libro>();

                    foreach (var libro in libros.ToList()) //utilizamos ToList para no realizar modificaciones mientras se recorre la lista
                    {
                        if(existeLibro == libro.titulo.Equals(eliminarLibro, StringComparison.OrdinalIgnoreCase))
                        {
                            libros.Remove(libro);
                            Console.WriteLine($"Se eliminó de la lista el libro con el título {eliminarLibro}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"No se encontró el libro con el título {eliminarLibro}");
                        }
                    }
                    break;
                case "2":
                    //la siguiente función recorre y compara el título ingresado para luego eliminarlo de la lista
                    Console.Write("Ingrese el título del Ebook que desea eliminar de la lista: ");
                    string eliminarEbook = Console.ReadLine();

                    bool existeEbook = true;

                    List<Ebook> ebooks = new List<Ebook>();

                    foreach (var ebook in ebooks.ToList())
                    {
                        if (existeEbook == ebook.titulo.Equals(eliminarEbook, StringComparison.OrdinalIgnoreCase))
                        {
                            ebooks.Remove(ebook);
                            Console.WriteLine($"Se eliminó de la lista el Ebook con el título {eliminarEbook}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"No se encontró el Ebook con el título {eliminarEbook}");
                        }
                    }
                    break;
                case "3":
                    //la siguiente función recorre y compara el título ingresado para luego eliminarlo de la lista
                    Console.Write("Ingrese el título del Revista que desea eliminar de la lista: ");
                    string eliminarRevista = Console.ReadLine();

                    bool existeRevista = true;

                    List<Revista> revistas = new List<Revista>();

                    foreach (var revista in revistas.ToList())
                    {
                        if (existeRevista == revista.titulo.Equals(eliminarRevista, StringComparison.OrdinalIgnoreCase))
                        {
                            revistas.Remove(revista);
                            Console.WriteLine($"Se eliminó de la lista la revista con el título {eliminarRevista}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"No se encontró la revista con el título {eliminarRevista}");
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Opción incorrecta. Ingrese un opción del menú.");
                    break;
            }
        }
        public MaterialBibliografico(string titulo, int anio)
        {
            this.titulo = titulo;
            this.anio = anio;
        }
        public MaterialBibliografico()
        {
        }
        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Titulo: {titulo}");
            Console.WriteLine($"Año Publicado: {anio}");
        }
    }
}
