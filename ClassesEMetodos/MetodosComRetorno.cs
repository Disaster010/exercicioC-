using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    /*class CalculadoraComum {
        public int Somar(int a, int b) {
            return a + b;
        }
        public int Subtrair(int a, int b) {
            return a - b;
        }

        public int Multiplicar(int a, int b) {
            return a * b;
        }
    }*/

    class ConversorDeTemperatura {
        public double CelsiusParaFahrenheit(double Celsius) {
            return (Celsius * 9 / 5) + 32;
        }
        public double FahrenheitParaCelsius(double Fahrenheit) {
            return (Fahrenheit - 32) * 5 / 9;
        }
        public double CelsiusParaKelvin(double Celsius) {
            return Celsius + 273.15;
        }
        public double KelvinParaCelsius(double Kelvin) {
            return Kelvin - 273.15;
        }
    }

    internal class MetodosComRetorno {
            public static void Executar() {
                //instancia do método calculadoraComum
                /*  var calculadoraComum = new CalculadoraComum();
                  var resultado = calculadoraComum.Somar(10, 15);
                  Console.WriteLine(resultado);

                  Console.WriteLine(calculadoraComum.Subtrair(15, 10));

                  Console.WriteLine(calculadoraComum.Multiplicar(15, 10));*/

                //instancia conversor de temperatura

                var conversordeTemperatura = new ConversorDeTemperatura();
                var resultado = conversordeTemperatura.CelsiusParaFahrenheit(15);
                Console.WriteLine(resultado);

                Console.WriteLine(conversordeTemperatura.FahrenheitParaCelsius(20));

                Console.WriteLine(conversordeTemperatura.CelsiusParaKelvin(26));

                Console.WriteLine(conversordeTemperatura.KelvinParaCelsius(36));

            
        }
    }
}
