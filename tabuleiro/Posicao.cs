namespace tabuleiro
{
    class Posicao
    {
        #region Propriedades

        public int Linha { get; set; }
        public int Coluna { get; set; }

        #endregion

        public Posicao(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }

        #region Métodos

        public override string ToString()
        {
            return $"{Linha}, {Coluna}";
        }

        #endregion
    }
}
