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
            return new Usuario(){
                Id = id,
                Nome = "Beltrano"
            };

        }

        public Restaurante BuscarRestaurante(int id)
        {
            return new Restaurante(){
                Id = id,
                Nome = "OutBack"
            }
        }
    }
}