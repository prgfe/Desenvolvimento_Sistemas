namespace Projeto_Fim_Sprint
{
    public class Login
    {
        public bool Logado { get; set; }

        public Login()
        {
            Usuario user = new Usuario();

            Logar(user);

            if (this.Logado == true)
            {
                GerarMenu();
            }
        }
        public void Logar(Usuario usuario)
        {
            Console.WriteLine($"Insira o email: ");
            string email = Console.ReadLine();

            Console.WriteLine($"Insira a senha: ");
            string senha = Console.ReadLine();

            if (email == usuario.Email && usuario.Senha == "1234")
            {
                this.Logado = true;
                Console.WriteLine($"Login efetuado com sucesso!");

            }
            else
            {
                this.Logado = false;
                Console.WriteLine($"Falha ao logar.");

            }
        }
        public void Deslogar()
        {
            this.Logado = false;
        }

        public void GerarMenu()
        {
            Produto produto = new Produto();
            Marca marca = new Marca();

            string opcao;

            do
            {
                Console.WriteLine(@$"
            [1] Cadastrar produtos
            [2] Listar produtos
            [3] Remover produtos
            ---------------------
            [4] Cadastrar marcas
            [5] Listar marcas
            [6] Remover marcas
            ---------------------
            [0] Sair
            ");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        produto.Cadastrar();
                        break;
                    case "2":
                        produto.Listar();
                        break;
                    case "3":
                        Console.WriteLine($"Insira o código a ser excluído: ");
                        int codigoProduto = int.Parse(Console.ReadLine());

                        produto.Deletar(codigoProduto);
                        break;
                    case "4":
                        marca.Cadastrar();
                        break;
                    case "5":
                        marca.Listar();
                        break;
                    case "6":
                        Console.WriteLine($"Insira o código a ser excluído: ");
                        int codigoMarca = int.Parse(Console.ReadLine());

                        marca.Deletar(codigoMarca);
                        break;
                    case "0":
                        Console.WriteLine($"App encerrado!");
                        break;
                    default:
                        Console.WriteLine($"Opção inválida!");
                        break;
                }

            } while (opcao != "0");
        }
    }
}