using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Livro
    {
        public string titulo = Console.ReadLine();
        public double qtdpg = double.Parse(Console.ReadLine()), hpd = double.Parse(Console.ReadLine()), pph=double.Parse(Console.ReadLine());

        public double TempodLeitura(int pph)
        {
            return qtdpg / pph;
        }

    }
}
