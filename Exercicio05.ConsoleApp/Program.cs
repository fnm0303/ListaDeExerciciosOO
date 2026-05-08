// 5) Crie um programa para calcular o volume de uma esfera
using Exercicio05.ConsoleApp;

Esfera esfera = new Esfera();

esfera.raio = 3;

double volume = esfera.CalcularVolume();

Console.WriteLine($"O volume de uma esfera com raio = 3cm é {volume:F2} cm³");
