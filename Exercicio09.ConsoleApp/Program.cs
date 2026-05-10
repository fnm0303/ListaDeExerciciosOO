// 9) Crie um programa para calcular a média harmônica das notas de um aluno

using Exercicio09.ConsoleApp;

Aluno felipe = new Aluno();
felipe.nota1 = 5;
felipe.nota2 = 10;

decimal media = felipe.CalcularMediaHarmonica();
Console.WriteLine($"A média harmônica do aluno será: {media:F2}.");


