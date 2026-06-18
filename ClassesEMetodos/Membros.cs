using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class Membros {
        public static void Executar() {
            Pessoa Pessoa1 = new Pessoa();
            Pessoa1.Nome = "Neymar Jr";
            Pessoa1.Idade = 34;

            Pessoa Pessoa2 = new Pessoa();
            Pessoa2.Nome = "Messi";
            Pessoa2.Idade = 38;

            Pessoa1.ApresentarNoConsole();
            Pessoa2.ApresentarNoConsole();

        }
    }
}
