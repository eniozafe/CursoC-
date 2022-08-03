﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.POO
{
    public abstract class Celular
    {
        public abstract string Assistente();

        public string Tocar()
        {
            return "Triim Triiim";
        }
    }

    public class Samsung : Celular
    {
        public override string Assistente()
        {
            return "Olá! Meu nome é Bixby!";
        }
    }

    public class Iphone : Celular
    {
        public override string Assistente()
        {
            return "Olá! Meu nome é Siri!";
        }
    }
    class Abstract
    {
        public static void Executar()
        {
            var celulares = new List<Celular>
            {
                new Iphone(),
                new Samsung()
            };

            foreach (var celular in celulares)
            {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}