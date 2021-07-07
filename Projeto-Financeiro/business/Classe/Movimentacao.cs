using database;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business.Classe
{
    [Table("Movimentacao")]
    public abstract class Movimentacao : modelocrud
    {
        public Movimentacao()
        {
            Data = DateTime.Now;
        }

        public static int UltimoRegistro { get; set; }

        public double Valor { get; set; }
        public DateTime Data { get; set; }
    }
}
