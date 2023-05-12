namespace Jogador_POO
{
    public abstract class Jogador
    {
        public string Nome { get; set; }
        public int Nascimento { get; set; }
        public string Nacionalidade { get; set; }
        public float Altura { get; set; }
        public float Peso { get; set; }

        public void DadosJogador(string nome, int nascimento, string nacionalidade, float altura, float peso)
        {
            Nome = nome;
            Nascimento = nascimento;
            Nacionalidade = nacionalidade;
            Altura = altura;
            Peso = peso;
        }

        public void DadosJogador()
        {
            Console.WriteLine($"{}");

        }
    }
}