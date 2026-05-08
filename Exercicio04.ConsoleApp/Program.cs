// 4) Crie um programa para calcular o consumo de combustível por Km. Deverá ser
//informado a kilometragem Inicial e Final do Percurso do Veículo. Deverá ser
//informado o total de Combustível utilizado
using Exercicio04.ConsoleApp;

Carro onixAzul = new Carro();

onixAzul.kmInicial = 41234;
onixAzul.kmFinal = 42148;
onixAzul.totalCombustivelUtilizado = 48.7m;

decimal media = onixAzul.CalcularMédia();

Console.WriteLine($"A média do veículo foi de: {media:F2} km/l.");
