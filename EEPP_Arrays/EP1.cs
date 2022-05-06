using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEPP_Arrays
{
    internal class EP1
    {

        public EP1()
        {

        }

        public void ArrayAlumnos()
        {
            string[] alumnos = new string[10];

            int contador = 1;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Ingrese el nombre del alumno {contador}");
                string nombreAlumno = Console.ReadLine();
                alumnos[i] = nombreAlumno;
                contador++;
            }
            
            Console.Clear();
            foreach (string i in alumnos) Console.WriteLine($"Nombre del alumno {i}");
        }
    }
}
