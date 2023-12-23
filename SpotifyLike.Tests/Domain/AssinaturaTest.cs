using Assinaturas = SpotifyLike.Domain.Conta.Agreggates.Assinatura;
using Planos = SpotifyLike.Domain.Conta.Agreggates.Plano;
using SpotifyLike.Domain.Streaming.Agreggates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyLike.Tests.Domain
{
    public class AssinaturaTest
    {
        [Fact]
        public void DeveCriarAssinaturaComSucesso()
        {
            var plano = Plano.Criar("Basico", "Assinatura Basica", 40);
            plano.Id = Guid.NewGuid();
           
            var dataInicio = Convert.ToDateTime("10/01/2023");

            Planos planos = new Planos() {
                Id = plano.Id,
                Status = plano.Status,
                Descricao= plano.Descricao,
                Nome= plano.Nome,
                Valor  = plano.Valor
            };

            var assinatura = Assinaturas.Criar(planos, dataInicio);

            Assert.Equal(plano.Id, assinatura.Plano.Id);
            Assert.Equal(dataInicio, assinatura.Vigencia.DtInicio);
            Assert.Equal(dataInicio.AddMonths(1), assinatura.Vigencia.DtFim);
        }
    }
}
