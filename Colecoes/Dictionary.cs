using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Dictionary
    {
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>(); // chave não aceita repetição, o valor aceita! 

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Os Incríveis");
            filmes.Add(2006, "O Grande Truque");

            if (filmes.ContainsKey(2004))
            {
                Console.WriteLine("2004: " + filmes[2008]);
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2004));
            }
        }
    }
}
