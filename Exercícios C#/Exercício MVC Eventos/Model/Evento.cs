namespace Exercício_MVC_Eventos.Model
{
    public class Evento
    {
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public DateTime Data { get; set; }

        private const string PATH = "Database/Evento.csv";

        public Evento() {
            string pasta = PATH.Split('/')[0];

            if (!Directory.Exists(pasta)) {
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(PATH)) {
                File.Create(PATH);
            }
        }

        public List<Evento> Ler() {
            List<Evento> eventos = new List<Evento>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (string linha in linhas) {
                string[] atributos = linha.Split(';');

                Evento evento = new Evento();

                evento.Nome = atributos[0];
                evento.Descricao = atributos[1];
                evento.Data = DateTime.Parse(atributos[2]);

                eventos.Add(evento);
            }
            return eventos;
        }

        public string PrepararLinhas(Evento evento) => $"{evento.Nome};{evento.Descricao};{evento.Data}";

        public void Inserir(Evento evento) {
            string[] linhas = {PrepararLinhas(evento)};

            File.AppendAllLines(PATH, linhas);
        }
    }
}