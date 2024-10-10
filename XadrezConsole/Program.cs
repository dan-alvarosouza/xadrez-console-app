using tabuleiro;

namespace XadrezConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(20, 20);
            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
        }

    }
}
