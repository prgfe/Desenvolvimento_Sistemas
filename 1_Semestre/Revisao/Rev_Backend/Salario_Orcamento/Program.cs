// Faça um programa que o usuário informe o salário recebido e o total gasto. Deverá ser exibido na tela “Gastos dentro do orçamento” caso o valor gasto não ultrapasse o valor do salário e “Orçamento estourado” se o valor gasto ultrapassar o valor do salário.

Console.WriteLine($"Digite o seu salário: ");
float salario = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o total gasto: ");
float gasto = float.Parse(Console.ReadLine());

string result = salario >= gasto ? "Gastos dentro do orçamento" : "Orçamento estourado";
Console.WriteLine($"{result}");