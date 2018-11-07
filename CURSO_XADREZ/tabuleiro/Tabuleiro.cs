namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas; // matriz de pecas. Privado para q somente o tabuleiro possa alterar

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linha, int coluna) // método para Tela.cs poder acessar Peca
        {
            return pecas[linha, coluna];
        }

        public Peca peca(Posicao pos) // sobrecarga
        {
            return pecas[pos.linha, pos.coluna];
        }

        public bool existePeca(Posicao pos) // metodo para verificar se existe Peca na posicao
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }

        public void colocarPeca(Peca p, Posicao pos)
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }
            pecas[pos.linha, pos.coluna] = p; // colocando peca p na posicao
            p.posicao = pos; // informar a posicao da peca p
        }

        public Peca retirarPeca(Posicao pos)
        {
            if (peca(pos) == null)
            {
                return null;
            }
            Peca aux = peca(pos);
            aux.posicao = null;
            pecas[pos.linha, pos.coluna] = null;
            return aux;
        }

        public bool posicaoValida(Posicao pos) // método para verificar se é uma posicao válida
        {
            if (pos.linha < 0 || pos.linha >= linhas || pos.coluna<0 || pos.coluna >= colunas)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void validarPosicao(Posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição Inválida!");
            }

        }



    }
}
