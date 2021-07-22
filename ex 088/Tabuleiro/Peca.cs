﻿using System;

namespace tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            Posicao = null;
            QteMovimentos = 0;
            Tab = tab;
            Cor = cor;

        }

        public void IncrementarQteMovimentos()
        {
            QteMovimentos++;
        }
    }
}
