using Domain.Arguments.Jogador;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using System;

namespace Domain.Services
{
    public class ServiceJogador : IServiceJogadorcs
    {
        private readonly IRepositoryJogador _repositoryJogador;
        public ServiceJogador()
        {

        }
        public ServiceJogador(IRepositoryJogador repositoryJogador)
        {
            this._repositoryJogador = repositoryJogador;
        }

        public AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request)
        {
            Guid Id = _repositoryJogador.AdicionarJogador(request);

            return new AdicionarJogadorResponse() { Id = Id, Message = "Operãção Realizada com o Sucesso!!!" };
        }

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {
            if (request == null)
            {
                throw new Exception("AutenticarJogadorResponse é obrigatorio");
            }

            var Response = _repositoryJogador.AutenticarJogador(request);

            return Response;
        }
    }
}
