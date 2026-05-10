using System;

namespace Exercicio09.ConsoleApp;

public class Aluno
{
    public decimal nota1;
    public decimal nota2;

    public decimal CalcularMediaHarmonica()
    {
        decimal media = 2 / ((1 / nota1) + (1 / nota2));
        return media;
    }
}
