// Escreva um programa que pergunte o raio de uma circunferência, e sem seguida mostre o diâmetro, comprimento e área da circunferência.

Console.WriteLine($"Bem-vindo ao sistema para círculos matemáticos. Informe o raio da circunferência: ");

double raio = double.Parse(Console.ReadLine());

double diametro = raio * 2;
double comprimento = 2 * Math.PI * raio;
double area = Math.PI * Math.Pow(raio, 2);

Console.WriteLine($"O diametro é {diametro}, o comprimento é {comprimento} e a área é {area}");
