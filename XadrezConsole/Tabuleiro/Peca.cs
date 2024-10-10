namespace tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int qteMovimento { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor )
        {
            Posicao = null;
            Cor = cor;
            this.qteMovimento = 0;
            this.tab = tab;
        }

        public void incrementarQteMovimentos()
        {
            qteMovimento++;
        }
    }
}
