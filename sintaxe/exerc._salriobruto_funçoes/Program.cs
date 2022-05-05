using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Criar um programa para fazer emprestimos, e dizer se o credito +´´e aprovado ou não?
namespace exerc._salriobruto_funçoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int salario_bruto;
            int prestacao;

            Console.WriteLine("Qual é o salário bruto ? ");
            salario_bruto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual é a prestação pretendida ? ");
           prestacao = Convert.ToInt32(Console.ReadLine());  

            Console.WriteLine($"credito aprovado ? -> {validacredito( salario_bruto, prestacao)}");
            Console.ReadKey();
        }
        //validação de salrio bruto
        static bool validacredito(int sb, int p)
        {
            //if(sb *0.3 <= p)
            //{
            //    return:true;
            //}
            //else
            //{
            ////    return:false;
            //} ou também podemos fazer assim:


            bool retorno;
            if(sb * 0.3 >= p)
            {
                retorno = true;
            }
            else
            {
                retorno = false;
            }
            return retorno;
        }
    }
}
