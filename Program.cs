using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositivoMedia1060
{
    class Program
    {
        static void Main(string[] args)
        {
            double media;
            double valor = 0;
            int i = 1;
            int j = 0;
            for (i = 1; i < 7; i++)
            {
                double n = double.Parse(Console.ReadLine());
                if (n >= 0.1)
                {
                    valor += n;
                    j = j + 1;
                }

            }
            media = valor / j;
            Console.WriteLine(j + " valores positivos");
            //Console.WriteLine(valor);
            Console.WriteLine(media.ToString("#0.0"));
            Console.ReadKey();
        }
    }
}
