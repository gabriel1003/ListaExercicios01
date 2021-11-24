using System;

namespace Exercicios03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite o preço do primeiro produto: ");
            //string? textoProduto01 = Console.ReadLine();
            double preco01 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite o valor do segundo produto: ");
            //string? textoProduto02 = Console.ReadLine();
            double preco02 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite o preço do terceiro produto: ");
            //string? textoProduto03 = Console.ReadLine();
                      double preco03 = Convert.ToDouble(Console.ReadLine());
            //double menorPreco = 0;

            if (preco01 < preco02 && preco01 < preco03)
            {
                Console.WriteLine("o produto a ser comprado é o produto 01. ");
        }
        else if (preco02 < preco03)
        {
            Console.WriteLine("o produto a ser comprado é o 02. ");
        }
        else
        {
            Console.WriteLine("o produto a ser comprado é o 03. ");
        }
                      }
    }
}