using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjOng_Dapper.Model
{
    public class Adotante
    {
        #region Properties
        public string Nome { get; set; }
        public string CPF { get; set; }
        public char Sexo { get; set; }
        public string DataNascimento { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Telefone { get; set; }
        #endregion
        #region ConstantInsert
        public readonly static string INSERT = "INSERT INTO dbo.Adotante (Nome, CPF, Sexo, DataNascimento, Logradouro, Numero, CEP, Bairro, Complemento, Cidade, UF, Telefone) VALUES (@Nome, @CPF, @Sexo, @DataNascimento, @Logradouro, @Numero, @CEP, @Bairro, @Complemento, @Cidade, @UF, @Telefone)";
        #endregion
        #region SelectAll
        public readonly static string SELECT = "SELECT Nome, CPF, Sexo, DataNascimento, Logradouro, Numero, CEP, Bairro, Complemento, Cidade, UF, Telefone FROM dbo.Adotante";
        #endregion
        #region SelectOneSpecific
        public readonly static string SELECTONE = "SELECT Nome, CPF, Sexo, DataNascimento, Logradouro, Numero, CEP, Bairro, Complemento, Cidade, UF, Telefone FROM dbo.Adotante WHERE CPF = @CPF";
        #endregion
        #region DeleteOne
        public readonly static string DELETEONE = "DELETE FROM dbo.Adotante WHERE CPF = @CPF";
        #endregion
        #region DeleteAll
        public readonly static string DELETEALL = "DELETE FROM dbo.Adotante";
        #endregion
        //fazer o update de cada propriedade
        public override string ToString()
        {
            return $"CPF: {this.CPF} \nNome: {this.Nome} \nSexo: {this.Sexo} \nData de Nascimento: {this.DataNascimento} \nEndereco: \nLogradouro {this.Logradouro}, Numero: {this.Numero}, CEP: {this.CEP}, Bairro: {this.Bairro}, Complemento: {this.Complemento}, Cidade: {this.Cidade}, UF: {this.UF}, Telefone: {this.Telefone}".ToString();
        }
    }
}
