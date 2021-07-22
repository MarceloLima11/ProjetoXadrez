﻿using System;
using xadrez;
using tabuleiro;

namespace ex_088
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 10));

                Tela.ImprimirTabuleiro(tab);
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
