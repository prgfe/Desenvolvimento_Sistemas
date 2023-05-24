using Console_MVC.Model;

namespace Console_MVC.view
{
    public class ProdutoView
    {
        // Método para exibir os dados da lista no console
        public void Listar(List<Produto> produto)
        {
            foreach (var item in produto)
            {
                Console.WriteLine($"\n Código: {item.Codigo}");
                Console.WriteLine($" Nome: {item.Nome}");
                Console.WriteLine($" Preço: {item.Preco:C}");
            }
        }
    }
}