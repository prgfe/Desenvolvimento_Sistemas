namespace Console_MVC.Model
{
    public class Produto
    {
        // propriedades
        public int Codigo { get; set; }

        public string? Nome { get; set; }

        public float Preco { get; set; }

        // Caminho da pasta e do arquivo csv
        private const string PATH = "Database/Produto.csv";

        public Produto()
        {
            // Criar a lógica para gerar a pasta e o arquivo

            // Obter o caminho da pasta
            string pasta = PATH.Split("/")[0];

            // Verificar se o caminho já existe uma pasta
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            // Verificar se já existe um arquivo
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }
        // Método para ler os dados do arquivo csv
        public List<Produto> Ler()
        {
            // Instância da lista de produtos
            List<Produto> produtos = new List<Produto>();

            // Array de strings armazenando todas as linhas do csv
            string[] linhas = File.ReadAllLines(PATH);

            // Leitura das linhas 
            foreach (var item in linhas)
            {
                // Separação de atributos de cada linha
                string[] atributos = item.Split(";");

                // Instância de produto
                Produto p = new Produto();

                // Atribuição de valores dentro do objeto
                p.Codigo = int.Parse(atributos[0]);
                p.Nome = atributos[1];
                p.Preco = float.Parse(atributos[2]);

                // Adiciona objeto dentro da lista
                produtos.Add(p);
            }

            return produtos;
        }

        // Método para preparar as linhas a serem inseridas no csv
        public string PrepararLinhasCSV(Produto p)
        {
            return $"{p.Codigo};{p.Nome};{p.Preco}";
            // 10200;CocaZero;6,99
        }

        // Método para inserir um produto na linha do csv
        public void Inserir(Produto p)
        {
            // Inicialização de array entre chaves
            // Array que armazena as linhas obtidas pelo método PrepararLinhaCSV

            string[] linhas = { PrepararLinhasCSV(p) };

            // Inserir todas as linhas no arquivo dentro do PATH
            File.AppendAllLines(PATH, linhas);
        }
    }
}