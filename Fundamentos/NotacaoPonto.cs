using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "olá".ToUpper().Insert(3, " World!").Replace("World!", "Mundo!");

            Console.WriteLine(saudacao);

            Console.WriteLine("texto".Length);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length); //o ? só faz a notação ponto acessar a variavel se ela não for vazia, navegação segura
        }
    }
}
