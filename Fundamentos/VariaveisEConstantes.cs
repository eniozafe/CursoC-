using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            //PI = 3.1415;
            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("A área é " + area + 1000);

            //tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo ? " + estaChovendo);

            byte idade = 45; //nao armazena numero negativo
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue; // armazena numero negativo e positivo
            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("O salário é " + salario);

            int menorValorInt = int.MinValue; //Mais usado dos inteiros
            Console.WriteLine("Menor int " + menorValorInt);

            uint populacaoBrasileira = 207_600_000; //uint é valor inteiro positivo
            Console.WriteLine("A população do Brasil é " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor valor Long é " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000; //nao armazena negativo
            Console.WriteLine("A população Mundial é de " + populacaoMundial + "pessoas");

            float precoComputador = 1299.99f;
            Console.WriteLine("O preço do computador é de " + precoComputador);

            double valorMercadoApple = 1_000_000_000_000.00;
            Console.WriteLine("O valor de mercado da Apple é " + valorMercadoApple);

            decimal distanciaEntreAsEstrelas = decimal.MaxValue;
            Console.WriteLine("A distância entre as estrelas é " + distanciaEntreAsEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra + " + letra);

            string texto = "Seja Bem Vindo ao Curso de C#";
            Console.WriteLine(texto);
        }
    }
}
