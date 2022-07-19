using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        // método de classe ou método estático
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }
        // método de instância
        public int Somar(int a, int b)
        {
            return a + b;
        }
    }
    class MetodosEstaticos //membros estáticos pertencem a classe e não a instância!!
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("Resultado da multiplicação é: {0}", resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(2, 2)); //só pode acessar pela instância!
            Console.WriteLine(CalculadoraEstatica.Multiplicar(2, 2)); //só pode acessar pela classe!
        }
    }
}
