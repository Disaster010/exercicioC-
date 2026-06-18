using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class Metodo1 {
        public static void Executar() {
            Jogador Jogador1 = new Jogador();
            Jogador1.Nome = "Vinícius Jr";
            Jogador1.Selecao = "Brasil";
            Jogador1.NumeroCamisa = 7;
            Jogador1.Continente = "América do Sul";
            Jogador1.ComidaTipica = "Feijoada";

            Jogador1.ApresentarNoConsole1();
        }
    }
}
