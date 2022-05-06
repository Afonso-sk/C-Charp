using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// criar um programa para gerar numeros aleatorios e apresentar os min e os maximos.
namespace exeestrutrarepetcao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //primeirio vamos criar as variaveis

            int nums, min, max;
            Console.WriteLine("Quantos números aleatorios pretende gerar ? ");
            nums = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual é o minimo dos nºs a gerar ? ");
            min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual é o maxino dos nºs a gerar ?? ");
            max = Convert.ToInt32(Console.ReadLine());

            // criar aleatorio, já que não sabemos quantos os numeros o usaurio vai digitar, 
            //então fizemos uma estrura de repetição

           Random aleatorio = new Random();
            //já que não sabemos quantos os numeros o usaurio vai digitar, 
            //então fizemos uma estrura de repetição


            int num_gerado;


            while (nums > 0)
            {
                num_gerado = aleatorio.Next(min, max);

                Console.WriteLine($"{num_gerado}");

                if (num_gerado > maior)
                {
                    maior = num_gerado;
                }

                nums--;

                
            }

            Console.ReadKey();
        }
    }
}
