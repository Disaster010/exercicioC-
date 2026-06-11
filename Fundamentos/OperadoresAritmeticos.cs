using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresAritmeticos {
        public static void Executar() {
            /*Console.WriteLine("digite um número: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("digite outro número: ");
            double n2 = double.Parse(Console.ReadLine());

            double total = n1 + n2;

            Console.WriteLine(total);


            Console.WriteLine("digite um número(base): ");
            double Base = double.Parse(Console.ReadLine());

            Console.WriteLine("digite outro número(altura): ");
            double Altura = double.Parse(Console.ReadLine());

            double R = Base * Altura / 2;

            Console.WriteLine($"a resposta é {R}");*/


            int a = 10;
            int b = 20;
            int c = 42;
            int d = 14;

            Console.WriteLine(c >= b);
            Console.WriteLine(d < b);

            Console.WriteLine(a == b && d <= b);
            // F e V = F

            Console.WriteLine(a > d || c != d);
            // F ou V = V






        }
    }
}
