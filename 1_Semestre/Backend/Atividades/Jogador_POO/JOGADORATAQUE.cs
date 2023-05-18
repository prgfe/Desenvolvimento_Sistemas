namespace Jogador_POO
{
    public class JOGADORATAQUE : Jogador
    {
        public void Ataque()
        {
            Console.WriteLine($"{this.Idade()}");

            if (this.Idade() < 35)
            {
                Console.WriteLine($"Falta apenas {35 - this.Idade()} anos para se aposentar.");
            }
            else
            {
                Console.WriteLine($"O jogador está aposentado!");
            }
        }
    }
}