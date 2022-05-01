using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // aqui chamamos a função soma
            Console.WriteLine($" A soma de 4 + 5 é {soma(4, 5)} e subtração é {subtracao(4 , 5)}");
            Console.WriteLine($" A soma de 10 + 5 é {soma(4, 5)} e subtração é {subtracao(10, 5)}");
            Console.ReadKey();
        }
        // Criar uma função nossa e essa função pode ser chamada qts vzs quisermos
         static int soma (int x , int y)
        {
            return x + y;
        }

        static int subtracao(int x, int y)
        {
            return x - y;
        }


    }
}
