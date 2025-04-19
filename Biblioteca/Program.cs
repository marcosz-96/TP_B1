using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;
using Biblioteca.Clases;


namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanciamos la clase principal
            MaterialBibliografico MB = new MaterialBibliografico();
            //creamos una variable de tipo bool para la ejecición del programa
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("<---¡Bienvenido!--->");
                Console.WriteLine("--------------------");
                Console.WriteLine("Seleccione una opción del menú");
                Console.WriteLine("1. Agregar Bibliografía");
                Console.WriteLine("2: Eliminar Bibliografía");
                Console.WriteLine("3. Para salir");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        MB.AgregarBibliografia();
                        break;
                    case "2":
                        MB.EliminarBibliografia();
                        break;
                    case "3":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta. Ingrese una opcón del menú");
                        break;
                }
            }
        }
    }
}
