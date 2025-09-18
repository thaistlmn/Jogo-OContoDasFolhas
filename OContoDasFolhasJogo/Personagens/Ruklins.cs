using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OContoDasFolhasJogo.Personagens
{
    public class Ruklins : Personagem
    {
        public override void Atacar(Personagem personagens)
        {
            int dano = Math.Max(1, Forca - personagens.Defesa / 4);
            personagens.PontoVida -= dano;
            Console.WriteLine($"{Nome} atacou {personagens.Nome} causando {dano} de dano! (PV restante: {personagens.PontoVida})");
        }

        public override void UsarMagia(Personagem personagens)
        {
            int danoMagico = Math.Max(5, Inteligencia - personagens.Defesa / 3);
            personagens.PontoVida -= danoMagico;
            Console.WriteLine($"{Nome} lançou uma magia em {personagens.Nome}, causando {danoMagico} de dano mágico! (PV restante: {personagens.PontoVida})");
        }

        public override void UsarPocao(Personagem personagens)
        {
            int danoPocao = Math.Max(7, Forca - personagens.Defesa / 4);
            personagens.PontoVida -= danoPocao;
            Console.WriteLine($"{Nome} lançou uma poção em {personagens.Nome}! (PV restante: {personagens.PontoVida})");
        }

        public override void Defender(int danoRecebido)
        {
            int danoReduzido = danoRecebido - Defesa;
            if (danoReduzido < 0) danoReduzido = 0;
            PontoVida -= danoReduzido;
            Console.WriteLine($"{Nome} se defendeu e recebeu apenas {danoReduzido} de dano!");
        }
        public override void ReceberPontos(Personagem personagens, int defesa, int forca, int pontovida)
        {
            personagens.Defesa = defesa;
            personagens.Defesa += 10;
            personagens.Forca = forca;
            personagens.Forca += 13;
            personagens.PontoVida = pontovida;
            personagens.PontoVida += 35;

            Console.WriteLine($"\n{personagens.Nome} recebeu bônus:");
            Console.WriteLine("+10 Defesa | +13 Força | +35 Ponto de Vida");
            Console.WriteLine($"Novo status - PV: {personagens.PontoVida}, Força: {personagens.Forca}, Defesa: {personagens.Defesa}");
            Console.Clear();
        }
    }
}
