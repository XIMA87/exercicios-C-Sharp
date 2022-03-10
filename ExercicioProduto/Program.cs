// See https://aka.ms/new-console-template for more information

/*
- O programa deve ler os dados (nome, preço e quantidade) de um produto em estoque e em seguida:
    -Mostrar os dados nome, preço, quantidade no estoque e valor total no estoque
    -Realizar uma entrada no estoque e mostrar os dados atualizados
    -Realizar uma saída no estoque e mostrar os dados atualizados
*/

using System;
using System.Globalization;
using Exercicio_Produto;


Produto p = new Produto(); //criação do objeto p e instanciação

Console.WriteLine("Entre os dados do Produto:");
Console.Write("Nome: ");
p.Nome = Console.ReadLine();
Console.Write("Preço: ");
p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantidade: ");
p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine();
Console.WriteLine("Dados do Produto: " + p); //objeto dentro de writeline o C# implicitamente chama o método ToString

Console.WriteLine();
Console.Write("Digite o numero de Produtos a ser adiconado ao estoque: ");
int qte = int.Parse(Console.ReadLine());
p.AdicionarProdutos(qte);

Console.WriteLine();
Console.WriteLine("Dados atualizados: " + p);

Console.WriteLine();
Console.Write("Digite o numero de Produtos a ser removide do estoque: ");
qte = int.Parse(Console.ReadLine());
p.RemoverProdutos(qte);

Console.WriteLine();
Console.WriteLine("Dados atualizados: " + p);
