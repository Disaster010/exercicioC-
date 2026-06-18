using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    class Selecao {
        public string País;
        public string Continente;
        public int Titulos;

        public Selecao(string país, string continente, int titulos) {
            País = país;
            Continente = continente;
            Titulos = titulos;
        }
        public void GanharTitulo(double titulos) {
            titulos += 1;
        }
    }

    internal class Exercicio4 {
        public static void Executar() {

        }
    }
}
