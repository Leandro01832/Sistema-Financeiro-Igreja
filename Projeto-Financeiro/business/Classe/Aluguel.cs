using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business.Classe
{
    [Table("Aluguel")]
    public class Aluguel : MovimentacaoSaida
    {
        public string NomeProduto { get; set; }
    }
}
