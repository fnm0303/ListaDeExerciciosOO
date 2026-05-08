using System;

namespace Exercicio03.ConsoleApp;

public class Cilindro
{
    public decimal raio;
    public decimal altura;

    private decimal pi = 3.14m;

    public decimal CalcularVolumeCilindro()
    {
        decimal volume = (pi * (raio * raio)) * altura;

        return volume;
    }
}
