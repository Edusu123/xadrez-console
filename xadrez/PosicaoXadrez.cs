using tabuleiro;

namespace xadrez
{
    class PosicaoXadrez
    {
        #region Propriedades

        public char Coluna { get; set; }
        public int Linha { get; set; }

        #endregion

        public PosicaoXadrez(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }

        #region Métodos

        public Posicao ToPosicao()
        {
            return new Posicao(8 - Linha, Coluna - 'a');
        }

        public override string ToString()
        {
            return $"{Coluna}{Linha}";
        }

        #endregion
    }
}
