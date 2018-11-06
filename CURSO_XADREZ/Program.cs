using System;
using tabuleiro; //para ter acesso a classe

namespace CURSO_XADREZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tab);



            Console.ReadLine();




        }
    }
}
