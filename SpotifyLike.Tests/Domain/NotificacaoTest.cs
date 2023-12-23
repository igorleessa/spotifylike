using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using SpotifyLike.Domain.Conta.Agreggates;
using SpotifyLike.Domain.Notificacao;

namespace SpotifyLike.Tests.Domain
{
    public class NotificacaoTest
    {
        [Fact]
        public void CriarNotificacaoSuccess()
        {

            var usuario = new Usuario() { 
                Id = new Guid(),
                Nome = "Caloteiro",
                DtNascimento= new DateTime(10/10/1990),
                Email = "calotedobom@gmail.com",
                Senha = "SenhaDificil1234"
            };

            var remetente = new Usuario()
            {
                Id = new Guid(),
                Nome = "Sistema",
                DtNascimento = new DateTime(10 / 10 / 1990),
                Email = "sistema@gmail.com",
                Senha = "SenhaDificil1234"
            };

            var notificacao = Notificacao.Criar("Assinatura Cancelada", "Prezado cliente, sua assinatura foi cancelada", TipoNotificacao.Sistema, usuario, remetente);

            Assert.Equal(usuario.Id, notificacao.UsuarioDestino.Id);
            Assert.Equal("Assinatura Cancelada", notificacao.Titulo);
            Assert.Equal("Prezado cliente, sua assinatura foi cancelada", notificacao.Mensagem);
            Assert.Equal(TipoNotificacao.Sistema, notificacao.TipoNotificacao);
        }

        [Fact]
        public void CriarNotificacaoFailed()
        {

            var usuario = new Usuario()
            {
                Id = new Guid(),
                Nome = "Caloteiro",
                DtNascimento = new DateTime(10 / 10 / 1990),
                Email = "calotedobom@gmail.com",
                Senha = "SenhaDificil1234"
            };

            var remetente = new Usuario()
            {
                Id = new Guid(),
                Nome = "Sistema",
                DtNascimento = new DateTime(10 / 10 / 1990),
                Email = "sistema@gmail.com",
                Senha = "SenhaDificil1234"
            };

           // var notificacao = Notificacao.Criar(null, "Prezado cliente, sua assinatura foi cancelada", TipoNotificacao.Sistema, usuario, remetente);

            Assert.Throws<Exception>(() =>
            {
               Notificacao.Criar("", "Prezado cliente, sua assinatura foi cancelada", TipoNotificacao.Sistema, usuario);
            });
        }
    }
}
