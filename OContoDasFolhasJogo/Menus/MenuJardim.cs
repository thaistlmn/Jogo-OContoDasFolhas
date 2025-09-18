using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OContoDasFolhasJogo.Sistema;

namespace OContoDasFolhasJogo.Menus
{
    public class MenuJardim
    {
        public static void Exibir(Jardim jardim, Inventario inventario)
        {
            int opcaoSelecionada = 0;
            string[] opcoes = { "Plantar sementes", "Colher ingredientes", "Mostrar o jardim", "Mostrar ingredientes disponíveis", "Voltar" };
            bool mostrarMensagem = false;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
                Console.WriteLine("-*-*-*-                   -*-*-*-");
                Console.WriteLine("-*-*-*-     JARDINAGEM    -*-*-*-");
                Console.WriteLine("-*-*-*-                   -*-*-*-");
                Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
                Console.WriteLine();

                for (int i = 0; i < opcoes.Length; i++)
                {
                    if (i == opcaoSelecionada)
                    {
                        Console.BackgroundColor = ConsoleColor.White; // muda as cores conforme as setas
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine($"> {opcoes[i]} <");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"  {opcoes[i]}");
                    }
                }

                var tecla = Console.ReadKey(true).Key;

                if (tecla == ConsoleKey.UpArrow)
                {
                    opcaoSelecionada--;
                    if (opcaoSelecionada < 0)
                        opcaoSelecionada = opcoes.Length - 1;
                }
                else if (tecla == ConsoleKey.DownArrow)
                {
                    opcaoSelecionada++;
                    if (opcaoSelecionada >= opcoes.Length)
                        opcaoSelecionada = 0;
                }
                else if (tecla == ConsoleKey.Enter)
                {
                    switch (opcaoSelecionada)
                    {
                       
                        case 0:
                            jardim.Cultivar();
                            Console.WriteLine("\nPressione qualquer tecla para continuar...");
                            Eventos.RegistrarAcao();
                            Console.ReadKey();
                            mostrarMensagem = false; // Depois de plantar, volta ao menu
                            break;
                        case 1:
                            var colhidos = jardim.Colher();
                            foreach (var item in colhidos)
                            {
                                var ingrediente = Ingredientes.CriarPorNome(item);
                            }
                            Console.WriteLine("\nPressione qualquer tecla para continuar...");
                            Console.ReadKey();
                            mostrarMensagem = false;
                            break;
                        case 2:
                            jardim.MostrarJardim();
                            Console.WriteLine("\nPressione qualquer tecla para continuar...");
                            Eventos.RegistrarAcao();
                            Console.ReadKey();
                            mostrarMensagem = false;
                            break;
                        case 3: 
                            jardim.MostrarIngredientesDisponiveis();
                            Console.WriteLine("\nPressione qualquer tecla para continuar...");
                            Console.ReadKey();
                            mostrarMensagem = false;
                            break;
                        case 4: 
                            return;

                    }
                }
            }
        }

    }
}
