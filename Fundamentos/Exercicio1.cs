using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Exercicio1 {
        public static void Executar() {
            Console.WriteLine("Digite o nome do jogador? ");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite a idade do jogador? ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero da camisa? ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o salário mensal do jogador? ");
            ulong salario = ulong.Parse(Console.ReadLine());

            Console.WriteLine(salario.ToString("C"));

            Console.WriteLine("Digite a quantidade de gols marcados do jogador? ");
            int gols = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a data de nascimento do jogador? ");
            DateOnly dataNascimento = DateOnly.Parse(Console.ReadLine());

            const double jogadoresConvocados = 26;



        }
    }
}
