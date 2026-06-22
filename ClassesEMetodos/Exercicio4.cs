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
        public void GanharTitulo(int numero) {
            Titulos += numero;
        }
        public void PerderTitulo(int numero) {
            Titulos -= numero;
        }
        public void MostrarDados() {
            Console.WriteLine($"Seleção: {País} / Continente: {Continente} / Titulos: {Titulos} ");
        }
    }

    internal class Exercicio4 {
        public static void Executar() {

            Selecao Selecao1 = new Selecao("Brasil","América do Sul",0);

            Selecao1.GanharTitulo(5);
            Selecao1.PerderTitulo(0);
            Selecao1.MostrarDados();

        }
    }
}
