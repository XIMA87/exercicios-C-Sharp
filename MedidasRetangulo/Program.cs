// See https://aka.ms/new-console-template for more information

/*
O programa deve ler os valores de largura e altura de um retângulo.
Em seguida deve mostrar na tela o valor de sua área, perímetro e diagonal.
*/

using System;
using System.Globalization;
using MedidasRetangulo;

Retangulo ret = new Retangulo();

Console.Write("Digite a largura do retângulo: ");
ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Digite a altura do retângulo: ");
ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("ÁREA = " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("PERÍMETRO = " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("DIAGONAL = " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
