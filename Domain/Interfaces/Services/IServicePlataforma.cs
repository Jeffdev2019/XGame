using Domain.Arguments.Jogador;
using Domain.Arguments.Plataforma;
using Domain.ValueObjects;
using System;

namespace Domain.Interfaces.Services
{
    public interface IServicePlataforma
    {
        AdicionarPlataformaResponse AdicionarPlataforma(AdicionarPlataformaRequest request);
    }
}
