using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Estrutura de decisão

namespace estrutura_decisao
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            int num;
            Console.WriteLine("Que idade tens ? ");
            idade = Convert.ToInt32(Console.ReadLine());

            if(idade > 50)
            {
                Console.WriteLine("Tens mais de 50 anos de idade !!!");
            }
            else if(idade < 50)
            {
                Console.WriteLine("Tens menos de 50 anos de idade !!!");
            }
            else
            {
                Console.WriteLine("Tens 50 anos de idade");
            }

            /*
              Escreva um programa no qual aceite um número do usuário e identifique se o número é par 
            ou ímpar.
             */
            Console.WriteLine(" Digite o seu número");
            num = Convert.ToInt32(Console.ReadLine());

            if(num % 2 == 0) //

            {
                Console.WriteLine($"{num} é um número par !!!");
            }
            else
            {
                Console.WriteLine($"{num} é um número Impar !!!");
            }

            Console.ReadKey();
        }
    }
}
