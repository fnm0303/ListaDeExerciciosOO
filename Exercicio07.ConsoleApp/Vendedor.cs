using System;

namespace Exercicio07.ConsoleApp;

public class Vendedor
{
    public decimal salarioBase;
    public decimal totalVendas;

    public decimal CalcularSalarioTotal(decimal comissao)
    {
        decimal salarioTotal = salarioBase + (totalVendas * (comissao / 100));

        return salarioTotal;
    }
}
