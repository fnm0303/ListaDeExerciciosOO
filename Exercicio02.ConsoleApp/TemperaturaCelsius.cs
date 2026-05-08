using System;

namespace Exercicio02.ConsoleApp;

public class TemperaturaCelsius
{
    public decimal grausCelsius;

    public TemperaturaFahrenheit ConverterParaFahrenheit()
    {
        TemperaturaFahrenheit fahrenheit = new TemperaturaFahrenheit();

        fahrenheit.grausFahrenheit = (grausCelsius * 9 / 5) + 32;

        return fahrenheit;
    }
}
