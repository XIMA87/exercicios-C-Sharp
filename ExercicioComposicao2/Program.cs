// See https://aka.ms/new-console-template for more information

/*
O programa deve ler os dados de um cliente (Nome, email, aniversario).
Posteriormente ler os dados de pedidos fornecidos pelo usuário (status, quantos itens, nome, preço, quantidade).
Por fim o programa deve mostrar um sumário do pedido(Momento do pedido, Status do pedido, cliente, itens, subtotal de cada item, total do pedido)
OBS: Usar DateTime.Now para o momento do pedido.
OBS2: Escreva o código no idioma inglês.
*/


using System;
using System.Globalization;
using ExercicioComposicao2.Entities;
using ExercicioComposicao2.Entities.Enums;

Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(clientName, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);