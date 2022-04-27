using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Escreva um programa que para escrver o primeiro e ultimo nome e ele exibir na tela 
 o primeiro e o ultimo nome*/
namespace exercicio2
{ 
   
    class Program
    {
        static void Main(string[] args)
        {
            string nome_completo;
            Console.WriteLine(" Qual é o teu primeiro e o último nome");
            nome_completo = Console.ReadLine();

            Console.WriteLine($" Primeiro Nome: {nome_completo.Substring(0, nome_completo.IndexOf(' '))}");


            Console.WriteLine($" Sobrenome: {nome_completo.Substring(nome_completo.IndexOf(' ') + 1) }");

            Console.ReadKey();
        }
    }
}
