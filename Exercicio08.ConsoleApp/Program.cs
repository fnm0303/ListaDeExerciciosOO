// 8) Crie um programa para calcular o volume de uma lata de óleo
using Exercicio08.ConsoleApp;

LataDeOleo lata = new LataDeOleo();

lata.raio = 4;
lata.altura = 10;

double volumeCalculado = lata.CalcularVolumeLata();

Console.WriteLine($"O volume da lata de óleo será: {volumeCalculado:F2} mL");




