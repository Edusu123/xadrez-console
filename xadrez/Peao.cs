using tabuleiro;

namespace xadrez
{
    class Peao : Peca
    {
        #region Variáveis

        private PartidaXadrez _partida;

        #endregion

        public Peao(Tabuleiro tab, Cor cor, PartidaXadrez partida) : base(tab, cor)
        {
            _partida = partida;
        }

        #region Métodos

        public override string ToString()
        {
            return "P";
        }

        public override bool[,] MovimentosPossiveis()
        {
            var mat = new bool[Tab.Linhas, Tab.Colunas];

            var pos = new Posicao(0, 0);

            if(Cor == Cor.Branca)
            {
                pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
                if (Tab.PosicaoValida(pos) && Livre(pos))
                    mat[pos.Linha, pos.Coluna] = true;

                pos.DefinirValores(Posicao.Linha - 2, Posicao.Coluna);
                var p2 = new Posicao(Posicao.Linha - 1, Posicao.Coluna);
                if (Tab.PosicaoValida(p2) && Livre(p2) && Tab.PosicaoValida(pos) && Livre(pos))
                    mat[pos.Linha, pos.Coluna] = true;

                pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
                if (Tab.PosicaoValida(pos) && ExisteInimigo(pos))
                    mat[pos.Linha, pos.Coluna] = true;

                pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
                if (Tab.PosicaoValida(pos) && ExisteInimigo(pos))
                    mat[pos.Linha, pos.Coluna] = true;
            }
            else
            {
                pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
                if (Tab.PosicaoValida(pos) && Livre(pos))
                    mat[pos.Linha, pos.Coluna] = true;

                pos.DefinirValores(Posicao.Linha + 2, Posicao.Coluna);
                var p2 = new Posicao(Posicao.Linha + 1, Posicao.Coluna);
                if (Tab.PosicaoValida(p2) && Livre(p2) && Tab.PosicaoValida(pos) && Livre(pos))
                    mat[pos.Linha, pos.Coluna] = true;

                pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
                if (Tab.PosicaoValida(pos) && ExisteInimigo(pos))
                    mat[pos.Linha, pos.Coluna] = true;

                pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
                if (Tab.PosicaoValida(pos) && ExisteInimigo(pos))
                    mat[pos.Linha, pos.Coluna] = true;
            }

            return mat;
        }

        #endregion

        #region Funções

        private bool ExisteInimigo(Posicao pos)
        {
            Peca p = Tab.Peca(pos);
            return p != null && p.Cor != Cor;
        }

        private bool Livre(Posicao pos)
        {
            return Tab.Peca(pos) == null;
        }

        #endregion
    }
}
