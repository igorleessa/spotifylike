using System.Net.NetworkInformation;

namespace SpotifyLike.Domain.Conta.Agreggates
{
    public class Assinatura
    {
        public Guid Id { get; set; }
        public Plano Plano { get; set; }
        public Boolean Ativo { get; set; }
        public DateTime DtAtivacao { get; set; }
        public bool Status { get; set; }
        public Vigencia Vigencia { get; set; }


        public static Assinatura Criar(Plano plano, DateTime DtInicio)
        {
            if (!plano.Status)
            {
                throw new Exception("Obrigatório possuir um plano ativo.");
            }

            return new Assinatura()
            {
                Plano = plano,
                Status = true,
                Vigencia = new Vigencia() { 
                    DtInicio = DtInicio,
                    DtFim = DtInicio.AddMonths(1)
                } 
            };
        }
    }

    public class Vigencia
    {
        public DateTime DtInicio { get; set; }
        public DateTime DtFim { get; set; }
    }
}
