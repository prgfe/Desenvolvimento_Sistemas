namespace Projeto_Fim_Sprint
{
    public class Marca
    {
        public int Codigo { get; set; }

        public string NomeMarca { get; set; }

        public DateTime DataCadastro { get; set; }

        List<Marca> listaMarcas = new List<Marca>();

        public Marca Cadastrar()
        {
            Marca novaMarca = new Marca();
            return novaMarca;
        }

        public void Listar() { }

        public void Deletar(int codigo) { }
    }
}