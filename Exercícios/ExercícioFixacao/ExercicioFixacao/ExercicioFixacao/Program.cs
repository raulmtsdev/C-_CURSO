using System;
using System.Globalization;

namespace ExercicioFixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem em sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de um produto?");
            double produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite seu segundo nome, sua idade e sua altura na mesma linda dando espaço entre cada dado digitado");

            String[] vet = Console.ReadLine().Split(' ');
            string nome2 = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2],CultureInfo.InvariantCulture);

            Console.WriteLine(" ");
            Console.WriteLine("DADOS DIGITADOS:");
            Console.WriteLine(" ");
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(produto.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(nome2);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString( "F2", CultureInfo.InvariantCulture));
        }
    }
}
