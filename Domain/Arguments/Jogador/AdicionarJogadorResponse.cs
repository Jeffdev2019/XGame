using Domain.Interfaces.Arguments;
using System;

namespace Domain.Arguments.Jogador
{
    public class AdicionarJogadorResponse : IResponse 
    {
        public Guid Id { get; set; }

        public string Message { get; set; }
    }
}
