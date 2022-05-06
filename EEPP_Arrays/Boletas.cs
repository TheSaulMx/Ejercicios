using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEPP_Arrays
{
    public class Boletas
    {
        public Boletas()
        {
        }

        //public string[] Nombres()
        //{
        //    Console.WriteLine("¿Cuantos alumnos tiene?");
        //    int totalAlumnos = int.Parse(Console.ReadLine());

        //    string[] listaNombres = new string[totalAlumnos];

        //    int contador = 1;
        //    for (int i = 0; i < listaNombres.Length; i++)
        //    {
        //        Console.WriteLine($"Nombre del alumno {contador}");
        //        string nomalum = Console.ReadLine();
        //        listaNombres[i] = nomalum;

        //        contador++;
        //    }
        //    return listaNombres;
        //} 

        //public void getNombres()
        //{
        //    string[] TodosNombres = Nombres();
        //    Console.Clear();
        //    foreach (string i in TodosNombres)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        public void Boleta()
        {
            Console.WriteLine("¿Cuántos alumnos hay en el curso?");
            int totalAlumnos = int.Parse(Console.ReadLine());

            string[,] boleta = new string[totalAlumnos, totalAlumnos];

            int contador = 1;
            for (int i = 0; i < totalAlumnos; i++)
            {
                Console.Write($"Nombre del alumno {contador}:");
                string nombre = Console.ReadLine();
                boleta[i,0] = nombre;

                Console.Write($"Calificación: ");
                string calificacion = Console.ReadLine();
                boleta[i,1] = calificacion;

                Console.WriteLine();
                contador++;
            }
            Console.Clear();
            Console.WriteLine("Nombre:\nCalificación:");
            Console.WriteLine();
            foreach (var i in boleta)
            {
                Console.WriteLine(i); 
            }
        }
    }
}
