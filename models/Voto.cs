namespace OndeComer.ConsoleApplication.models
{
    public class Voto
    {
        public Usuario Usuario { get; private set; }
        public Restaurante Restaurante { get; private set; }

        public Voto(Usuario usuario, Restaurante restaurante)
        {
            Usuario = usuario;
            Restaurante = restaurante;
        }
    }
}