using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEPP_Arrays
{
    internal class EP2
    {
        public EP2()
        {

        }

        public void Nombre_Edades()
        {
            string[] nom_edad = new string[5];

            int contador = 1;
            for (int i = 0; i < 5;  i++)
            {
                Console.WriteLine($"¿Cuál es el nombre del niño {contador}?");
                nom_edad[i] = Console.ReadLine();

               
                contador++;
            }

            Console.Clear();
            foreach (string i in nom_edad)
            {
                Console.WriteLine(i);
            }

        }
    }
}
