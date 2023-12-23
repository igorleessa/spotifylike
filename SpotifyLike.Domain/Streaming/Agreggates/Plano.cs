using SpotifyLike.Domain.Core.ValueObject;
using System.Net.NetworkInformation;

namespace SpotifyLike.Domain.Streaming.Agreggates
{
    public class Plano
    {
        public Guid Id { get; set; }
        public String Nome { get; set; }
        public String Descricao { get; set; }
        public Monetario Valor { get; set; }
        public bool Status { get; set; }

        public static Plano Criar(string nome, string descricao, Monetario valor)
        {
            if (String.IsNullOrWhiteSpace(nome))
            {
                throw new Exception("Nome obrigatório");
            }

            return new()
            {
                Nome = nome,
                Descricao = descricao,
                Valor = valor,
                Status = true
            };
        }
    }
}
