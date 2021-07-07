namespace OndeComer.ConsoleApplication.models
{
    public class Usuario
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }

        public Usuario(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}