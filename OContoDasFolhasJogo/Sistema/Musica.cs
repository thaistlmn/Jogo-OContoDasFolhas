using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OContoDasFolhasJogo.Sistema
{
        public static class Musica
        {
            private static Thread musicaThread;
            private static bool tocando = false;

            public static void Tocar(Action musica)
            {
                Parar(); // Garante que não tenha duas músicas tocando
                tocando = true;
                musicaThread = new Thread(() =>
                {
                    while (tocando)
                    {
                        musica();
                    }
                });
                musicaThread.IsBackground = true;
                musicaThread.Start();
            }

            public static void Parar()
            {
                tocando = false;
                if (musicaThread != null && musicaThread.IsAlive)
                {
                    musicaThread.Join();
                }
            }
            public static void TemaMagico()
            {
                Console.Beep(659, 250);
                Console.Beep(784, 250);
                Console.Beep(987, 400);
                Console.Beep(880, 250);
                Console.Beep(784, 250);
                Console.Beep(659, 400);

                Thread.Sleep(300);

                Console.Beep(587, 250);
                Console.Beep(698, 250);
                Console.Beep(880, 400);
                Console.Beep(784, 250);
                Console.Beep(659, 400);

                Thread.Sleep(500);
            }

            public static void TemaBatalha()
            {
                Console.Beep(880, 150);
                Console.Beep(988, 150);
                Console.Beep(1046, 150);
                Console.Beep(988, 150);
                Console.Beep(880, 150);
                Console.Beep(784, 150);
                Console.Beep(698, 150);
                Console.Beep(784, 150);
                Thread.Sleep(300);
            }

            public static void TemaVitoria()
            {
                Console.Beep(659, 200);
                Console.Beep(784, 200);
                Console.Beep(880, 200);
                Console.Beep(987, 400);
                Thread.Sleep(200);
                Console.Beep(987, 400);
                Console.Beep(1046, 600);
                Thread.Sleep(500);
            }

            public static void TemaMineracao()
            {
                Console.Beep(440, 200); // A4
                Console.Beep(392, 200); // G4
                Thread.Sleep(100);
                Console.Beep(349, 200); // F4
                Console.Beep(392, 200); // G4
                Thread.Sleep(200);
            }

            public static void TemaComidaPronta()
            {
                Console.Beep(523, 150); // C5
                Console.Beep(659, 150); // E5
                Console.Beep(784, 300); // G5
                Thread.Sleep(100);
                Console.Beep(784, 150);
                Console.Beep(880, 300); // A5
                Thread.Sleep(300);
            }

            public static void TemaArvoreEleanor()
            {
                Console.Beep(392, 300); // G4
                Console.Beep(440, 400); // A4
                Console.Beep(494, 400); // B4
                Thread.Sleep(200);
                Console.Beep(440, 400); // A4
                Console.Beep(392, 400); // G4
                Thread.Sleep(300);
            }

            public static void TemaJardim()
            {
                Console.Beep(440, 250); // A4
                Console.Beep(494, 250); // B4
                Console.Beep(587, 300); // D5
                Console.Beep(659, 300); // E5
                Thread.Sleep(100);
                Console.Beep(587, 250); // D5
                Console.Beep(494, 250); // B4
                Console.Beep(440, 300); // A4
                Thread.Sleep(100);
                Console.Beep(587, 300); // D5
                Console.Beep(659, 300); // E5
                Console.Beep(494, 250); // B4
                Console.Beep(440, 300); // A4
            Thread.Sleep(400);
            }
        }

}
