using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Odbc;
using System.Data;
using System.ComponentModel;

namespace Api.Models{
	public class Cliente
	{
		//VARIÁVEIS DO CLIENTE
		public String CODIGO_CLIENTE { get; set; }
		public String ID_CLIENTE { get; set; }
		public String ID_IND { get; set; }
		public String COD_CIDADE { get; set; }
		public String NOME_CLIENTE { get; set; }
		public String NOME_FANTASIA { get; set; }
		public String FLG_FISICA { get; set; }
		public String FLG_CONTRIB_ICMS { get; set; }
		public String IDENTIDADE { get; set; }
		public String INSC_ESTADUAL { get; set; }
		public String INSC_MUNICIPAL { get; set; }
		public String CNPJ { get; set; }
		public String NASCIMENTO { get; set; }
		public String EMAIL { get; set; }
		public String HOMEPAGE { get; set; }
		public String DAT_INCLUSAO { get; set; }
		public String DAT_ULT_ALTER { get; set; }
		public String INSC_SUFRAMA { get; set; }
		public String MARCA { get; set; }
		public String TEL_RESIDENCIAL { get; set; }
		public String TEL_COMERCIAL { get; set; }
		public String CELULAR { get; set; }
		public String FAX { get; set; }
		public String NRO_COMPRAS { get; set; }
		public String VLR_VENDA { get; set; }
		public String ID_CATCRED { get; set; }
		public String NRO_MULT_COMISSAO { get; set; }
		public String ID_TIPO { get; set; }
		public String PAI { get; set; }
		public String MAE { get; set; }
		public String ATIVO { get; set; }
		public String PROFISSAO { get; set; }
		public String CONCEITO { get; set; }
		public String TURMA { get; set; }
		public String TURMA_DATA { get; set; }
		public String TURMA_VALOR { get; set; }
		public String RETEMISS { get; set; }
		public String DATA_RETORNO { get; set; }
		public String ORGAO_ESPEDIDOR { get; set; }
		public String EMPRESA_EM_QUE_TRABALHA { get; set; }
		public String MOSTRA_EM_RELATORIO { get; set; }
		public String PRECO_PRATICADO { get; set; }
		public String CAIXA { get; set; }
		public String TIPO_CAIXA { get; set; }
		public String PAGA_INSS { get; set; }
		public String RETEM_INSS { get; set; }
		public String ULTIMA_VENDA_FATURADA { get; set; }
		public String ULTIMO_PEDIDO_FATURADO { get; set; }
		public String ID_VENDEDOR { get; set; }
		public String ID_ROTA { get; set; }
		public String SENHA { get; set; }
		public String OBS { get; set; }
		public String ULTIMA_VENDA_FATURADA_DATA { get; set; }
		public String ART { get; set; }
		public String SEXO { get; set; }
		public String ESTADOCIVIL { get; set; }
		public String ID_TIPO_TAMANHO { get; set; }
		public String FUMANTE { get; set; }
		public String ALTURA { get; set; }
		public String PESO { get; set; }
		public String MANEQUIM { get; set; }
		public String ID_CONDICAO { get; set; }

		//VARIÁVEIS DE ENDEREÇO
		public String TIPO { get; set; }
		public String CIDADE { get; set; }
		public String ESTADO { get; set; }
		public String LOGRADOURO { get; set; }
		public String NUMERO { get; set; }
		public String COMPLEMENTO { get; set; }
		public String REFERENCIA { get; set; }
		public String COD_END { get; set; }
		public String BAIRRO { get; set; }
		public String CEP { get; set; }
		//TABELA CLIENTE DO BANCO DE DADOS
		/*
        CREATE TABLE "CLIENTES"

        (

          "CODIGO_CLIENTE" VARCHAR(25),

          "ID_CLIENTE" INTEGER NOT NULL,

          "ID_IND" INTEGER,

          "COD_CIDADE" INTEGER,

          "NOME_CLIENTE" VARCHAR(100) NOT NULL,

          "NOME_FANTASIA" VARCHAR(100),

          "FLG_FISICA" CHAR(1) NOT NULL,

          "FLG_CONTRIB_ICMS" CHAR(1) DEFAULT 'S',

          "IDENTIDADE" CHAR(20),

          "INSC_ESTADUAL" CHAR(20),

          "INSC_MUNICIPAL" CHAR(20),

          "CNPJ" CHAR(20) NOT NULL,

          "NASCIMENTO" TIMESTAMP,

          "EMAIL" CHAR(250),

          "HOMEPAGE" CHAR(250),

          "DAT_INCLUSAO" TIMESTAMP NOT NULL,

          "DAT_ULT_ALTER" TIMESTAMP NOT NULL,

          "INSC_SUFRAMA" CHAR(15),

          "MARCA" CHAR(50),

          "TEL_RESIDENCIAL" CHAR(20),

          "TEL_COMERCIAL" CHAR(20),

          "CELULAR" CHAR(20),

          "FAX" CHAR(20),

          "NRO_COMPRAS" SMALLINT,

          "VLR_VENDA" DOUBLE PRECISION DEFAULT 0,

          "ID_CATCRED" INTEGER,

          "NRO_MULT_COMISSAO" SMALLINT,

          "ID_TIPO" CHAR(5),

          "PAI" VARCHAR(100),

          "MAE" VARCHAR(100),

          "ATIVO" CHAR(1),

          "PROFISSAO" VARCHAR(50),

          "CONCEITO" VARCHAR(10),

          "TURMA" VARCHAR(20),

          "TURMA_DATA" TIMESTAMP,

          "TURMA_VALOR" DOUBLE PRECISION,

          "RETEMISS" CHAR(1),

          "DATA_RETORNO" TIMESTAMP,

          "ORGAO_ESPEDIDOR" VARCHAR(20),

          "EMPRESA_EM_QUE_TRABALHA" VARCHAR(50),

          "MOSTRA_EM_RELATORIO" CHAR(1),

          "PRECO_PRATICADO" VARCHAR(20),

          "CAIXA" DOUBLE PRECISION,

          "TIPO_CAIXA" CHAR(1),

          "PAGA_INSS" CHAR(1),

          "RETEM_INSS" CHAR(1),

          "ULTIMA_VENDA_FATURADA" INTEGER,

          "ULTIMO_PEDIDO_FATURADO" INTEGER,

          "ID_VENDEDOR" INTEGER,

          "ID_ROTA" INTEGER,

          "SENHA" CHAR(8),

          "OBS" BLOB SUB_TYPE TEXT SEGMENT SIZE 80,

          "ULTIMA_VENDA_FATURADA_DATA" TIMESTAMP,

          "ART" CHAR(20),

          "SEXO" CHAR(1),

          "ESTADOCIVIL" CHAR(1),

          "ID_TIPO_TAMANHO" INTEGER,

          "FUMANTE" CHAR(1),

          "ALTURA" DOUBLE PRECISION,

          "PESO" DOUBLE PRECISION,

          "MANEQUIM" DOUBLE PRECISION,

          "ID_CONDICAO" INTEGER,

        CONSTRAINT "PK_CLIENTE" PRIMARY KEY ("ID_CLIENTE")

        );
         */

		//VARIÁVEIS PARA COMANDOS ODBC
		public OdbcConnection objConexao;
		public OdbcCommand objCommand;
		public OdbcCommand objCommandEnd;

		//LISTANDO OS CLIENTES DO BANCO
		public List<Cliente> ConsultarClientes(int Choice)
		{
			//LISTA DE CLIENTES
			var listaRetorno = new List<Cliente>();
			//ABRINDO CONEXÃO
			//using (objConexao = new OdbcConnection("Dsn=FirebirdProgetec2;Uid=SYSDBA;Pwd=masterkey;")){  // BANCO OFICIAL PROGETEC
			using (objConexao = new OdbcConnection("Dsn=FirebirdPROGETEC;Uid=SYSDBA;Pwd=masterkey;")) // BANCO DE TESTES PROGETEC
			{ // BANCO DE TESTE PROGETEC
			  //SELECIONANDO OS DADOS QUE SE QUER MOSTRAR

				if (Choice == 1)
				{
					using (objCommand = new OdbcCommand("SELECT CODIGO_CLIENTE, ID_CLIENTE, NOME_CLIENTE, NOME_FANTASIA, FLG_FISICA, IDENTIDADE, INSC_ESTADUAL, INSC_MUNICIPAL, CNPJ, EMAIL, DAT_INCLUSAO, TEL_RESIDENCIAL, TEL_COMERCIAL, CELULAR, FAX, ATIVO  FROM CLIENTES", objConexao))
					{
						try
						{
							//CONEXÃO ABERTA
							objConexao.Open();

							//LISTANDO E COLOCANDO NA LISTA OS DADOS
							var objDataReader = objCommand.ExecuteReader();
							//SE POSSUIR DADOS NA TABELA
							if (objDataReader.HasRows)
								listaRetorno = PreencheValores(objDataReader);
							listaRetorno.OrderBy(c => c.CODIGO_CLIENTE).ToList();
						}
						catch (Exception ex)
						{
							throw new Exception(ex.Message);
						}
						finally
						{
							//CONEXÃO FECHADA
							objConexao.Close();
						}
					}
				}
				else if (Choice == 2)
				{
					using (objCommandEnd = new OdbcCommand("SELECT ID_CLIENTE, COD_END, COD_TIPO_END, CIDADE, UF, LOGRADOURO, LOG_NUMERO, COMPLEMENTO, REFERENCIA, BAIRRO, CEP FROM ENDERECOS", objConexao))
					{
						try
						{
							//CONEXÃO ABERTA
							objConexao.Open();

							//LISTANDO E COLOCANDO NA LISTA OS DADOS
							var objDataReader = objCommandEnd.ExecuteReader();
							//SE POSSUIR DADOS NA TABELA
							if (objDataReader.HasRows)
								listaRetorno = PreencheValoresEnd(objDataReader);
							listaRetorno.OrderBy(c => c.ID_CLIENTE).ToList();
						}
						catch (Exception ex)
						{
							throw new Exception(ex.Message);
						}
						finally
						{
							//CONEXÃO FECHADA
							objConexao.Close();
						}
					}
				}
			}
			return listaRetorno;
		}

		//PREENCHENDO A LISTA DE CLIENTES
		public List<Cliente> PreencheValores(OdbcDataReader reader)
		{
			//LISTA COM OS DADOS DE CADA CLIENTE
			var lista = new List<Cliente>();

			//PERCORRE TODA A TABELA
			while (reader.Read())
			{
				//NOVO CLIENTE
				var clientes = new Cliente();

				//VARIÁVEIS QUE SE QUER DA COLUNA DO CLIENTE
				clientes.CODIGO_CLIENTE = reader["CODIGO_CLIENTE"].ToString();
				clientes.ID_CLIENTE = reader["ID_CLIENTE"].ToString();
				clientes.NOME_CLIENTE = reader["NOME_CLIENTE"].ToString();
				clientes.NOME_FANTASIA = reader["NOME_FANTASIA"].ToString();
				clientes.FLG_FISICA = reader["FLG_FISICA"].ToString();
				clientes.IDENTIDADE = reader["IDENTIDADE"].ToString();
				clientes.INSC_ESTADUAL = reader["INSC_ESTADUAL"].ToString();
				clientes.INSC_MUNICIPAL = reader["INSC_MUNICIPAL"].ToString();
				clientes.CNPJ = reader["CNPJ"].ToString();
				clientes.EMAIL = reader["EMAIL"].ToString();
				clientes.DAT_INCLUSAO = reader["DAT_INCLUSAO"].ToString();
				clientes.TEL_RESIDENCIAL = reader["TEL_RESIDENCIAL"].ToString();
				clientes.TEL_COMERCIAL = reader["TEL_COMERCIAL"].ToString();
				clientes.CELULAR = reader["CELULAR"].ToString();
				clientes.FAX = reader["FAX"].ToString();
				clientes.ATIVO = reader["ATIVO"].ToString();

				//ADICIONANDO O CLIENTE NA LISTA
				lista.Add(clientes);
			}
			//RETORNA A LISTA COM TODOS OS CLIENTES E SEUS DADOS
			return lista;
		}

		//PREENCHE A LISTA DE ENDEREÇOS
		public List<Cliente> PreencheValoresEnd(OdbcDataReader reader)
		{
			//LISTA COM OS DADOS DE CADA CLIENTE
			var lista = new List<Cliente>();

			//PERCORRE TODA A TABELA
			while (reader.Read())
			{
				//NOVO ENDEREÇO
				var enderecos = new Cliente();

				//VARIÁVEIS QUE SE QUER DA COLUNA DE ENDEREÇO
				enderecos.ID_CLIENTE = reader["ID_CLIENTE"].ToString();
				enderecos.COD_END = reader["COD_END"].ToString();
				enderecos.TIPO = reader["COD_TIPO_END"].ToString();
				enderecos.CIDADE = reader["CIDADE"].ToString();
				enderecos.ESTADO = reader["UF"].ToString();
				enderecos.LOGRADOURO = reader["LOGRADOURO"].ToString();
				enderecos.NUMERO = reader["LOG_NUMERO"].ToString();
				enderecos.COMPLEMENTO = reader["COMPLEMENTO"].ToString();
				enderecos.REFERENCIA = reader["REFERENCIA"].ToString();
				enderecos.BAIRRO = reader["BAIRRO"].ToString();
				enderecos.CEP = reader["CEP"].ToString();

				//ADICIONANDO O ENDEREÇO NA LISTA
				lista.Add(enderecos);
			}
			//RETORNA A LISTA COM TODOS OS ENDEREÇOS E SEUS DADOS
			return lista;
		}
		/*
		public void mostrarClientes()
		{
			var listaProdutos = new Cliente().ConsultarClientes(1);
			if (listaProdutos != null && listaProdutos.Count > 0)
			{
				int x = 0;
				while (x < listaProdutos.Count)
				{
					Console.WriteLine(listaProdutos[x].CODIGO_CLIENTE + listaProdutos[x].ID_CLIENTE + listaProdutos[x].NOME_CLIENTE +
						listaProdutos[x].NOME_FANTASIA + listaProdutos[x].FLG_FISICA + listaProdutos[x].IDENTIDADE +
						listaProdutos[x].INSC_ESTADUAL + listaProdutos[x].INSC_MUNICIPAL + listaProdutos[x].CNPJ +
						listaProdutos[x].EMAIL + listaProdutos[x].DAT_INCLUSAO + listaProdutos[x].TEL_RESIDENCIAL +
						listaProdutos[x].TEL_COMERCIAL + listaProdutos[x].CELULAR + listaProdutos[x].FAX + listaProdutos[x].ATIVO);

					x++;
				}
			}
		}

		public void mostrarEnderecos()
		{
			var listaProdutos = new Cliente().ConsultarClientes(2);
			if (listaProdutos != null && listaProdutos.Count > 0)
			{
				int x = 0;
				while (x < listaProdutos.Count)
				{
					Console.WriteLine(listaProdutos[x].ID_CLIENTE + " -- " + listaProdutos[x].COD_END + " -- " + listaProdutos[x].TIPO +
						" -- " + listaProdutos[x].CIDADE + " -- " + listaProdutos[x].ESTADO + " -- " + listaProdutos[x].LOGRADOURO + " -- " + listaProdutos[x].NUMERO +
						" -- " + listaProdutos[x].COMPLEMENTO + " -- " + listaProdutos[x].REFERENCIA + " -- " + listaProdutos[x].BAIRRO + " -- " + listaProdutos[x].CEP);

					x++;
				}
			}
		}


		public void listarID(int ID)
		{
			var listaClientes = new Cliente().ConsultarClientes(1);
			int count = 0;
			while (count < listaClientes.Count)
			{
				if (listaClientes[count].ID_CLIENTE.ToString() == ID.ToString())
				{
					if (listaClientes != null && listaClientes.Count > 0)
					{

						Console.WriteLine("CODIGO: " + listaClientes[count].CODIGO_CLIENTE.ToString());
						Console.WriteLine("ID: " + listaClientes[count].ID_CLIENTE.ToString());
						Console.WriteLine("NOME: " + listaClientes[count].NOME_CLIENTE.ToString());
						Console.WriteLine("NOME FANTASIA" + listaClientes[count].NOME_FANTASIA.ToString());
						Console.WriteLine("FLG: " + listaClientes[count].FLG_FISICA.ToString());
						Console.WriteLine("IDENTIDADE: " + listaClientes[count].IDENTIDADE.ToString());
						Console.WriteLine("INSC. ESTADUAL: " + listaClientes[count].INSC_ESTADUAL.ToString());
						Console.WriteLine("INSC. MUNICIPAL: " + listaClientes[count].INSC_MUNICIPAL.ToString());
						Console.WriteLine("CNPJ: " + listaClientes[count].CNPJ.ToString());
						Console.WriteLine("EMAIL: " + listaClientes[count].EMAIL.ToString());
						Console.WriteLine("DATA DE INCLUSAO: " + listaClientes[count].DAT_INCLUSAO.ToString());
						Console.WriteLine("TEL. RESIDENCIAL: " + listaClientes[count].TEL_RESIDENCIAL.ToString());
						Console.WriteLine("TEL. COMERCIAL: " + listaClientes[count].TEL_COMERCIAL.ToString());
						Console.WriteLine("CELULAR: " + listaClientes[count].CELULAR.ToString());
						Console.WriteLine("FAX: " + listaClientes[count].FAX.ToString());
						Console.WriteLine("ATIVO: " + listaClientes[count].ATIVO.ToString());

					}
				}
				count++;
			}
		}*/

		public void insereJuridica(String Nome1, String Nome_Fantasia, String FLG1, String CNPJ1, String Email1, String Tel_Comercial1, String Insc_Estadual1, String Insc_Municipal1)
		{
			if (Nome1 == "" || Nome_Fantasia == "" || FLG1 == "" || CNPJ1 == "" || Email1 == "" || Tel_Comercial1 == "" || Insc_Estadual1 == "" || Insc_Municipal1 == "")
			{
				//ALERTA DE INSERÇÃO MAL SUCEDIDA
				Console.WriteLine("Insira Todos os Campos!");
			}
			else
			{
				//ABRINDO CONEXAO
				//OdbcConnection connection = new OdbcConnection("Dsn=FirebirdProgetec2;Uid=SYSDBA;Pwd=masterkey;"); // BANCO OFICIAL PROGETEC
				OdbcConnection connection = new OdbcConnection("Dsn=FirebirdPROGETEC;Uid=SYSDBA;Pwd=masterkey;"); // BANCO DE TESTE PROGETEC
				connection.Open();
				try
				{
					var listaClientes = new Cliente().ConsultarClientes(1);
					var ultimoCliente = listaClientes[listaClientes.Count - 1];
					int valor = Convert.ToInt32(ultimoCliente.ID_CLIENTE);

					//DADOS PARA A INSERÇÃO
					int ID = Convert.ToInt32(valor + 1);
					String CODIGO = Convert.ToString(ID);
					String Nome = Nome1;
					String NomeFantasia = Nome_Fantasia;
					Char FLG = Convert.ToChar(FLG1);
					int INCS_ESTADUAL = Convert.ToInt32(Insc_Estadual1);
					int INCS_MUNICIPAL = Convert.ToInt32(Insc_Municipal1);
					int CNPJ = Convert.ToInt32(CNPJ1);
					String EMAIL = Email1;

					DateTime DAT_INCLUSAO = new DateTime(2001, 01, 01, 00, 00, 00);
					//DateTime.TryParseExact(DAT_INCLUSAO1.Text, "MMddyyyy", null, DateTimeStyles.None, out DAT_INCLUSAO);          

					int TEL_COMERCIAL = Convert.ToInt32(Tel_Comercial1);
					Char ATIVO = 'S';

					//INSERINDO
					OdbcCommand objInsert = new OdbcCommand("INSERT INTO CLIENTES (CODIGO_CLIENTE, ID_CLIENTE, NOME_CLIENTE, NOME_FANTASIA, FLG_FISICA, INSC_ESTADUAL, INSC_MUNICIPAL, CNPJ, EMAIL, DAT_INCLUSAO, TEL_COMERCIAL, ATIVO, DAT_ULT_ALTER) VALUES('" + CODIGO + "', '" + ID + "', '" + Nome + "', '" + NomeFantasia + "', '" + FLG + "', '" + INCS_ESTADUAL + "', '" + INCS_MUNICIPAL + "', '" + CNPJ + "', '" + EMAIL + "', '" + DAT_INCLUSAO + "', '" + TEL_COMERCIAL + "', '" + ATIVO + "', '" + DAT_INCLUSAO + "')", connection);
					objInsert.ExecuteNonQuery();

					//FECHANDO CONEXÃO
					connection.Close();
				}
				catch (Exception ex)
				{
					throw new Exception(ex.Message);
				}
				finally
				{
					//CONEXÃO FECHADA
					connection.Close();
				}

			}
		}

		public void insereFisica(String Nome1, String FLG1, String Identidade1, String Email1, String Celular1, String Pai1, String Mae1, String Profissao1, String Orgao_Expedidor1, String Sexo1, String Estado_Civil1)
		{
			if (Nome1 == "" || FLG1 == "" || Identidade1 == "" || Email1 == "" || Celular1 == "" || Pai1 == "" || Mae1 == "" || Profissao1 == "" || Orgao_Expedidor1 == "" || Sexo1 == "" || Estado_Civil1 == "")
			{
				//ALERTA DE INSERÇÃO MAL SUCEDIDA
				Console.WriteLine("Insira Todos os Campos!");
			}
			else
			{
				//ABRINDO CONEXAO
				//OdbcConnection connection = new OdbcConnection("Dsn=FirebirdProgetec2;Uid=SYSDBA;Pwd=masterkey;"); // BANCO OFICIAL PROGETEC
				OdbcConnection connection = new OdbcConnection("Dsn=FirebirdPROGETEC;Uid=SYSDBA;Pwd=masterkey;"); // BANCO DE TESTE PROGETEC
				connection.Open();

				try
				{
					var listaClientes = new Cliente().ConsultarClientes(1);
					var ultimoCliente = listaClientes[listaClientes.Count - 1];
					int valor = Convert.ToInt32(ultimoCliente.ID_CLIENTE);

					//DADOS PARA A INSERÇÃO
					int ID = Convert.ToInt32(valor + 1);
					String CODIGO = Convert.ToString(ID);
					String Nome = Nome1;
					Char FLG = Convert.ToChar(FLG1);
					Int32 Identidade = Convert.ToInt32(Identidade1);
					String EMAIL = Email1;
					Int32 Celular = Convert.ToInt32(Celular1);
					String Pai = Pai1;
					String Mae = Mae1;
					String Profissao = Profissao1;
					String OrgaoExpedidor = Orgao_Expedidor1;
					Char Sexo = Convert.ToChar(Sexo1);
					Char EstadoCivil = Convert.ToChar(Estado_Civil1);
					Int32 CNPJ = 00000001;

					DateTime DAT_INCLUSAO = new DateTime(2001, 01, 01, 00, 00, 00);
					//DateTime.TryParseExact(DAT_INCLUSAO1.Text, "MMddyyyy", null, DateTimeStyles.None, out DAT_INCLUSAO);          

					Char ATIVO = 'S';

					//INSERINDO
					OdbcCommand objInsert = new OdbcCommand("INSERT INTO CLIENTES (CODIGO_CLIENTE, ID_CLIENTE, NOME_CLIENTE, FLG_FISICA, IDENTIDADE, EMAIL, CELULAR, PAI, DAT_INCLUSAO, MAE, ATIVO, DAT_ULT_ALTER, PROFISSAO, ORGAO_ESPEDIDOR, SEXO, ESTADOCIVIL, CNPJ) VALUES('" + CODIGO + "', '" + ID + "', '" + Nome + "', '" + FLG + "', '" + Identidade + "', '" + EMAIL + "', '" + Celular + "', '" + Pai + "', '" + DAT_INCLUSAO + "', '" + Mae + "', '" + ATIVO + "', '" + DAT_INCLUSAO + "', '" + Profissao + "', '" + OrgaoExpedidor + "', '" + Sexo + "', '" + EstadoCivil + "', '" + CNPJ + "')", connection);
					objInsert.ExecuteNonQuery();
					//FECHANDO CONEXÃO
					connection.Close();
				}
				catch (Exception ex)
				{
					throw new Exception(ex.Message);
				}
				finally
				{
					//CONEXÃO FECHADA
					connection.Close();
				}
			}
		}

		public void insereEndereco(String ID_CLIENTE4, String COD_TIPO_END4, String CIDADE4, String UF4, String LOGRADOURO4, String LOG_NUMERO4, String COMPLEMENTO4, String REFERENCIA4, String BAIRRO4, String CEP4)
		{
			if (ID_CLIENTE4 == "" || COD_TIPO_END4 == "" || CIDADE4 == "" || UF4 == "" || LOGRADOURO4 == "" || LOG_NUMERO4 == "" || COMPLEMENTO4 == "" || REFERENCIA4 == "" || BAIRRO4 == "" || CEP4 == "")
			{
				//ALERTA DE INSERÇÃO MAL SUCEDIDA
				Console.WriteLine("Insira Todos os Campos!");
			}
			else
			{
				//ABRINDO CONEXAO
				//OdbcConnection connection = new OdbcConnection("Dsn=FirebirdProgetec2;Uid=SYSDBA;Pwd=masterkey;"); // BANCO OFICIAL PROGETEC
				OdbcConnection connection = new OdbcConnection("Dsn=FirebirdPROGETEC;Uid=SYSDBA;Pwd=masterkey;"); // BANCO DE TESTE PROGETEC
				connection.Open();
				try
				{
					var listaEnderecos = new Cliente().ConsultarClientes(2);

					//DADOS PARA A INSERÇÃO
					var ultimoEndereco = listaEnderecos[listaEnderecos.Count - 1];
					int valor = Convert.ToInt32(ultimoEndereco.COD_END);
					Console.WriteLine(valor);
					int COD_END1 = Convert.ToInt32(valor + 1);

					int ID = Convert.ToInt32(ID_CLIENTE4);
					int COD_TIPO_END1 = Convert.ToInt32(COD_TIPO_END4);
					String CIDADE1 = CIDADE4;
					String UF1 = UF4;
					String LOGRADOURO1 = LOGRADOURO4;
					String LOG_NUMERO1 = LOG_NUMERO4;
					String COMPLEMENTO1 = COMPLEMENTO4;
					String REFERENCIA1 = REFERENCIA4;
					String BAIRRO1 = BAIRRO4;
					String CEP1 = CEP4;

					//INSERINDO
					OdbcCommand objInsert = new OdbcCommand("INSERT INTO ENDERECOS (ID_CLIENTE, COD_END, COD_TIPO_END, CIDADE, UF, LOGRADOURO, LOG_NUMERO, COMPLEMENTO, REFERENCIA, BAIRRO, CEP) VALUES('" + ID + "', '" + COD_END1 + "', '" + COD_TIPO_END1 + "', '" + CIDADE1 + "', '" + UF1 + "', '" + LOGRADOURO1 + "', '" + LOG_NUMERO1 + "', '" + COMPLEMENTO1 + "', '" + REFERENCIA1 + "', '" + BAIRRO1 + "', '" + CEP1 + "')", connection);
					objInsert.ExecuteNonQuery();

					//FECHANDO CONEXÃO
					connection.Close();
				}
				catch (Exception ex)
				{
					throw new Exception(ex.Message);
				}
				finally
				{
					//CONEXÃO FECHADA
					connection.Close();
				}
			}
		}
		/*
		public void listarPessoaF()
		{
			var listaClientes = new Cliente().ConsultarClientes(1);
			int count = 0;
			while (count < listaClientes.Count)
			{
				if (listaClientes[count].FLG_FISICA.ToString() == "F" || listaClientes[count].FLG_FISICA.ToString() == "f")
				{
					if (listaClientes != null && listaClientes.Count > 0)
					{

						Console.WriteLine("CODIGO: " + listaClientes[count].CODIGO_CLIENTE.ToString());
						Console.WriteLine("ID: " + listaClientes[count].ID_CLIENTE.ToString());
						Console.WriteLine("NOME: " + listaClientes[count].NOME_CLIENTE.ToString());
						Console.WriteLine("NOME FANTASIA" + listaClientes[count].NOME_FANTASIA.ToString());
						Console.WriteLine("FLG: " + listaClientes[count].FLG_FISICA.ToString());
						Console.WriteLine("IDENTIDADE: " + listaClientes[count].IDENTIDADE.ToString());
						Console.WriteLine("INSC. ESTADUAL: " + listaClientes[count].INSC_ESTADUAL.ToString());
						Console.WriteLine("INSC. MUNICIPAL: " + listaClientes[count].INSC_MUNICIPAL.ToString());
						Console.WriteLine("CNPJ: " + listaClientes[count].CNPJ.ToString());
						Console.WriteLine("EMAIL: " + listaClientes[count].EMAIL.ToString());
						Console.WriteLine("DATA DE INCLUSAO: " + listaClientes[count].DAT_INCLUSAO.ToString());
						Console.WriteLine("TEL. RESIDENCIAL: " + listaClientes[count].TEL_RESIDENCIAL.ToString());
						Console.WriteLine("TEL. COMERCIAL: " + listaClientes[count].TEL_COMERCIAL.ToString());
						Console.WriteLine("CELULAR: " + listaClientes[count].CELULAR.ToString());
						Console.WriteLine("FAX: " + listaClientes[count].FAX.ToString());
						Console.WriteLine("ATIVO: " + listaClientes[count].ATIVO.ToString());

					}
				}
				count++;
			}
		}

		public void listarPessoaJ()
		{
			var listaClientes = new Cliente().ConsultarClientes(1);
			int count = 0;
			while (count < listaClientes.Count)
			{
				if (listaClientes[count].FLG_FISICA.ToString() == "j" || listaClientes[count].FLG_FISICA.ToString() == "J")
				{
					if (listaClientes != null && listaClientes.Count > 0)
					{

						Console.WriteLine("CODIGO: " + listaClientes[count].CODIGO_CLIENTE.ToString());
						Console.WriteLine("ID: " + listaClientes[count].ID_CLIENTE.ToString());
						Console.WriteLine("NOME: " + listaClientes[count].NOME_CLIENTE.ToString());
						Console.WriteLine("NOME FANTASIA" + listaClientes[count].NOME_FANTASIA.ToString());
						Console.WriteLine("FLG: " + listaClientes[count].FLG_FISICA.ToString());
						Console.WriteLine("IDENTIDADE: " + listaClientes[count].IDENTIDADE.ToString());
						Console.WriteLine("INSC. ESTADUAL: " + listaClientes[count].INSC_ESTADUAL.ToString());
						Console.WriteLine("INSC. MUNICIPAL: " + listaClientes[count].INSC_MUNICIPAL.ToString());
						Console.WriteLine("CNPJ: " + listaClientes[count].CNPJ.ToString());
						Console.WriteLine("EMAIL: " + listaClientes[count].EMAIL.ToString());
						Console.WriteLine("DATA DE INCLUSAO: " + listaClientes[count].DAT_INCLUSAO.ToString());
						Console.WriteLine("TEL. RESIDENCIAL: " + listaClientes[count].TEL_RESIDENCIAL.ToString());
						Console.WriteLine("TEL. COMERCIAL: " + listaClientes[count].TEL_COMERCIAL.ToString());
						Console.WriteLine("CELULAR: " + listaClientes[count].CELULAR.ToString());
						Console.WriteLine("FAX: " + listaClientes[count].FAX.ToString());
						Console.WriteLine("ATIVO: " + listaClientes[count].ATIVO.ToString());

					}
				}
				count++;
			}
		}

		public void listarIDEnd(int ID)
		{
			var listaEnderecos = new Cliente().ConsultarClientes(2);
			int count = 0;
			while (count < listaEnderecos.Count)
			{
				if (listaEnderecos[count].ID_CLIENTE.ToString() == ID.ToString())
				{
					if (listaEnderecos != null && listaEnderecos.Count > 0)
					{
						Console.WriteLine("ID CLIENTE: " + listaEnderecos[count].ID_CLIENTE.ToString());
						Console.WriteLine("CODIGO ENDEREÇO: " + listaEnderecos[count].COD_END.ToString());
						Console.WriteLine("TIPO ENDEREÇO: " + listaEnderecos[count].TIPO.ToString());
						Console.WriteLine("CIDADE: " + listaEnderecos[count].CIDADE.ToString());
						Console.WriteLine("ESTADO: " + listaEnderecos[count].ESTADO.ToString());
						Console.WriteLine("LOGRADOURO: " + listaEnderecos[count].LOGRADOURO.ToString());
						Console.WriteLine("NUMERO: " + listaEnderecos[count].NUMERO.ToString());
						Console.WriteLine("COMPLEMENTO: " + listaEnderecos[count].COMPLEMENTO.ToString());
						Console.WriteLine("REFERENCIA: " + listaEnderecos[count].REFERENCIA.ToString());
						Console.WriteLine("BAIRRO: " + listaEnderecos[count].BAIRRO.ToString());
						Console.WriteLine("CEP: " + listaEnderecos[count].CEP.ToString());
						Console.WriteLine("");
						Console.WriteLine("");
						Console.WriteLine("");
					}
				}
				count++;
			}
		}*/

	}

}