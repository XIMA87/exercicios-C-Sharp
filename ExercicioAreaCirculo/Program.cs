// See https://aka.ms/new-console-template for more information

/*
O programa deve ler o valor do raio de um círculo e mostrar 
na tela a área deste circulo com 4 casas decimais.
*/

using System;
using System.Globalization;

            double R, A, pi = 3.14159;

            Console.Write("Digite o valor do raio: ");
            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            A = pi * R * R;

            Console.WriteLine("Área= " + A.ToString("F4", CultureInfo.InvariantCulture));