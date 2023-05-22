int idade;
do
{
    Console.Clear();
    Console.WriteLine($"Qual é a idade do Brad Pitt? ");
    idade = int.Parse(Console.ReadLine());
} while (idade != 59);

if (idade == 59)
{
    Console.WriteLine($"Acertou");
}



