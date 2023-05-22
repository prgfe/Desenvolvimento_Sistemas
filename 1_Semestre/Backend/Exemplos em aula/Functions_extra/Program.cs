//faça um método para calcular imposto sobre a renda

//regras de negócio
//tabela de imposto vs renda
//até $1500 - isento
//de $1501 até $3500 - 20% de imposto
//de $3501 até $6000 - 25% de imposto
//acima de $6000 - 35% de imposto

// informar a renda

static float LeaoFaminto(float imposto)
{
    float taxa = imposto;
    return taxa;
}
float x = 0, y = 0.2f, z = 0.25f, w = 0.35f;

Console.WriteLine($"Informe a sua renda em reais: ");
float renda = float.Parse(Console.ReadLine()!);

if (renda <= 1500)
{
    float taxa = x;
    Console.WriteLine($"O imposto sobre a renda é {x} reais");
}

else if ((renda >= 1501) && (renda <= 3500))
{
    Console.WriteLine($"O imposto sobre a renda é: {y * renda} reais");
}

else if ((renda >= 3501) && (renda <= 6000))
{
    Console.WriteLine($"O imposto sobre a renda é: {z * renda} reais");
}

else if (renda >= 6001)
{
    Console.WriteLine($"O imposto sobre a renda é: {w * renda} reais");
}