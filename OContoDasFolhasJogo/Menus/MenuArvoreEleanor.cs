using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OContoDasFolhasJogo.Sistema;

namespace OContoDasFolhasJogo.Menus
{
    public class MenuArvoreEleanor
    {
        public static void Exibir()
        {
            string[] opcoes = { "Ver Estado", "Curar Folhas", "Voltar" };
            int indiceSelecionado = 0;
            ConsoleKey tecla;

            do
            {
                Console.Clear();
                Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
                Console.WriteLine("-*-*-*-                   -*-*-*-");
                Console.WriteLine("-*-*-*-  ÁRVORE  ÉLEANÓR  -*-*-*-");
                Console.WriteLine("-*-*-*-                   -*-*-*-");
                Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-\n");

                Console.WriteLine($"Vida Atual: {ArvoreEleanor.VidaAtual}/{ArvoreEleanor.VidaMaxima}\n");

                for (int i = 0; i < opcoes.Length; i++)
                {
                    if (i == indiceSelecionado)
                    {
                        Console.BackgroundColor = ConsoleColor.White; 
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine($"> {opcoes[i]} <");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"  {opcoes[i]}");
                    }
                }

                tecla = Console.ReadKey(true).Key;

                if (tecla == ConsoleKey.UpArrow)
                {
                    indiceSelecionado = (indiceSelecionado - 1 + opcoes.Length) % opcoes.Length;
                }
                else if (tecla == ConsoleKey.DownArrow)
                {
                    indiceSelecionado = (indiceSelecionado + 1) % opcoes.Length;
                }
                else if (tecla == ConsoleKey.Enter)
                {
                    Console.Clear();
                    switch (indiceSelecionado)
                    {
                        case 0:
                            ArvoreEleanor.MostrarEstado();
                            break;
                        case 1:
                            ArvoreEleanor.Curar(10);
                            break;
                        case 2:
                            return; // Sair do menu
                    }

                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey(true);
                }

            } while (true);
        }

    }
}
