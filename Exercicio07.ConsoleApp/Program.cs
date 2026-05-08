/* 7) Crie um programa para calcular o salário total de um vendedor. Deverá ser
informado o salário base e o total de vendas. A comissão é calculada com um
percentual (informado pelo usuário) sobre o total de vendas. */

using Exercicio07.ConsoleApp;

Console.Write("Informe o percentual da comissão: ");
decimal percentualComissao = Convert.ToDecimal(Console.ReadLine());

Vendedor felipe = new Vendedor();

felipe.salarioBase = 3500;
felipe.totalVendas = 42600;

decimal salarioTotal = felipe.CalcularSalarioTotal(percentualComissao);

Console.WriteLine($"\nO salário total será R$ {salarioTotal:F2}");