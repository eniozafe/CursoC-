using System;
using System.Collections;
using System.Collections.Generic;


namespace CursoCSharp.Colecoes
{
    class Queue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            fila.Enqueue("Fulano");
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);

            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            foreach(var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();
            // salada.Enqueue(3);  nao funciona

        }
    }
}
