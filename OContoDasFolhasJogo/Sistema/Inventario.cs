using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OContoDasFolhasJogo.Sistema
{
    public class Inventario
    {
        private static List<Ingredientes> ingredientes = new List<Ingredientes>();
        private static List<Arma> ArmasDisponiveis = new List<Arma>();
        private static Dictionary<string, Arma> ArmasEquipadas = new Dictionary<string, Arma>();
        private static List<string> Itens = new List<string>();

        #region InventarioIngredientes
        public static void AdicionarIngredientes(Ingredientes ingrediente)
        {
            var existente = ingredientes.FirstOrDefault(i => i.Nome == ingrediente.Nome);
            if (existente != null)
            {
                existente.Quantidade += ingrediente.Quantidade;
            }
            else
            {
                ingredientes.Add(ingrediente);
            }
            Console.WriteLine($"\n{ingrediente.Quantidade} - {ingrediente.Nome} coletado!");
        }

        // remover os ingredientes
        public static void RemoverIngrediente(string nome, int quantidade)
        {
            var ingrediente = ingredientes.FirstOrDefault(i => i.Nome == nome);
            if (ingrediente != null)
            {
                ingrediente.Quantidade -= quantidade;
                if (ingrediente.Quantidade <= 0)
                {
                    ingredientes.Remove(ingrediente);
                }
            }
        }
        public static void ListarIngredientes()
        {
            Console.WriteLine("\nLista de Ingredientes");

            if (ingredientes.Count == 0)
            {
                Console.WriteLine("Lista vazia!\nColete ingredientes para começar a cozinhar!");
            }
            else
            {
                foreach (var item in ingredientes)
                {
                    {
                        Console.WriteLine($"{item.Quantidade} - {item.Nome}");

                    }
                }
            }
        }
        public static bool TemIngrediente(string nome, int quantidade)
        {
            var ingrediente = ingredientes.FirstOrDefault(i => i.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
            return ingrediente != null && ingrediente.Quantidade >= quantidade;
        }
        #endregion

        #region InventarioArmas
        public static void AdicionarArma(Arma arma)
        {
            ArmasDisponiveis.Add(arma);
            Console.WriteLine($"Arma '{arma.Nome}' foi adicionada ao inventário.");
        }

        public static void ListarArmas()
        {
            if (ArmasDisponiveis.Count == 0)
            {
                Console.WriteLine("Nenhuma arma disponível.");
                return;
            }

            Console.WriteLine("Armas disponíveis:");
            for (int i = 0; i < ArmasDisponiveis.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {ArmasDisponiveis[i]}");
            }
        }

        public static void EquiparArma(string nomeBarbafolha)
        {
            ListarArmas();
            Console.Write("Escolha o número da arma para equipar: ");
            if (int.TryParse(Console.ReadLine(), out int escolha) &&
                escolha > 0 && escolha <= ArmasDisponiveis.Count)
            {
                var armaEscolhida = ArmasDisponiveis[escolha - 1];
                ArmasEquipadas[nomeBarbafolha] = armaEscolhida;
                Console.WriteLine($"{nomeBarbafolha} agora está equipado com {armaEscolhida.Nome}");
            }
            else
            {
                Console.WriteLine("Escolha inválida.");
            }
        }

        public static Arma ObterArmaEquipada(string nomeBarbafolha)
        {
            if (ArmasEquipadas.ContainsKey(nomeBarbafolha))
                return ArmasEquipadas[nomeBarbafolha];
            return null;
        }

        public static void RemoverItem(string item)
        {
            if (Itens.Contains(item))
                Itens.Remove(item);
        }

        #endregion

        #region InventarioGemas
        public static bool TemGema()
        {
            return Itens.Any(item => item.StartsWith("Gem "));
        }
        public static void AdicionarItem(string item)
        {
            Itens.Add(item);
        }
        public static void RemoverGema()
        {
            var gemaEncontrada = Itens.FirstOrDefault(item => item.StartsWith("Gem "));
            if (gemaEncontrada != null)
                Itens.Remove(gemaEncontrada);
        }
        #endregion

    }
}
