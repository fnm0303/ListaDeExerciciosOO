using System;

namespace Exercicio04.ConsoleApp;

//MÉDIA = KM RODADOS / COMBUSTÍVEL USADO
public class Carro
{
    public decimal kmInicial;
    public decimal kmFinal;
    public decimal totalCombustivelUtilizado;

    public decimal CalcularMédia()
    {
        decimal media = (kmFinal - kmInicial) / totalCombustivelUtilizado;

        return media;
    }
}
