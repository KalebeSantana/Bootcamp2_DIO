﻿namespace EverisStore.Domain
{
    public class Usuario : EntidadeBase //Usuario herda os atributos da EntidadeBase
    {
        public Usuario(int id, string nome, string email, string senha, int perfilId)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            PerfilId = perfilId;
            Ativar();
        }
        
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int PerfilId { get; set; }
        public Perfil Perfil { get; set; }

        public bool RetornarAtivo() => Ativo;
        public void Desativar() => Ativo = false;
        public void Desativar(int id) //Mesmo método com parâmetros diferentes (Sobrecarga)
        {
            Id = 0;
            Ativo = false;
            return;
        }
        public void Ativar() => Ativo = true;
    }
}
