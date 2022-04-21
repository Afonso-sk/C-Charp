using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Criar um programa para gerar números aleatorios e depois dizer se o número é impar ou par.

namespace estrtut_repeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nums_a_gerar;// declaração de variavel

            Console.WriteLine("Quantos números aleatórios pretendes gerar? ");
            nums_a_gerar = Convert.ToInt32(Console.ReadLine());

            Random aleatorio = new Random();
            int num_gerado;

            while (nums_a_gerar > 0) // Enquanto nº a gerado for maior que zero ele vai executar os numeros
            {
                num_gerado = aleatorio.Next(1, 1000);
                // estrutura de decisão dentro da estrutura de repetição
                if (num_gerado % 2 == 0)
                {
                    //Colocar cor no par
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"PAR - {num_gerado}");
                }
                else
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine($"IMPAR - {num_gerado}");
                }
                nums_a_gerar--;
               
            }
            Console.ReadKey();
        }
    }
}
