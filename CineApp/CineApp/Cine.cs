using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineApp
{
    public class Cine : Variables 
    {

        public Cine()
        {
        }

        public string NomPersona()
        { 
            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"Bienvenido, {nombre}!");
            Console.WriteLine("=================");
            Console.WriteLine();

            return nombre;
        }

        public int EdadPersona()
        {
            Console.WriteLine("¿Cuál es tu edad?");
            edad = Convert.ToInt16(Console.ReadLine());

            return edad;
        }

        public int Cartelera()
        {
            string mensaje = $"Hola, {nombre}, las películas disponibles para ti son:";
            
            if (edad >= 18) 
            { 
                Console.Clear();
                Console.WriteLine(mensaje);
                Console.WriteLine();

                Console.WriteLine("1.- Avengers");
                Console.WriteLine("2.- DeadPool");
                Console.WriteLine("3.- PawPatrol");
            }
                       
            else if (edad < 18)
            {
                Console.Clear();
                Console.WriteLine(mensaje);
                Console.WriteLine();

                Console.WriteLine("1.- Avengers");
                Console.WriteLine("2.- PawPatrol");
            }

            Console.WriteLine();
            Console.WriteLine("Ingresa el número correspondiente a la película que deseas ver:");

            idPelicula = Convert.ToInt16(Console.ReadLine());
            return idPelicula;

        }
        
        public string SelecPelicula()
        {
            Console.Clear();
            string mensaje = "La película seleccionada es: ";
            string Avengers = "Avengers";
            string DeadPool = "DeadPool";
            string PawPatrol = "PawPatrol";

            if (edad >= 18)
            {

                if (idPelicula == 1)
                {
                    peliSelec = Avengers;
                }

                else if (idPelicula == 2)
                {
                    peliSelec = DeadPool;
                }

                else if (idPelicula == 3)
                {
                    peliSelec = PawPatrol;
                }
                else 
                {
                    Cartelera();
                    SelecPelicula();
                }

            }
            if (edad < 18)
            {

                if (idPelicula == 1)
                {
                    peliSelec = Avengers;
                }

                else if (idPelicula == 2)
                {
                    peliSelec = PawPatrol;
                }
                else
                {
                    Cartelera();
                    SelecPelicula();
                }

            }


            Console.WriteLine($"{mensaje} {peliSelec}");
            return peliSelec;

        }

        public void Confirmacion()
        {
            string y = "y";
            Console.Clear();
            Console.WriteLine($"{nombre}, has seleccionado la película {peliSelec}");
            Console.WriteLine();
            Console.WriteLine("¿Es correcto? y/n");

            cancelar = Console.ReadLine();

            if (cancelar == y)
            {
                Console.Clear();
                Console.WriteLine("================================");
                Console.WriteLine("| ¡¡Que disfrutes la función!! |");
                Console.WriteLine("================================");
            }
            else
            {
                Cartelera();
                SelecPelicula();
                Confirmacion();
            }

        }

    }

}
