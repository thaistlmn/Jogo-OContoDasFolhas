using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OContoDasFolhasJogo.Sistema
{
    public static class ArvoreEleanor
    {
        public static int VidaMaxima { get; set; } = 100;
        public static int VidaAtual { get; set; } = 20;

        
        public static void Curar(int quantidade)
        {
            
            if (Inventario.TemGema()) // Verifica se a gema está no inventário
            {
                VidaAtual += quantidade;
                if (VidaAtual > VidaMaxima) VidaAtual = VidaMaxima;
                // Remove a gema do inventário após o uso
                Inventario.RemoverGema();
                Console.WriteLine($"\nA árvore Éleanór foi curada em {quantidade} pontos usando a Gema. Vida atual: {VidaAtual}/{VidaMaxima}");
                Desenhos.DesenharEstrelas();
            }
            else
            {
                // Caso a gema não esteja no inventário
                Console.WriteLine("\nA cura com a Gema não está disponível! Você não possui uma Gema no inventário.");
                // Aguarda o usuário e retorna para o menu anterior
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey(true);
                return; // Retorna ao menu
            }

        }

        public static void SofrerDano(int quantidade)
        {
            VidaAtual -= quantidade;
            if (VidaAtual < 0) VidaAtual = 0;
            Console.WriteLine($"\nA árvore Éleanór sofreu {quantidade} de dano! Vida atual: {VidaAtual}/{VidaMaxima}");
            VerificarSeMorreu(); 
        }

        public static void RestaurarTotalmente()
        {
            VidaAtual = VidaMaxima;
            Console.WriteLine("\nA árvore Éleanór foi restaurada por completo após a vitória contra o Lorde Ulze!");
        }

        public static void VerificarSeMorreu()
        {
            if (VidaAtual <= 0)
            {
                Console.WriteLine("\nA árvore Éleanór perdeu toda sua energia...");
                Console.WriteLine("A escuridão tomou conta do bosque. O jogo chegou ao fim.");
                Console.WriteLine("\nObrigado por jogar!");
                Environment.Exit(0); // Fecha o programa
            }
        }
        public static void MostrarEstado()
        {
            Console.Clear();
            Musica.Tocar(Musica.TemaArvoreEleanor);
            Desenhos.DesenharArvore();
            Console.WriteLine($"Vida Atual: {VidaAtual}/{VidaMaxima}");

            /* 
             * Menu de barra ao invés de numérico
             */
            
            double percentualVida = (double)VidaAtual / VidaMaxima; // Calculo da proporção

            // Gerar a barra de vida com base no percentual
            int larguraBarra = 40; // Tamanho 
            int quantidadePreenchida = (int)(percentualVida * larguraBarra); // Quantidade preenchida 

            // Construção visual
            string barra = new string('#', quantidadePreenchida) + new string('-', larguraBarra - quantidadePreenchida);

            // Exibir a barra
            Console.WriteLine($"[{barra}] {percentualVida * 100:0}%");


            if (VidaAtual == VidaMaxima)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nA árvore está em perfeita saúde!");
            }
            else if (VidaAtual >= VidaMaxima * 0.6)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nA árvore está saudável, mas pode melhorar.");
            }
            else if (VidaAtual >= VidaMaxima * 0.3)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nA árvore está enfraquecida... cuidado! ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nA árvore está em estado crítico!");
            }
            Console.ResetColor();
            Musica.Parar();
        }
    }
}
