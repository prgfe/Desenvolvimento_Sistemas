namespace Projeto_Produto_Interface
{
    // Interface carrinho
    public interface ICarrinho
    {
        // Regras do contrato
        // Métodos que deverão ser declarados, sem corpo!

        // CRUD: Create, Read, Update, Delete

        // Padrão de chamada de método
        // tipo Nome(parametros, se houver)

        // Create
        void Adicionar(Produto _produto);

        // Read
        void Listar();

        // Update
        void Atualizar(int _codigo, Produto _produto);

        // Delete
        void Remover(Produto _produto);
    }
}