using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.POO
{
    public class Carro
    {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima) //construtor setado não padrao
        {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta)
        {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0)
            {
                VelocidadeAtual = 0;
            }
            else if (novaVelocidade > VelocidadeMaxima)
            {
                VelocidadeAtual = VelocidadeMaxima;
            }
            else
            {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;
        }

        public virtual int Acelerar() //virtual significa que pode ser sobrescrita em algum momento do código e usar override na classe de herança
        {
            return AlterarVelocidade(5);
        }

        public int Frear()
        {
            return AlterarVelocidade(-5);
        }
    }

    public class Uno : Carro
    {
        public Uno() : base(200) //tem que chamar o construtor base() pq nao tem um construtor padrão
        {

        }
    }

    public class Ferrari : Carro
    {
        public Ferrari() : base(350)
        {

        }

        public override int Acelerar() //override faz par com o vitual na classe pai setada com virtual
        {
            return AlterarVelocidade(15);
        }

        //oculta o método da classe pai
        public new int Frear()
        {
            return AlterarVelocidade(-15);
        }
    }
    class Heranca
    {
        public static void Executar()
        {
            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());


            Console.WriteLine("Ferrari...");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());

            Console.WriteLine("Ferrari com tipo carro ...");
            Carro carro3 = new Ferrari(); 
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear()); //usa o Frear() setado no tipo Carro e não no tipo Ferrari
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

            Console.WriteLine("Uno com tipo carro ...");
            carro3 = new Uno(); //Polimorfismo
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
        }

    }
}
