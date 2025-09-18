using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OContoDasFolhasJogo.Sistema
{
    public  class HistoriaReceitas
    {
        private static Random random = new Random();

        private static string[] comentariosInicioCozinhar = new string[]
        {
        "Forín: \"Hora de cozinhar uma receita nova!!\n",
        "Mirvím: \"Comida boa, batalha ganha\n",
        "Bomím: \"Nada como um bom prato para fortalecer o espírito.\n",
        "Loín: \"Hora da mágica acontecer, coloque a mão na massa!\n"
        };

        private static string[] comentariosSucessoCozinhar = new string[]
        {
        "Loín: \"Hmmm, o aroma está incrível!\n",
        "Forín: \"A comida mágica está pronta!\n",
        "Bomím: \"Essa refeição vai nos dar forças renovadas!\n",
        "Mirvím: \"Missão cumprida! Agora, hora de saborear.\n"
        };

        private static string[] comentariosFaltaIngredientes = new string[]
        {
        "Mirvím: \"Oh não... estamos sem os ingredientes necessários!\"",
        "Lóín: \"Parece que precisamos voltar ao jardim e colher mais.\"",
        "Bomím: \"Sem ingredientes, sem banquete...\""
        };

        private static string[] comentariosVoltarMenu = new string[]
        {
        "Forín: \"Voltando para casa...\n",
        "Mirím: \"Hora de decidir o próximo passo!\n",
        "Bomím: \"Ainda temos muito para fazer.\n"
        };

        private static string[] comentariosGemaEncantada = new string[]
    {
        "Loín: \"Incrível! Você criou uma Gema Encantada!\n",
        "Forín: \"Essa é uma obra-prima... vai nos proteger em qualquer batalha!\n",
        "Bomím: \"Sinto o poder vibrando nesta gema!\n",
        "Mirvím: \"Poucos conseguem forjar algo tão magnífico!\n"
    };


        public static void ComentarInicioCozinhar()
        {
            Console.WriteLine(EscolherAleatorio(comentariosInicioCozinhar));
        }

        public static void ComentarSucessoCozinhar()
        {
            Console.WriteLine(EscolherAleatorio(comentariosSucessoCozinhar));
        }

        public static void ComentarFaltaIngredientes()
        {
            Console.WriteLine(EscolherAleatorio(comentariosFaltaIngredientes));
        }

        public static void ComentarVoltarMenu()
        {
            Console.WriteLine(EscolherAleatorio(comentariosVoltarMenu));
        }

        public static void ComentarGemaEncantada()
        {
            Console.WriteLine(EscolherAleatorio(comentariosGemaEncantada));
        }

        private static string EscolherAleatorio(string[] opcoes)
        {
            return opcoes[random.Next(opcoes.Length)];
        }
    }
}
