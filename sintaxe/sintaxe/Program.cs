using System; //significa que podemos usar as classes do system namespace
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Sintaxe básica do C-SHARP.

namespace sintaxe // namespace: é usada para organoizar o nosso código.
{
    internal class Program // Class : é um container para todos os métodos, que traz funcionalidades para o nosso programa.
    {
        //{} : Marcam o inicio e o fim do codigos
        static void Main(string[] args)
        {
            /*Console.writeLne(), é o método que serve para imprimir o texto na tela,mas se não colocarmos 
             Console.ReadLine o texto que imprime na tela some muito Rápido.*/
            Console.WriteLine("Olá, chamo-me Sako Afonso Miezi Vuna ! ");
            Console.WriteLine("3 + 3");
            Console.ReadLine();
            
           
        }
    }
}
