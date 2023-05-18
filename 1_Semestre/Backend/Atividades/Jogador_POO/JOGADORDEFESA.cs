namespace Jogador_POO
{
    public class JOGADORDEFESA : Jogador
    {
        public void Defesa()
        {
            Console.WriteLine($"{this.Idade()}");

            if (this.Idade() < 40)
            {
                Console.WriteLine($"Falta apenas {40 - this.Idade()} anos para se aposentar.");
            }
            else
            {
                Console.WriteLine($"O jogador está aposentado!");
            }

        }
    }
}