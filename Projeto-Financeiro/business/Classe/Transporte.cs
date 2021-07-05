using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
