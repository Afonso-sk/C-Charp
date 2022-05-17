using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// pedir ao utilizador para escrever uma frase, apresentar as vogsis
// em verde e restantes catacteres em vermelho.
namespace exe2arrarys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expressao;

            Console.WriteLine(" Escreva uma expressão");
            expressao = Console.ReadLine();
 
            for(int i = 0; i < expressao.Length; i++)
            {
                if (expressao.Substring(i, 1) == "a" || expressao.Substring(i, 1) == "e" || expressao.Substring(i, 1) == "i" || expressao.Substring(i, 1) == "o" || expressao.Substring(i, 1) == "u")

                {
                 Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.Write(expressao.Substring(i, 1));
            }

           Console.ReadKey();
        }
    }
}
