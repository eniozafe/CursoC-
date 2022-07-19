using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresTernarios
    {
        public static void Executar()
        {
            Console.WriteLine("Digite sua nota: ");
            double nota = double.Parse(Console.ReadLine());
            string resultado = nota >= 7.0 ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
        }
    }
}
