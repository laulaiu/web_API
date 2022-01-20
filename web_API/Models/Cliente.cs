using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_API.Models
{
    public class Cliente
    {
        public string nome { get; set; }

        public Cliente(String nome)
        {
            this.nome = nome;

        }

    }
}