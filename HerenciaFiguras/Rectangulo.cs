using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaFiguras
{
    public class Rectangulo : Figuras
    {

        public void Vuela()
        {
            Console.WriteLine("El rectángulo vuela");
        }

        public override void Area(int lado, int lado2)
        {
            //base.Area(lado, lado2);
            Console.WriteLine($"El área de un rectángulo es: {lado * lado2}");
        }

        public void Perimetro(int lado, int lado2)
        {
            Console.WriteLine("El perimetro de un rectángulo es: " + (lado + lado + lado2 + lado2));
        }

    }
}
