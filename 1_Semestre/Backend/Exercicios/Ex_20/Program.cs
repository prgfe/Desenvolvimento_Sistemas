// Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
// preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
// desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
// - Se quantidade <= 5 o desconto será de 2%
// - Se quantidade > 5 e quantidade <=10 o desconto será de 3%
// - Se quantidade > 10 o desconto será de 5%
// Dica: utilize if / else if / else

// Informar o nome 
// Armazenar nome
// Informar a quantidade
// Armazenar quantidade
// Armazenar preço unitário

// Calcular total
// Mostrar total
// Calcular desconto
// Mostrar desconto
// Calcular total a pagar
// Mostrar total a pagar

using System.Globalization;

Console.WriteLine($"Informe o nome do produto: ");
string nome = Console.ReadLine()!.ToLower();

Console.WriteLine($"Informe a quantidade do produto: ");
int qtde = int.Parse(Console.ReadLine()!);

float preco = 5.89f;
float dois = 0.02f, tres = 0.03f, cinc = 0.05f, desc = 0f, totalBruto = 0f;

totalBruto = qtde * preco;

if (qtde <= 5)
{
    desc = totalBruto * (1 - dois);
}
else if ((qtde > 5) && (qtde <= 10))
{
    desc = totalBruto * (1 - tres);    
}
else if (qtde > 10)
{
    desc = totalBruto * (1 - cinc);
}

Console.WriteLine($"O total a pagar é {desc.ToString("C",CultureInfo.CurrentCulture)}"); 
