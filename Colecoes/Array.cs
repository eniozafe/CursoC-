using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Array
    {
        public static void Executar()
        {
            //estrutura estática = criei array[5](5 posições) só posso usar até 5 posições
            string[] alunos = new string[5]; //estrutura homogenea = criando array[] string só posso receber tipo string
            //acessando posições (indices)
            alunos[0] = "Anderson";
            alunos[1] = "Bia";
            alunos[2] = "Carlos";
            alunos[3] = "Daniela";
            alunos[4] = "Emanuel";
            //alunos[5] = "ENIO";             //indice a mais

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

            foreach (var nota in notas)
            {
                somatorio += nota;
            }

            //for(int i = 0; i < notas.Length; i++)
            //{
            //    somatorio += notas[i];
            //}


            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);
        }
    } 
}
