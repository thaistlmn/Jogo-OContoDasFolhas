using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OContoDasFolhasJogo.Sistema
{
    public class Desenhos
    {
        #region Desenho Titulo Jogo
        public static void TituloJogo()
        {
            Musica.Tocar(Musica.TemaVitoria);
            string[] titulo = new string[]
            {
            "╔╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╗",
           "╠╬╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╬╣",
            "╠╣                                                                                                               ╠╣",
            "╠╣                                                                                                               ╠╣",
            "╠╣                                                                                                               ╠╣",
            "╠╣         ...           .,-:::::      ...     :::.    :::.::::::::::::    ...                                   ╠╣",
            "╠╣      .;;;;;;;.      ,;;;'````'   .;;;;;;;.  `;;;;,  `;;;;;;;;;;;'''' .;;;;;;;.                                ╠╣",
            "╠╣     ,[[     \\[[,    [[[         ,[[     \\[[,  [[[[[. '[[     [[     ,[[     \\[[,                              ╠╣",
            "╠╣     $$$,     $$$    $$$         $$$,     $$$  $$$ \"Y$c$$     $$     $$$,     $$$                              ╠╣",
            "╠╣     \"888,_ _,88P    `88bo,__,o, \"888,_ _,88P  888    Y88     88,    \"888,_ _,88P                              ╠╣",
            "╠╣       \"YMMMMMP\"       \"YUMMMMMP\"  \"YMMMMMP\"   MMM     YM     MMM      \"YMMMMMP\"                               ╠╣",
            "╠╣     :::::::-.    :::.      .::::::.         .-:::::'    ...      :::       ::   .:    :::.      .::::::.      ╠╣",
            "╠╣      ;;,   `';,  ;;`;;    ;;;`    `         ;;;''''  .;;;;;;;.   ;;;      ,;;   ;;,   ;;`;;    ;;;`    `      ╠╣",
            "╠╣      `[[     [[ ,[[ '[[,  '[==/[[[[,        [[[,,== ,[[     \\[[, [[[     ,[[[,,,[[[  ,[[ '[[,  '[==/[[[[,     ╠╣",
            "╠╣       $$,    $$c$$$cc$$$c   '''    $        `$$$\"`` $$$,     $$$ $$'     \"$$$\"\"\"$$$ c$$$cc$$$c   '''    $     ╠╣",
            "╠╣       888_,o8P' 888   888, 88b    dP         888    \"888,_ _,88Po88oo,.__ 888   \"88o 888   888, 88b    dP     ╠╣",
            "╠╣       MMMMP\"`   YMM   \"\"`   \"YMmMY\"          \"MM,     \"YMMMMMP\" \"\"\"\"YUMMM MMM    YMM YMM   \"\"`   \"YMmMY\"      ╠╣",
            "╠╣                                                                                                               ╠╣",
            "╠╣                                                                                                               ╠╣",
            "╠╣                                                                                                               ╠╣",
            "╠╬╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╬╣",
            "╚╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╝"
            };

            foreach (string linha in titulo)
            {
                Console.WriteLine(linha);
                Thread.Sleep(80); // tempo de exibição linha por linha
            }
            Thread.Sleep(4000);
            Musica.Parar();
            Console.Clear();
        }
        #endregion

        #region Desenhos Barbafolhas
        public static void DesenharBomim()
        {
            string[] barbafolha = new string[]
                {
                    "            .::=..            ",
                    "            .:    :.          ",
                    "           :'      ':         ",
                    "          .:+''''''+:.        ",
                    "          :+  @  @  +:        ",
                    "        .%%:  ^^^^  :%%.      ",
                    "          +::::::::::+        ",
                    "           .##. .##.          "
                };

            foreach (string line in barbafolha)
            {
                Console.WriteLine(line);
            }

        }
        public static void DesenharLoin()
        {
            string[] barbafolha = new string[]
                {
                    "            .::=..            ",
                    "            .:    :.          ",
                    "           :'      ':         ",
                    "          .:+''''''+:.        ",
                    "          :+  -  -  +:        ",
                    "        .%%:  ^^^^  :%%.      ",
                    "          +::::::::::+        ",
                    "            ##.  ##.          "
                };

            foreach (string line in barbafolha)
            {
                Console.WriteLine(line);
            }
        }
        public static void DesenharForin()
        {
            string[] barbafolha = new string[]
                {
                    "            .::=..            ",
                    "            .:    :.          ",
                    "           :'      ':         ",
                    "          .:+''''''+:.        ",
                    "          :+ -0--0- +:        ",
                    "        .%%:  ^^^^  :%%.      ",
                    "          +::::::::::+        ",
                    "            ##)  ##)          "
                };

            foreach (string line in barbafolha)
            {
                Console.WriteLine(line);
            }
        }
        public static void DesenharMirvim()
        {
            string[] barbafolha = new string[]
                {
                    "            .::=..            ",
                    "            .:    :.          ",
                    "           :'      ':         ",
                    "          .:+''''''+:.        ",
                    "          :+  >  <  +:        ",
                    "        .%%:  ^^^^  :%%.      ",
                    "          +::::::::::+        ",
                    "            ##)  ##)          "
                };

            foreach (string line in barbafolha)
            {
                Console.WriteLine(line);
            }
        }

        public static void DesenharBarbafolhas()
        {
            string[] barbafolha = new string[]
            {
                "                                                                                           ",
                "   .        .::=..              .::=..       .      .::=..         .   .::=..              ",
                "   ..       .:    :.      *     .:    :.    ..      .:    :.      ..   .:    :.       .    ",
                "   *+      :'      ':    ++*    :'      ':   +*    :'      ':    +.    :'      ':      .   ",
                "   .      .:+''''''+:.    .   .:+''''''+:.    .   .:+''''''+:.   +*    .:+''''''+:.   +*+  ",
                "   .      :+  >  <  +:        :+  @  @  +:        :+ -0--0- +:   .    :+  -  -  +:     +   ",
                "  *+    .%%:  ^^^^  :%%.    .%%:  ^^^^  :%%.    .%%:  ^^^^  :%%.    .%%:  ^^^^  :%%.   .   ",
                "  .       +::::::::::+        +::::::::::+        +::::::::::+        +::::::::::+         ",
                "           |__)  |__)           |__) |__)           |__) |__)           |__) |__)          ",
                "      .=#+*...=#+*...=#..  .=*...=#+*...=#+*.. .=#+*...=#+*.=#+*..   .=#+*..=#+*#+*..      ",
                "'.'..=-+*..*+-=..'.'..=-+*..*+-=..'.'..=-+*..*+-=..'.'..=-+*..*+-=..'.'..=-+*..*+-=..'.'..=",
                "                                                                                           ",
            };
            foreach (string line in barbafolha)
            {
                Console.WriteLine(line);
            }
        }

        #endregion

        #region Ruklins
        public static void DesenharRuklins()
        {
            string[] desenho = new string[]
            {
                    "          *^.^^^^.^*                          *^.^^^^.^*                          *^.^^^^.^*                ",
                    "#=+-:::+=  .+.  .+.  =+:::-+=#      #=+-:::+=  .+.  .+.  =+:::-+=#      #=+-:::+=  .+.  .+.  =+:::-+=#      ",
                    " '+=:    =:   ::   :=    :=+'        '+=:    =:   ::   :=    :=+'         '+=:    =:   ::   :=    :=+'      ",
                    "   ':=...   @'   '@   ...=:'          ':=...   @'   '@   ...=:'            ':=...   @'   '@   ...=:'        ",
                    "         +.    ..   .+                      +.    ..   .+                       +.    ..   .+               ",
                    "       <<%+.  ''''  .+%>>                 <<%+.  ''''  .+%>>                  <<%+.  ''''  .+%>>            ",
                    "          %=-=##=-=%                          %=-=##=-=%                          %=-=##=-=%                ",
                    "          <<<    >>>                          <<<    >>>                          <<<    >>>                "
            };

            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();

                foreach (string linha in desenho)
                {
                    Console.ForegroundColor = (ConsoleColor)random.Next(1, 16);
                    Console.WriteLine(linha);
                }

                Console.ResetColor();
                Thread.Sleep(300);

                Console.Clear();
            }

        }

        public static void DesenharRuklinses()
        {
            string[] desenho = new string[]
            {
                    "                                ",
                    "          *^.^^^^.^*            ",
                    "#=+-:::+=  .+.  .+.  =+:::-+=#  ",
                    " '+=:    =:   ::   :=    :=+'   ",
                    "   ':=...   @'   '@   ...=:'    ",
                    "         +.    ..   .+          ",
                    "       <<%+.  ''''  .+%>>       ",
                    "          %=-=##=-=%            ",
                    "          <<<    >>>            ",
                    "                                "
            };

            Console.ForegroundColor = ConsoleColor.DarkGray; 
            foreach (string linha in desenho)
            {
                Console.WriteLine(linha);
            }
            Console.ResetColor();
        }
        #endregion

        #region Desenho Receitas
        public static void DesenharComida()
        {
            string[] desenho = new string[]
            {
                "             *+   +              ",
                "           *  *  *               ",
                "          *   + * +              ",
                "          ++    *  *             ",
                "  @@@@@%#* +   * * * *##@@@@@    ",
                "  %@@@**%@@@@@@@@@#@@@@@@@@@@@   ",
                "     @*+==+++++*%@@@@@@@@@@@@    ",
                "     @*===+++++=+@@@@@@@@@       ",
                "     @%*==+++++#@@@@@@@@@@       ",
                "      @@*==++*@@*@@@@@@@#        ",
                "        @@@@@@@@@@@@@@%#         "
            };
            for (int i = 0; i < desenho.Length; i++)
            {
                if (i < 4)
                    Console.ForegroundColor = ConsoleColor.Yellow;
                else
                    Console.ForegroundColor = ConsoleColor.DarkYellow; // marrom

                Console.WriteLine(desenho[i]);
            }

            Console.ResetColor();

        }
        #endregion

        #region Desenho Jardim
        public static void DesenharJardim()
        {
            string[] desenho = new string[]
            {
                "                                                                                ",
                "                                                                                ",
                "            -@@+                      .@                                        ",
                "          #@@@@@@*               #@-   #@@- *@=                     @.          ",
                "  *@@@@@: @@@@@@@%*    . . . .  +@@@@+@@@@%@@@@.     @.            #@@-         ",
                " :@@@@@@@ @@@@@@@@@.   @ @ @ @   .@@@@@@@%@@@@     -=@=#         @ @ @ @        ",
                " .@@@@@@@@@@@@@@%@@.    @@ @@     -%@@@@@@@@*.      %@@-        @@ @@ @@        ",
                "  -@@@@@@@+@@@*@@@:      @@@@       %@@@#@@=        :@%         -@@@@@@-        ",
                "    .*@@@# :#@@@%.      @@@@@@        :@=           =.*           -@@-          ",
                "         * +-.         #@@@@@@@      .+@%=        +#%+%%*:       =* +-.=        ",
                "          %@-          -@@@@@@-     +@@@@@@.    +%@@@#@%@@@        %@-          ",
                "          -%             -@@-       +@@@@@@:   :@@@@@#@@@@@%       -%           ",
                ":==============================================================================:"
            };
            for (int i = 0; i < desenho.Length; i++)
            {
                if (i == desenho.Length - 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow; 
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green; 
                }

                Console.WriteLine(desenho[i]);
            }

            Console.ResetColor();
        }

        public static void DesenharJardimVazio()
        {
            string[] desenho = new string[]
            {

                "                                                                                ",
                "                                                                                ",
                "                                                                                ",
                "          %@-              @         +              +%@             %@-         ",
                "          -%             -@@-       +@@:           :@#%             -%          ",
                ":==============================================================================:"
            };
            for (int i = 0; i < desenho.Length; i++)
            {
                if (i == desenho.Length - 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green; 
                }

                Console.WriteLine(desenho[i]);
            }

            Console.ResetColor();

        }

        public static void DesenharColher()
        {
            string[] desenho = new string[]
            {
                "                         ",
                "                         ",
                "        =+*****+=        ",
                "     :%+*%+. .+%*+#-     ",
                "    #++#         @*=@    ",
                "   =*#.           +%#*   ",
                "   ++#             %*+   ",
                "  %*****---------*****#  ",
                "  #####***************#  ",
                "   +**@+=#*===*%==%*++   ",
                "   +#%@**%%***#@**@#**   ",
                "    =#*@++%+=+%+=@**+    ",
                "      -#@%@%*#@%@#-      ",
                "                         ",
                "                         "
            };
            foreach (string linha in desenho)
            {
                Console.WriteLine(linha);
            }
        }

        public static void DesenharSemente()
        {
            string[] desenho = new string[]
            {

                    "              *#            ",
                    "        ''@@=: .=@%''       ",
                    "  .        -#=@@=@@-    .   ",
                    "   .+       .@.       .     ",
                    "    *      ..#@:      *+    ",
                    "        #@@@@@@=       .    ",
                    "       +@@@@@@@-            ",
                    "        =%@@@=              ",
                    "                            ",
            };
            Random rand = new Random(); 

            foreach (string linha in desenho)
            {
                foreach (char c in linha)
                {
                    // Escolhe uma cor aleatória
                    Console.ForegroundColor = (ConsoleColor)rand.Next(1, 16); 
                    Console.Write(c);
                }
                Console.WriteLine(); 
            }

            Console.ResetColor();

        }
        #endregion

        #region Desenhos Mineracao
        public static void DesenharGem(string gema)
        {
            string[] desenho = new string[]
            {
                "                 ",
                "         *       ",
                "       %*+*%     ",
                "      ##===##    ",
                "        %*%      ",
                "         *       ",
                "                 "
            };

            if (gema == "Gem Terrosa")
            {
                Console.ForegroundColor = ConsoleColor.Yellow; 
                Console.WriteLine("\nGema Terrosa encontrada!");
            }
            else if (gema == "Gem Flamejante")
            {
                Console.ForegroundColor = ConsoleColor.Red; 
                Console.WriteLine("\nGema Flamejante encontrada!");
            }
            else if (gema == "Gem Sombria")
            {
                Console.ForegroundColor = ConsoleColor.DarkGray; 
                Console.WriteLine("\nGema Sombria encontrada!");
            }
            else if (gema == "Gem Celeste")
            {
                Console.ForegroundColor = ConsoleColor.Cyan; 
                Console.WriteLine("\nGema Celeste encontrada!");
            }
            else if (gema == "Gem Dourada")
            {
                Console.ForegroundColor = ConsoleColor.Yellow; 
                Console.WriteLine("\nGema Dourada encontrada!");
            }

            foreach (var linha in desenho)
            {
                Console.WriteLine(linha);
            }
            Console.ResetColor(); // Resetando a cor do console para a cor padrão

        }
        public static void DesenharMartelo()
        {
            string[] desenho = new string[]
            {
                "                    ",
                "          .:.       ",
                "        .-:.:: .    ",
                "        --..--*++.  ",
                "         .:=-%++=.  ",
                "         .++*+=:..-.",
                "       .+#**..:.++*=",
                "     .=*++.    .:=  ",
                "   .:#**.           ",
                " .#*+*:.            ",
                "                    "
            };
            foreach (string linha in desenho)
            {
                Console.WriteLine(linha);
            }

        }
       public static void DesenharEscudo()
        {
            string[] desenho = new string[]
            {
                "                                  ",
                "                .:                ",
                "               .-=: ..            ",
                "            :-. ..:=-  ..         ",
                "         -:.....:====-==.-        ",
                "        .=......:======+=+        ",
                "         -......:======+-=        ",
                "          =:....:=====+-:         ",
                "           -:-:.:==+++:           ",
                "              ---+++=             ",
                "                 +                ",
                "                                  "
            };
            foreach (string linha in desenho)
            {
                Console.WriteLine(linha);
            }

        }
        public static void DesenharMachado()
        {
            string[] desenho = new string[]
            {
                "                       ",
                "              .        ",
                "        .=*-=@:   .    ",
                "        =**=-=***#=.   ",
                "          *%#****#+    ",
                "         :## :+*#*-    ",
                "        .##   +#*-     ",
                "        ##.   ==:      ",
                "       ##:             ",
                "      #@*              ",
                "     .+.               ",
                "                       "
            };
            foreach (string linha in desenho)
            {
                Console.WriteLine(linha);
            }
        }
        #endregion

        #region Desenho Arvore
        public static void DesenharArvore()
        {
            string[] maisUmDesenho = new string[]
            {
                "                                ",
                "         ...     .        .     ",
                "   .. .            ...       .. ",
                "         .:-.--..*--- .-.       ",
                "      :..--==+*%@#*##===+-=..   ",
                "  .. .+***@@@@##@@+#%+##%##*+-  ",
                " . +#@@@#@%#%#:%@#:*+-+##*+#*:  ",
                "  .*%=:-.-#@#%##@# *-+@@%##-=.  ",
                " .-#-+- =+@+#*#@@@@- .=*--+#**: ",
                " :*+:.       --@@%*-=-     .:   ",
                "      ..       -*%%#-           ",
                "     .        :*+*@+      .     ",
                "           .=#@%@%@@*=:         ",
                "    .:--=+*+*%*++**#@*#+++=:..  ",
                "                                ",
                "                                ",
            };

            ConsoleColor[] paletaMagico = new ConsoleColor[]
            {
                ConsoleColor.Magenta,
                ConsoleColor.Blue,
                ConsoleColor.Cyan,
                ConsoleColor.DarkMagenta,
                ConsoleColor.DarkBlue,
                ConsoleColor.White
            };

            for (int i = 0; i < maisUmDesenho.Length; i++)
            {
                Console.ForegroundColor = paletaMagico[i % paletaMagico.Length];
                Console.WriteLine(maisUmDesenho[i]);
            }
            Console.ResetColor();
        }
        public static void DesenharEstrelas()
        {
            string[] luzes = new string[]
            {

                "                                                ",
                "  .     .*     +            .*       +       .  ",
                "      :+*#*+:    : ::     :+*#*+:      : ::     ",
                " :      .*    #   :    +    .*      #   :       ",
                "          ..*#*#*.              ..*#*#*.      . ",
                "    +.    .   #   .:      +.    .   #   .:      ",
                "          *   .:     .          *   .:          ",
                "       .+*#*+.   +     ..    .+*#*+.   +     *  ",
                "   :      *   .      *          *       ..      ",
                "                                                ",
            };

            ConsoleColor[] paletaVerao = new ConsoleColor[]
            {
                ConsoleColor.Yellow,
                ConsoleColor.Red,
                ConsoleColor.Green,
                ConsoleColor.Cyan,
                ConsoleColor.White,
                ConsoleColor.Magenta
            };
            for (int i = 0; i < luzes.Length; i++)
            {
                Console.ForegroundColor = paletaVerao[i % paletaVerao.Length];
                Console.WriteLine(luzes[i]);
            }
            Console.ResetColor();

        }
        #endregion

        #region Desenhos Extras
        public static void MenuDesenho()
        {
            string[] floresta = new string[]
                {
            "*+*#-----===+++==++++*#%%%#%%%%*-::-:::::::-*%%%%%%%%@@%%#%%%%%%%#%%%%%%%%%#*%*----------",
            "@@@+++=+++++=+++++==+++#*=*-::::::::::::::::-+###*#%#*#@@%%%%%@@%%@%%%****+++++==++++++++",
            "@@@#*++++++=-+++++*+++*=-::::::::::::::::::::::--:=%%%%%%@@#*=--=++*%@#%#*+++++++*=-=++==",
            "*+*#@**+***+++++*+++*##%*-::::::::::::::::::::::-:-*#*#*=-----=+++++*##%%%%###*++++++*+**",
            "+++****%#%%#******%%%%*:  .::::::-::::::::::-:   :::-:---=+++++++-==++*%#%@#%%%%%*#**#%%#",
            "++***%%*#@@%%%%@%%%%%+     ::   :::-. .::::      .:----=+++-+++++++*##%%*#@... *%%%#*%#=:",
            "%%%%%%#**@@@@#*@@@@*.      ::.  ::::     ::      .:=+++++++=+++*+***%%%***@.. .*#     :::",
            "##%%%****@@%**%@@-...       :::::::-     :.      ..=+++++**+*++***%%%%#***@:..=*#     :::",
            "    :*******%##*: ...        .::::::    ::.      ...   =**%*##%%%=+=:.+***%++**%.     :::",
            "+   .*****%-      ...          .-:::    ::       ...         .+**:    +*****##        :::",
            "***::*****%       ...          :::::   :-:       ...           **#*   =****%:.       .:::",
            "*********#@       ...          :::::::::.        ...            +**********%:.       .:::",
            ": ****%%*#@       ...          :::::.            ...             -*********%:.       ::::",
            "   =*%@@%%@.      ...          ::::              ...               .+******@:.       ::::",
            "   :*%%%##@:      ..:===++:.  :::::              ...   =+=++--.     .******@:.       ::::",
            "   :*****#@=      .:-+++=-++#-:::-:  .=+++=:     ... :=+++=-++*+     ******@*.  :====::::",
            "   :*****#@*   ..:-=:+=+++=+*#*-:-+++++++++++++:.::--=-+==++-+*#*.   ******%@=+++++++++==",
            "   =******@% :-=+=+**+++****#%##*++++++++++++++==++=+***+*+*###%##*.:******%@++++++++++++",
            "   *******%#-==-++*##*++=+**=##%%#*++*******++==+=*****==+=++*-*%%####*****%#*++**++**+++",
             };
            foreach (string line in floresta)
            {
                Console.WriteLine(line);
            }
        }
        #endregion
    }
}
