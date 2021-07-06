using System;
using Onde_Comer.service;

namespace Onde_Comer
{
    class Program
    {
        static void Main(string[] args)
        {
            VotacaoService _votacaoService = new VotacaoService();
            _votacaoService.RealizarVotacao(1,2);
            _votacaoService.RealizarVotacao(2,1);
            _votacaoService.RealizarVotacao(3,2);
        }
    }
}
