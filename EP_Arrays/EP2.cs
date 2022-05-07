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

        string[,] nombres_edades = new string[5, 2];

        public void SetInfo()
        {
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("Nombre");
                    string nombre = Console.ReadLine();
                    nombres_edades[i, 0] = nombre;
                    Console.WriteLine("Edad");
                    string edad = Console.ReadLine();
                    nombres_edades[j, 1] = edad;
                }

            }
        }

        public void GetInfo()
        {
            Console.Clear();
            
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("Nombre: ");
                    Console.WriteLine(nombres_edades[i, 0]);
                    Console.Write("Edad: "); 
                    Console.WriteLine(nombres_edades[j, 1]);
                    Console.WriteLine();

                }
            }
            Console.ReadKey();
        }
    }



}
