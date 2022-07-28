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
                Console.WriteLine("2004: " + filmes[2004]); //usando valor que nao existe dentro da string ele retorna erro
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2004)); //nao retorna erro se usar valor errado dentro do parametro

            }

            Console.WriteLine(filmes.ContainsValue("Amnésia")); //retorna true or false

            Console.WriteLine($" Removeu? {filmes.Remove(2004)}"); //se existir a chave ele remove! retorna true

            filmes.TryGetValue(2016, out string filme2006);
            Console.WriteLine($"Filme {filme2006}!");

            foreach (var chave in filmes.Keys)
            {
                Console.WriteLine(chave);
            }

            foreach (var valor in filmes.Values)
            {
                Console.WriteLine(valor);
            }

            foreach (KeyValuePair<int, string> filme in filmes)
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}.");
            }

            foreach(var filme in filmes)
            {
                Console.WriteLine($" {filme.Value} é de {filme.Key}.");
            }
        }
    }
}
