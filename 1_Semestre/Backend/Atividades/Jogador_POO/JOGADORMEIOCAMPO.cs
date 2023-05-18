namespace Jogador_POO
{
    public class JOGADORMEIOCAMPO : Jogador
    {
        public void MeioCampo()
        {
            Console.WriteLine($"{this.Idade()}");

            if (this.Idade() < 38)
            {
                Console.WriteLine($"Falta apenas {38 - this.Idade()} anos para se aposentar.");
            }
            else
            {
                Console.WriteLine($"O jogador está aposentado!");
            }
        }

    }
}