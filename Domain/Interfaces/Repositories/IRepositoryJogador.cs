using Domain.Arguments.Jogador;
using Domain.Entity;
using System;

namespace Domain.Interfaces.Repositories
{
    public interface IRepositoryJogador
    {
        AutenticarJogadorResponse AutenticarJogador(string email, string senha);

        Guid AdicionarJogador(Jogador jogador);
    }
}
