using SpotifyLike.Domain.Transacao.Agreggates;

namespace SpotifyLike.Domain.Conta.Agreggates
{
    public class Conta
    {
        public Guid Id { get; set; }
        public Boolean Ativo { get; set; }
        public DateTime DataCriacao { get; set; }
        public Decimal ValorDisponivel { get; set; }

        public List<Cartao> Cartoes { get; set; } = new List<Cartao>();
    }
}
