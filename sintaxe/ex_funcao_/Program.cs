using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_funcao_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome_formando, apelido_formando;   
            int idade_formando;

            Console.WriteLine("Qual é o nome do formando ?");
            nome_formando = Console.ReadLine();

            Console.WriteLine("Qual é o apelido do formando ?");
            apelido_formando = Console.ReadLine();


            Console.WriteLine("Qual é a idade do formando ?");
            idade_formando = Convert.ToInt32(Console.ReadLine());

            //passar o parametro para guardar
            ficha_formando(nome_formando, apelido_formando, idade_formando);
            Console.ReadKey();
        }

        // As voides não devolvem nada no ecrã

        static void ficha_formando(string nome, string apelido, int idade)
        {
            Console.WriteLine($"{nome}  {apelido} tem {idade} anos");
        }
    }
}
