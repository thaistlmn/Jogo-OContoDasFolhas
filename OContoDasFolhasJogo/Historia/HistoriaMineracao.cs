using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OContoDasFolhasJogo.Sistema
{
    public class HistoriaMineracao
    {
        private static Random random = new Random();


        private static string[] comentariosEncontrarGem = new string[]
        {
        "Mirím: \"Brilha como as estrelas! Encontramos uma gema!\"",
        "Bomím: \"A natureza foi generosa hoje.\"",
        "Mirvím: \"Essa pedra vai nos fortalecer nas próximas batalhas!\""
        };

        private static string[] comentariosForjarSemGemas = new string[]
        {
        "Forín: \"Hmm... precisamos de mais pedras para forjar algo.\n",
        "Mirvím: \"Nada nasce do vazio. Hora de minerar mais!\n",
        "Mirvím: \"Sem gems, sem glória...\n"
        };

        private static string[] comentariosForjarComSucesso = new string[]
        {
        "Loín: \"Forjamos uma arma digna das lendas!\n",
        "Bomím: \"Que esta arma brilhe em nossas batalhas!\n",
        "Forín: \"O espírito da árvore Éleanór sorri para nós!\n"
        };


        public static void ComentarEncontrarGem()
        {
            Console.WriteLine(EscolherAleatorio(comentariosEncontrarGem));
        }

        public static void ComentarForjar(bool sucesso)
        {
            if (sucesso)
                Console.WriteLine(EscolherAleatorio(comentariosForjarComSucesso));
            else
                Console.WriteLine(EscolherAleatorio(comentariosForjarSemGemas));
        }

        private static string EscolherAleatorio(string[] opcoes)
        {
            return opcoes[random.Next(opcoes.Length)];
        }
    }
}
