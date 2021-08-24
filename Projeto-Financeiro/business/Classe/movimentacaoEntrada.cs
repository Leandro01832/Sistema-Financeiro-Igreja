using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace business.Classe
{
    [Table("MovimentacaoEntrada")]
    public abstract class MovimentacaoEntrada : Movimentacao
    {
        public MovimentacaoEntrada()
        {

        }

        public DateTime? DataRecebimento { get; set; }
        public int? Pessoa_ { get; set; }
        [ForeignKey("Pessoa_")]
        public virtual Pessoa Pessoa { get; set; }
    }
}
