using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vs, stv,fs1,fs2,fs3,fs4,result;
            char resp;
            do
            {
                Console.WriteLine("Digite o sálario bruto mensal de um funcionário");
                vs = double.Parse(Console.ReadLine());
                if (vs <= 1412)
                {
                    fs1 = 1412 * 0.075;
                    result = Math.Round(fs1, 2);
                    Console.WriteLine("O desconto será de: " + result);
                }
                if (vs >= 1412 && vs <= 2666.68)
                {
                    fs1 = 1412 * 0.075;
                    fs2 = (vs - 1412) * 0.09;
                    stv = fs1 + fs2;
                    result = Math.Round(stv, 2);
                    Console.WriteLine("O desconto será de: " + result);
                }
                if (vs >= 2666.69 && vs <= 4000.03)
                {
                    fs1 = 1412 * 0.075;
                    fs2 = (2666.68 - 1412) * 0.09;
                    fs3 = (vs - 2666.69) * 0.12;
                    stv = fs1 + fs2 + fs3;
                    result = Math.Round(stv, 2);
                    Console.WriteLine("O desconto será de: " + result);
                }
                if (vs >= 4000.04 && vs <= 7786.02)
                {
                    fs1 = 1412 * 0.075;
                    fs2 = (2666.68 - 1412) * 0.09;
                    fs3 = (4000.03 - 2666.69) * 0.12;
                    fs4 = (vs - 4000.04) * 0.14;
                    stv = fs1 + fs2 + fs3 + fs4;
                    result = Math.Round(stv, 2);
                    Console.WriteLine("O desconto será de: " + result);
                }
                if (vs > 7786.02)
                {
                    fs1 = 1412 * 0.075;
                    fs2 = (2666.68 - 1412) * 0.09;
                    fs3 = (4000.03 - 2666.69) * 0.12;
                    fs4 = (7786.02 - 4000.04) * 0.14;
                    stv = fs1 + fs2 + fs3 + fs4;
                    result = Math.Round(stv, 2);
                    Console.WriteLine("O desconto será de: " + result);
                }
                Console.WriteLine("Deseja informar mais um voto \n\nS \n\nN");
                resp = char.Parse(Console.ReadLine());
            } while (resp == 'S');
            Console.ReadLine();
        }
    }
}
