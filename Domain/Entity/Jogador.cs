﻿using Domain.Enum;
using Domain.Extensions;
using Domain.Resources;
using Domain.ValueObjects;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;

namespace Domain.Entity
{
    public class Jogador : Notifiable
    {

        public Jogador(Email email, string senha)
        {
            Email = email;
            Senha = senha;

            new AddNotifications<Jogador>(this)
                .IfNullOrInvalidLength(x => x.Senha, 6, 32, "A senha deve ter entre 6  e 32 caracteres") // Válida se o parametro passado tem esta dentro do range passada.
                ;



            if (String.IsNullOrEmpty(email.Endereco))
            {
                throw new Exception();
            }
            if (String.IsNullOrEmpty(senha))
            {
                throw new Exception();
            }
        }

        public Jogador(Nome nome, Email email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Id = Guid.NewGuid();
            Status = EnumSituacaoJogador.EmAnalise;



            new AddNotifications<Jogador>(this)
                .IfNullOrInvalidLength(x => x.Senha, 6, 32, Message.X0_OBRIGATORIA_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("A senha", "6", "32"));

            if (IsValid())
            {
                Senha = Senha.ConvertToMD5();
            }

            AddNotifications(Nome, Email);
        }

        public Guid Id { get; private set ; }

        public Nome Nome { get; private set; }

        public Email Email { get; private set; }

        public string Senha { get; private set; }

        public EnumSituacaoJogador Status { get; private set; }


    }
}
