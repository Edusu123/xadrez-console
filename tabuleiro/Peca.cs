namespace tabuleiro
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

        public void DecrementarQtdeMovimentos() => QtdMovimentos--;

        public void IncrementarQtdeMovimentos() => QtdMovimentos++;

        public bool ExisteMovimentosPossiveis()
        {
            bool[,] mat = MovimentosPossiveis();
            for(int i = 0; i < Tab.Colunas; i++)
            {
                for(int j = 0; j < Tab.Linhas; j++)
                {
                    if (mat[i, j])
                        return true;
                }
            }

            return false;
        }

        public bool PodeMoverPara(Posicao pos)
        {
            return MovimentosPossiveis()[pos.Linha, pos.Coluna];
        }

        #endregion

        #region Métodos Abstratos

        public abstract bool[,] MovimentosPossiveis();

        #endregion
    }
}
