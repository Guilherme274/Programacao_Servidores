namespace Programacao_Servidores.Models
{
    public class ContatoModel
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }

        private static long contator = 0;

        public ContatoModel(String Nome, String Celular, String Email)
        {
            this.Nome = Nome;
            this.Celular = Celular;
            this.Email = Email;
            Id = contator++;
        }
    }
    public class ListaContatosModel
    {
        public List<ContatoModel> Lista = new List<ContatoModel>
        {
            new ContatoModel("Maria", "9 9876 6754", "maria@yahoo.com"),
            new ContatoModel("Carlos", "9 9876 9950", "carlos@yahoo.com"),
            new ContatoModel("João", "9 9123 4567", "joao@gmail.com")
        };
    }
}