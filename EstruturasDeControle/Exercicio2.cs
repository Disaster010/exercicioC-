using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class Exercicio2 {
        public static void Executar() {
            /*Console.WriteLine("quantos gols marcados? ");
            int gols = int.Parse(Console.ReadLine());

            if (gols >= 0 && gols <= 4) {
                Console.WriteLine("Não classificado");
            } else if (gols >= 5 && gols <= 9) {
                Console.WriteLine("Reserva");
            } else if (gols >= 10) {
                Console.WriteLine("Titular");
            }*/


            /* Console.WriteLine("Qual a idade? ");
             int idade = int.Parse(Console.ReadLine());

             Console.WriteLine("Tem lesão?(sim/nao) ");
             string lesao = Console.ReadLine();

             if (idade >= 18 && idade <= 40 && lesao == "nao") {
                 Console.WriteLine("pode jogar");
             } else if (idade >= 18 && idade <= 40 && lesao == "sim") {
                 Console.WriteLine("aguardando recuperação");
             } else {
                 Console.WriteLine("fora da convocação");
             }*/


            /*Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("O ingresso custa 120R$, quantos ingressos precisa? ");
            int ingressos = int.Parse(Console.ReadLine());

            if (ingressos >= 5) {
                double preco = (120 * ingressos);
                double desconto = (preco - 0.1);

                Console.WriteLine($"valor total: 120R$ Desconto: 10% valor final:{desconto} ");
            } else if (ingressos < 5) { 
                double precofinal = (120 * ingressos);
                Console.WriteLine($"valor total: 120R$ Desconto: n valor final:{precofinal} ");
            } else {
                Console.WriteLine("inválido");
            }*/


            /* Console.WriteLine("Quantos pontos a seleção fez? ");
             int pontos = int.Parse(Console.ReadLine());

             if (pontos >= 0 && pontos <= 3) {
                 Console.WriteLine("seleção eliminada!");
             } else if (pontos >= 4 && pontos <= 6) {
                 Console.WriteLine("saldo de gols: ");
                 int saldo_de_gols = int.Parse(Console.ReadLine())
                     if(saldo_de_gols > 3) {
                     Console.WriteLine("seleção classificada");
                 } else if(saldo_de_gols <= 2) {
                     Console.WriteLine("repescagem");
                 } else if(pontos >= 7) {
                     Console.WriteLine("seleção classificada");
                 }*/


            /* Console.WriteLine("quantos chutes fez o jogador? ");
             double chutes = double.Parse(Console.ReadLine());

             Console.WriteLine("quantos gols marcou? ");
             double gols = double.Parse(Console.ReadLine());

             double aproveitamento = (gols * chutes) / 100;

             if (aproveitamento < 0.2) {
                 Console.WriteLine($"{aproveitamento:P0} = ruim");
             } else if (aproveitamento >= 0.2 && aproveitamento <= 0.5) {
                 Console.WriteLine($"{aproveitamento:P0} = bom");
             } else if (aproveitamento > 0.5) {
                 Console.WriteLine($"{aproveitamento:P0} = excelente");
             }
          */

            /* Console.WriteLine("quantas camisas comprar? ");
             int camisas = int.Parse(Console.ReadLine());

             if (camisas <= 2) {
                 double preco = camisas + 199.90;
                 Console.WriteLine($"subtotal: {preco:C} / desconto: N / valor final:{preco:C}");
             } else if (camisas >= 3 && camisas <= 5) {
                 double preco = camisas + 199.90;
                 double desconto = preco - 5.0;
                 Console.WriteLine($"subtotal: {preco:C} / desconto: 5% / valor final:{desconto:C}");
             } else if (camisas > 5) {
                 double preco = camisas + 199.90;
                 double desconto = preco - 10.0;
                 Console.WriteLine($"subtotal: {preco:C} / desconto: 10% / valor final:{desconto:C}");
             }
            */





            /*Console.WriteLine("idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("quantos gols: ");
            int gols = int.Parse(Console.ReadLine());

            if(idade >= 18 && idade <= 35 && gols >= 20) {
                Console.WriteLine("convocado");
            } else if (idade >= 18 && idade <= 35 && gols < 20) {
                Console.WriteLine("lista de espera");
            } else {
                Console.WriteLine("não convocado");
            }
            */


          /*  Console.WriteLine("nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("idade: ");
            int idade = int.Parse(Console.ReadLine());

            int gols = int.Parse(Console.ReadLine());

            int assistencias = int.Parse(Console.ReadLine());

            double pontuacao = gols * 5 + assistencias * 3;

            if(pontuacao >= 100) {
                Console.WriteLine("lenda da copa");
            } else if (pontuacao >= 50 && pontuacao < 100) {
                Console.WriteLine("craque");
            } else if (pontuacao >= 20 && pontuacao < 50) {
                Console.WriteLine("bom jogador");
            } else {
                Console.WriteLine("reserva");
                }
          */






        }
    }
}