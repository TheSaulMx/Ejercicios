using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Autor: Saúl Contreras
/// Fecha: 06/05/22
/// Ejercicio Propuesto: En una lista guardar un catalogo de peliculas despues de 5 peliculas tendras que agregar dos mas y mostrar la primera y la ultima pelicula 
/// </summary>

namespace Arrays
{
    public class EP4
    {
        public EP4()
        {
            Console.WriteLine("En una lista guardar un catalogo de peliculas despues de 5 peliculas tendras que agregar dos mas y mostrar la primera y la ultima pelicula");
            Console.WriteLine();
        }

        public List<string> ListaPeliculas()
        {

            
            List<string> peliculas = new List<string>();

            peliculas.Add("Avengers");
            peliculas.Add("Titanic");
            peliculas.Add("Matrix");
            peliculas.Add("SpiderMan");
            peliculas.Add("Muy Parecido al Amor");

            Console.WriteLine("La lista de películas es:");
            Console.WriteLine("=========================");

            foreach (string item in peliculas)
            {
                Console.WriteLine(item);
            }
            return peliculas;
        }

        public void Agregar(List<string> peliculas)
        {

            Console.WriteLine();
            Console.Write("Nombre de la película a agregar:");
            string? addpeli = Console.ReadLine();
            peliculas.Add(addpeli);

            foreach (var item in peliculas)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("¿Desea agregar más películas? y/n");
            string? respuesta = Console.ReadLine();

            if (respuesta == "y")
            {
                Console.Clear();
                Agregar(peliculas);
            }
            else
            {   
                string first = peliculas.First();
                Console.WriteLine($"La primera película de la lista es: {first}");
                string last = peliculas.Last();
                Console.WriteLine($"La última película de la lista es: {last}");
            }


            Console.ReadKey();
        }
    }
}
