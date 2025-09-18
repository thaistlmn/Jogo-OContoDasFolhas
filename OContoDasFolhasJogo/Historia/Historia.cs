using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OContoDasFolhasJogo.Sistema
{
    public class Historia
    {
 

        static public void Intro()
        {
            Console.Clear();
            string[] introducao = new string[]
            {
                "BEM-VINDO AO BOSQUE DE LYANÓR ",
                "",
                "Em um canto oculto do mundo, onde a magia dança entre as folhas, protegido de todos está o Bosque de Lyanór.",
                "",
                "No coração deste bosque vibra com vida e magia das folhas a árvore Éleanór — uma entidade mística,",
                "fonte de toda luz e guardiã dos habitantes e da vida no bosque.",
                "",
                "Aqui vivem os Barbafolhas, pequenas criaturas de sabedoria ancestral, que vivem em harmonia com a terra e a magia",
                "",
                "Mas uma sombra se agita sob as raízes profundas...",
                "Os Ruklins, seres corrompidos pela ganância e pelo vazio, ressurgiram e quase drenaram a luz vital da Árvore.",
                "",
                "Você, Guardião, foi convocado para ajudar os Barbafolhas!",
                "Cuide do jardim mágico e cozinhe muitas vezes, forje novas armas, proteja a vida no bosque e as folhas cintilantes",
                "",
                "Que a luz de Éleanór guie seus passos...",
                "",
                "Pressione qualquer tecla para começar sua jornada..."
            };

            bool pularTexto = false;

            foreach (string str in introducao) // se o usuário apertar qualquer tecla
            {
                foreach (char letra in str)
                {
                    if (Console.KeyAvailable)
                    {
                        pularTexto = true;
                        break;
                    }
                    Console.Write(letra);
                    Thread.Sleep(55);
                }

                Console.WriteLine();

                if (pularTexto)
                    break;
            }

            if (pularTexto)// completar o restante do texto se o usuário apertou alguma tecla
            {
                Console.Clear();
                foreach (string str in introducao)
                {
                    Console.WriteLine(str);
                }
            }

            Musica.Parar();
            Console.ReadKey(true); // Espera o jogador confirmar que leu
        }
    }
}
