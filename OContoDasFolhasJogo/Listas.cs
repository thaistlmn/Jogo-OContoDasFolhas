using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OContoDasFolhasJogo.Personagens;
using OContoDasFolhasJogo.Sistema;
using static OContoDasFolhasJogo.Sistema.Receitas;

namespace OContoDasFolhasJogo
{
    public class Listas
    {
        /*
         * Listas estaticas para conseguir usar as listas em program
         * Colocar depois em listas para ser universal = Listas.List<Batalhas>(); ~exemplo
         */

        public static List<Barbafolha> barbafolhas = new List<Barbafolha>();

        public static List<Ruklins> ruklinses = new List<Ruklins>();

        public static List<Historia> capitulos = new List<Historia>();

        public static List<Ingredientes> ingredientes = new List<Ingredientes>();

        public static List<Receita> ListaDeReceitas = new List<Receita>();

        public static List<string> gemsObtidas = new List<string>();

        public static List<string> armasForjadas = new List<string>();

    }
}
