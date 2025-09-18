using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OContoDasFolhasJogo.Sistema
{
    public class Ingredientes
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Efeitos { get; set; }
        public int Quantidade { get; set; }

        public Ingredientes() { }

        public Ingredientes(string nome, string tipo, string efeitos, int quantidade)
        {
            Nome = nome;
            Tipo = tipo;
            Efeitos = efeitos;
            Quantidade = quantidade;
        }

        public override string ToString()
        {
            return $"Nome: {Nome} - Tipo: {Tipo} - Efeito: {Efeitos} - Quantidade: {Quantidade}";
        }

        public static Ingredientes CriarPorNome(string nome)
        {
            switch (nome)
            {
                case "Raiz Flamejante":
                    return new Ingredientes(nome, "Raiz", "Aumenta ataque", 1);
                case "Néctar Dourado":
                    return new Ingredientes(nome, "Líquido", "Recupera energia", 1);
                case "Cogumelo Sombrio":
                    return new Ingredientes(nome, "Fungo", "Cura veneno", 1);
                case "Pólen Luminoso":
                    return new Ingredientes(nome, "Pólen", "Aumenta defesa", 1);
                case "Fruto da Aurora":
                    return new Ingredientes(nome, "Fruto", "Cura completa", 1);
                default:
                    return new Ingredientes(nome, "Desconhecido", "Efeito desconhecido", 1);
            }
        }

    }
}
