using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros_Hermione
{
    class Program
    {
        static void Main(string[] args)
        {
            int pph, hpd, N, totalhr = 0,Dias,imp;

            Console.WriteLine("Quantos livros?");
            N = int.Parse(Console.ReadLine());

            Livro[] livro = new Livro[N];

            Console.WriteLine("Quantas paginas por hora?");
            pph = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantas horas por dia?");
            hpd = int.Parse(Console.ReadLine());


            int i = 0;
            while (i < N)
            {
                livro[i] = new Livro();

                Console.WriteLine("Titulo do Livro:");
                livro[i].titulo = Console.ReadLine();

                Console.WriteLine("Quantidade de paginas do livro: ");
                livro[i].qtdpag = int.Parse(Console.ReadLine());

                Console.WriteLine("Quantos dias até a devolução? ");
                livro[i].DiasAteDev = int.Parse(Console.ReadLine());

                Ttotalhr = totalhr + livro[i].TempoDeLeitura(paghr);

                i++;
            }

            i = 0;
            imp = 0;
            while (i < N)
            {
                if (livro[i].TempoDeLeitura(paghr) < N * hrsdia)
                {
                    Console.WriteLine("O livro '{0}' é impossivel de ser lido", livro[i].titulo);
                    imp++;
                }
                i++;
            }

            if (imp == 0)
                Console.WriteLine("Nenhum livro pode ser considerado impossivel segundo os seus critérios");

            TtotalDias = totalhr / hpd;

            Console.WriteLine("levará {0} dias para ler todos os livros",Dias);

        }
    }
}
