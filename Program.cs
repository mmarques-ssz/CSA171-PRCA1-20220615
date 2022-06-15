using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projJAP
{
    class Program
    {
        static void Main(string[] args)
        {
            int oculto;
            int palpite;
            int li;
            int ls;
            int vez;
            int qtde;
            string[] nomes;
            nomes = new string[5];

            li = 1;
            ls = 100;

            do
            {
                Console.Write("Quantos jogadores (2..5): ");
                qtde = int.Parse(Console.ReadLine());
            }
            while (qtde < 2 || qtde > 5);

            for (vez = 0; vez < qtde; vez++)
            {
                Console.Write("Informe o nome do {0}º jogador: ", vez+1);
                nomes[vez] = Console.ReadLine();
            }
            vez = 0;

            /* estou desabilitando essa parte do programa
            do
            {
               Console.Write("Jogador neutro, informe nº entre 1 e 100: ");
               oculto = int.Parse(Console.ReadLine());
            }
            while (oculto <= li || oculto >= ls);
            */

            Random rnd;
            rnd = new Random();

            oculto = rnd.Next(98)+2;
            //Console.WriteLine(oculto);

            do
            {
                // Aqui vem o palpite do jogador da vez
                do
                {
                    Console.Write("Jogador {0}, informe nº entre {1} e {2}: ", nomes[vez], li, ls);
                    palpite = int.Parse(Console.ReadLine());
                }
                while (palpite <= li || palpite >= ls); // garante valor válido para o palpite

                if (palpite < oculto)
                {
                    li = palpite;
                }
                else
                    if (palpite > oculto)
                    {
                        ls = palpite;
                    }
                    else
                    {
                        Console.WriteLine("Parabéns jogador {0}, voce perdeu!!!", nomes[vez]);
                    }

                if (++vez > qtde-1)
                {
                    vez = 0;
                }
            }
            while (palpite != oculto);

            Console.ReadKey();
        }
    }
}
