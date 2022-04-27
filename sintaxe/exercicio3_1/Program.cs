using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Exibir a palavra que for rscrita, uma letra maiuscula e outra não,  e co cores diferentes*/
namespace exercicio3_1
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
                if(i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{frase.Substring(i, 1).ToUpper()}  ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{frase.Substring(i, 1).ToLower()}  ");
                }
            }

            Console.ReadKey();
        }
    }
}
