using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaFiguras
{
    public class Cuadrado : Figuras
    {
        public void Camina()
        {
            Console.WriteLine("El cuadrado camina...");
        }

        public override void Area(int lado, int lado2)
        {
            //base.Area();
            Console.WriteLine($"El área de un cuadrado es: {lado*lado2}");
        }
        public void Perimetro(int lado1, int lado2)
        {
            Console.WriteLine($"El perimetro de un cuadrado es: {lado1 * 4}");
        }
    }
}
