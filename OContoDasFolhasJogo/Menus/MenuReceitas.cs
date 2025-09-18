using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OContoDasFolhasJogo.Sistema;

namespace OContoDasFolhasJogo.Menus
{
    public class MenuReceitas
    {
        public static void Exibir()
        {
            string[] opcoes = { "Preparar refeições", "Voltar" };
            int indiceSelecionado = 0;
            ConsoleKey tecla;

            do
            {
                Console.Clear();
                Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
                Console.WriteLine("-*-*-*-                   -*-*-*-");
                Console.WriteLine("-*-*-*-  NA COZINHA...    -*-*-*-");
                Console.WriteLine("-*-*-*-                   -*-*-*-");
                Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-\n");

                for (int i = 0; i < opcoes.Length; i++)
                {
                    if (i == indiceSelecionado)
                    {
                        Console.BackgroundColor = ConsoleColor.White; // muda a cor da "caixa" 
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
                            Receitas.Receita.PrepararComida();
                            Eventos.RegistrarAcao();
                            break;
                        case 1:
                            return; // Voltar
                    }

                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey(true);
                }

            } while (true);
        }
    }
}
