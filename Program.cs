using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>()
            {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variaveis E Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados do Console - Fundamentos", LendoDados.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumeros.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternários - Fundamentos", OperadoresTernarios.Executar},

                // ESTRUTURAS DE CONTROLE
                {"For - Estruturas de Controle", For.Executar},
                {"ForEach - Estruturas de Controle", ForEach.Executar},

                // CLASSES E METÓDOS (CLASSES x OBJETOS)
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construtor - Classes e Métodos", Construtor.Executar},
                {"Métodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar},
                {"Params - Classes e Métodos", Params.Executar},
                {"Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                {"Getters e Setters - Classes e Métodos", GettersESetters.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}