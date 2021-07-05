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
        private DateTime data;

        public decimal Valor { get; set; }
        public DateTime Data
        {
            get { return data; }
            set { data = DateTime.Now; }
        }         
    }
}
