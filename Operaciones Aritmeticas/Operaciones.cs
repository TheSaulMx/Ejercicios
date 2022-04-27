using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OperacionesAritmeticas
{
    /// <summary>
    /// Autor:SaulMx
    /// Descripcion:Esta clase realiza cuatro operacions aritmeticas + - * /.
    /// Fecha: 20/04/22
    /// </summary>
    public class Operaciones
    {
        int num1;
        int num2;
        int resSuma;
        int resResta;
        int resMult;
        int resDiv;

        //Constructor. Debe ir vacío para permitir que se ejecute el código.
        public Operaciones()
        {
            
        }

        //Metodo Suma
        public void OperacionSuma()
        {
            num1 = 8;
            num2 = 2;
            resSuma = num1 + num2;
            Console.WriteLine("El resultado es: " + resSuma);
        }
        
        //Metodo Resta
        public void OperacionResta()
        {
            num1 = 8;
            num2 = 2;
            resResta = num1 - num2;
            Console.WriteLine("El resultado es: " + resResta);
        }
        
        //Metodo Multiplicacion
        public void OperacionMultiplicacion()
        {
            num1 = 8;
            num2 = 2;
            resMult = num1 * num2;
            Console.WriteLine("El resultado es: " + resMult);
        }
        
        //Metodo Suma
        public void OperacionDiv()
        {
            num1 = 8;
            num2 = 2;
            resDiv = num1 / num2;
            Console.WriteLine("El resultado es: " + resDiv);
        }


    }
}