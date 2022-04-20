using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Fazer um programa para gerar numeros aleatorios em numero de vezes digitado. exe: gerar 5 nºs aleatorios
namespace estrutura_repeticao_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nums_a_gerar;// declaração de variavel

            Console.WriteLine("Quantos números aleatórios pretendes gerar? ");
            nums_a_gerar = Convert.ToInt32(Console.ReadLine());

            Random aleatorio = new Random();
            int num_aleatorio;

            while( nums_a_gerar > 0) // Enquanto nº a gerar for maior que zero ele vai executar os numeros
            {
                num_aleatorio = aleatorio.Next(1, 100);
              //  Console.WriteLine(num_aleatorio); ou poderiar ser:
                 Console.WriteLine($"{nums_a_gerar} -  {num_aleatorio}");
                nums_a_gerar--; //ou num_a_gerar = num_a_gerar-1|| decremento um número para não entrar  ko lop infinito
            }
            Console.ReadKey();
        }
    }
} 
