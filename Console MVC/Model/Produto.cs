namespace Console_MVC.Model
{
    public class Produto
    {
        // Propriedades
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public float Preco { get; set; }

        // Caminho da pasta e do arquivo CSV
        private const string PATH = "Database/.Produto.csv";

        public Produto() {
            // Criar a lógica para gerar a pasta e o arquivo
            // Obter o caminho da pasta
            string pasta = PATH.Split('/')[0];

            // Verificar se no caminho já existe uma pasta
            if (!Directory.Exists(pasta)) {
                Directory.CreateDirectory(pasta);
            }

            // Verificar se no caminho já existe um arquivo
            if (!File.Exists(PATH)) {
                File.Create(PATH);
            }
        }

        public List<Produto> Ler() {
            List<Produto> produtos = new List<Produto>();

            string[] linhas = File.ReadAllLines(PATH);

            // Leitura de cada linha
            foreach (string linha in linhas) {
                // Separação de atributos de cada linha
                string[] atributos = linha.Split(';');

                // Instância do Produto
                Produto produto = new Produto();

                // Atribuição dos valores do produto
                produto.Codigo = int.Parse(atributos[0]);
                produto.Nome = atributos[1];
                produto.Preco = float.Parse(atributos[2]);

                produtos.Add(produto);
            }

            return produtos;
        }

        // Método para preparar as linhas a serem inseridas no csv
        public string PrepararLinhasCSV(Produto produto) => $"{produto.Codigo};{produto.Nome};{produto.Preco};";

        // Método para inserir um produto na linha do CSV
        public void Inserir(Produto produto) {
            // Array que armazena as linhas obtidas pelo método
            string[] linhas = {PrepararLinhasCSV(produto)};

            // Inserir todas as linhas no arquivo dentro do PATH
            File.AppendAllLines(PATH, linhas);
        }
    }
}