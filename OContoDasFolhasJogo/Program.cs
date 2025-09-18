using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OContoDasFolhasJogo.Menus;
using OContoDasFolhasJogo.Personagens;
using OContoDasFolhasJogo.Sistema;

namespace OContoDasFolhasJogo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Personagens adicionados, somente quando a lista está estática fora do Main
            #region Listas e Itens Adicionados
            Listas.barbafolhas = new List<Barbafolha>();
            Listas.ruklinses = new List<Ruklins>();
            Listas.ingredientes = new List<Ingredientes>();

            Listas.barbafolhas.Add(new Barbafolha { Nome = "Forín", PontoVida = 190, Inteligencia = 120, Destreza = 80, Forca = 90, Defesa = 80 }); // sábio
            Listas.barbafolhas.Add(new Barbafolha { Nome = "Mirvím", PontoVida = 130, Inteligencia = 100, Destreza = 120, Forca = 150, Defesa = 150 }); // guardião
            Listas.barbafolhas.Add(new Barbafolha { Nome = "Bomím", PontoVida = 145, Inteligencia = 180, Destreza = 80, Forca = 100, Defesa = 155 }); // alquimista
            Listas.barbafolhas.Add(new Barbafolha { Nome = "Loín", PontoVida = 195, Inteligencia = 170, Destreza = 110, Forca = 140, Defesa = 180 }); // curandeiro

            Listas.ruklinses.Add(new Ruklins { Nome = "Ruklin", PontoVida = 85, Inteligencia = 100, Destreza = 60, Forca = 75, Defesa = 80 }); // inimigo fraco
            Listas.ruklinses.Add(new Ruklins { Nome = "Ruklin", PontoVida = 105, Inteligencia = 110, Destreza = 85, Forca = 90, Defesa = 90 }); // levemente mais forte
            Listas.ruklinses.Add(new Ruklins { Nome = "Ruklin", PontoVida = 110, Inteligencia = 145, Destreza = 100, Forca = 80, Defesa = 110 }); // mid-Boss
            Listas.ruklinses.Add(new Ruklins { Nome = "Ruklin", PontoVida = 130, Inteligencia = 160, Destreza = 110, Forca = 100, Defesa = 145 }); // Elite
            Listas.ruklinses.Add(new Ruklins { Nome = "Rei Uzi", PontoVida = 200, Inteligencia = 180, Destreza = 170, Forca = 200, Defesa = 190 }); // Elite

            Listas.ingredientes.Add(new Ingredientes("Raiz Flamejante", "Raiz", "Aumenta força", 0));
            Listas.ingredientes.Add(new Ingredientes("Néctar Dourado", "Néctar", "Recupera PV", 0));
            Listas.ingredientes.Add(new Ingredientes("Cogumelo Sombrio", "Fungo", "Diminui defesa do inimigo", 0));
            Listas.ingredientes.Add(new Ingredientes("Pólen Luminoso", "Pólen", "Aumenta defesa", 0));
            Listas.ingredientes.Add(new Ingredientes("Fruto da Aurora", "Fruta", "Cura 20 PV", 0));
            Listas.ingredientes.Add(new Ingredientes("Gema Terrosa", "Mineral", "Aumenta resistência", 0));


            #endregion
            Desenhos.TituloJogo();
            Historia.Intro();
            MenuPrincipal();
            Console.ReadLine();
        }

        public static void MenuPrincipal()
        {
            Inventario inventario = new Inventario();
            Jardim jardim = new Jardim();

            string[] opcoes = {
                   "Cuidar do Jardim",
                   "Cozinhar",
                   "Minerar",
                   "Visitar a Árvore Éleanór",
                   "Sair do Bosque"
            };

            int opcaoSelecionada = 0;
            bool jogando = true;

            Console.CursorVisible = false;

            Musica.Tocar(Musica.TemaMagico);

            while (jogando)
            {
                
                Console.Clear();
                Console.WriteLine("╔══════════════════════════════════════════════╗");
                Console.WriteLine("║        Bosque da Árvore Éleanór - Menu       ║");
                Console.WriteLine("╚══════════════════════════════════════════════╝\n");
                Desenhos.DesenharBarbafolhas();

                Console.WriteLine("\nBomím apareceu: \"Olá! Seja bem-vindo ao nosso lar!\"\"\n");
                Console.WriteLine("Mirvím: \"Escolha com sabedoria... cada ação fortalece nossa floresta!\"\n");
                Console.WriteLine("Loín explica: \"Você precisa plantar ingredientes para conseguir fazer as suas receitas!\"\n");
                Console.WriteLine("Forín: \"E para forjar suas armas lendárias busque as gems dentro das minas.\"\n");
                Console.WriteLine("Bomím avisa: \"Mas fique atento, pois os Ruklins podem aparecer a qualquer momento! Coragem!\"\"\n");

                Console.WriteLine("Os Barbafolhas se reunem e perguntam:");
                Console.WriteLine("\n\"Guardião, o que deseja fazer agora?\"\n");

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

                ConsoleKey tecla = Console.ReadKey(true).Key;

                switch (tecla)
                {
                    case ConsoleKey.UpArrow:
                        opcaoSelecionada = (opcaoSelecionada - 1 + opcoes.Length) % opcoes.Length;
                        break;
                    case ConsoleKey.DownArrow:
                        opcaoSelecionada = (opcaoSelecionada + 1) % opcoes.Length;
                        break;
                    case ConsoleKey.Enter:
                        Console.Clear();
                        switch (opcaoSelecionada)
                        {
                            case 0:
                                MenuJardim.Exibir(jardim, inventario);
                                break;
                            case 1:
                                MenuReceitas.Exibir();
                                break;
                            case 2:
                                MenuMineracao.Exibir();
                                break;
                            case 3:
                                MenuArvoreEleanor.Exibir();
                                break;
                            case 4:
                                jogando = false;
                                Console.WriteLine("\nOs Barbafolhas se despedem com reverência...");
                                Thread.Sleep(1500);
                                Musica.Parar();
                                break;
                        }
                        break;
                }
            }
            Console.CursorVisible = true;
        }

    }
}
