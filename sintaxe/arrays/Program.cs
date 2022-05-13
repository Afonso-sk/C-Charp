using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Arrays : 
namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[5];

             
            valores[0] = 10;
            valores[1] = 100;
            valores[2] = 40;
            valores[3] = 28;
            valores[4] = 35;

            for(int i = 0; i < valores.Length; i++)

            {
                Console.Write($"{valores[i]} ");
            }

            Console.ReadKey();
        }
    }
}
