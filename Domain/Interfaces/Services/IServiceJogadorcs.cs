using Domain.Arguments.Jogador;
using Domain.ValueObjects;
using System;

namespace Domain.Interfaces.Services
{
    public interface IServiceJogadorcs
    {
        AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request);

        AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request);

    }
}
