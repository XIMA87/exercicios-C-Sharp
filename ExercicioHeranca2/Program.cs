// See https://aka.ms/new-console-template for more information

/*
O programa deve ler dados de N figuras (retangulo ou circulo, largura e altura, raio).
Posteriormente deve mostrar a área destas figuras.
*/

using System.Globalization;
using ExercicioHeranca2.Entidades;
using ExercicioHeranca2.Entidades.Enums;

List<Figura> lista = new List<Figura>();

Console.Write("Entre com a quantidade de figuras: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Dados da figura #{i}:");
    Console.Write("Retangulo ou Círculo (R/C)?");
    char rc = char.Parse(Console.ReadLine());
    Console.Write("Qual a cor (Preto/Azul/Vermelho): ");
    Cores cores = Enum.Parse<Cores>(Console.ReadLine()); //conversão da string em item de Enum

    if (rc == 'R')
    {
        Console.Write("Digite a Largura: ");
        double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Digite a Altura: ");
        double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        lista.Add(new Retangulo(largura, altura, cores));
    }
    else
    {
        Console.Write("Digite o Raio: ");
        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        lista.Add(new Circulo(raio, cores));
    }
}

Console.WriteLine();
Console.WriteLine("ÁREAS DAS FIGURAS");
Console.WriteLine();
foreach (Figura fig in lista)
{
    Console.WriteLine(fig.Area().ToString("F2", CultureInfo.InvariantCulture));
}