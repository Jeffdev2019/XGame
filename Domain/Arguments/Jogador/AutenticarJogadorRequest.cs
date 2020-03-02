using Domain.ValueObjects;
using prmToolkit.NotificationPattern;

namespace Domain.Arguments.Jogador
{
    public class AutenticarJogadorRequest : Notifiable
    {
        public AutenticarJogadorRequest(string email, string senha)
        {
            Email = new Email(email);
            Senha = senha;//implememnt

            AddNotifications(Email);
        }

        public Email Email { get; set; }

        public string Senha { get; set; }

    }
}
