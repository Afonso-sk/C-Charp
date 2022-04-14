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
        static void Main(string[] args)
        {
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
            Console.ReadLine();

            // A palavra const é quando não queremos que o valor atribuito seja alterada. exedmplo: pi = 3.14
            /*Tipos de variaveis
             1-int- Armazena números inteiros ( exemplo: 83 ou -83 )
             2- double- Armazena números de ponto flutuantes com decimais( exemplo: 83,5 ou -83,5 )
             3-Char- Armazena cartacteres únicos como 'a' ou 'B' e são cercados por aspas simples
             4- string- Armazena texto como "Hello world", e são cercados de aspas duplas
             5- bool- Armazena valores com dois estados: Verdadeiro ou falso ( true or false)
            
            Para declarar uma variavel, devemos especificar o Tipo e atribuir um valor.
            
            SINTAXE: type variableName = value ( tipo nomeVariavel = valor)

            
            Para declarar uma variavel, ddevemos especificar o tipo e atribuir um valor.
            Onde type é um tipo C# (como intou string), e variableName é o nome da variável (como x ou name ).

            O sinal de igual é usado para atribuir valores à variável.
             */
            

        }
    }
}
