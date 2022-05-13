using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Criar um programa para gearar numeros aleatórios e apresentar os minimos e maximos
namespace arrays_ex1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int nums, min, max;
            Console.WriteLine("Quantos números aleatorios pretendes gerar ?   ");
            nums = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual é o minimo dos numeros a gerar ?   ");
            min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual é o máximo dos números a gerar ?   ");
            max = Convert.ToInt32(Console.ReadLine());


            int[] valores = new int[nums];
            
            Random random = new Random();

            for (int i = 0; i < valores.Length; i++)

            {
                valores[i] = random.Next(min, max);
            }

            for (int i = 0; i < valores.Length; i++)

            {
                Console.Write(valores[i]);
            }

            Console.WriteLine("\n -------- Pares ------\n ");
             
            for (int i = 0; i < valores.Length; i++)

            {
                if (valores[i] % 2 == 0)
                {
                    Console.Write($"{valores[i]} ");
                }
            }

            Console.WriteLine("\n -------- impares ------\n ");

            for (int i = 0; i < valores.Length; i++)

            {
                if (valores[i] % 2  != 0)
                {
                    Console.Write($"{valores[i]} ");
                }
            }

            Console.WriteLine("\n -------- par/impares ------\n ");

            for (int i = 0; i < valores.Length; i++)

            {
                if (valores[i] % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor= ConsoleColor.Green;
                }

                Console.Write($"{valores[i]}  ");
            }



            Console.ReadKey(); 

        }
    }
}
