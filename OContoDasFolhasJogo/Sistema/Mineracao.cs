using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OContoDasFolhasJogo.Sistema
{
    public class Mineracao
    {
        public static Random random = new Random();
        private List<Mineracao> mina = new List<Mineracao>();
        public static void MinerarGems()
        {
            Musica.Tocar(Musica.TemaMineracao);
            Console.WriteLine("Minerando gems agora...\n");
            string[] gemsPossiveis = { "Gem Terrosa", "Gem Flamejante", "Gem Sombria", "Gem Celeste", "Gem Dourada" };
            string gem = gemsPossiveis[random.Next(gemsPossiveis.Length)]; // pega as gems em modo aleatório de acordo com a length do string
            
            Listas.gemsObtidas.Add(gem);
            Inventario.AdicionarItem(gem);

            HistoriaMineracao.ComentarEncontrarGem();
            Desenhos.DesenharGem(gem);

            Musica.Parar();
            Jardim.PassarTurno();
        }
        public static void ForjarArmas()
        {
            Musica.Tocar(Musica.TemaMineracao);
            if (Listas.gemsObtidas.Count == 0)
            {
                HistoriaMineracao.ComentarForjar(false);
                Console.WriteLine("Sem gems suficientes para forjar uma arma, tente novamente depois...");
                return;
            }

            Console.WriteLine("Forjando arma...");
            HistoriaMineracao.ComentarForjar(true);
            string[] armasPossiveis = { "Machado Dinan", "Escudo Duplo", "Martelo Orebro" }; // armas usadas em combate!
            string nomeArma = armasPossiveis[random.Next(armasPossiveis.Length)];

            Listas.armasForjadas.Add(nomeArma);

            int poderAtaque = 0;
            switch (nomeArma)
            {
                case "Machado Dinan":
                    poderAtaque = 25;
                    break;
                case "Escudo Duplo":
                    poderAtaque = 20;
                    break;
                case "Martelo Orebro":
                    poderAtaque = 30;
                    break;
            }

            Arma novaArma = new Arma(nomeArma, poderAtaque, "Forjada");
            Inventario.AdicionarArma(novaArma);

            string gemConsumida = Listas.gemsObtidas[0];
            Listas.gemsObtidas.RemoveAt(0);

            Inventario.RemoverItem(gemConsumida);

            System.Threading.Thread.Sleep(2000);
            Console.Clear();

            Console.WriteLine($"{nomeArma} forjado(a) com sucesso! Uma gem utilizada!");



            Console.WriteLine("\nVisual da arma forjada:\n");
            if (nomeArma == "Machado Dinan")
            {
                Desenhos.DesenharMachado();
            }
            else if (nomeArma == "Escudo Duplo")
            {
                Desenhos.DesenharEscudo();
            }
            else if (nomeArma == "Martelo Orebro")
            {
                Desenhos.DesenharMartelo();
            }
            Console.ReadKey();
            Jardim.PassarTurno();
            Musica.Parar();
        }
        public static void MostrarGemsDisponiveis()
        {
            Console.Clear();
            Console.WriteLine("Gems Disponíveis:\n");

            if (Listas.gemsObtidas.Count == 0)
            {
                Console.WriteLine("Nenhuma gem disponível no momento.");
                return;
            }

            foreach (var gem in Listas.gemsObtidas)
            {
                Console.WriteLine($"- {gem}");
            }
        }

        public static void MostrarArmasForjadas()
        {
            Console.Clear();
            Console.WriteLine("Armas Forjadas:\n");

            if (Listas.armasForjadas.Count == 0)
            {
                Console.WriteLine("Nenhuma arma foi forjada ainda.");
                return;
            }

            foreach (var arma in Listas.armasForjadas)
            {
                Console.WriteLine($"- {arma}");
            }
        }
    }

}
