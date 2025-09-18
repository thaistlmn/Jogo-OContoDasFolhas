using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OContoDasFolhasJogo.Sistema
{
    public class Arma
    {
        public string Nome { get; set; }
        public int PoderAtaque { get; set; }
        public string Tipo { get; set; }
        public Arma() { }
        public Arma(string nome, int poderAtaque, string tipo)
        {
            this.Nome = nome;
            this.PoderAtaque = poderAtaque;
            this.Tipo = tipo;
        }
        public override string ToString()
        {
            return $"{Nome}, poder ataque: {PoderAtaque}, tipo: {Tipo}";
        }
    }
}
