﻿using Domain.Interfaces.Arguments;
using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Arguments.Jogador
{
    public class AdicionarJogadorRequest : IRequest
    {
        public Nome Nome { get; set; }

        public Email Email { get; set; }

        public string Senha { get; private set; }
    }
}