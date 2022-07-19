using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            var nome = "Leonardo"; //Inferencia - o C# reconheceu o var como string
            Console.WriteLine(nome);
            //nome = 123; não posso alterar o tipo da variavel pq já foi entendido como string
            //var idade; nao é possível criar variável sem atribuir valor.
            //idade = 33;
            int idade;
            idade = 33; // esse é o jeito certo de fazer.
            //poderia ser assim: var idade = 33; assim é inicialização da variável. aí o C# reconhece

            int a; //declaração de variavel, dizendo ipo e nome
            a = 33; //inicizalização da variável

        }
    }
}
