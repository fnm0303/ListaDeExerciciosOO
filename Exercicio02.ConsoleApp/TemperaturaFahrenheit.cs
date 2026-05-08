using System;

namespace Exercicio02.ConsoleApp;

//C = (F - 32) * 5 / 9
public class TemperaturaFahrenheit
{
    public decimal grausFahrenheit;
    public TemperaturaCelsius ConverterParaCelsius()
    {
        TemperaturaCelsius celsius = new TemperaturaCelsius();

        celsius.grausCelsius = (grausFahrenheit - 32) * 5 / 9;

        return celsius;
    }
}
