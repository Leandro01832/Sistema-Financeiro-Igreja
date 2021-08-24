using System.ComponentModel.DataAnnotations.Schema;

namespace business.Classe
{
    [Table("MovimentacaoSaida")]
    public abstract class MovimentacaoSaida : Movimentacao
    {
        public MovimentacaoSaida()
        {

        }
    }
}
