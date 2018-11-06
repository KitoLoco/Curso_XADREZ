using tabuleiro;

namespace xadrez
{
    class Torre : Peca // classe Rei.cs é uma SubClasse da classe Peca (Herança)
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor) // : base repassa para construtor da classe PAI (Peca)
        {
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
