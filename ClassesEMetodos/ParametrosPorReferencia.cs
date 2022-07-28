using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosPorReferencia
    {
        public static void AlterarRef(ref int numero)
        {
            numero = numero + 1000;
        }

        public static void AlterarOut(out int numero1, out int numero2)
        {
            numero1 = 0; //Tem que inicializar o número ! A partir do númro inicializado podemos usá-lo.
            numero2 = 0;
            numero1 = numero1 + 15;
            numero2 = numero2 + 30;
        }
        public static void Executar()
        {
            int a = 3;
            AlterarRef(ref a);
            Console.WriteLine(a);

            //int b;
            AlterarOut(out int b, out int c);
            Console.WriteLine($"{b} {c}");


            //EXEMPLO DE OUT
            string str = "100";
            if (int.TryParse(str, out int num))
            {
                Console.WriteLine("{0}", num + 1);
            }
            else
            {
                Console.WriteLine("A conversão falhou!");
            }



            //EXEMPLO 2 DE SAÍDA COM OUT
            double calcularMedia(double nota1, double nota2, double nota3, out String conc)
            {
                double media = (nota1 + nota2 + nota3) / 3;
                conc = media >= 7 ? "aprovado" : "reprovado";
                return media;
            }

            String conceito;
            double mediaDoAluno = calcularMedia(1.6, 9.4, 5.0, out conceito);

            Console.WriteLine("A media é " + mediaDoAluno + " e o aluno está " + conceito);
        }
    }
}
