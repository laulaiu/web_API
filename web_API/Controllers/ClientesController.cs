using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using web_API.Models;

namespace web_API.Controllers
{
    public class ClientesController : ApiController
    {
        private static List<Cliente> clientes = new List<Cliente>();

        [HttpGet]
        public List<Cliente> ChamadaGet()
        {
            return clientes;
        }

        [HttpPost]
        public void ChamadaPost(string nome)
        {
            if (!string.IsNullOrEmpty(nome))
            {
                clientes.Add(new Cliente(nome));
            }            
        }
        
        [HttpDelete]
        public void Chamadadelete(string nome)
        {            
            clientes.RemoveAt(clientes.IndexOf(clientes.Find(x => x.nome.Equals(nome))));
        }

    }
}
