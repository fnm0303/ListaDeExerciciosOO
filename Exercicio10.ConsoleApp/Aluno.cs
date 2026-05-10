using System;

namespace Exercicio10.ConsoleApp;

public class Aluno
{
    public decimal prova1;
    public decimal prova2;
    public decimal trabalho1;

    private decimal pesoNotaProva = 7;

    private decimal pesoNotaTrabalho = 3;

    public decimal CalcularMediaPonderada()
    {
        decimal media = ((((prova1 + prova2) / 2) * pesoNotaProva) + (trabalho1 * pesoNotaTrabalho)) / (pesoNotaProva + pesoNotaTrabalho);
        return media;
    }
}
