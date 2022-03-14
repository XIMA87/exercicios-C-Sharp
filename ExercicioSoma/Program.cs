// See https://aka.ms/new-console-template for more information

//O programa deve ler 2 valores inteiros e mostrar na tela a soma deles.


using System;

            int A, B, soma;

            Console.Write("Digite o primeiro número: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            B = int.Parse(Console.ReadLine());

            soma = A + B;
        
            Console.WriteLine("SOMA = " + soma);