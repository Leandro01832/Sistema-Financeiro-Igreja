using database;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace business.Classe
{
    [Table("Pessoa")]
    public abstract class Pessoa : modelocrud
    {
        public string Nome { get; set; }
        public virtual Contato Contato { get; set; }
        public virtual List<MovimentacaoEntrada> Receber { get; set; }
    }
}