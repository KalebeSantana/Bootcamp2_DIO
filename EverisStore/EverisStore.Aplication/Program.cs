using EverisStore.Domain;
using System;

namespace EverisStore.Aplication
{
    class Program 
    {
        static void Main(string[] args)
        {
            // Testando cenário de usuário e perfil
            Perfil perfil = new Perfil
            {
                Id = 1,
                Descricao = "Administrador",
                Regra = "Acesso total",
                DataCadastro = DateTime.Now,
            };
         

            Usuario usuario = new Usuario(1, "Kalebe", "kalebe@gmail.com", "123456", 1);
            usuario.Perfil = perfil;
            var usuarioPerfil = usuario.Perfil;
            string descricaoPerfil = usuarioPerfil.Descricao;
     
            var verificaAtivo = usuario.RetornarAtivo();

            usuario.Desativar();
            usuario.Desativar(0);
            var verificaAtivo2 = usuario.RetornarAtivo();

            usuario.Ativar();
            var verificaAtivo3 = usuario.RetornarAtivo();


            // Testando cenario produto
            Produto produto = new Produto(1, "Mesa", "Mesa escritório", 200.00M, 5);

            produto.ReporEstoque(15);

            produto.PossuiEstoque(15);

            var possuiEstoque = produto.PossuiEstoque(10);
            if (possuiEstoque)
                produto.DebitarEstoque(10);

            var possuiEstoque2 = produto.PossuiEstoque(15);
            if (possuiEstoque2)
                produto.DebitarEstoque(10);

        }
    }
}
