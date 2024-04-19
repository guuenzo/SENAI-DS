
// Criar um programa console Para cadastro de Eventos. Aplique os conceitos MVC aprendidos em sala de aula.

// O evento deve ter Nome, Descrição e Data que o evento ocorrerá.

// As funcionalidades devem ser Cadastrar e Listar.

namespace Atividade_MVC_eventos.Model
{
    public class Evento
    {
        //propriedades
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public string? Data { get; set; }

        //caminho da pasta e do CSV
        public const string PATH = "DataBase/Evento.csv";

        //gerar a pasta e o arquivo
        public Evento()
        {
            //obter o caminho da pasta
            string pasta = PATH.Split("/")[0];

            //verificar se no caminho ja existe pasta
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            //verificar se no caminho ja existe arquivo
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }

        public List<Evento> Ler()
        {
            List<Evento> eventos = new List<Evento>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                string[] atributos = item.Split(";");

                Evento e = new Evento();

                e.Nome = atributos[0];
                e.Descricao = atributos[1];
                e.Data = atributos[2];

                eventos.Add(e);
            }
            return eventos;
        }

        public string PrepararLinhasCSV(Evento e)
        {
            return $"{e.Nome}; {e.Descricao}; {e.Data}";
        }

        public void Inserir(Evento e)
        {
            string[] linhas = {PrepararLinhasCSV(e)};

            File.AppendAllLines(PATH, linhas);
        }
    }
}
