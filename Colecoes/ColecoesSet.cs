using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Throne", 49.90);

            //NOTAÇÃO GENERICS
            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto>
            {
                new Produto("Camisa", 29.90),
                new Produto("8ª Temporada Game of Thrones", 99.90),
                new Produto("Poster", 10.00)
            };
            
            carrinho.UnionWith(combo); //Usando Set o AddRange vira UnionWith

            Console.WriteLine(carrinho.Count);

            //carrinho.RemoveAt(3);
            foreach (var item in carrinho)
            {
                //Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($": Nome: {item.Nome}, Preço: R${item.Preco}"); 
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro); //Set não add 2x o mesmo item
            Console.WriteLine(carrinho.Count);
        }
    }
}
