using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

/*Fazer um programa para ler as medidads dos lados de dois triangulos  x e y, em seguida , mostrar
 o valoor das áreas dls dois traingulos e dizer qual dos dois possui a maior area*/
namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaração da classe do tipo triangulo
            Triangulo x, y;
            // declar só não basta, temos que instanciar.

            x = new Triangulo(); // x recebe new triangulo
            y = new Triangulo();//y recebe novo triangulo

            Console.WriteLine("Entre com as medidads do traingulo X");
            // para acessar o atributo do seu objeto x é:
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // isso faz a leitura do primeiro lado do triangulo X
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(" Entre com as medidas do triangulo Y ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areax = Math.Sqrt(p * (p - x.A) * (p - x.B)* (p - x.C));
            
            p = (y.A + y.B + y.C) / 2.0;
            double areay = Math.Sqrt(p * (p - y.A) * (p - y.B )* (p - y.C));


            Console.WriteLine("Área de x =" + areax.ToString("F4", CultureInfo.InvariantCulture);
            Console.ReadKey();

        }
    }
}
S