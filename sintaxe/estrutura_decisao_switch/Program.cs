using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//switch : instrução para selecionar um dos muitos blocos de código a serem executados.

namespace estrutura_decisao_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int day;

            label:
            Console.WriteLine("Digite a sua opção de (1-7) para dias de semana. Exemplo: 1 para segunda feira:\n");
            day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Segunda feira");
                    break;
                case 2:
                    Console.WriteLine("Terça feira");
                    break;
                case 3:
                    Console.WriteLine("Quarta feira");
                    break;
                case 4:
                    Console.WriteLine("Quinta feira");
                    break;
                case 5:
                    Console.WriteLine("Sexta feira");
                    break;
                case 6:
                    Console.WriteLine("Sábado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("Opção inválida, por favor, tente novamente \n");
                    goto label;
            }
            Console.ReadKey();
        }

        }
    }

