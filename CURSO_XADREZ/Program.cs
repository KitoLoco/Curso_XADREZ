using System;
using tabuleiro; //para ter acesso a classe
using xadrez;

namespace CURSO_XADREZ
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();


        }
    }
}
