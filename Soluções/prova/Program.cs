using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n = int.Parse(Console.ReadLine());
            Questao[] ex = new Questao[n];
            i = 0;
            while (i < n)
            {
                ex[i] = new Questao();

                ex[i].tomA = int.Parse(Console.ReadLine());
                ex[i].tomB = int.Parse(Console.ReadLine());
                ex[i].tomC = int.Parse(Console.ReadLine());
                ex[i].tomD = int.Parse(Console.ReadLine());
                ex[i].tomE = int.Parse(Console.ReadLine());

                i++;
            }
            i = 0;
            while (i < n)
            {
                ex[i].Resposta();
                i++;
            }
        }
    }
}
