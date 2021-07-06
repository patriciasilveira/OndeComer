namespace Onde_Comer.models
{
    public class Restaurante
    {
        public int Id { get; private set; }
        public string Nome {get;private set;}

        public Restaurante(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}