using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OContoDasFolhasJogo.Personagens;

namespace OContoDasFolhasJogo.Sistema
{
    public class Eventos
    {
        private static Random random = new Random();
        private static int interacoesDesdeUltimoEvento = 0;

        private const int ACOES_MINIMAS_PARA_EVENTO = 5;  
        private const int CHANCE_EVENTO_PERCENTUAL = 25;  
        
        /* Misturei os eventos com as duas formas (porcentagem e sorteio) após duas ações pra ficar mais orgânico
         * E evita de toda vez que escolher uma opção os eventos ocorram. Deixando mais imprevisível 
         */

        public static void RegistrarAcao()
        {
            interacoesDesdeUltimoEvento++;

            if (interacoesDesdeUltimoEvento >= ACOES_MINIMAS_PARA_EVENTO)
            {
                int sorteio = random.Next(1, 101); // Sorteia de 1 a 100
                if (sorteio <= CHANCE_EVENTO_PERCENTUAL)
                {
                    interacoesDesdeUltimoEvento = 0; // Reseta contador
                    DispararEventoAleatorio();
                }
            }
        }
        public static void DispararEventoAleatorio()
        {
            Musica.Tocar(Musica.TemaBatalha);
            //Disparar tela 
            for (int i = 0; i < 6; i++) 
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Thread.Sleep(100); 

                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Thread.Sleep(100);
            }

            // Depois volta tudo ao normal
            Console.ResetColor();
            Console.Clear();

            // Aqui chama o evento mesmo
            Console.WriteLine("Um evento misterioso aconteceu no bosque!");
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey(true);

            int chanceUlze = random.Next(1, 6); 
            var copiaBarbafolhas = Listas.barbafolhas.Select(b => b.Clone()).ToList();

            if (chanceUlze == 1)
            {
                IniciarCombate(copiaBarbafolhas, new List<Ruklins> { Listas.ruklinses.Last() });
            }
            else
            {
                var ruklinses = GerarInimigosAleatorios();
                IniciarCombate(copiaBarbafolhas, ruklinses);
            }
            Musica.Parar();
        }
        private static List<Ruklins> GerarInimigosAleatorios()
        {
            int quantidade = random.Next(1, 4);
            var lista = new List<Ruklins>();
            for (int i = 0; i < quantidade; i++)
            {
                int index = random.Next(0, Listas.ruklinses.Count - 1);
                lista.Add(Listas.ruklinses[index]);
            }
            return lista;
        }

        private static void IniciarCombate(List<Barbafolha> barbafolhas, List<Ruklins> ruklinses)
        {
            Musica.Tocar(Musica.TemaBatalha);
            Desenhos.DesenharRuklins();
            Console.WriteLine("Os Ruklins apareceram!!");
            Console.WriteLine($"Barbafolhas: {barbafolhas.Count} contra Ruklins: {ruklinses.Count}");

            while (barbafolhas.Count > 0 && ruklinses.Count > 0)
            {
                // turno do usuário
                Console.WriteLine("\n -*-*-*-*-*- SEU TURNO -*-*-*-*-*- ");
                Console.WriteLine("Escolha um Barbafolha para agir:");
                int linhaMenuInicio = Console.CursorTop;

                for (int i = linhaMenuInicio; i < Console.WindowHeight; i++)
                {
                    Console.SetCursorPosition(0, i);
                    Console.Write(new string(' ', Console.WindowWidth));
                }

                Console.SetCursorPosition(0, linhaMenuInicio);

                int indiceSelecionado = EscolherComSetas(barbafolhas);

                var heroi = barbafolhas[indiceSelecionado];

                Console.Clear();
                Console.WriteLine($"\n{heroi.Nome} está preparado!");

                Console.WriteLine("\nDeseja equipar ou trocar a arma deste Barbafolha? (s/n)");
                Console.SetCursorPosition(0, Console.CursorTop); 
                string respostaEquipar = Console.ReadLine();

                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, Console.CursorTop);

                if (respostaEquipar.ToLower() == "s")
                {
                    Inventario.EquiparArma(heroi.Nome);
                }


                Console.ForegroundColor = ConsoleColor.DarkYellow;
                switch (heroi.Nome)
                {
                    case "Bomím":
                        Desenhos.DesenharBomim();
                        break;
                    case "Forín":
                        Desenhos.DesenharForin();
                        break;
                    case "Mirvím":
                        Desenhos.DesenharMirvim();
                        break;
                    case "Loín":
                        Desenhos.DesenharLoin();
                        break;
                    default:
                        Console.WriteLine("(Barbafolha desconhecido!)");
                        break;
                }
                Console.ResetColor();
                Console.WriteLine("Escolha uma ação: 1. Ataque Físico  2. Magia  3. Defesa");

                string acao = Console.ReadLine();
                var alvoRuklin = ruklinses[random.Next(ruklinses.Count)];

                switch (acao)
                {
                    case "1":
                        int danoBase = heroi.Forca;
                        var arma = Inventario.ObterArmaEquipada(heroi.Nome);
                        if (arma != null)
                        {
                            Console.WriteLine($"{heroi.Nome} ataca com {arma.Nome}!");
                            danoBase += arma.PoderAtaque;
                        }
                        else
                        {
                            Console.WriteLine($"{heroi.Nome} ataca com as próprias forças!");
                        }

                        int danoFinal = danoBase - (alvoRuklin.Defesa / 4);
                        alvoRuklin.PontoVida -= Math.Max(0, danoFinal);
                        Console.WriteLine($"{heroi.Nome} causou {Math.Max(0, danoFinal)} de dano em {alvoRuklin.Nome}!");

                        if (alvoRuklin.PontoVida <= 0)
                        {
                            Console.WriteLine($"{alvoRuklin.Nome} foi derrotado!");
                            ruklinses.Remove(alvoRuklin);
                        }
                        break;

                    case "2":
                        Console.WriteLine($"{heroi.Nome} lança uma magia contra {alvoRuklin.Nome}!");
                        int danoMagico = heroi.Inteligencia - (alvoRuklin.Defesa / 5);
                        alvoRuklin.PontoVida -= Math.Max(0, danoMagico);
                        Console.WriteLine($"Magia causou {Math.Max(0, danoMagico)} de dano!");

                        if (alvoRuklin.PontoVida <= 0)
                        {
                            Console.WriteLine($"{alvoRuklin.Nome} foi derrotado!");
                            ruklinses.Remove(alvoRuklin);
                        }
                        break;

                    case "3":
                        Console.WriteLine($"{heroi.Nome} se defende (+20 Defesa temporária)");
                        heroi.Defesa += 20;
                        break;
                }

                if (ruklinses.Count == 0) break;

                Desenhos.DesenharRuklinses();
                Console.WriteLine("\n Turno dos Ruklins ");
                var ruklinAtacante = ruklinses[random.Next(ruklinses.Count)];
                var alvoHeroi = barbafolhas[random.Next(barbafolhas.Count)];

                int dano = ruklinAtacante.Forca - (alvoHeroi.Defesa / 4);
                alvoHeroi.PontoVida -= Math.Max(0, dano);
                Console.WriteLine($"{ruklinAtacante.Nome} ataca {alvoHeroi.Nome} e causa {Math.Max(0, dano)} de dano!");

                if (alvoHeroi.PontoVida <= 0)
                {
                    Console.WriteLine($"{alvoHeroi.Nome} foi derrotado!");
                    barbafolhas.Remove(alvoHeroi);
                }

                // remove a defesa bônus temporária
                foreach (var b in barbafolhas)
                    b.Defesa = Math.Max(80, b.Defesa - 20);
            }

            // resultado final do evento 
            if (barbafolhas.Count > 0)
            {
                Console.WriteLine("\nOs Barbafolhas venceram!");
                ArvoreEleanor.Curar(10); // Cura a árvore após vitória
                Jardim.PassarTurno();
            }
            else
            {
                Desenhos.DesenharRuklins();
                Console.WriteLine("\nOs Ruklins venceram... o bosque escurece.");
                ArvoreEleanor.SofrerDano(10); 
                Console.WriteLine("\nVoltando ao menu principal...");
                Console.ReadKey();
                Program.MenuPrincipal();
            }
            Musica.Parar();
            Console.ReadKey();
        }
        private static int EscolherComSetas(List<Barbafolha> barbafolhas)
        {
            int indice = 0;
            ConsoleKey tecla;
            int linhaInicial = Console.CursorTop;
            int linhasParaLimpar = barbafolhas.Count;

            if (Console.BufferHeight < linhaInicial + linhasParaLimpar + 1)
            {
                Console.BufferHeight = linhaInicial + linhasParaLimpar + 5;
            }
            do
            {
                for (int i = 0; i < linhasParaLimpar; i++)
                {
                    Console.SetCursorPosition(0, linhaInicial + i);
                    Console.Write(new string(' ', Console.WindowWidth));
                }
                for (int i = 0; i < barbafolhas.Count; i++)
                {
                    int linhaDestino = linhaInicial + i;
                    if (linhaDestino < Console.BufferHeight)
                    {
                        Console.SetCursorPosition(0, linhaDestino);
                        if (i == indice)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($"> {barbafolhas[i].Nome} (HP: {barbafolhas[i].PontoVida})");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine($"  {barbafolhas[i].Nome} (HP: {barbafolhas[i].PontoVida})");
                        }
                    }
                }
                tecla = Console.ReadKey(true).Key;

                if (tecla == ConsoleKey.UpArrow && indice > 0)
                {
                    indice--;
                }
                else if (tecla == ConsoleKey.DownArrow && indice < barbafolhas.Count - 1)
                {
                    indice++;
                }

            } while (tecla != ConsoleKey.Enter);

            return indice;
        }

    }
}
