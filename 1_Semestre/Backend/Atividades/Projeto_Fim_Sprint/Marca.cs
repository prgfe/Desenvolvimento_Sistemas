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

        public void Listar()
        {
            if (listaMarcas.Count > 0)
            {
                foreach (Marca p in listaMarcas)
                {
                    Console.WriteLine(@$"
                    Código: {p.Codigo}
                    Nome do produto: {p.NomeMarca}
                    Data de cadastro: {p.DataCadastro}
                    ");
                }
            }
        }
        public void Deletar(int codigo)
        {
            Marca p = listaMarcas.Find(x => x.Codigo == codigo);
            listaMarcas.Remove(p);
        }
    }
}