Console.WriteLine($"Insira a idade em anos: ");
int idadeAnos = int.Parse(Console.ReadLine());

int idadeMeses = idadeAnos * 12;
int idadeDias = idadeMeses * 365;
int idadeHoras = idadeDias * 24;
int idadeMinutos = idadeHoras * 60;

Console.WriteLine($"A idade é: {idadeAnos} anos, {idadeMeses} meses, {idadeDias} dias, {idadeHoras} horas, {idadeMinutos} minutos");