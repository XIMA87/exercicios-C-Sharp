// See https://aka.ms/new-console-template for more information

//O programa deve ler o nome e salário de 2 funcionários e mostrar o salário médio.

using System;
using System.Globalization;
using SalarioMedio;

Funcionario f1 = new Funcionario();
Funcionario f2 = new Funcionario();

Console.WriteLine("--- Dados do primeiro funcionário ---");
Console.Write("Nome: ");
f1.Nome = Console.ReadLine();
Console.Write("Salário: ");
f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("--- Dados do segundo funcionário ---");
Console.Write("Nome: ");
f2.Nome = Console.ReadLine();
Console.Write("Salário: ");
f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double media = (f1.Salario + f2.Salario) / 2.0;
Console.WriteLine("Salário Médio = " + media.ToString("F2", CultureInfo.InvariantCulture));