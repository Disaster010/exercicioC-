using CursoCSharp.ClassesEMetodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {


    internal class Exercicio5 {

        class VendaCelular {
            public string Cliente;
            public string ModeloCelular;
            public double ValorCelular;
            public double Quantidade;

            public VendaCelular(string cliente, string modeloCelular, double valorCelular, double quantidade) {
                Cliente = cliente;
                ModeloCelular = modeloCelular;
                ValorCelular = valorCelular;
                Quantidade = quantidade;
            }

            public double CalcularSubTotal() {
                return ValorCelular * Quantidade;
            }
            public void CalcularDesconto() {
                double subtotal = CalcularSubTotal();
                if (Quantidade >= 3) {
                    double valorfinal = subtotal - 0.15;
                }

            }
            public void CalcularValorFinal() {
                double subtotal = CalcularSubTotal();
                double valorfinal = subtotal - 0.05;
            }
            public void mostrarVenda() {
                Console.WriteLine($"Cliente: {Cliente}");
                Console.WriteLine($"Modelo do Celular: {ModeloCelular}");
                Console.WriteLine($"Valor do Celular: {ValorCelular:C}");
                Console.WriteLine($"Quantidade: {Quantidade}");
                Console.WriteLine($"Subtotal: {CalcularSubTotal()}");
                Console.WriteLine($"Desconto: {CalcularDesconto}");
                Console.WriteLine($"Valor Final: {CalcularValorFinal}");
            }

        }



        public static void Executar() {

            VendaCelular celular1 = new VendaCelular("luan", "IphoneXS", 900, 1);

            celular1.mostrarVenda();

        }
    }
}
