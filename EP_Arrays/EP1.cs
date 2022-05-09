using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Autor: Saúl Contreras
/// Fecha: 06/05/22
/// Ejercicio Propuesto: En un arreglo de 10 alumnos vas a pedir los nombre de cada uno de ellos usando un metodo recursivo y al final los vas mostrar
/// </summary>

namespace Arrays
{
    public class EP1
    {

        public EP1()
        {
            Console.WriteLine("En un arreglo de 10 alumnos vas a pedir los nombre de cada uno de ellos usando un metodo recursivo y al final los vas mostrar.");
            Console.WriteLine();
        }

        string[] alumnos = new string[10];

        int contadorAlumnos = 1;
        int i = 0;

        public void PedirNombre()
        {

            

            if (i < alumnos.Length)
            {
                Console.WriteLine($"Nombre del alumno {contadorAlumnos}");
                string alumno;
                alumno = Console.ReadLine();
                alumnos[i] = alumno;

                i++;
                contadorAlumnos++;

                PedirNombre();
            }

        }

        public void ImprimirLista()
        {
            int contador = 1;
            Console.Clear();

            for (int j = 0; j < alumnos.Length; j++)
            {
                Console.WriteLine($"Nombre del alumno {contador}: {alumnos[j]}");
                contador++;
            }
            Console.ReadKey();
        }
        

    }

}