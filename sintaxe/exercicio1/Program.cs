using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Cria um programa que leia a quantidades de caracteres da frase que for digitada na tela
namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase; // declaração da variavel frase
            Console.WriteLine(" Escreva uma frase");
            frase = Console.ReadLine(); // Guarda a frase que utilizador digitor na variavel frase

            // para escrever o numero de caracter usamos o nome da variavel.length

            Console.WriteLine($"\n\n\n A frase tem { frase.Length}  caracteres");
            
            //passar tudo para maiuscula
             Console.WriteLine($"\n\n { frase.ToUpper()} ");
            //passar tudo para minuscula
            Console.WriteLine($"\n\n { frase.ToLower()} ");


            // buscar apenas os 3 primeiros caaracteres usando a propriedade substring
            Console.WriteLine($"\n\n { frase.Substring(0, 3)} ");

            /* buscar apenas os 3 ultimos caaracteres usando a propriedade substring
             Neste caso vamos andar o comprimento máximo - 3 */
             
            Console.WriteLine($"\n\n { frase.Substring(frase.Length-3 ,3)} ");

            // Quando encontra o caracter o develve a posição onde o encontra.
            // se não encontrar devolve o -1
            Console.WriteLine($"\n\n { frase.IndexOf('o')} ");
            Console.ReadKey();
        }
       
    }
}

