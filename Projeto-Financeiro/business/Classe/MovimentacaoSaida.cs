using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business.Classe
{
    [Table("MovimentacaoSaida")]
    public abstract class MovimentacaoSaida : Movimentacao
    {
        public bool Pago { get; set; }
    }
}
