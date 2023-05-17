namespace Projeto_Fim_Sprint
{
    public class Produto
    {
        public int Codigo { get; set; }

        public string NomeProduto { get; set; }

        public float Preco { get; set; }

        public DateTime DataCadastro { get; set; }

        public Marca marca = new Marca();

        public Usuario CadastradoPor { get; set; }

        List<Produto> listaProdutos = new List<Produto>();

        public void Cadastrar()
        {

        }

        public void Listar()
        {
            if (listaProdutos.Count > 0)
            {
                foreach (Produto p in listaProdutos)
                {
                    Console.WriteLine(@$"
                    Código: {p.Codigo}
                    Nome do produto: {p.NomeProduto}
                    Preço: {p.Preco}
                    Marca: {p.marca}
                    Data de cadastro: {p.DataCadastro}
                    Cadastrado por: {p.CadastradoPor}
                    ");

                }
            }
        }

        public void Deletar(int codigo)
        {
            Produto p = listaProdutos.Find(x => x.Codigo == codigo);
            listaProdutos.Remove(p);
        }
    }
}