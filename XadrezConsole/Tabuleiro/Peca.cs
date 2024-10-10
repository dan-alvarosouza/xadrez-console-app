namespace tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int qteMovimento { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Posicao posicao, Tabuleiro tab, Cor cor )
        {
            Posicao = posicao;
            Cor = cor;
            this.qteMovimento = qteMovimento;
            this.tab = tab;
        }
    }
}
