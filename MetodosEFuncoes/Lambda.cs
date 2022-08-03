using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    class Lambda
    {
        public static void Executar()
        {
            Action algoNoConsole = () =>
            {
                Console.WriteLine("Lambda com C#");
            };

            algoNoConsole();

            Func<int> jogarDado = () =>
            {
                Random random = new Random();
                return random.Next(1, 7); //de 1 até 6
            };

            Console.WriteLine(jogarDado());

            Func<int, string> conversorHex = numero => numero.ToString("X");

            //PODE FAZER IGUAL ABAIXO TBM
            //Func<int, string> conversorHex = (numero) =>
            //{
            //    return numero.ToString("X");
            //};
            Console.WriteLine(conversorHex(1234));

            Func<int, int, int, string> formatarData = (dia, mes, ano) => String.Format("{0:D2}/{1:D2}/{2:D2}", dia, mes, ano);

        }
    }
}
