using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Calcular a nota dos formandos

namespace notaformando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num_formando, num_formando_exato;
            double nota_formando;
            double media;
            double total = 0;

            Console.WriteLine("Queres inserir as notas de quantos formandos? ");
            num_formando = Convert.ToInt32(Console.ReadLine());
            num_formando_exato = num_formando;

            while (num_formando > 0)
            {
                Console.WriteLine(" Qual é a nota do formando? ");
                nota_formando = Convert.ToDouble(Console.ReadLine());
               
                total = total + nota_formando;

                num_formando--;

            }
            Console.WriteLine($" A média das notas é: {total / num_formando} ");                      
            Console.ReadKey();
        }                           
    }
}
