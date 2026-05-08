// Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit
using Exercicio06.ConsoleApp;

TemperaturaCelsius celsius = new TemperaturaCelsius();

celsius.grausCelsius = 37;

decimal fahrenheit = celsius.ConverterParaFahrenheit();

Console.WriteLine($"A conversão de {celsius.grausCelsius:F1} °C resultou em {fahrenheit:F1} °F.");