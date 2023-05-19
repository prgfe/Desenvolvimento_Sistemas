Console.WriteLine($"Insira o raio da circunferência: ");
float raio = float.Parse(Console.ReadLine());

float diametro = raio * 2f;
double comprimento = diametro * Math.PI;
double area = Math.PI * Math.Pow(raio, 2);

Console.WriteLine(@$"Raio: {raio}
Comprimento: {comprimento.ToString("F2")}
Área: {area.ToString("F2")}
");