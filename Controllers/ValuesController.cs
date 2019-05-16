using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Api.Models;


namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private static List<Cliente> clientes = new List<Cliente>();
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> Get()
        {
            return clientes;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IEnumerable<Cliente> Get([FromBody] string id)
        {
            var cliente = from aux in clientes
                          where aux.Id == id
                          select aux;
            return cliente;
        }

        // POST api/values
        [HttpPost]
        public void Post( string id, string nome, string cpf, string cnpj, string telefone, string email, string dataIn, string datUltAlt, string fglFisica)
        {
           if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(id))
			{
				clientes.Add(new Cliente(id, nome, cpf, cnpj, telefone, email, dataIn, datUltAlt, fglFisica));
			} 
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put([FromBody] string id, string nome, string cpf, string cnpj, string telefone, string email, string dataIn, string datUltAlt, string fglFisica, string tipo, string cidade, string estado, string logradouro, int numero, string complemento, string referencia)
        {
            var cliente = from aux in clientes
                          where aux.Id == id
                          select aux;
            foreach(Cliente c in cliente){
                if(c != null){
                    c.Nome = nome;
                    c.Cpf = cpf;
                    c.Cnpj = cnpj;
                    c.Telefone = telefone;
                    c.Email = email;
                    c.DataIn = dataIn;
                    c.DatUltAlt = datUltAlt;
                    c.FglFisica = fglFisica;
                    c.End.Add(new Endereco(tipo, cidade, estado, logradouro, numero, complemento, referencia));
                }
                
            }
        }
         
        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete([FromBody] string id)
        {
            clientes.RemoveAt(clientes.IndexOf(clientes.First(x =>x.Id.Equals(id))));

        }
    }
}
