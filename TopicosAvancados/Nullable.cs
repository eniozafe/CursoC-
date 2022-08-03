using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados
{
    class Nullable
    {
        public static void Executar()
        {
            Nullable<int> num1 = null;
            int? num2 = null;

            if (num1.HasValue)
            {
                Console.WriteLine("O valor de num: {0}", num1);
            }
            else
            {
                Console.WriteLine("A varivável não possui valor.");
            }

            int valor = num1 ?? 1000; //?? = se o valor estiver nulo ele pega o valor depois das interrogações
            Console.WriteLine(num1);

            bool? booleana = null;
            bool resultado = booleana.GetValueOrDefault();
            Console.WriteLine(resultado);

            try
            {
                int x = num1.GetValueOrDefault();
                int y = num2.Value; //se tenta pegar o value diretamete pode ser que haja erro por se algum numero null
                Console.WriteLine(x + y);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
