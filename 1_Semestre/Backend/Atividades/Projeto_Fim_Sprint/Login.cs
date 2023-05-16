namespace Projeto_Fim_Sprint
{
    public class Login
    {
        public bool Logado { get; set; }

        public void Logar()
        {
            Console.WriteLine($"Insira o email: ");
            string email = Console.ReadLine();

            Console.WriteLine($"Insira a senha: ");
            string senha = Console.ReadLine();

            if (email == "f" && senha == "1")
            {
                Console.WriteLine($"Acesso liberado!");
            }
            else
            {
                Console.WriteLine($"Acesso negado.");
            }
        }
        public void Deslogar() { }
    }
}