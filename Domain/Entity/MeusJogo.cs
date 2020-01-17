using System;

namespace Domain.Entity
{
    public class MeusJogo
    {
        public Guid Id { get; set; }

        public JogoPlataforma JogoPlataforma { get; set; }

        public Boolean Desejo { get; set; }

        public DateTime DataDesejo { get; set; }

        public Boolean Troco { get; set; }

        public Boolean Vendo { get; set; }

        
    }
}
