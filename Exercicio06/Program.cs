using System;

namespace Exercicio06
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite um número que corresponda aos dias da semana de (1 a 7)");
            int diaSemana = Convert.ToInt32(Console.ReadLine());

            switch (diaSemana)
            {
                case 1:
                    Console.WriteLine("domingo: ");
                    break;
                case 2:
                    Console.WriteLine("segunda-feira: ");
                    break;
                case 3:
                    Console.WriteLine("terça-feira: ");
                    break;
                case 4:
                    Console.WriteLine("Quarta-feira: ");
                    break;
                case 5:
                    Console.WriteLine("Quinta-feira: ");
                    break;
                case 6:
                    Console.WriteLine("Sexta-feira: ");
                    break;
                case 7:
                    Console.WriteLine("Sabado: ");
                    break;
                    default:
                    Console.WriteLine("dia da Semana inválido.");
                    break;
            }
        }
    }
}