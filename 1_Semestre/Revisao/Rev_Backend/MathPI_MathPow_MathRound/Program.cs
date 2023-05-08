// Escreva um programa que pergunte o raio de uma circunferência, e sem seguida mostre o diâmetro, comprimento e área da circunferência.

Console.WriteLine($"Digite o raio da circunferência: ");
float raio = float.Parse(Console.ReadLine());

double diametro = 2f * raio;
double comprimento = 2f * (Math.PI) * raio;
double area = Math.PI * Math.Pow(raio, 2);

Console.WriteLine($"O diâmetro da circunferência é {diametro.ToString("F2")} u.m., o comprimento {comprimento.ToString("F2")} u.m. e a área {area.ToString("F2")} u.m.");