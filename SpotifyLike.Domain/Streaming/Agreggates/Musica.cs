using SpotifyLike.Domain.Conta.Agreggates;
using SpotifyLike.Domain.Streaming.ValueObject;

namespace SpotifyLike.Domain.Streaming.Agreggates
{
    public class Musica
    {
        public Guid Id { get; set; }
        public String Nome { get; set; }
        public Duracao Duracao { get; set; }

        public List<Playlist> Playlists { get; set; } = new List<Playlist>();

    }
}
