using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OContoDasFolhasJogo.Sistema
{
    public class Jardim
    {
        private class PlantaCultivada
        {
            public string Nome { get; set; }
            public int TurnosParaCrescer { get; set; }
        }

        private static List<PlantaCultivada> plantas = new List<PlantaCultivada>();
        private static Dictionary<string, int> ingredientesDisponiveis = new Dictionary<string, int>();
        private Random random = new Random();

        public Dictionary<string, int> ingredientesComTurnos = new Dictionary<string, int>
        {
        {"Raiz Flamejante", 1},
        {"Néctar Dourado", 3},
        {"Cogumelo Sombrio", 2},
        {"Pólen Luminoso", 2},
        {"Fruto da Aurora", 1},
        };

        public void Cultivar()
        {
            
            Console.Clear();
            var ingrediente = EscolherIngredientesAleatorio();
            int turnos = ingredientesComTurnos[ingrediente];

            plantas.Add(new PlantaCultivada { Nome = ingrediente, TurnosParaCrescer = turnos });

            HistoriaJardim.ComentarPlantar();
            Console.WriteLine($"\nVocê plantou {ingrediente}. Ficará pronto em {turnos} turno(s)\n\n");

            Desenhos.DesenharSemente();

        }

        public List<string> Colher()
        {

            List<string> colhidos = new List<string>();
            Console.Clear();
            plantas.RemoveAll(p =>
            {
                if (p.TurnosParaCrescer <= 0)
                {
                    colhidos.Add(p.Nome);
                    return true;
                }
                return false;
            });

            HistoriaJardim.ComentarColher(colhidos.Count > 0);

            if (colhidos.Count > 0)
            {
                foreach (var c in colhidos)
                {
                    Console.WriteLine($"Você colheu: {c}");
                    Inventario.AdicionarIngredientes(new Ingredientes { Nome = c, Quantidade = 1 });
                }
                Desenhos.DesenharColher();
            }
            return colhidos;

        }

        public static void PassarTurno()
        {
            HistoriaJardim.ComentarPassarTurno();
            foreach (var planta in plantas)
            {
                if (planta.TurnosParaCrescer > 0)
                    planta.TurnosParaCrescer--;
            }
        }
        public string EscolherIngredientesAleatorio()
        {
            var chaves = new List<string>(ingredientesComTurnos.Keys);
            return chaves[random.Next(chaves.Count)];
        }

        public void MostrarJardim()
        {
            Musica.Tocar(Musica.TemaJardim);
            HistoriaJardim.ComentarInspecionar(plantas.Count == 0);
            Console.Clear();
            if (plantas.Count == 0)
            {
                Console.WriteLine("Seu jardim está vazio! Volte a plantar novos ingredientes.");
                Desenhos.DesenharJardimVazio();
                return;
            }

            foreach (var p in plantas)
            {
                string status = p.TurnosParaCrescer > 0
                    ? $"(cresce em {p.TurnosParaCrescer} turnos)"
                    : "(pronto para colher)";
                Console.WriteLine($"Planta: {p.Nome} - Status: {status}");
            }
            Desenhos.DesenharJardim();
            Musica.Parar();

        }
        public void MostrarIngredientesDisponiveis()
        {
            Console.Clear();
            Console.WriteLine("=== Ingredientes Disponíveis ===");
            if (ingredientesDisponiveis.Count == 0)
            {
                Console.WriteLine("Nenhum ingrediente disponível no momento!");
            }
            else
            {
                foreach (var item in ingredientesDisponiveis)
                {
                    Console.WriteLine($"{item.Key}: {item.Value} unidade(s)");
                }
            }
            Console.WriteLine("===============================");
        }
    }
}
