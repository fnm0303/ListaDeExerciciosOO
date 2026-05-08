//1) Crie um programa para calcular o volume de uma caixa retangular
//V = COMP x LARG x ALT
using Exercicio01.ConsoleApp;

CaixaRetangular caixa = new CaixaRetangular();

caixa.comprimento = 50;

caixa.largura = 30;

caixa.altura = 20;

decimal volumeCaixa = caixa.CalcularVolume();
Console.WriteLine($"O volume da caixa é: {volumeCaixa.ToString("F2")} cm³");

