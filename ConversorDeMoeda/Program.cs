// See https://aka.ms/new-console-template for more information

/*
O programa deve ler a cotação do dólar e um valor em dólares a ser comprado em reais.
Em seguida o programa deve mostrar o valor a ser pago pelos dólares considerando IOF de 6% sobre o valor em dólares.
*/

using System;
using System.Globalization;
using ConversorDeMoeda;

Console.Write("Qual é a cotação do dólar? ");
double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantos dólares você vai comprar? ");
double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double result = Conversor.DolarParaReal(quantia, cotacao);
Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));