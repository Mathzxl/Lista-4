using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temp = 31,mt = double.MinValue, met = double.MaxValue;
            int dmt = 0, dmet = 0;

            Console.WriteLine("Digite as temperaturas médias registradas em Belo Horizonte em cada dia do mês de abril:");
            for (int i = 0; i < 31; i++)
            {
                Console.Write($"Dia {i + 1}: ");
                temp = double.Parse(Console.ReadLine());

                if (temp > mt)
                {
                    mt = temp;
                    dmt = i + 1;
                }
                if (temp < mt)
                {
                    met = temp;
                    dmet = i + 1;
                }
            }
            Console.WriteLine($"\nA maior temperatura foi de {mt}ºC no dia {dmt}.");
            Console.WriteLine($"A menor temperatura foi de {met}ºC no dia {dmet}.");
            Console.ReadLine();
        }
    }
}
