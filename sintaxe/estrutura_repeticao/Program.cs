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
            while (num <= num_vezes)/*Enquanto 1 for menor do que o número de vezes digitado pelo usauario, vai continuar a rodar, 
                                     */
            {
                Console.WriteLine("Olá Sako Afonso");   

                //Incrementa mais uma unidade para não entrar no loop infinito. 
                num++; //também poderia ser: num = num+1;
            }   
                Console.ReadKey();                              
        }
    }
}
