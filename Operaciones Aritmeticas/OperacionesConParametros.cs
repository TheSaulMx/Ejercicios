using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesAritmeticas
{
    /// <summary>
    /// Autor:SaulMx
    /// Descripcion:Esta clase realiza cuatro operacions aritmeticas + - * / utilizando parametros y return.
    /// Fecha: 20/04/22
    /// </summary>
    public class OperacionesConParametros
    {

        public OperacionesConParametros()
        {

        }

        //Metodo Suma
        public void OperacionSuma(int num1,int num2)
        {
            int resSuma = num1 + num2;
            Console.WriteLine("El resultado es: " + resSuma);
        }

        //Metodo Resta
        public void OperacionResta(int num1, int num2)
        {
            var resResta = num1 - num2;
            Console.WriteLine("El resultado es: " + resResta);
        }

        //Metodo Multiplicacion
        public void OperacionMultiplicacion(int num1, int num2)
        {
            var resMult = num1 * num2;
            Console.WriteLine("El resultado es: " + resMult);
        }

        //Metodo Suma
        public void OperacionDiv(decimal num1, decimal num2)
        {
            var resDiv = num1 / num2;
            Console.WriteLine("El resultado es: " + resDiv);
        }
    }
}
