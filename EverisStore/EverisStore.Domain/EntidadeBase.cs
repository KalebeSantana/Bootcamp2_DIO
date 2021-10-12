using System;

namespace EverisStore.Domain
{
    public abstract class EntidadeBase
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        protected bool Ativo { get; set; }
    }
}
