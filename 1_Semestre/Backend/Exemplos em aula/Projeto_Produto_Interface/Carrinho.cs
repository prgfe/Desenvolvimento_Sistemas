namespace Projeto_Produto_Interface
{
    // Herança: classe, interface
    public class Carrinho : ICarrinho
    {
        public float Valor { get; set; }

        // Criar uma lista para manipular os objetos
        List<Produto> carrinho = new List<Produto>();

        public void Adicionar(Produto _produto)
        {
            carrinho.Add(_produto);
        }

        public void Atualizar(int _codigo, Produto _novoProduto)
        {
            carrinho.Find(x => x.Codigo == _codigo).Nome = _novoProduto.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = _novoProduto.Preco;

        }

        public void Listar()
        {
            if (carrinho.Count > 0)
            {
                foreach (Produto p in carrinho)
                {
                    Console.WriteLine(@$"
                    Código: {p.Codigo}
                    Nome: {p.Nome}
                    Preço: {p.Preco:C}
                    ");

                }
            }
        }

        public void Remover(Produto _produto)
        {
            carrinho.Remove(_produto);
        }

        public void TotalCarrinho()
        {
            Valor = 0;

            if (carrinho.Count > 0)
            {
                foreach (Produto p in carrinho)
                {
                    Valor += p.Preco;
                }
                Console.WriteLine($"Total do seu carrinho é {Valor:C}");
            }
            else
            {
                Console.WriteLine($"Carrinho vazio!");
            }
        }
    }
}