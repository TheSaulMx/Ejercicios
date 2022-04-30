using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineApp
{
    public class Info : Variables 
    {

        public Info()
        {
        }

        public string NomPersona()
        { 
            Console.WriteLine("Ingrese su nombre:");
            Nombre = Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"Bienvenido, {Nombre}!");
            Console.WriteLine("=================");
            Console.WriteLine();

            return Nombre;
        }

        public int EdadPersona()
        {
            Console.WriteLine("¿Cuál es tu edad?");
            Edad = Convert.ToInt16(Console.ReadLine());

            return Edad;
        }

        public int Cartelera()
        {
            string mensaje = $"Hola, {Nombre}, las películas disponibles para ti son:";
            
            if (Edad >= 18) 
            { 
                Console.Clear();
                Console.WriteLine(mensaje);
                Console.WriteLine();

                Console.WriteLine("1.- Avengers");
                Console.WriteLine("2.- DeadPool");
                Console.WriteLine("3.- PawPatrol");
            }
                       
            else if (Edad < 18)
            {
                Console.Clear();
                Console.WriteLine(mensaje);
                Console.WriteLine();

                Console.WriteLine("1.- Avengers");
                Console.WriteLine("2.- PawPatrol");
            }

            Console.WriteLine();
            Console.WriteLine("Ingresa el número correspondiente a la película que deseas ver:");

            IdPelicula = Convert.ToInt16(Console.ReadLine());
            return IdPelicula;

        }
        
        public string SelecPelicula()
        {
            Console.Clear();
            string mensaje = "La película seleccionada es: ";
            string Avengers = "Avengers";
            string DeadPool = "DeadPool";
            string PawPatrol = "PawPatrol";

            if (Edad >= 18)
            {

                if (IdPelicula == 1)
                {
                    PeliSelec = Avengers;
                }

                else if (IdPelicula == 2)
                {
                    PeliSelec = DeadPool;
                }

                else if (IdPelicula == 3)
                {
                    PeliSelec = PawPatrol;
                }
                else 
                {
                    Cartelera();
                    SelecPelicula();
                }

            }
            if (Edad < 18)
            {

                if (IdPelicula == 1)
                {
                    PeliSelec = Avengers;
                }

                else if (IdPelicula == 2)
                {
                    PeliSelec = PawPatrol;
                }
                else
                {
                    Cartelera();
                    SelecPelicula();
                }

            }


            Console.WriteLine($"{mensaje} {PeliSelec}");
            return PeliSelec;

        }

        public void Confirmacion()
        {
            string y = "y";
            Console.Clear();
            Console.WriteLine($"{Nombre}, has seleccionado la película {PeliSelec}");
            Console.WriteLine();
            Console.WriteLine("¿Es correcto? y/n");

            Cancelar = Console.ReadLine();

            if (Cancelar == y)
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
