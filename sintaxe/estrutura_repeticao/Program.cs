using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 // As principais Estrutura de Repetição ( while, do while, for, foreach)
namespace estrutura_repeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int num_vezes;

            Console.WriteLine("Qauntas vezes queres escrever a frase ?");
            num_vezes = Convert.ToInt32(Console.ReadLine());
            while (num <= num_vezes)/*Enquanto 1 for número digitado for menor que número de vezes*/
            {
                Console.WriteLine("Olá Sako Afoonso");

                //Incremento de uma unidade, para não entrar no loop infinito
                num++;
            }
                Console.ReadKey();
        }
    }
}
