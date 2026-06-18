using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class Pessoa {

        //atributos
        public string Nome;
        public int Idade;

        //método
        public string Apresentar() {
            return string.Format($"Olá! Me chamo {Nome} e tenho {Idade}");
        }

        public void ApresentarNoConsole() {
            Console.WriteLine(Apresentar());
        }
    }
}
