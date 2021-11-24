using System;

namespace Exercicio04
{
    public class Program
{
    public static void Main(string[] args)
    {
            Console.WriteLine("digite seu salario: ");
            double salario = Convert.ToDouble(Console.ReadLine());
double percentualReajuste;
double valorReajuste;
double novoSalario;


if (salario < 2800)
{
    percentualReajuste = 0.2;
}
else if (salario >= 2800 && salario < 7000)
{
    percentualReajuste = 0.15;
}
else if (salario >= 7000 && salario < 15000)
{
    percentualReajuste = 0.1;
}
else
{
    percentualReajuste = 0.05;
}
valorReajuste = percentualReajuste * salario;
novoSalario = valorReajuste + salario;
//Console.WriteLine("o seu salario atual é: " +novoSalario);
Console.WriteLine($"o salario original {salario}. o persentoal de ajuste foi {percentualReajuste * 100}. o valor real de almento foi {valorReajuste}.. o novo salario é {novoSalario}");
    }
}
}