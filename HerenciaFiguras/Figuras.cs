using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaFiguras
{
    public class Figuras
    {
        public void nombreFigura(string nomFigura)
        {
            Console.WriteLine($"El nombre de la figura es: {nomFigura}");
        }
        public void numeroLados(int numLados)
        {
            Console.WriteLine($"La cantidad de número de lados que tiene es: {numLados}");   
        }
        public virtual void Area(int lado, int lado2)
        {
            Console.WriteLine("El área es:");
        }
        public void Perimetro(int lado, int lado2)
        {
            Console.WriteLine("El perimetro es:");
        }
    }

}
