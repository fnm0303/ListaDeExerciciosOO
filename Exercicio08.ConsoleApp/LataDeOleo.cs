using System;

namespace Exercicio08.ConsoleApp;

public class LataDeOleo
{
    public double raio;
    public double altura;

    public double CalcularVolumeLata()
    {
        double volume = Math.PI * Math.Pow(raio, 2) * altura;

        return volume;
    }
}
