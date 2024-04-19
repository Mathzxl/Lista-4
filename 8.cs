using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, rq=0, sub, imp=1;
            Console.WriteLine("Digite um número inteiro");
            n = int.Parse(Console.ReadLine());
            sub = n;
            do
            {
                sub = sub - imp;
                imp += 2;
                rq++;
            } while (sub > 0);
            Console.WriteLine($"A raiz quadrada de {n} é aproximadamente: " + rq);
            Console.ReadLine();
        }
    }
}
