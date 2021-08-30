using tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor) { }

        #region Métodos

        public override string ToString()
        {
            return "T";
        }

        #endregion
    }
}
