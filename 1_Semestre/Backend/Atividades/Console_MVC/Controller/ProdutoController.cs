using Console_MVC.view;
using Console_MVC.Model;
namespace Console_MVC.Controller
{
    public class ProdutoController
    {
        // Instância das classes produto e produtoView
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

        List<Produto> exibir = new List<Produto>();

        // Método controlador para acessar a listagem de produtos
        public void ListarProdutos()
        {
            // Chamada da model para trazer a lista
            List<Produto> produtos = produto.Ler();
            // Chamada da view para mostrar a lista
            produtoView.Listar(produtos);
        }

        public void Cadastrar()
        {
            Produto novoProduto = produtoView.Cadastrar();

            produto.Inserir(novoProduto);
        }
    }
}