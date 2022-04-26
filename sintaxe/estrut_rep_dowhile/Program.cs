using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estrut_rep_dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // do while primeiro executa depois é que verifica

            Console.WriteLine(" Exemplo com do... while");
            int contador = 20;

            do
            {
                Console.WriteLine($"{contador} ");
                //contador = contador + 1;
                contador++; // para incremetar mais um em cada contagem até chegar no 10 e parar


            } while (contador < 2);

            Console.ReadKey();
        }
    }
}
