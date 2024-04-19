using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int votos, c1=0, c2=0, c3=0, vb=0, vn=0;
            char resp;
            do
            {
                Console.WriteLine("1- Candidato 1\n");
                Console.WriteLine("2- Candidato 2\n");
                Console.WriteLine("3- Candidato 3\n");
                Console.WriteLine("4- Voto em Branco\n");
                Console.WriteLine("5- Voto Nulo\n");
                Console.WriteLine("Digite o seu voto");
                votos = int.Parse(Console.ReadLine());
                if (votos == 1)
                {
                    c1++;
                }
                if (votos == 2)
                {
                    c2++;
                }
                if(votos == 3)
                {
                    c3++;
                }
                if(votos == 4)
                {
                    vb++;
                }
                if (votos !=5)
                {
                    vn++;
                }
                Console.WriteLine("Deseja informar mais um voto \n\nS \nN");
                resp = char.Parse(Console.ReadLine());
            } while(resp == 'S');
            Console.WriteLine("\n Resultados Eleição");
            Console.WriteLine($"\nO candidato 1 teve {c1} votos");
            Console.WriteLine($"\nO candidato 1 teve {c2} votos");
            Console.WriteLine($"\nO candidato 1 teve {c3} votos");
            Console.WriteLine($"\nTiveram {vb} votos em branco");
            Console.WriteLine($"\nTiveram {vn} votos nulos");
            Console.ReadLine();
        }
    }
}
