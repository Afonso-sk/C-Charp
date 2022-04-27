using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//gerar chaves aleatorios de euromilhoes

namespace chaveeuromilgoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();

            Console.WriteLine("Quantas chaves pretendes gerar ? ");
            int num_chaves = Convert.ToInt32(Console.ReadLine());

            while (num_chaves > 0)
            {

                int numeros = 5; 

                while (numeros > 0)
                {

                    Console.Write($"{aleatorio.Next(1, 50)}  ");
                    numeros--;
                }
                Console.Write(" - ");

                //numeros de estrelas
                int estrelas = 2;

                while (estrelas > 0)
                {
                    Console.Write($"{aleatorio.Next(1, 12)} ");
                    estrelas--;
                }

                num_chaves--;
                Console.WriteLine("\n"); 
            }
            Console.ReadKey();
        }
    }
}
