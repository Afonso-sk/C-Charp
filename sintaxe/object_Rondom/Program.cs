using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Gerar números aleatórios
namespace object_Rondom
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa para gerar numero aleatório entre 1 e 100. para isso vamos usar o objeto Random

            Random aleatorio = new Random(); /*Estou a dizer vai lá dentro do objeto Random, cria uma variaerl
            Chamada aleatorio que eu quero usar. podemos ver as definições do Random, clicando no botão direiro
            ensima do Random
            */
            Console.WriteLine(aleatorio.Next(1, 100)); // número aleatorio entre 1 e 100.

            Console.ReadKey();
        }
    }
}
