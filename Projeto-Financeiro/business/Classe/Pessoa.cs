using database;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace business.Classe
{
    [Table("Pessoa")]
    public abstract class Pessoa : modelocrud
    {
        public Pessoa()
        {
            Contato = new Contato();
        }

        [NotMapped]
        public static int UltimoRegistro { get; set; }
        public string Nome { get; set; }
        public virtual Contato Contato { get; set; }
        public virtual List<MovimentacaoEntrada> Receber { get; set; }

        public override string ToString()
        {
            if (modelocrud.condicaoTexto == 1)
                return "Identificação: " + this.Id.ToString() + " - " + this.Nome;
            else
            return base.ToString();
        }
    }
}