namespace Evento_MVC.Model
{
    public class Eventos
    {
        public string? Nome { get; set; }

        public string? Descricao { get; set; }

        public string? Data { get; set; }

        private const string PATH = "Database/Evento.csv";

        public Eventos()
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
            List<Eventos> eventos = new List<Eventos>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                string[] atributos = item.Split(";");

                Eventos e = new Eventos();

                e.Nome = atributos[0];
                e.Descricao = atributos[1];
                e.Data = atributos[2];

                eventos.Add(e);
            }

            return eventos;
        }

        public string PrepararLinhasCSV(Eventos e)
        {
            return $"{e.Nome};{e.Descricao};{e.Data}";
        }

        public void Inserir(Eventos e)
        {
            string[] linhas = { PrepararLinhasCSV(e) };

            File.AppendAllLines(PATH, linhas);
        }
    }
}