using Domain.Interfaces.Arguments;
using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Arguments.Jogador
{
    public class AdicionarJogadorRequest : IRequest
    {
        public string PrimeiroNome { get; set; }

        public string UltimoNome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }
    }
}
