using System;

namespace Exercicio02
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("digite um número: ");
            string? textoNumero01 = Console.ReadLine();
            Console.WriteLine("digite outro número: ");
            string? textoNumero02 = Console.ReadLine();
            Console.WriteLine("digite o ultimo número: ");
            string? textoNumero03 = Console.ReadLine();
            int numero01 = Convert.ToInt32(textoNumero01);
            int numero02 = Convert.ToInt32(textoNumero02);
            int numero03 = Convert.ToInt32(textoNumero03);
            int maior = 0;
            int menor =0;
            if (numero01 > numero02)
            {
                if (numero01 > numero03)
                {
                    maior = numero01;
                }
                else
                {
                    maior = numero03;
                }
            }
            else
            {
                if (numero02 > numero03)
                {
                    maior = numero02;
                }
                else
                {
                    maior = numero03;
                }
            }

            if (numero01 < numero02)
            {
                if (numero01 < numero03)
                {
                    menor = numero01;
                }
                else
                {
                    menor = numero03;
                }
            }
            else
            {
                if (numero02 < numero03)
                {
                    menor = numero02;
                }
                else
                {
                    menor = numero03;
                    
                }
            }
            Console.WriteLine("o maior número é: " +maior);
                    Console.WriteLine("o menor número é:" +menor);
        }
    }
}
