using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models{
    public class Cliente{
		public int Id { get; set; }
        public string Nome{ get; set; }
		public string NomeFantasia{ get; set; }
		public string Cpf { get; set; }
		public string Cnpj { get; set; }
		public string TelefoneComercial{get; set;}
		public string InsEstadual{ get; set; }
		public string InsMunicipal{ get; set; }
		public string Celular { get; set; }
		public string Email { get; set; }
		public string DataIn { get; set; }
		public string DatUltAlt { get; set; }
		public string FglFisica { get; set; }
		public string Identidade { get; set; }
		public string Nascimento { get; set; }
		public string Pai { get; set; }
		public string Mãe { get; set; }
		public string Profissao { get; set; }
		public string OrgaoExpedidor { get; set; }
		public string Sexo { get; set; }
		public string EstadoCivil { get; set; }
		public List<Endereco> End;

		public Cliente(int Id, string Nome,string NomeFantasia, string Cpf, string Cnpj, string TelefoneComercial , string InsEstadual, string InsMunicipal, string Celular, string Email, string DataIn, string DatUltAlt, string FglFisica, string Identidade, string Nascimento, string Pai, string Mãe, string Profissao, string OrgaoExpedidor, string Sexo, string EstadoCivil )
		{
			this.Id = Id;
            this.Nome = Nome;
			this.NomeFantasia = NomeFantasia;
			this.Cpf = Cpf;
			this.Cnpj = Cnpj;
			this.TelefoneComercial = TelefoneComercial;
			this.InsEstadual = InsEstadual;
			this.InsMunicipal = InsMunicipal;
			this.Celular = Celular;
			this.Email = Email;
			this.DataIn = DataIn;
			this.DatUltAlt = DatUltAlt;
			this.FglFisica = FglFisica;
			this.Identidade = Identidade;
			this.Nascimento = Nascimento;
			this.Pai = Pai;
			this.Mãe = Mãe;
			this.Profissao = Profissao;
			this.OrgaoExpedidor = OrgaoExpedidor;
			this.Sexo = Sexo;
			this.EstadoCivil = EstadoCivil;
            this.End = new List<Endereco>();

			
        }
    }
}