// See https://aka.ms/new-console-template for more information

// O programa deve ler os dados de duas pessoas e mostrar quem é mais velho

using System;
using IdadePessoa;

Pessoa p1 = new Pessoa();
Pessoa p2 = new Pessoa();

Console.WriteLine("*** Dados da primeira pessoa ***");
Console.Write("Nome: ");
p1.Nome = Console.ReadLine();
Console.Write("Idade: ");
p1.Idade = int.Parse(Console.ReadLine());

Console.WriteLine("*** Dados da segunda pessoa ***");
Console.Write("Nome: ");
p2.Nome = Console.ReadLine();
Console.Write("Idade: ");
p2.Idade = int.Parse(Console.ReadLine());

if (p1.Idade > p2.Idade) {
Console.WriteLine("Pessoa mais velha: " + p1.Nome);
}
else {
Console.WriteLine("Pessoa mais velha: " + p2.Nome);
}