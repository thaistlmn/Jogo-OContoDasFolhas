using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OContoDasFolhasJogo.Sistema;

namespace OContoDasFolhasJogo.Menus
{
    public class MenuMineracao
    {
        public static void Exibir()
        {
            string[] opcoes = { "Recuperar Gems", "Forjar", "Mostrar Gems Disponíveis", "Mostrar Armas Forjadas", "Voltar" };
            int indiceSelecionado = 0;
            ConsoleKey tecla;

            do
            {
                Console.Clear();
                Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
                Console.WriteLine("-*-*-*-                   -*-*-*-");
                Console.WriteLine("-*-*-*-  MINAS ILMARÍM    -*-*-*-");
                Console.WriteLine("-*-*-*-                   -*-*-*-");
                Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-\n");

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
                            Mineracao.MinerarGems();
                            Eventos.RegistrarAcao();
                            break;
                        case 1:
                            Mineracao.ForjarArmas();
                            Eventos.RegistrarAcao();
                            break;
                        case 2: 
                            Mineracao.MostrarGemsDisponiveis();
                            break;
                        case 3: 
                            Mineracao.MostrarArmasForjadas();
                            break;
                        case 4: 
                            return;

                    }
                    Console.WriteLine("\nPara voltar, pressione qualquer tecla...");
                    Console.ReadKey(true);
                }

            } while (true);
        }

    }
}
