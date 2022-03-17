// See https://aka.ms/new-console-template for more information

/*
O programa deve realizar um cadastro de conta (numero e titular) 
e dar a opção para que seja feito ou não um deposito inicial.
Em seguida deve realizar um depósito e um saque, sempre mostrando 
os dados aualizados após cada operação. As operações de saque devem 
contemplar uma taxa de $ 5.00.
*/

using System;
using System.Globalization;
using ContaBanc;

ContaBancaria conta ;

Console.Write("Entre o numero da conta: ");
int numero = int.Parse(Console.ReadLine());
Console.Write("Entre o titular da conta: ");
string titular = Console.ReadLine();
Console.Write("Haverá depósito inicial (s/n)? ");
char resp = char.Parse(Console.ReadLine());
if (resp == 's' || resp == 'S') {
    Console.Write("Entre o valor de depósito inicial: ");
    double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    conta = new ContaBancaria(numero, titular, depositoInicial);
}
else {
    conta = new ContaBancaria(numero, titular);
}

Console.WriteLine();
Console.WriteLine("Dados da Conta:");
Console.Write(conta);

Console.WriteLine();
Console.Write("Entre um valor para depósito: ");
double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Deposito(quantia);

Console.WriteLine();
Console.WriteLine("Dados da Conta atualizados:");
Console.Write(conta);

Console.WriteLine();
Console.Write("Entre um valor para saque: ");
quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Saque(quantia);

Console.WriteLine();
Console.WriteLine("Dados da Conta atualizados:");
Console.Write(conta);
