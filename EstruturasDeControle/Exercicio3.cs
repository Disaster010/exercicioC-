using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class Exercicio3 {
        public static void Executar() {


            /* Console.WriteLine("Digite o numero de dias: ");
             int dias = int.Parse(Console.ReadLine());
             int contador = dias;
             while (contador >= 0) {
                 Console.WriteLine($"faltam {dias} para o jogo!");
                 dias = contador - 1;
                 contador--;
             }*/

            /*
                        double soma = 1;
                        double media = 0;
                        int contador = 1;
                        Console.WriteLine($"digite o numero de gols em {contador} partidas: ");
                        int gols = int.Parse(Console.ReadLine());



                        while (contador != 5) {
                            int.Parse(Console.ReadLine());
                            soma = soma + gols;
                            contador = contador + 1;

                        }
                        media = (soma / 5);
                        Console.WriteLine($"media de gols: {media} ");
                        */

            Console.WriteLine("digite o nome do jogador: ");
            string nome = Console.ReadLine();

            Console.WriteLine("quantos gols: ");
            int gols = int.Parse(Console.ReadLine());




        } 
    }
}
