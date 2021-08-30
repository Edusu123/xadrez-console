namespace tabuleiro
{
    class Peca
    {
        #region Propriedades

        public Posicao Posicao { get; set; }
        public Cor Cor { get; set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro Tab { get; set; }

        #endregion

        public Peca(Posicao posicao, Tabuleiro tab, Cor cor)
        {
            Posicao = posicao;
            Tab = tab;
            Cor = cor;
            QtdMovimentos = 0;
        }
    }
}
