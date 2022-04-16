using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 /*Variáveis: São espaços criadas na memoria para armazenar dados, que podem ser alterados
ao longo do tempo.
 
  Exemplo: Bolso da nossa calça.
 */
namespace variaveis
{
    internal class Program
    {
        static void Main(string[] args) // o método Main, é a função principal. assim que executar App, vai aparecer o que está dentro do Main.
        {
            //Para declarar uma variavel, devemos especificar o Tipo e atribuir um valor.
            /* SINTAXE: type variableName = value ( tipo nomeVariavel = valor)
             * Onde type é um tipo C# (como int string), e variableName é o nome da variável (como x ou name ).

            O sinal de igual é usado para atribuir valores à variável.
             */
            string name = "Sako"; // Declarei uma variavel do tipo nome, e atribui um valor chamado sako
            int myNum = 15; // no entanto podemos adicionar a palavra const para que a variavel não seja alterada.
             Console.WriteLine(myNum);
            //--------------------------------------------------------------------------------------------------
            Console.WriteLine(name); // estamos a pedir para tela imprimir nome da variavel declarada
            string firstName = "sako ";
            string lastName = "Vuna";
            string fullName = firstName +  lastName; 
            Console.WriteLine(fullName);
            //--------------------------------------------------------------------------------------------------
            int x = 5;// poderia ser int x = 5, y = 6;
            int y = 6;
            Console.WriteLine(x + y);
            //--------------------------------------------------------------------------------------------------
       

            // A palavra const é quando não queremos que o valor atribuito seja alterada. exedmplo: pi = 3.14
            /*Tipos de variaveis
             1-int- Armazena números inteiros ( exemplo: 83 ou -83 )
             2-double- Armazena números de ponto flutuantes com decimais( exemplo: 83,5 ou -83,5 )
             3-Char- Armazena cartacteres únicos como 'a' ou 'B' e são cercados por aspas simples
             4- string- Armazena texto como "Hello world", e são cercados de aspas duplas
             5- bool- Armazena valores com dois estados: Verdadeiro ou falso ( true or false)
--------------------------------------------------------------------------------------------------------
               program.cs é o local onde fica guardado o nosso código C#
            
             */
//----------------------------------------------------------------------------------------------------
            // Interação com usuario.
            string nome;
            int idade;
            Console.WriteLine("Como te chamas ? ");
            nome = Console.ReadLine(); //Estou a dizer que Aquilo que a pessoa digitar vai ser guardado dentro da variavel nome

            Console.WriteLine("Qual é a sua idade ? ");
            idade = Convert.ToInt32(Console.ReadLine());/* Estou a dizer o que o texto que foi  escrito no ecrã
             estou a converter em inteiro e guardar na variavél idade.*/
        
            // Estou a pedir para ler o que o usuario digitar na tela. para isso vamos fazer concantenização
            Console.WriteLine($" O teu nome é: {nome} e tens {idade}  anos");

            int valor1, valor2, soma, multi;

            Console.WriteLine(" Qual é o valor1 ?");
            valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Qual é o valor2 ?");
            valor2 = Convert.ToInt32(Console.ReadLine());

            soma = valor1 + valor2;
            multi = valor1 * valor2;

            Console.WriteLine($"{valor1} + {valor2} é igual a {soma}");
            Console.WriteLine($"{valor1} * {valor2} é igual a {multi}");


            Console.ReadKey(); 

        }
    }
}
