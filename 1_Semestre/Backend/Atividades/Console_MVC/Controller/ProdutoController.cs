using Console_MVC.view;
using Console_MVC.Model;
namespace Console_MVC.Controller
{
    public class ProdutoController
    {
        // Instância das classes produto e produtoView
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

        // Método controlador para acessar a listagem de produtos
        public void ListarProdutos()
        {
            List<Produto> produtos = produto.Ler();

            produtoView.Listar(produtos);
        }
    }
}