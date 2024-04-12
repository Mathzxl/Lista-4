using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double vl, vt, total, mq;
            for (int i = 0; i <= 25; i++)
            {
                Console.WriteLine($"Dê o valor do vale alimentação do {i+1} pedreiro");
                vl = double.Parse(Console.ReadLine());
                Console.WriteLine($"Dê o valor do vale transporte do {i+1} pedreiro");
                vt = double.Parse(Console.ReadLine());
                Console.WriteLine($"Dê quantos metros quadrados o {i+1} pedreiro fez no dia");
                mq = double.Parse(Console.ReadLine());
                if(mq < 10)
                {
                    total = vl + (vt * 2) + 10;
                    Console.WriteLine($"O valor que o {i} pedreiro recebera será de: R$" + total);
                }
                else if(mq >= 10 && mq <= 20)
                {
                    total = vl + (vt * 2) + 11.50;
                    Console.WriteLine($"O valor que o {i} pedreiro recebera será de: R$" + total);
                }
                else
                {
                    total = vl + (vt * 2) + 13;
                    Console.WriteLine($"O valor que o {i} pedreiro recebera será de: R$" + total);
                }
            }
            Console.ReadLine();
        }
    }
}
