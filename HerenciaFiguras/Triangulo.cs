using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaFiguras
{
    public class Triangulo : Figuras 
    {
        public void Corre()
        {
            Console.WriteLine("El triángulo corre...");
        }

        public override void Area(int lado1, int lado2)
        {
            //base.Area(lado, lado2);
            Console.WriteLine("El área de un triángulo es: " + (lado1 * lado2)/(2) );
        }

        public void Perimetro(int lado1, int lado2)
        {
            Console.WriteLine($"El perimetro de un triángulo es: {lado1 + lado1 + lado2}");
        }
    }
}
