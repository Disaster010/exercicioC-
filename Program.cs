using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variaveis e Constantes - Fundamentos",VariaveisEConstantes.Executar},
                {"Notação Ponto - Fundamentos",NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos",LendoDados.Executar},
                {"Exercicio1 - Fundamentos",Exercicio1.Executar},
                {"Operadores Aritméticos - Fundamentos",OperadoresAritmeticos.Executar},
                //Estruturas de Controle
                {"Estrutura If - Estruturas De Controle",EstruturaIf.Executar},
                {"Exercicio2 - Estruturas De Controle",Exercicio2.Executar},
                {"Estrutura Switch - Estruturas De Controle",EstruturaSwitch.Executar},
                {"Estruturas de Repetição - Estruturas De Controle",EstruturasDeRepeticao.Executar},
                {"Exercicio3 - Estruturas De Controle",Exercicio3.Executar},
                //Classes e Metodos
                {"Membros - Classes e Métodos",Membros.Executar},
                {"Metodos1 - Classes e Métodos",Metodo1.Executar},
                {"MetodosComRetorno - Classes e Métodos",MetodosComRetorno.Executar},
                {"MetodoEstatico - Classes e Métodos",MetodoEstatico.Executar},
                {"CalcularDesconto - Classes e Métodos",CalcularDesconto.Executar},
                {"ContaBancaria - Classes e Métodos",ContaBancaria.Executar},
                {"Exercicio4 - Classes e Métodos",Exercicio4.Executar},
                {"OficinaMecanica - Classes e Métodos",OficinaMecanica.Executar},
                {"Exercicio5 - Classes e Métodos",Exercicio5.Executar},
                {"Params - Classes e Métodos",Params.Executar},
                {"Paramêtros Soma - Classes e Métodos",Soma.Executar},
                {"Lanchonete - Classes e Métodos",Lanchonete.Executar},
                {"Exercicio6 - Classes e Métodos",Exercicio6.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}