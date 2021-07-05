using System;
using Onde_Comer.service;

namespace Onde_Comer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            VotacaoService _votacaoService = new VotacaoService();
            _votacaoService.RealizarVotacao(1,2);
        }
    }
}
