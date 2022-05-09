using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Autor: Saúl Contreras
/// Fecha: 06/05/22
/// Ejercicio: En un metodo bidimensional vas a pedir nombre y edades de cada uno de los alumnos y los vas a mostrar (5 alumnos)
/// </summary>

namespace Arrays
{
    public class EP2
    {

        public EP2()
        {
            
        }
        
        public string[,] SetInfo()
        {
            string[,] nombres_edades = new string[5, 2];

            for (int i = 0; i < 5; i++)
            {

                    Console.WriteLine("Nombre");
                    string? nombre = Console.ReadLine();
                    nombres_edades[i, 0] = nombre;
                    Console.WriteLine("Edad");
                    string? edad = Console.ReadLine();
                    nombres_edades[i, 1] = edad;

            }
            return nombres_edades;
        }

        public void GetInfo(string[,] nombresYedades)
        {
            Console.Clear();

            for (int i = 0; i < 5; i++)
            {

                    Console.Write("Nombre: ");
                    Console.WriteLine(nombresYedades[i, 0]);
                    Console.Write("Edad: "); 
                    Console.WriteLine(nombresYedades[i, 1]);
                    Console.WriteLine();

            }
            Console.ReadKey();
        }
    }



}
