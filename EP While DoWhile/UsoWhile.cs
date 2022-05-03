using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP_While_DoWhile
{
    public class UsoWhile
    {
        public int c { get; set; }

        public UsoWhile()
        {
        }

        public void ContadorMas()
        {
            int c = 1;

            while (c <= 20)
            {
                Console.WriteLine(c);
                c++;
                System.Threading.Thread.Sleep(500);
            }
            Console.WriteLine("==");

        }  

        public void ContadorMenos()
        {
            int c = 20;

            do
            {
                Console.WriteLine(c);
                c--;
                System.Threading.Thread.Sleep(500);
            } while (c > 0);

        }

    }



}
