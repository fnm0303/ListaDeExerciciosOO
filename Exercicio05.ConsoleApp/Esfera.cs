using System;

namespace Exercicio05.ConsoleApp;

public class Esfera
{
    public double raio;

    public double CalcularVolume()
    {
        double volume = (4.0 / 3.0) * Math.PI * Math.Pow(raio, 3); //se fizesse 4 / 3 retornaria 1 como resultado

        return volume;
    }
}
