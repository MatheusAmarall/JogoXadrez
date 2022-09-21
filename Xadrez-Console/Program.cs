using System;
using TabuleiroEntities;

namespace Xadrez_Console { 
    class Program
    {
        public static void Main(string[] args)
        {
            Posicao p = new Posicao(3, 4);

            Console.WriteLine("Posição: " + p);

            Tabuleiro tab = new Tabuleiro(8, 8);
        }
    }
}

