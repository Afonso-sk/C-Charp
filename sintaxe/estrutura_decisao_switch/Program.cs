using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//switch : instrução para selecionar um dos muitos blocos de código a serem executados.
/*break: Sai do bloco switch(interromperá a execução e teste de case dentro do bloco)
 Quando uma correspondência é encontrada e o trabalho está concluído, é hora de uma pausa. Não há necessidade de mais
testes.
 */
//A default palavra-chave é opcional e especifica algum código a ser executado se não houver correspondência entre maiúsculas e minúsculas:

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
                    Console.WriteLine("Opção inválida, por favor, tente novamente \n\n");
                    goto label;
            }
            // Segundo exemplo:

            Console.WriteLine("=== Segundo Exemplo ====");

            int days = 4;
            switch (days)
            {
                case 1:
                    Console.WriteLine("Monday\n");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }

            Console.ReadKey();
        }

        }
    }

