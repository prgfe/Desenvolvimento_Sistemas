Console.WriteLine($"Informe a frequência do aluno: ");
float frequenciaAluno = float.Parse(Console.ReadLine());

if (frequenciaAluno < 75)
{
    Console.WriteLine($"Aluno reprovado");
    System.Environment.Exit(0);
}

Console.WriteLine($"Insira a média do aluno: ");
float mediaAluno = float.Parse(Console.ReadLine());

if (mediaAluno < 3)
{
    Console.WriteLine($"Aluno reprovado");
}
else if (mediaAluno > 3 && mediaAluno < 7)
{
    Console.WriteLine($"Aluno em recuperação");
}
else
{
    Console.WriteLine($"Aluno aprovado");
}