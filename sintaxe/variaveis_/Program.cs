using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Escreva um programa no qual aceite os detalhes do usuário como nome, cidade, idade e número do PIN.
Em seguida, armazene todos os valores na variável apropriada e imprima todas as informações no formato 
correto.
 */

namespace variaveis_
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string city;
            sbyte age;
            int pin;

            // \n é usado para quebra de linha
            Console.WriteLine("Escreva o seu nome \n");
            name = Console.ReadLine();

            Console.WriteLine("Escreva a sua cidade \n");
            city = Console.ReadLine();

            Console.WriteLine("Escreva a sua idade \n");
            age = sbyte.Parse(Console.ReadLine());

            Console.WriteLine("Escreva a sua senha \n");
            pin = Int32.Parse(Console.ReadLine());

            // Imprimir as informações preenchidas na aplicação console

            //formatting output
            Console.WriteLine("==============");
            Console.WriteLine("O seu endereço completo:");
            Console.WriteLine("============\n");

            Console.WriteLine($"Nome = {name}");
            Console.WriteLine($"Ciidade = {city}");
            Console.WriteLine($"Idade = {age} anos");
            Console.WriteLine($"Senha = {pin}");
            Console.WriteLine("===============");

            Console.ReadKey();
        }
    }
}
