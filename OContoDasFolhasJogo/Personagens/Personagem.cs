using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OContoDasFolhasJogo.Personagens
{
        public abstract class Personagem
        {
            public string Nome { get; set; }
            public int PontoVida { get; set; }
            public int Inteligencia { get; set; }
            public int Destreza { get; set; }
            public int Forca { get; set; }
            public int Defesa { get; set; }

            public abstract void Atacar(Personagem personagens);
            public abstract void UsarMagia(Personagem personagens);
            public abstract void UsarPocao(Personagem personagens);
            public abstract void Defender(int danoRecebido);
            public abstract void ReceberPontos(Personagem personagens, int defesa, int forca, int pontovida);

        }
    
}
