// See https://aka.ms/new-console-template for more information

/*
O programa deve ler 2 valores e retornar a soma deles.
Utilize o modificador de parametro params em uma classe.
*/
using CalculaSimples;

Console.Write("Insira o 1° número a ser somado: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Insira o 2° número a ser somado: ");
int y = int.Parse(Console.ReadLine());


int soma = Calcula.Sum(x, y);


Console.Write("O resultado da soma é: " + soma);