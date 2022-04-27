using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Escreva um programa para escrever letra por letra a frase que for idigigtada na tel

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
                Console.Write($"{frase.Substring(i, 1)}  ");
            }

            Console.ReadKey();
        }
    }
}
