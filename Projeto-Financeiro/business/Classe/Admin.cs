﻿using database;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business.Classe
{
    [Table("Admin")]
    public class Admin : Pessoa
    {
        [Index("USER", 2, IsUnique = true)]
        [Column(TypeName = "varchar")]
        public string User { get; set; }
        public string Password { get; set; }
        public string Permissao { get; set; }

        [NotMapped]
        public static string PrimeiroAdminUser = "leandro";
        [NotMapped]
        public static string PrimeiroAdminPassword = "01832";
        [NotMapped]
        public static string PrimeiroAdminPermissao = "Aluguel, Cantina, Compra, Dizimo, Retiro, Transporte, Transacao";


        public bool verificarAutenticacao(Admin adm)
        {
            if (this.bd.Pessoa.OfType<Admin>().FirstOrDefault(m => m.User == adm.User) != null &&
                this.bd.Pessoa.OfType<Admin>().FirstOrDefault(m =>  m.Password == adm.Password) != null)
                return true;
            return false;
        }

        public bool verificarTodos()
        {
            bool condicao = false;
            var modelos = this.recuperar(typeof(Admin));

            if(modelos != null)
            foreach(var item in modelos.OfType<Admin>())
            {
                if (this.verificarAutenticacao(item)) condicao = true;
            }

            return condicao;
        }

        public bool verificarPermissao(string permissao)
        {
            if (this.Permissao.Contains(permissao)) return true;
            return false;
        }

    }


}