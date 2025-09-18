using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OContoDasFolhasJogo
{
    public class HistoriaJardim
    {
        private static Random random = new Random();

        private static string[] comentariosPlantar = new string[]
        {
        "Bomím: \"Hora de cultivar novos ingredientes mágicos!\n",
        "Forín: \"Cada semente é uma descoberta.\n",
        "Loín: \"Ingrediente plantado... agora é só esperar a magia acontecer.\n"
        };

        private static string[] comentariosColherNada = new string[]
        {
        "Loín: \"Hmm... parece que ainda não está pronto.\n",
        "Mirvím: \"A paciência é o segredo de todo bom jardineiro.\n",
        "Borím: \"Ainda não é o momento certo! Vamos esperar mais um pouco.\n"
        };

        private static string[] comentariosColherSucesso = new string[]
        {
        "Forín: \"Olha só que colheita!\n",
        "Mirvím: \"Trabalho duro recompensado!\n",
        "Forín: \"Hoje é um dia de recompensas no bosque!\n"
        };

        private static string[] comentariosPassarTurno = new string[]
        {
        "...O vento sopra suavemente entre as folhas...",
        "...As raízes se esticam no silêncio da terra...",
        "...O tempo caminha em passos lentos sob o céu estrelado..."
        };

        private static string[] comentariosInspecionarVazio = new string[]
        {
        "Bomím: \"O jardim está vazio... Vamos semear vida!\"",
        "Forín: \"Terra limpa, sonhos por plantar.\""
        };

        private static string[] comentariosInspecionarCheio = new string[]
        {
        "Loín observa atentamente as plantas brotando...",
        "...O jardim está repleto de promessas verdes!",
        "...Cada folha possui um sopro de nova magia..."
        };

        public static void ComentarPlantar()
        {
            Console.WriteLine(EscolherAleatorio(comentariosPlantar));
        }

        public static void ComentarColher(bool colheuAlgo)
        {
            if (colheuAlgo)
                Console.WriteLine(EscolherAleatorio(comentariosColherSucesso));
            else
                Console.WriteLine(EscolherAleatorio(comentariosColherNada));
        }

        public static void ComentarPassarTurno()
        {
            Console.WriteLine(EscolherAleatorio(comentariosPassarTurno));
        }

        public static void ComentarInspecionar(bool jardimVazio)
        {
            if (jardimVazio)
                Console.WriteLine(EscolherAleatorio(comentariosInspecionarVazio));
            else
                Console.WriteLine(EscolherAleatorio(comentariosInspecionarCheio));
        }

        private static string EscolherAleatorio(string[] opcoes)
        {
            return opcoes[random.Next(opcoes.Length)];
        }
    }
}
