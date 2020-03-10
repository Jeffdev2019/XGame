using Domain.Arguments.Jogador;
using Domain.Entity;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Resources;
using Domain.ValueObjects;
using prmToolkit.NotificationPattern;
using System;

namespace Domain.Services
{
    public class ServiceJogador : Notifiable, IServiceJogadorcs
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

            var nome = new Nome(request.PrimeiroNome, request.UltimoNome);
            var email = new Email(request.Email);

            Jogador jogador = new Jogador(nome, email, request.Senha);

            if (IsInvalid())
            {
                return null;
            }

            Guid Id = _repositoryJogador.AdicionarJogador(jogador);

            return new AdicionarJogadorResponse() { Id = Id, Message = "Operãção Realizada com o Sucesso!!!" };
        }

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {
            if (request == null)
            {
                AddNotification("AutenticarJogadorResponse", string.Format(Message.X0_E_OBRIGATORIO, "AutenticarJogadorResponse"));
            }

            Jogador jogador = new Jogador(request.Email, request.Senha);

            AddNotifications(jogador, request.Email);

            if (jogador.IsInvalid())// verifica se obejto é valido.
            {
                return null;
            }

            //var Response = _repositoryJogador.AutenticarJogador(jogador.Email.Endereco, jogador.Senha);

            AutenticarJogadorResponse Response = null;

            return Response;
        }
    }
}
