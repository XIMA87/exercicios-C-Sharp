// See https://aka.ms/new-console-template for more information

/*
O programa deve ler o nome de um aluno e as 3 notas de 3 trimestres.
    - Os trimestres valem 30, 35 e 35 pts.
    - Mostrar a nota final
    - Mostrar APROVADO (>=60pts) ou REPROVADO (<60PTS)
*/

using System;
using System.Globalization;
using NotaAluno;

Aluno aluno = new Aluno();

Console.Write("Nome do aluno: ");
aluno.Nome = Console.ReadLine();
Console.WriteLine("Digite as três notas do aluno:");
aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

if (aluno.Aprovado()) {
Console.WriteLine("APROVADO");
}
else {
Console.WriteLine("REPROVADO");
Console.WriteLine("FALTARAM " + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
}