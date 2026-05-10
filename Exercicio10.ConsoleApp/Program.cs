// 10) Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno

using Exercicio10.ConsoleApp;

Aluno felipe = new Aluno();

felipe.prova1 = 5.6m;
felipe.prova2 = 8.9m;
felipe.trabalho1 = 9;

decimal media = felipe.CalcularMediaPonderada();

Console.WriteLine($"A média ponderada do aluno será: {media:F2}");
