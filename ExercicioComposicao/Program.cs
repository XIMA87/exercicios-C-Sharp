// See https://aka.ms/new-console-template for more information

/*
O programa deve ler os dados de um trabalhador com N contratos.
Posteriormente deve solicitar ao usuario um mes e mostrar qual foi o salário do funcionário nesse mês.
*/

using System.Globalization;
using ExercicioComposição.Entidades;
using ExercicioComposição.Entidades.Enums;


Console.Write("Digite o nome do departamento: ");
string nomeDpt = Console.ReadLine();

Console.WriteLine("Entre com os dados do trabalhador: ");
Console.Write("Nome: ");
string nome = Console.ReadLine();
Console.Write("Nível (Junior/Pleno/Senior): ");
NivelTrabalhador nivel = Enum.Parse<NivelTrabalhador>(Console.ReadLine());
Console.Write("Salário Base: ");
double salarioBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Departamento dept = new Departamento(nomeDpt);
Trabalhador trabalhador = new Trabalhador(nome, nivel, salarioBase, dept);

Console.Write("Quantos contratos para este trabalhador? :");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Entre os dados do contrato #{i}: ");

    Console.Write("Data (DD/MM/AAAA): ");
    DateTime data = DateTime.Parse(Console.ReadLine());
    Console.Write("Valor por hora: ");
    double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Duração (horas): ");
    int horas = int.Parse(Console.ReadLine());

    HoraContrato contrato =  new HoraContrato(data, valorPorHora, horas);
    trabalhador.AdicionarContrato(contrato);
}
    Console.WriteLine();
    Console.Write("Entre mes e ano para calcular a renda (MM/AAA): ");
    string mesAno = Console.ReadLine();
    int mes = int.Parse(mesAno.Substring(0, 2));
    int ano = int.Parse(mesAno.Substring(3));

    Console.WriteLine("Nome: " + trabalhador.Nome);
    Console.WriteLine("Departamento: " + trabalhador.Departamento.Nome);
    Console.WriteLine("Renda para " + mesAno + ": " + trabalhador.Receita(ano, mes).ToString("F2", CultureInfo.InvariantCulture));
