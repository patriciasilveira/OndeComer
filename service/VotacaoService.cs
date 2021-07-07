using System;
using System.Collections.Generic;
using System.Linq;
using OndeComer.ConsoleApplication.models;

namespace OndeComer.ConsoleApplication.service
{
    public class VotacaoService
    {
        private static List<Votacao> _votacoes = new List<Votacao>();

        private static List<Usuario> _usuarios = new List<Usuario>{
                    new Usuario(1, "Beltrano"),
                    new Usuario(2, "Ciclano"),
                    new Usuario(3, "fulano")
            };

        private static List<Restaurante> _restaurantes = new List<Restaurante>{
                new Restaurante(1,"OutBack" ),
                new Restaurante(2, "Applebee's"),
                new Restaurante(3, "McDonald's")
            };

        public void RealizarVotacao(int idUsuario, int idRestaurante)
        {
            var usuario = BuscarUsuario(idUsuario);

            if (usuario == null)
                throw new Exception("Usuario informado não existe");

            var restaurante = BuscarRestaurante(idRestaurante);

            if (restaurante == null)
                throw new Exception("Restaurante informado não existe");

            var voto = new Voto(usuario,
                                restaurante);

            IniciarVotacao();
            Votar(voto);
            ExibirResultados();
        }

        private void ExibirResultados()
        {
            var votacao = _votacoes.Find(x => x.Data.Date == DateTime.Now.Date);

            var restaurantesVotados = votacao.Votos.Select(x => x.Restaurante);
            var idsRestaurantesVotados = restaurantesVotados.Select(x => x.Id).Distinct();

            Console.WriteLine("Resultado da votação\n\n");

            foreach (var idRestauranteVotado in idsRestaurantesVotados)
                Console.WriteLine($"Restaurante: {restaurantesVotados.FirstOrDefault(x => x.Id == idRestauranteVotado).Nome}\nQtdVotos: {restaurantesVotados.Count(x => x.Id == idRestauranteVotado)}\n");
        }

        public void Votar(Voto voto)
        {
            var votacao = _votacoes.Find(x => x.Data.Date == DateTime.Now.Date);

            var usuarioJaVotou = votacao.Votos.Exists(x => x.Usuario.Id == voto.Usuario.Id);
            if (usuarioJaVotou)
                throw new Exception("Este usuário já votou");

            const int horarioMaximoVotacao = 20;
            if (DateTime.Now.Hour >= horarioMaximoVotacao)
                throw new Exception("Votação de hoje encerrada");

            votacao.Votos.Add(voto);
        }

        public void IniciarVotacao()
        {
            var existeVotacaoHoje = _votacoes.Exists(x => x.Data.Date == DateTime.Now.Date);

            if (!existeVotacaoHoje)
            {
                var votacao = new Votacao();
                votacao.Data = DateTime.Now;
                votacao.Votos = new List<Voto>();
                _votacoes.Add(votacao);
            }
        }

        public Usuario BuscarUsuario(int id)
        {
            return _usuarios.Find(x => x.Id == id);
        }

        public Restaurante BuscarRestaurante(int id)
        {
            return _restaurantes.Find(x => x.Id == id);
        }
    }
}
