using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objet_Random_estrutura_decisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int numero_gerado = aleatorio.Next(1, 1000);
            Console.WriteLine(numero_gerado);

            if(numero_gerado > 500)
            {
                Console.WriteLine("O número gerado é superior que 500");
            }
            else if(numero_gerado < 500)
            {
                Console.WriteLine("o número gerado é inferior a 500");
            }
            else
            {
                Console.WriteLine(" o número gerado é 500");
            }
            Console.ReadKey();
        }
    }
}
