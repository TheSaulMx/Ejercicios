using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Ejercicio Propuesto: Uso de for
/// Autor: Saúl Contreras
/// Fecha: 03/05/22
/// Tutor: Julian Lara
/// </summary>

namespace UsodeFor
{
    public class UsoDeFor
    {

        public UsoDeFor()
        {

        }

        public void ContadorxTres()
        {
            Console.WriteLine("Contador con aumento de 3 en 3");
            Console.WriteLine();
            for (int i = 0; i <= 30; i+=3)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine("Pulse cualquier tecla para el siguiente ejercicio.");
            Console.ReadKey();
            Console.Clear();
        }

   
        //public void CompararParImpar()
        //{
        //    Console.WriteLine("Comparador de números pares e impares");
        //    Console.WriteLine();
            
        //    for (int i = 1; i <= 50; i++)
        //    {
        //        if (i % 2 == 0) Console.WriteLine($"El número {i} es par");
 
        //        else Console.WriteLine($"El número {i} es impar");
        //    }

        //    Console.WriteLine();
        //    Console.WriteLine("Pulse cualquier tecla para el siguiente ejercicio.");
        //    Console.ReadKey();
        //    Console.Clear();
        //}

        

        public void Comparar()
        {
            Console.WriteLine("Comparador de números pares e impares");
            Console.WriteLine();

            for (int i = 1; i <= 50; i++) 
            {
                if (i % 2 == 0) Console.WriteLine($"El número {i} es par");

                else if (i % 2 != 0) Console.WriteLine($"El número {i} es impar");

            }

            Console.WriteLine();
            Console.WriteLine("Pulse cualquier tecla para el siguiente ejercicio.");
            Console.ReadKey();
            Console.Clear();
        }

        public void TablaMultiplicar()
        {
            Console.WriteLine("Ingrese el número del que desa obtener la tabla");
            int num = Int16.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine($"Tabla de multiplicar del {num} es:");
            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {(i * num)}");
            }

        }

    }

}
