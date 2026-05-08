//2) Crie um programa para converter a temperatura de graus Fahrenheit para graus Celsius
using Exercicio02.ConsoleApp;

TemperaturaFahrenheit fahrenheit = new TemperaturaFahrenheit();

fahrenheit.grausFahrenheit = 100;

TemperaturaCelsius celsius = fahrenheit.ConverterParaCelsius();

Console.WriteLine($"A conversão de {fahrenheit.grausFahrenheit:F1} °F resultou em {celsius.grausCelsius:F1} °C.");

TemperaturaCelsius celsius1 = new TemperaturaCelsius();

celsius.grausCelsius = 37;

TemperaturaFahrenheit fahrenheit1 = celsius.ConverterParaFahrenheit();

Console.WriteLine($"A conversão de {celsius.grausCelsius:F1} °C resultou em {fahrenheit.grausFahrenheit:F1} °F.");
