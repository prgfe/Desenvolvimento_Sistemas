namespace Jogador_POO
{
    public abstract class Jogador
    {
        public string Nome { get; set; }

        public int AnoNascimento { get; set; }

        public string Nacionalidade { get; set; }

        public float Altura { get; set; }

        public float Peso { get; set; }


        public void Pergunta()
        {
            Console.WriteLine($"Insira o nome: ");
            this.Nome = Console.ReadLine();


            Console.WriteLine($"Insira o ano de nascimento: ");
            this.AnoNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine($"Insira a nacionalidade: ");
            this.Nacionalidade = Console.ReadLine();

            Console.WriteLine($"Insira a altura: ");
            this.Altura = float.Parse(Console.ReadLine());

            Console.WriteLine($"Insira o peso: ");
            this.Peso = float.Parse(Console.ReadLine());
        }
        public void Dados()
        {
            Console.WriteLine(@$"
            Nome: {this.Nome}
            Ano de nascimento: {this.AnoNascimento}
            Nacionalidade: {this.Nacionalidade}
            Altura: {this.Altura}
            Peso: {this.Peso}
            ");

        }
        public int Idade()
        {
            return DateTime.Now.Year - AnoNascimento;
        }
    }
}