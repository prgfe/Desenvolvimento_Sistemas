// criar método para multiplicar 2 números
// criar método para dividir 2 números
// criar método para subtrair 2 números
Console.WriteLine($"Multiplicação");

Console.WriteLine($"");

Console.WriteLine($"Informe o 1º número: ");
float n1 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o 2º número: ");
float n2 = float.Parse(Console.ReadLine()!);


static float Mult(float n1, float n2){
    float m = n1 * n2;
    return m;
}

float calc = Mult(n1, n2);

Console.WriteLine($"Resultado {calc}");

Console.WriteLine($"");

Console.WriteLine($"Divisão");

Console.WriteLine($"");

Console.WriteLine($"Informe o 1º número: ");
float n3 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o 2º número: ");
float n4 = float.Parse(Console.ReadLine()!);


static float Div(float n3, float n4){
    float d = n3 / n4;
    return d;
}

float div = Div(n3, n4);

Console.WriteLine($"Resultado {div}");

Console.WriteLine($"");

Console.WriteLine($"Subtração");

Console.WriteLine($"");

Console.WriteLine($"Informe o 1º número: ");
float n5 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o 2º número: ");
float n6 = float.Parse(Console.ReadLine()!);


static float Sub(float n5, float n6){
    float s = n5 - n6;
    return s;
}

float sub = Sub(n5, n6);

Console.WriteLine($"Resultado {sub}");

Console.WriteLine($"");
