using tabuleiro;
using xadrez;

namespace XadrezConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            
            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();

            /*try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 9));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

                Tela.imprimirTabuleiro(tab);

                Console.ReadLine();
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }*/
        }

    }
}
