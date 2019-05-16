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


		public Endereco(string tipo, string cidade, string estado, string logradouro, int numero, string complemento, string referencia)
		{
			this.Tipo= tipo;
			this.Cidade = cidade;
			this.Estado = estado;
			this.Logradouro = logradouro;
			this.Numero = numero;
			this.Complemento = complemento;
			this.Referencia = referencia;
		}
	}
}