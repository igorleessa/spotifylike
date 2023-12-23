namespace SpotifyLike.Domain.Streaming.Agreggates
{
    public class Banda
    {
        public Guid Id { get; set; }
        public String Nome { get; set; }
        public String Descricao { get; set; }
        public String Backdrop { get; set; }
        public List<Album> Albums { get; set; } = new List<Album>();

        public void AdicionarAlbum(Album album) =>
            this.Albums.Add(album);

        public static Banda Criar(Banda banda)
        {
            if (banda != null)
            {
                if (string.IsNullOrWhiteSpace(banda.Nome)) throw new Exception("Nome obrigatorio");

                return new Banda {
                    Nome = banda.Nome,
                    Backdrop = banda.Backdrop,
                    Albums = banda.Albums,
                    Descricao = banda.Descricao,
                    Id = new Guid()
                };
            }
            else
            {
                throw new Exception("Objeto banda nulo");
            }
            
        }
    }
}
