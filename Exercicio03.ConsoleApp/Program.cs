//3) Crie um programa para calcular o volume de um Cilindro
using Exercicio03.ConsoleApp;

Cilindro volumeCilindro = new Cilindro();

volumeCilindro.raio = 2;
volumeCilindro.altura = 5;

decimal volume = volumeCilindro.CalcularVolumeCilindro();

Console.WriteLine($"O volume de um cilindro com raio = 2cm e altura = 5cm é: {volume:F2} cm³");