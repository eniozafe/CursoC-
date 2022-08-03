using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados
{
    class Dynamics
    {
        public static void Executar()
        {
            dynamic meuObjeto = "teste";
            meuObjeto = 3;
            meuObjeto++;

            Console.WriteLine(meuObjeto);

            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.Nome = "Maria Julia";
            aluno.Nota = 8.9;
            aluno.Idade = 24;

            Console.WriteLine($"{aluno.Nome} teve a nota: {aluno.Nota} e sua idade é {aluno.Idade} anos.");
        }
    }
}
