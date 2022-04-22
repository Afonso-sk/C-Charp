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
            int num_formando, num_formando_exato; // acrescentei o num_formando_exato porque não estava a dar valor exato ao dividir o total.
            double nota_formando;
            double total = 0;

            Console.WriteLine("Queres inserir as notas de quantos formandos? ");  
            num_formando = Convert.ToInt32(Console.ReadLine());
            num_formando_exato = num_formando; // igualei o num_formando_exado a num_formando para divisão dar um valor correto

            while (num_formando > 0)
            {
                Console.WriteLine(" Qual é a nota do formando? ");
                nota_formando = Convert.ToDouble(Console.ReadLine());

                total = total + nota_formando;


                num_formando--;

            }
            Console.WriteLine($" o total é {total}\n");
            Console.WriteLine($"{total/num_formando_exato}");                     
            Console.ReadKey();
        }                           
    }
}
