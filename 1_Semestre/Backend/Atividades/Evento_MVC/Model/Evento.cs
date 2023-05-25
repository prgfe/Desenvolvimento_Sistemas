namespace Evento_MVC.Model
{
    public class Evento
    {
        public string? Nome { get; set; }

        public string? Descricao { get; set; }

        public string? Data { get; set; }

        private const string PATH = "Database/Produto.csv";

        public Evento()
        {
            string pasta = PATH.Split("/")[0];

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }

        public List<Eventos> Ler()
        {

        }
    }
}