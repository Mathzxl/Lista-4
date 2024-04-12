using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int dn, i, f, c;
            double s = 1;
            Console.WriteLine("Digite um valor inteiro");
            dn = int.Parse(Console.ReadLine());
            for(i = 1; i <= dn; i++)
            {
                f = 1;
                for (c = 1; c <= i; c++)
                {
                    f = f * c;
                }
                Console.WriteLine("\nO valor da fatoração foi de: " + f);
                s = s + 1 / (double)f;
                Console.WriteLine("A soma das fatoraços é igual a: " + s);
            }
            Console.ReadLine();
        }
    }
}
