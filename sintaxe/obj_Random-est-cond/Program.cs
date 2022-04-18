using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obj_Random_est_cond
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int numero_gerado = aleatorio.Next(1, 1000);
            Console.WriteLine(numero_gerado);

            // % significa Resto da divisão
            // == comparação - isso serve para fazer comparação
            // = atribuição

            if(numero_gerado % 2 == 0) // estou a comparar se o resto do numero gerado / 2 vai ser 0? se for
            {
                Console.WriteLine("O número é par");
            }
            else
            {
                Console.WriteLine("O número é impar");
            }
            Console.ReadKey();
        }
    }
}
