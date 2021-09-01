﻿namespace tabuleiro
{
    abstract class Peca
    {
        #region Propriedades

        public Posicao Posicao { get; set; }
        public Cor Cor { get; set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro Tab { get; set; }

        #endregion

        public Peca(Tabuleiro tab, Cor cor)
        {
            Posicao = null;
            Tab = tab;
            Cor = cor;
            QtdMovimentos = 0;
        }

        #region Métodos

        public void IncrementarQtdeMovimentos()
        {
            QtdMovimentos++;
        }

        #endregion

        #region Métodos Abstratos

        public abstract bool[,] MovimentosPossiveis();

        #endregion
    }
}
