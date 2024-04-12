using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double pkwh, qkwh, tp, mc = double.MinValue, mn = double.MaxValue, cm;
            Console.WriteLine("Digite o preço do kWh");
            pkwh = double.Parse(Console.ReadLine());
            for(int i = 0; i <= 50; i++)
            {
                Console.WriteLine($"Digite a quantidade de kWh consumidos durante o mês do {i + 1} morador");
                qkwh = double.Parse(Console.ReadLine());
                tp = pkwh * qkwh;
                Console.WriteLine($"O valor total a ser pago pelo {1} morador é de: R$" + tp);
                if (qkwh > mc)
                {
                    Console.WriteLine("O maior consumo foi de: " + qkwh);
                }
                if (qkwh < mn)
                {
                    Console.WriteLine("O menor consumo foi de: " + qkwh);
                }

            }
            Console.ReadLine();
        }
    }
}
