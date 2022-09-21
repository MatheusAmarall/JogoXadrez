using System;
using TabuleiroEntities;

namespace Xadrez_Console { 
    class Program
    {
        public static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.ImprimirTabuleiro(tab);
        }
    }
}

