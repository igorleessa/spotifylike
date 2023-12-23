using SpotifyLike.Domain.Streaming.Agreggates;

namespace SpotifyLike.Tests.Domain
{
    public class BandaTest
    {
        [Fact]
        public void CriarSuccess()
        {
            var banda = new Banda()
            {
                Nome = "Metallica",
                Albums = new List<Album>() { },
                Backdrop = "https://www12.senado.leg.br/radio/1/capitulo-rock/2021/08/06/30-anos-do-black-album-do-metallica/@@images/2d7e4475-3a1d-4679-93f2-5336b7f14088.jpeg",
                Descricao = "Maior de todos os tempos"
            };


            var bandas = Banda.Criar(banda);

            Assert.Equal(bandas.Nome, banda.Nome);
        }

        public void CriarFailed()
        {
            Assert.Throws<Exception>(() =>
            {
                var banda = Banda.Criar(null);
            });
        }
    }
}
