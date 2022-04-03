// See https://aka.ms/new-console-template for more information

/*
O programa deve iniciar com 10 quartos vazios (0 a 9).
Em seguida deve registrar o aluguel de N estudantes (nome, email e quarto escolhido no registro)
Ao fim, imprimir relatório de todas as ocupações por ordem de quarto.
*/

using System;
using System.Globalization;
using AluguelQuartos;

Estudante[] vetor = new Estudante[10];

Console.Write("Quantos quartos serão alugados? ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Aluguel #{i}:");
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Email: ");
    string email = Console.ReadLine();
    Console.Write("Quarto: ");
    int quarto = int.Parse(Console.ReadLine());

    vetor[quarto] = new Estudante(nome, email);
}
Console.WriteLine();
Console.WriteLine("Quartos ocupados:");

for (int i = 0; i < 10; i++)
{
    if (vetor[i] != null)
    {
        Console.WriteLine(i + ": " + vetor[i]);
    }
}