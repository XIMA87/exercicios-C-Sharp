// See https://aka.ms/new-console-template for more information

/*
O programa deve ler os dados de N funcionários (nome, horas trabalhadas e valor por hora) e armazena-los em uma lista.
Em seguida deve mostrar nome e pagamento de cada funcionário.
OBS: funcionários terceirizados recebem um bônus correspondente a 110% de sua despesa adicional.
*/

using System;
using System.Collections.Generic;
using ExercicioHeranca.Entidades;
using System.Globalization;


List<Empregados> lista = new List<Empregados>();

Console.Write("Digite o número de Funcionários: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <=n; i++)
{
    Console.WriteLine($"Dados do empregado #{i}");
    Console.Write("Terceirizado (S/N)? ");
    char simNao = char.Parse(Console.ReadLine());
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Horas: ");
    int horas = int.Parse(Console.ReadLine());
    Console.Write("Valor por hora: ");
    double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (simNao =='S')
    {
        Console.Write("Despesa adicional: ");
        double despesaAdicional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        lista.Add(new Terceirizados(nome, horas, valorPorHora, despesaAdicional));

    }
    else
    {
        lista.Add(new Empregados(nome, horas, valorPorHora));
    }
}

    Console.WriteLine();
    Console.WriteLine("PAGAMENTOS");
    foreach (Empregados emp in lista) //percorre a lista
    {
        Console.WriteLine(emp.Nome + " - $ " + emp.Pagamento().ToString("F2", CultureInfo.InvariantCulture));
    }