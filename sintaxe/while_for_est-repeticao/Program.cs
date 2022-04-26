using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Fazer um programa para contar de 1 até 9. a contagem em programação começa sempre no 0.

namespace while_for_est_repeticao
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Exemplo com while");


            int contador = 0;

            while(contador < 10)
            {
                Console.WriteLine($"{contador} ");
                //contador = contador + 1;
                contador++; // para incremetar mais um em cada contagem até chegar no 10 e parar

    
            }
            // o for é mais usado quando a sequencia é sempre a mesma

            Console.WriteLine("\n\nExemplo com FOR");

            for(int cont = 0; cont < 10; cont++)
            {
                Console.WriteLine($"{cont} ");
            }
            Console.ReadKey();
        }
    }
}
