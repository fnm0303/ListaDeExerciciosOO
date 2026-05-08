using System;

namespace Exercicio06.ConsoleApp;

public class TemperaturaCelsius
{
    public decimal grausCelsius;

    public decimal ConverterParaFahrenheit()
    {
        decimal fahrenheit = (grausCelsius * 9 / 5) + 32;

        return fahrenheit;
    }
}
