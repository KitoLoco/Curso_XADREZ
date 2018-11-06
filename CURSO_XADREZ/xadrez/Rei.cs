using tabuleiro;

namespace xadrez
{
    class Rei : Peca // classe Rei.cs é uma SubClasse da classe Peca (Herança)
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor) // : base repassa para construtor da classe PAI (Peca)
        {
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
