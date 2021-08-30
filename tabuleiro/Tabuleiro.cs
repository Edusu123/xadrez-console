namespace tabuleiro
{
    class Tabuleiro
    {
        #region Propriedades

        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas { get; set; }

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[linhas, colunas];
        }

        #endregion

        #region Métodos

        public Peca Peca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }

        #endregion
    }
}
