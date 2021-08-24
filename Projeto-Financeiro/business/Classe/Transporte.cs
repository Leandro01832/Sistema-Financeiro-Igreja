using System.ComponentModel.DataAnnotations.Schema;

namespace business.Classe
{
    [Table("Transporte")]
    public class Transporte : MovimentacaoSaida
    {
        public bool Gasolina { get; set; }
        public bool Alcool { get; set; }
        public bool Diesel { get; set; }
    }
}
