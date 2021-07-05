using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business.Classe
{
    [Table("MovimentacaoEntrada")]
    public class MovimentacaoEntrada : Movimentacao
    {
        public bool Pago { get; set; }
        public DateTime DataRecebimento { get; set; }
        public int Pessoa_ { get; set; }
        [ForeignKey("Pessoa_")]
        public virtual Pessoa Pessoa { get; set; }
    }
}
