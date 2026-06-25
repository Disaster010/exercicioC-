using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class Exercicio6 {

        public static void MontarPizza(params string[] igredientes) {
            Console.WriteLine(" seu pedido tem: ");

            foreach(string i in igredientes) {
                Console.WriteLine($"igredientes: {i}");
            }
            Console.WriteLine($"total de igredientes: {igredientes.Length}");
        
        }

        public static void Executar() {
            List<string> itens = new List<string>();

            Console.WriteLine("Digite o Pedido: ");
            Console.WriteLine("Digite fim para finalizar");

            while (true) {
                Console.WriteLine("Item: ");
                string item = Console.ReadLine();

                if (item == "fim") {
                    break;
                } else if (item == "") {
                   
                    }
                    itens.Add(item);
                }
                MontarPizza(itens.ToArray());
            }
        }
    }

