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
        public IEnumerable<Cliente> Get( int Id)
        {
            var cliente = from aux in clientes
                          where aux.Id == Id
                          select aux;
                  
            return cliente;
        }
        public bool Verication( int Id){

            bool aux = true;
            foreach(Cliente c in clientes){
                if(c.Id == Id){
                    aux = false;
                }
            }
            return aux;

        }
        // POST api/values
        [HttpPost]
        public void Post(int Id, string Nome,string NomeFantasia, string Cpf, string Cnpj, string TelefoneComercial , string InsEstadual, string InsMunicipal, string Celular, string Email, string DataIn, string DatUltAlt, string FglFisica, string Identidade, string Nascimento, string Pai, string Mãe, string Profissao, string OrgaoExpedidor, string Sexo, string EstadoCivil )
        {
           if (!string.IsNullOrEmpty(Nome))
			{
                if(Verication(Id)){
				    clientes.Add(new Cliente(Id, Nome, NomeFantasia, Cpf, Cnpj, TelefoneComercial , InsEstadual, InsMunicipal, Celular, Email, DataIn, DatUltAlt, FglFisica, Identidade, Nascimento, Pai, Mãe, Profissao, OrgaoExpedidor, Sexo, EstadoCivil ));
                }
            } 
        }

        // PUT api/values/("{id}/{Nome}/{NomeFantasia}/{Cpf}/{Cnpj}/{TelefoneComercial}/{InsEstadual}/{InsMunicipal}/{Celular}/{Email}/{DataIn}/{DatUltAlt}/{Identidade}/{Nascimento}/{Pai}/{Mãe}/{Profissao}/{OrgaoExpedidor}/{Sexo}/{EstadoCivil}/{Tipo}/{Cidade}/{Estado}/{Logradouro}/{Numero}/{Complemento}/{Referencia
        [HttpPut]
        public void Put(int Id, string Nome,string NomeFantasia, string Cpf, string Cnpj, string TelefoneComercial , string InsEstadual, string InsMunicipal, string Celular, string Email, string DataIn, string DatUltAlt, string FglFisica, string Identidade, string Nascimento, string Pai, string Mãe, string Profissao, string OrgaoExpedidor, string Sexo, string EstadoCivil,string Tipo, string Cidade, string Estado, string Logradouro, int Numero, string Complemento, string Referencial )
        {
            var cliente = from aux in clientes
                          where aux.Id == Id
                          select aux;
            foreach(Cliente c in cliente){
                if(c != null){
                    c.Id = Id;
                    c.Nome = Nome;
                    c.Nome = NomeFantasia;
                    c.Cpf = Cpf;
                    c.Cnpj = Cnpj;
                    c.TelefoneComercial = TelefoneComercial;
                    c.InsEstadual = InsEstadual;
                    c.InsMunicipal = InsMunicipal;
                    c.Celular = Celular;
                    c.Email = Email;
                    c.DataIn = DataIn;
                    c.DatUltAlt = DatUltAlt;
                    c.FglFisica = FglFisica;
                    c.Identidade = Identidade;
                    c.Nascimento = Nascimento;
                    c.Pai = Pai;
                    c.Mãe = Mãe;
                    c.Profissao = Profissao;
                    c.OrgaoExpedidor = OrgaoExpedidor;
                    c.Sexo = Sexo;
                    c.EstadoCivil = EstadoCivil;

                    c.End.Add(new Endereco(Tipo, Cidade, Estado, Logradouro, Numero, Complemento, Referencial));
                }
                
            }
        }
         
        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            clientes.RemoveAt(clientes.IndexOf(clientes.First(x =>x.Id == id)));

        }
    }
}
