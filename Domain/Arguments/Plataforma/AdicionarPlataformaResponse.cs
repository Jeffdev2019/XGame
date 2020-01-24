using Domain.Interfaces.Arguments;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Arguments.Plataforma
{
    public class AdicionarPlataformaResponse :IResponse 
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string Message { get; set; }
    }
}
