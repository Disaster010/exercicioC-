using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;

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
            });

            central.SelecionarEExecutar();
        }
    }
}