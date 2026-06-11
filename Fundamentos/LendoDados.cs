using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class LendoDados {
        public static void Executar() {
            Console.WriteLine("Digite o seu CVV?");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("O CVV do seu cartão é ",codigo);

            //formatando numeros
            double valor = 67.67676767;

            //arredondar numeros
            Console.WriteLine(valor.ToString("F1"));

            //valor monetario
            Console.WriteLine(valor.ToString("C"));

            //formatando do jeito que voce quer
            Console.WriteLine(valor.ToString("#.###"));

            //porcentagem
            Console.WriteLine(valor.ToString("P"));

        }
    }
}
