using System;
using System.Collections.Generic;

namespace Onde_Comer.models
{
    public class Votacao
    {
        public DateTime Data {get; set;}
        public List<Voto> Votos {get; set;}
    }
}