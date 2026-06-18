using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class Jogador {

        public string Nome;
        public string Selecao;
        public int NumeroCamisa;
        public string Continente;
        public string ComidaTipica;

        public string Apresentar1() {
            return string.Format($"Olá! Meu nome é {Nome}, jogo pela seleção do {Selecao} e uso a camisa" +
                $" {NumeroCamisa}. Meu país está localizado na {Continente} e uma comida típica muito" +
                $" conhecida é {ComidaTipica}.");
        }

        public void ApresentarNoConsole1() {
            Console.WriteLine(Apresentar1());
        }

    }
}
