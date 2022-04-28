using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineApp
{
    public class Info : VarModel
    {

        public Info()
        {

        }

 
        public void InfoPersona()
        {

            Console.WriteLine("Ingrese su nombre:");

            name = Console.ReadLine();

            Console.Clear();

            Console.WriteLine($"Bienvenido, {name}!");
            Console.WriteLine("=================");
            Console.WriteLine();

        }

        

        public void InfoPelicula()
        {
            string mensaje = "La película que seleccionaste es:";

            Console.WriteLine("¿Cuál es tu edad?");

            edad = Convert.ToInt16(Console.ReadLine());

            Console.Clear();
            if (edad >= 18)
            {
                Console.WriteLine("Películas disponibles para ti");
                Console.WriteLine();
                Console.WriteLine("1.- Avengers");
                Console.WriteLine("2.- DeadPool");
                Console.WriteLine("3.- PawPatrol");

                Console.WriteLine();
                Console.WriteLine("Ingresa el número correspondiente a la película que deseas ver:");

                idpelicula = Convert.ToInt16(Console.ReadLine());



                if (idpelicula == 1)
                {
                    
                    Console.Clear();
                    Console.WriteLine($"Bienvenido, {name}!");
                    Console.WriteLine("=================");
                    Console.WriteLine();
                    Console.WriteLine($"{mensaje} Avengers");

                }
                else if (idpelicula == 2)
                {
                    Console.Clear();
                    Console.WriteLine($"Bienvenido, {name}!");
                    Console.WriteLine("=================");
                    Console.WriteLine();
                    Console.WriteLine($"{mensaje} DeadPool");
                }
                else if (idpelicula == 3)
                {
                    Console.Clear();
                    Console.WriteLine($"Bienvenido, {name}!");
                    Console.WriteLine("=================");
                    Console.WriteLine();
                    Console.WriteLine($"{mensaje} PawPatrol");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Bienvenido, {name}!");
                    Console.WriteLine("=================");
                    Console.WriteLine();
                    Console.WriteLine("Número de película invalido");
                }


            }

            if (edad >= 10)
            {
                Console.WriteLine("Películas disponibles para ti");
                Console.WriteLine();
                Console.WriteLine("1.- Avengers");
                Console.WriteLine("2.- PawPatrol");

                Console.WriteLine();
                Console.WriteLine("Ingresa el número correspondiente a la película que deseas ver:");

                idpelicula = Convert.ToInt16(Console.ReadLine());



                if (idpelicula == 1)
                {

                    Console.Clear();
                    Console.WriteLine($"Bienvenido, {name}!");
                    Console.WriteLine("=================");
                    Console.WriteLine();
                    Console.WriteLine($"{mensaje} Avengers");

                }
                else if (idpelicula == 2)
                {
                    Console.Clear();
                    Console.WriteLine($"Bienvenido, {name}!");
                    Console.WriteLine("=================");
                    Console.WriteLine();
                    Console.WriteLine($"{mensaje} PawPatrol");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Bienvenido, {name}!");
                    Console.WriteLine("=================");
                    Console.WriteLine();
                    Console.WriteLine("Número de película invalido");
                }


            }

            if (edad <= 10)
            {
                Console.WriteLine("La pelíccula disponible para ti es:");
                Console.WriteLine();

                Console.WriteLine("1.- PawPatrol");

                Console.WriteLine();
                Console.WriteLine("Ingresa el número correspondiente a la película");

                idpelicula = Convert.ToInt16(Console.ReadLine());



                if (idpelicula == 1)
                {
                    Console.Clear();
                    Console.WriteLine($"Bienvenido, {name}!");
                    Console.WriteLine("=================");
                    Console.WriteLine();
                    Console.WriteLine($"{mensaje} PawPatrol");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Bienvenido, {name}!");
                    Console.WriteLine("=================");
                    Console.WriteLine();
                    Console.WriteLine("Número de película invalido");
                }


            }


        }

        public void Confirmación()
        {
            Console.WriteLine($"La película seleccionada es {nomPelicula}");
            Console.WriteLine($"¿Es correcto?");

        }



    }

   


}
