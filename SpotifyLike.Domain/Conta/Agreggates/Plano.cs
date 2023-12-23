namespace SpotifyLike.Domain.Conta.Agreggates
{
    public class Plano
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Decimal Valor { get; set; }
        public bool Status { get; set; }
    }
}
