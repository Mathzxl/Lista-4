using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            double temp, res;

            do
            {
                Console.WriteLine("Menu de Conversão de Temperatura:\n");
                Console.WriteLine("1. Converter de Celsius para Fahrenheit\n");
                Console.WriteLine("2. Converter de Celsius para Kelvin\n");
                Console.WriteLine("3. Converter de Fahrenheit para Celsius\n");
                Console.WriteLine("4. Converter de Fahrenheit para Kelvin\n");
                Console.WriteLine("5. Converter de Kelvin para Celsius\n");
                Console.WriteLine("6. Converter de Kelvin para Fahrenheit\n");
                Console.WriteLine("7. Sair\n");
                Console.WriteLine("Escolha uma opção uma das opções");
                op = int.Parse(Console.ReadLine());
                
                switch (op)
                {
                    case 1:
                        Console.Write("Digite a temperatura em Celsius: ");
                        temp = double.Parse(Console.ReadLine());
                        res = temp * 9 / 5 + 32;
                        Console.WriteLine("Temperatura em Fahrenheit: " + res);
                        break;
                    case 2:
                        Console.Write("Digite a temperatura em Celsius: ");
                        temp = double.Parse(Console.ReadLine());
                        res = temp + 273.15;
                        Console.WriteLine("Temperatura em Kelvin: " + res);
                        break;
                    case 3:
                        Console.Write("Digite a temperatura em Fahrenheit: ");
                        temp = double.Parse(Console.ReadLine());
                        res = (temp - 32) * 5 / 9;
                        Console.WriteLine("Temperatura em Celsius: " + res);
                        break;
                    case 4:
                        Console.Write("Digite a temperatura em Fahrenheit: ");
                        temp = double.Parse(Console.ReadLine());
                        res = (temp - 32) * 5 / 9 + 273.15;
                        Console.WriteLine("Temperatura em Kelvin: " + res);
                        break;
                    case 5:
                        Console.Write("Digite a temperatura em Kelvin: ");
                        temp = double.Parse(Console.ReadLine());
                        res = temp - 273.15;
                        Console.WriteLine("Temperatura em Celsius: " + res);
                        break;
                    case 6:
                        Console.Write("Digite a temperatura em Kelvin: ");
                        temp = double.Parse(Console.ReadLine());
                        res = (temp - 273.15) * 9 / 5 + 32;
                        Console.WriteLine("Temperatura em Fahrenheit: " + res);
                        break;
                    case 7:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Número Inválido digite novamente");
                        break ;
                }
            } while (op != 7);
            Console.ReadLine(); 
        }
    }
}
