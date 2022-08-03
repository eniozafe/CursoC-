using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using CursoCSharp.ExplorandoAPI;

namespace CursoCSharp.ExplorandoAPI
{
    class Diretorios
    {
        public static void Executar()
        {
            var novoDir = @"~/PastaCSharp".ParseHome();
            var novoDirDestino = @"~/PastaCSharpDestino".ParseHome();
            var dirProjeto = @"~/source/repos/CursoCSharp/CursoCSharp".ParseHome();
        }
    }
}
