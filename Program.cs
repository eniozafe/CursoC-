using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.POO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.ExplorandoAPI;
using CursoCSharp.TopicosAvancados;

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
                {"Lendo Dados do Console - Fundamentos", Fundamentos.LendoDados.Executar},
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
                {"Getters e Setters - Classes e Métodos", GetESet.Executar},
                {"Propriedades - Classes e Métodos", Props.Executar},
                {"Readonly - Classes e Métodos", Readonly.Executar},
                {"Exemplo Enum - Classes e Métodos", ExemploEnum.Executar},
                {"Struct - Classes e Métodos", Struct.Executar},
                {"Struct VS Class - Classes e Métodos", StructVsClass.Executar},
                {"Valor VS Referência - Classes e Métodos", ValorVsReferencia.Executar},
                {"Parâmetros Por Referência - Classes e Métodos", ParametrosPorReferencia.Executar},
                {"Parâmetro Padrão- Classes e Métodos", ParametroPadrao.Executar},

                //COLEÇÕES
                {"Array - Coleções", Colecoes.Array.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"Array List - Coleções", ArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", Queue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", Stack.Executar},
                {"Dictionary - Coleções", Dictionary.Executar},

                // PROG ORIENTADA A OBJETOS
                {"Herança - POO", Heranca.Executar},
                {"Construtor This - POO", ConstrutorThis.Executar},
                {"Encapsulamento - POO", POO.Encapsulamento.Executar},
                {"Polimorfismo - POO", Polimorfismo.Executar},
                {"Classe Abstrata - POO", Abstract.Executar},
                {"Interface - POO", Interface.Executar},
                {"Sealed - POO", Sealed.Executar},

                //MÉTODOS E FUNÇÕES
                {"Exemplo Lambda - Métodos e Funções", Lambda.Executar},
                {"Lambdas como Delegate - Métodos e Funções", LambdasDelegate.Executar},
                {"Usando Delegate - Métodos e Funções", UsandoDelegate.Executar},
                {"Delegate com Funções Anônimas - Métodos e Funções", DelegateFuncAnonima.Executar},
                {"Delegates como Parâmetros - Métodos e Funções", DelegatesComoParametros.Executar},
                {"Métodos de Extensão - Métodos e Funções", MetodosExtensao.Executar},


                //EXCEÇÕES E TRATAMENTO DE ERROS
                {"Exceções e Tratamento Erros", ExcecoesErros.Executar},
                {"Exceções Personalizadas", ExcecoesPersonalizadas.Executar},

                //EXPLORANDO API
                {"Arquivo: Escrevendo Dados - Explorando API", EscrevendoDados.Executar},
                {"Arquivo: Lendo Dados - Explorando API", ExplorandoAPI.LendoDados.Executar},
                {"Usando o File Info - Explorando API", FileInfo.Executar},
                {"Diretórios - Explorando API", Diretorios.Executar},

                //TÓPICOS AVANÇADOS
                {"LINQ #1- Tópicos Avançados", LINQ1.Executar},
                {"LINQ #2- Tópicos Avançados", LINQ2.Executar},
                {"Nullables - Tópicos Avançados", TopicosAvancados.Nullable.Executar},
                {"Dynamics - Tópicos Avançados", Dynamics.Executar},
                {"Generics - Tópicos Avançados", Generics.Executar},

           });

            central.SelecionarEExecutar();
        }
    }
}