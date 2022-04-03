// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;
using MediaAltura;

Console.Write("Entre o numero de pessoas a serem medidas: ");
int n = int.Parse(Console.ReadLine());

Altura[] vetor = new Altura[n];

for (int i = 0; i < n; i++)
{
    Console.Write("Digite o nome: ");
    string name = Console.ReadLine();
    Console.Write("Digite a altura: ");
    double medida = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    vetor[i] = new Altura { Nome = name, Medida = medida };
}

double soma = 0.0;

for (int i = 0; i < n; i++)
{
    soma += vetor[i].Medida;
}
double media = soma / n;
Console.WriteLine("Média das alturas = " + media.ToString("F2", CultureInfo.InvariantCulture));