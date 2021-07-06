using System;
using System.Collections.Generic;
using Onde_Comer.models;

namespace Onde_Comer.service
{
    public class VotacaoService
    {
        public void RealizarVotacao(int idUsuario, int idRestaurante)
        {
            var usuario = BuscarUsuario(idUsuario);
            var restaurante = BuscarRestaurante(idRestaurante);

            var voto = new Voto()
            {
                Usuario= usuario,
                Restaurante = restaurante
            };

              Console.WriteLine(voto.Usuario.Nome + " Votou no restaurante " + voto.Restaurante.Nome);

            var votacao = new Votacao();
            votacao.Data = DateTime.Now;
            votacao.Votos = new List<Voto>();
            votacao.Votos.Add(voto);
        }

        public Votacao ObterVotacao()
        {
            return null;
        }

        public Votacao ContabilizarVotos()
        {
            return null;
        }

        public Usuario BuscarUsuario(int id)
        {
            List<Usuario> Usuarios = new List<Usuario>();
            Usuarios.Add(new Usuario(){
                Id = 1,
                Nome = "Beltrano"
            });

            Usuarios.Add(new Usuario(){
                Id = 2,
                Nome = "Ciclano"
            });
            
              Usuarios.Add(new Usuario(){
                Id = 3,
                Nome = "fulano"
            });
            return Usuarios.Find(x =>x.Id == id);

        }

        public Restaurante BuscarRestaurante(int id)
        {
                   List<Restaurante> restaurantes = new List<Restaurante>();
            restaurantes.Add(new Restaurante(){
                Id = 1,
                Nome = "OutBack"
            });

            restaurantes.Add(new Restaurante(){
                Id = 2,
                Nome = "Applebee's"
            });
            
            restaurantes.Add(new Restaurante(){
                Id = 3,
                Nome = "McDonald's"
            });
            
            return restaurantes.Find(x =>x.Id == id);
        }
    }
}
