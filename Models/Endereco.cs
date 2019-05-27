using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models
{
	public class Endereco
	{
		public string Tipo { get; set; }
		public string Cidade { get; set; }
		public string Estado { get; set; }
		public string Logradouro { get; set; }
		public int Numero { get; set; }
		public string Complemento { get; set; }
		public string Referencia { get; set; }


		public Endereco(string Tipo, string Cidade, string Estado, string Logradouro, int Numero, string Complemento, string Referencia)
		{
			this.Tipo = Tipo;
			this.Cidade = Cidade;
			this.Estado = Estado;
			this.Logradouro = Logradouro;
			this.Numero = Numero;
			this.Complemento = Complemento;
			this.Referencia = Referencia;
		}
	}
}