namespace Projeto_Fim_Sprint
{
    public class Marca
    {
        public int Codigo { get; set; }

        public string NomeMarca { get; set; }

        public DateTime DataCadastro { get; set; }

        // // public CadastrarMarca()
        // {
        //     Console.WriteLine($"Insira a marca do produto: ");
        //     int marca = int.Parse(Console.ReadLine());
        // }

        List<Marca> marcas = new List<Marca>();

        Marca m = new Marca();
        // m.Nome = "Nike"
    }
}