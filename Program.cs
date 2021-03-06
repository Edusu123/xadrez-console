using System;

using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.White;

                var partidaXadrez = new PartidaXadrez();

                while (!partidaXadrez.Terminada)
                {
                    try
                    {
                        Console.Clear();
                        Tela.ImprimirPartida(partidaXadrez);


                        Console.Write("\nOrigem: ");
                        Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                        partidaXadrez.ValidarPosicaoOrigem(origem);

                        bool[,] posicoesPossiveis = partidaXadrez.Tabuleiro.Peca(origem).MovimentosPossiveis();

                        Console.Clear();
                        Tela.ImprimirTabuleiro(partidaXadrez.Tabuleiro, posicoesPossiveis);

                        Console.Write("\nDestino: ");
                        Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
                        partidaXadrez.ValidarPosicaoDestino(origem, destino);

                        partidaXadrez.RealizaJogada(origem, destino);
                    }
                    catch(TabuleiroException ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.ReadLine();
                    }

                }

                Console.Clear();
                Tela.ImprimirPartida(partidaXadrez);
            }
            catch(TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
