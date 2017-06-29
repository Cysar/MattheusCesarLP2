using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Questao
    {
        public int tomA, tomB, tomC, tomD, tomE, respn, respinv;
        public string resp;
        public void Resposta()
        {
            respn = 0;
            respinv = 0;

            if (tomA <= 100)
            {
                resp = "A";
                respn++;
            }
            else if (tomA <= 155)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Questao
    {
        public int tomA, tomB, tomC, tomD, tomE, respn, respinv;
        public string resp;
        public void Resposta()
        {
            respn = 0;
            respinv = 0;

                if (tomA <= 100)
                {
                    resp = "A";
                    respn++;
                }
                else if (tomA <= 155)
                    respinv++;

                if (tomB <= 100)
                {
                    resp = "B";
                    respn++;
                }
                else if (tomB <= 155)
                    respinv++;
                if (tomC <= 100)
                {
                    resp = "C";
                    respn++;
                }
                else if (tomC <= 155)
                    respinv++;
                if (tomD <= 100)
                {
                    resp = "D";
                    respn++;
                }
                else if (tomD <= 155)
                    respinv++; 
                if (tomE <= 100)
                {
                    resp = "E";
                    respn++;
                }
                else if (tomE <= 155)
                    respinv++;
            
            if (respn != 1 || respinv != 0)
                Console.WriteLine("*");
            else
                Console.WriteLine(resp);

    }
    }
}



