// See https://aka.ms/new-console-template for more information

/*
O programa deve registrar N funcionários e depois os dados ID, NOME e SALARIO.
Em seguida deve efetuar o aumento de X% no salario de um determinado funcionario (informar ID).
Se o ID não existir, informar isto, abortar operação e mostrar a lista dos funcionarios.

*/


using System;
using System.Globalization;
using System.Collections.Generic;
using AumentoSalario;

Console.Write("Quantos Funcionários serão registrados: ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionarios> list = new List<Funcionarios>();

            for (int i = 1; i <= n; i++) {
                Console.WriteLine("Funcionário #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionarios(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Entre com o ID do funcionário que receberá aumento : ");
            int searchId = int.Parse(Console.ReadLine());

            Funcionarios emp = list.Find(x => x.Id == searchId);
            if (emp != null) {
                Console.Write("Digite a porcentagem de aumento: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.AumentaSalario(porcentagem);
            }
            else {
                Console.WriteLine("Este ID não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista atualizada de Funcionários:");
            foreach (Funcionarios obj in list) {
                Console.WriteLine(obj);
            }
