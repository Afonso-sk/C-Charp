using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)

        {
            string frase;
            Console.WriteLine(" Escreva uma frase");
            frase = Console.ReadLine();

            for (int i = 0; i < frase.Length; i++)
            {
                Console.WriteLine($"{frase.Substring(i, 1)}");
            }
            Console.ReadKey();
        }
    }
}
