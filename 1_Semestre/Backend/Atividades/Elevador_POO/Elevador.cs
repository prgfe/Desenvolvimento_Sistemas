namespace Elevador_POO
{
    public class Elevador
    {
        public int AndarAtual { get; set; }

        public int TotalAndares { get; set; }

        public int Capacidade { get; set; }

        public int Pessoas {get; set; }

        public Elevador(int Capacidade, int TotalAndares)
        {
            this.AndarAtual = 0;
            this.Pessoas = 0;

            this.Capacidade = Capacidade;
            this.TotalAndares = TotalAndares;
        }
        public string Inicializar(int capacidade, int totalAndares, int pessoas)
        {
            return $"A capacidade do elevadoe é {capacidade} pessoas e o prédio tem {totalAndares}";
        }
        public void Entrar()
        {
            if (Capacidade < 10)
            {
                Console.WriteLine($"Dentro do limite, pode entrar.");
            }
            else
            {
                Console.WriteLine($"Limite de pessoas ultrapassado");
            }
        }
        public void Sair()
        {
            if (true)
            {
                
            }
        }
        public void Subir()
        {
            if (true)
            {
                
            }
        }
        public void Descer()
        {
        }
    }
}