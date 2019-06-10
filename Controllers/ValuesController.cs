using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Data.Odbc; //BIBLIOTECA ODBC, NECESSÁRIA PARA CONEXÃO COM O BANCO
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using Api.Models;


namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
		//private static List<Cliente> clientes = new List<Cliente>();
		Cliente listaProdutos = new Cliente();
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> Get()
        {
			//clientes.ConsultarClientes();

			return listaProdutos.ConsultarClientes(1);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IEnumerable<Cliente> Get( String Id)
        {
			List<Cliente> clientes = listaProdutos.ConsultarClientes(1);
            var cliente = from aux in clientes
                          where aux.ID_CLIENTE == Id
                          select aux;
                  
            return cliente;
        }
       

        // POST api/values
        [HttpPost]
        public void Post(String Nome1, String Nome_Fantasia, String FLG1, String CNPJ1, String Email1, String Tel_Comercial1, String Insc_Estadual1, String Insc_Municipal1, String Identidade1, String Celular1, String Pai1, String Mae1, String Profissao1, String Orgao_Expedidor1, String Sexo1, String Estado_Civil1, String ID_CLIENTE, String COD_TIPO_END, String CIDADE, String UF, String LOGRADOURO, String LOG_NUMERO, String COMPLEMENTO, String REFERENCIA, String BAIRRO, String CEP)
        {
           if (!string.IsNullOrEmpty(Nome) && string.IsNullOrEmpty(Logradouro) )
			{
				if (FLG1.ToString == "j" || FLG1.ToString == "J")
				{
					listaProdutos.insereJuridica(Nome1, Nome_Fantasia, FLG1, CNPJ1, Email1, Tel_Comercial1, Insc_Estadual1, Insc_Municipal1);
				}
				else if(FLG1.ToString == "f" || FLG11.ToString == "F")
				{
					listaProdutos.insereFisica(Nome1, FLG1, Identidade1, Email1, Celular1, Pai1, Mae1, Profissao1, Orgao_Expedidor1, Sexo1, Estado_Civil1);
				}
				
			}
			else
			{
				listaProdutos.insereEndereco(ID_CLIENTE, COD_TIPO_END, CIDADE, UF, LOGRADOURO, LOG_NUMERO, COMPLEMENTO, REFERENCIA, BAIRRO, CEP);
			} 
        }

        // PUT api/values/("{id}/{Nome}/{NomeFantasia}/{Cpf}/{Cnpj}/{TelefoneComercial}/{InsEstadual}/{InsMunicipal}/{Celular}/{Email}/{DataIn}/{DatUltAlt}/{Identidade}/{Nascimento}/{Pai}/{Mãe}/{Profissao}/{OrgaoExpedidor}/{Sexo}/{EstadoCivil}/{Tipo}/{Cidade}/{Estado}/{Logradouro}/{Numero}/{Complemento}/{Referencia
        [HttpPut]
        public void Put(String ID_UPDATE, String Nome, String Nome_Fantasia, String FLG, String Cnpj, String Email, String Tel_Comercial, String Insc_Estadual, String Insc_Municipal, String Identidade, String Celular, String Pai, String Mae, String Profissao,String Orgao_Expedidor,String Sexo, String Estado_Civil,String ID_CLIENTE,String COD_TIPO_END,String CIDADE,String UF,String LOGRADOURO,String LOG_NUMERO,String COMPLEMENTO,String REFERENCIA,String  BAIRRO,String CEP)
        {
			if (!string.IsNullOrEmpty(Nome) && string.IsNullOrEmpty(LOGRADOURO))
			{
				if (FLG.ToString == "j" || FLG.ToString == "J")
				{
					listaProdutos.insereJuridica(Nome1, Nome_Fantasia, FLG1, CNPJ1, Email1, Tel_Comercial1, Insc_Estadual1, Insc_Municipal1);
				}
				else if (FLG.ToString == "f" || FLG.ToString =="F")
				{
					listaProdutos.insereFisica(Nome1, FLG1, Identidade1, Email1, Celular1, Pai1, Mae1, Profissao1, Orgao_Expedidor1, Sexo1, Estado_Civil1);
				}

			}
			else
			{
				listaProdutos.updateEndereco(ID_CLIENTE, COD_TIPO_END, CIDADE, UF, LOGRADOURO, LOG_NUMERO, COMPLEMENTO, REFERENCIA, BAIRRO, CEP);
			}
		}
         
        /* DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            clientes.RemoveAt(clientes.IndexOf(clientes.First(x =>x.Id == id)));

        }*/
    }
}
