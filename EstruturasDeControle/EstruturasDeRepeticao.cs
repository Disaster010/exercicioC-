using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturasDeRepeticao {
        public static void Executar() {
            /*int contador = 1;

            while(contador <= 10) {
                Console.WriteLine(contador);
                contador++;
            }

            for(int cont = 1; cont<= 10; cont++) {
                Console.WriteLine(cont);
            }
            */
            /*Console.WriteLine("digite a quantidade de torcedores: ");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantidade; i++ ) {
                Console.WriteLine($"torcedor {i} entrou no estadio");
            }*/

            /*Console.WriteLine("quantos jogos deseja registrar? ");
            int jogos = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 1; i <= jogos; i++) {
                Console.WriteLine($"{i}° jogo: ");
                int gols = int.Parse(Console.ReadLine());
                soma = soma + gols;
            }
            Console.WriteLine($"soma de todos os {jogos} são {soma}");
            
            */


            int contador = 0;
            int tentativas = 3;
            Console.WriteLine("digite a senha: ");
            string password = Console.ReadLine();

            while (password != "1234L" && contador != 3) {
                Console.WriteLine($"Senha inválida!, Você tem {tentativas-contador} tentativas." +
                    $"Digite a senha novamente: ");
                password = Console.ReadLine();

                if (password == "1234L") {
                    Console.WriteLine("Acesso Permitido!");
                    break;
                } else {
                    Console.WriteLine("Acesso Negado!");
                    contador++;
                }







            }

            }
    }
}
  