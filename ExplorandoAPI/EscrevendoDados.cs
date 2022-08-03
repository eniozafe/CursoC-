using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CursoCSharp.ExplorandoAPI
{
    public static class ExtensaoString
    {
        public static string ParseHome(this string path)
        {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.MacOSX)
            ? Environment.GetEnvironmentVariable("HOME") : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH");
            return path.Replace("~", home);
        }
    }
    class EscrevendoDados
    {
        public static void Executar()
        {
            //var s = @"\teste\testes\a.txt"; o arroba faz a string aparecer inteira
            //Console.WriteLine(s);           sem @ ele entende \t como tab , \n como quebra de linha etc

            var path = @"~/escrevendo_dados.txt".ParseHome(); //o tio ~ é usado para associar a pasta HOME do usuário

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Esse é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("arquivo!");
                }
            }
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("");
                sw.WriteLine("É possível");
                sw.WriteLine("adicionar");
                sw.WriteLine("mais texto.");
            }
        }
    }
}
