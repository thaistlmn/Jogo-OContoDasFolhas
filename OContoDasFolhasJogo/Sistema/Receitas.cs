using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OContoDasFolhasJogo.Sistema
{
    public static class Receitas
    {
        // Classe básica para definir receitas culinárias
        public class Receita
        {
            public string Nome { get; set; }
            public string Efeito { get; set; }

            public Receita(string nome, string efeito)
            {
                Nome = nome;
                Efeito = efeito;
            }
            // Método para preparar comida
            public static void PrepararComida()
            {
                Musica.Tocar(Musica.TemaComidaPronta);
                string[] opcoes = {
                    "Ensopado de Raízes (Requer: 3 Raiz Flamejante)",
                    "Doce de Néctar (Requer: 2 Néctar Dourado)",
                    "Risoto Sombrio (2 Cogumelo Sombrio)",
                    "Pólen Fortalecedor (2 Pólen Luminoso)",
                    "Salada da Aurora (2 Fruto da Aurora)",
                    "Gema Encantada (1 Gema Terrosa, 1 Néctar Dourado)",
                    "Voltar"
                };

                int indiceSelecionado = 0;
                ConsoleKey tecla;

                do
                {
                    Console.Clear();

                    HistoriaReceitas.ComentarInicioCozinhar();
                    Console.WriteLine("Escolha a receita para preparar:\n");

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
                        bool comidaPreparada = false; 

                        switch (indiceSelecionado)
                        {
                            case 0:
                                Preparar ("Raiz Flamejante", 3, "Ensopado de Raízes", "Recupera 80 PV");
                                comidaPreparada = true;
                                break;
                            case 1:
                                Preparar("Néctar Dourado", 2, "Doce de Néctar", "Restaura 30 PV e aumenta Defesa +5");
                                comidaPreparada = true;
                                break;
                            case 2:
                                Preparar("Cogumelo Sombrio", 2, "Risoto Sombrio", "Reduz defesa do inimigo em 10 no próximo ataque");
                                comidaPreparada = true;
                                break;
                            case 3:
                                Preparar("Pólen Luminoso", 2, "Pólen Fortalecedor", "Aumenta defesa do grupo por 2 turnos");
                                comidaPreparada = true;
                                break;
                            case 4:
                                Preparar("Fruto da Aurora", 2, "Salada da Aurora", "Cura 40 PV para todos os Barbafolhas");
                                comidaPreparada = true;
                                break;
                            case 5:
                                if (Inventario.TemIngrediente("Gema Terrosa", 1) && Inventario.TemIngrediente("Néctar Dourado", 1))
                                {
                                    Inventario.RemoverIngrediente("Gema Terrosa", 1);
                                    Inventario.RemoverIngrediente("Néctar Dourado", 1);
                                    Listas.ListaDeReceitas.Add(new Receita("Gema Encantada", "Aumenta resistência e recupera 20 PV"));
                                    Console.WriteLine("\nGema Encantada preparada!");
                                    HistoriaReceitas.ComentarGemaEncantada();
                                    comidaPreparada = true;
                                }
                                else
                                {
                                    Console.WriteLine("\nIngredientes insuficientes. Você precisa plantar e colher novos ingredientes antes de cozinhar.");
                                    HistoriaReceitas.ComentarFaltaIngredientes();
                                }
                                break;
                            case 6:
                                HistoriaReceitas.ComentarVoltarMenu();
                                Console.WriteLine("\nVoltando ao menu...");
                                return;
                        }

                        if (comidaPreparada)
                        {
                            Console.WriteLine();
                            Desenhos.DesenharComida();
                        }

                        Console.WriteLine("\nPressione qualquer tecla para continuar...");
                        Console.ReadKey(true);
                    }
                    Musica.Parar();
                } while (true);

            }

            public static void Preparar(string nomeIngrediente, int quantidade, string nomeReceita, string efeito)
            {
                Musica.Tocar(Musica.TemaComidaPronta);
                if (Inventario.TemIngrediente(nomeIngrediente, quantidade))
                {
                    Inventario.RemoverIngrediente(nomeIngrediente, quantidade);
                    Listas.ListaDeReceitas.Add(new Receita(nomeReceita, efeito));
                    HistoriaReceitas.ComentarSucessoCozinhar();
                    Console.WriteLine($"\n{nomeReceita} preparado!");
                    ArvoreEleanor.Curar(10);
                }
                else
                {
                    HistoriaReceitas.ComentarFaltaIngredientes();
                    Console.WriteLine("\nVolte a cultivar mais ingredientes para tentar novas receitas!");
                }
                Musica.Parar();

            }

        }
    }
}
