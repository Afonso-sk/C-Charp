using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_advinhar_2_estrrepet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variavéis que iremos precisar
            int num_a_adivinhar;
            int num_tentativa_utilizador = 0;
            int num_tentativas = 0;
            string nome;
            string continuar = "S"; 

            //Aqui começa o meu jogo
            Console.WriteLine("\nDigite aqui o seu nome para começar a jogar\n");
            Console.WriteLine("\nQual é o seu nome ? ");
            nome = Console.ReadLine();
            Console.WriteLine($" Olá {nome}, Seja bem-vindo ao jogo de adivinha\n");
            Console.WriteLine("Escreva um número entre 1 a 100 para adivinhar o número aleatório gerado pelo jogo de adivinha\n");
            Console.WriteLine("Vamos começar ? \n");


            //declaração de Random para gerar numeros aleatorios
            Random aleatorio = new Random();
            num_a_adivinhar = aleatorio.Next(1, 100);

            //Console.WriteLine(num_a_adivinhar);

            // Enquanto que o continuar for igual a S ele vai jogar
               while(continuar == "S")
            {
                num_a_adivinhar = aleatorio.Next(1, 100);// para repetir o jogo
                num_tentativas = 0;
                num_tentativa_utilizador = 0;

                //======= Jogar ======

                //Enqunto numero a adivinhar for diferente do numero de tentativas pergunta qual é o seu palpite
                while (num_a_adivinhar != num_tentativa_utilizador)
                {
                    Console.WriteLine("Qual é o seu palpite ?\n ");
                    // e vou guardar na variavel num_tentativa_utilizador
                    num_tentativa_utilizador = Convert.ToInt32(Console.ReadLine());
                    num_tentativas++;// cada vez que o utilizador tentar vai dizer o numero de tentativas

                    if (num_a_adivinhar > num_tentativa_utilizador)
                    {
                        Console.WriteLine("O número a adivinhar é maior que o número digitado");
                    }
                    else if (num_a_adivinhar < num_tentativa_utilizador)
                    {
                        Console.WriteLine(" O número a adivinhar é menor que o número digitado");
                    }
                    else
                    {
                        Console.WriteLine($"Parabéns acertaste em {num_tentativas} tentativas !!! ");
                    }
                }

                Console.ReadKey();
                Console.WriteLine(" \nQueres continuar a jogar (S/N) ? ");                  
                continuar = Console.ReadLine();      
            }

            
        }
    }
}
