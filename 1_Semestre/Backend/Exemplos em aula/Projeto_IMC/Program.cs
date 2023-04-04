
Console.BackgroundColor = ConsoleColor.Yellow;
Console.WriteLine(@$"
-----------------
| Programa para |
| calcular IMC  |
-----------------
");
Console.ResetColor();

Console.BackgroundColor = ConsoleColor.Green;

Console.WriteLine($"Informe o nome do paciente: ");
string nome = Console.ReadLine();

Console.WriteLine($"Informe o peso atual do paciente: ");
float peso = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe a altura do paciente: ");
float altura = float.Parse(Console.ReadLine());

Console.ResetColor();

float imc = peso / ((float)Math.Pow(altura,2));

Console.WriteLine(imc);

Console.ForegroundColor = ConsoleColor.Magenta;

Console.WriteLine($"O paciente (nome) tem o imc igual a (imc)");
Console.ResetColor();



