using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models{
    public class Cliente{
		public string Id { get; set; }
        public string Nome{ get; set; }
		public string Cpf { get; set; }
		public string Cnpj { get; set; }
		public string Telefone { get; set; }
		public string Email { get; set; }
		public string DataIn { get; set; }
		public string DatUltAlt { get; set; }
		public string FglFisica { get; set; }
		public List<Endereco> End;

		public Cliente(string id, string nome, string cpf, string cnpj, string telefone, string email, string dataIn, string datUltAlt, string fglFisica)
		{
			this.Id = Id;
            this.Nome = nome;
			this.Cpf = cpf;
			this.Cnpj = cnpj;
			this.Telefone = Telefone;
			this.Email = email;
			this.DataIn = dataIn;
			this.DatUltAlt = datUltAlt;
			this.FglFisica = fglFisica;
            this.End = new List<Endereco>();

			
        }
    }
}