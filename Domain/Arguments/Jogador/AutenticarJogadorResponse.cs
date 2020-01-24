using Domain.Interfaces.Arguments;
using Domain.ValueObjects;

namespace Domain.Arguments.Jogador
{
    public class AutenticarJogadorResponse : IResponse
    {
        public string PrimeiroNome{ get; set; }

        public Email Email{ get; set; }

    }
}