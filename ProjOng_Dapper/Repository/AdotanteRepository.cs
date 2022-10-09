using Dapper;
using ProjOng_Dapper.Config;
using ProjOng_Dapper.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjOng_Dapper.Repository
{
    public class AdotanteRepository : IAdotanteRepository
    {
        private string _conn;
        public AdotanteRepository()
        {
            //Passar a string de conexão
            _conn = DataBaseConfiguration.Get();
        }

        public bool AddAdotante(Adotante adotante)
        {
            bool result = false;
            using(var db = new SqlConnection(_conn))
            {
                db.Open();
                db.Execute(Adotante.INSERT, adotante);
                result = true;
                //nao preciso de um close se estou usando o using
                //o objeto de conexão db é destruido apos a utilização do using
            }
            return result;
        }
        public List<Adotante> GetAllAdotante()
        {
            using(var db = new SqlConnection(_conn))
            {
                db.Open();
                var adotantes = db.Query<Adotante>(Adotante.SELECT);
                return (List<Adotante>) adotantes;
            }
        }
        public Adotante GetOneAdotante(string cpf)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var adotante = db.QueryFirstOrDefault<Adotante>(Adotante.SELECTONE, new {CPF = cpf });
                return (Adotante) adotante;
            }
        }
        public bool UpdateBairro(string cpf, string bairro)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCEP(string cpf, string cep)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCidade(string cpf, string cidade)
        {
            throw new NotImplementedException();
        }

        public bool UpdateComplemento(string cpf, string complemento)
        {
            throw new NotImplementedException();
        }

        public bool UpdateDataNascimento(string cpf, DateTime datanasc)
        {
            throw new NotImplementedException();
        }

        public bool UpdateLogradouro(string cpf, string logradouro)
        {
            throw new NotImplementedException();
        }

        public bool UpdateNome(string cpf, string nome)
        {
            throw new NotImplementedException();
        }

        public bool UpdateNumero(string cpf, string numero)
        {
            throw new NotImplementedException();
        }

        public bool UpdateSexo(string cpf, char sexo)
        {
            throw new NotImplementedException();
        }

        public bool UpdateTelefone(string cpf, string telefone)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUF(string cpf, string uf)
        {
            throw new NotImplementedException();
        }
        public bool DeleteAllAdotante(List<Adotante> adotantes)
        {
            throw new NotImplementedException();
        }

        public bool DeleteOneAdotante(string cpf)
        {
            throw new NotImplementedException();
        }
    }
}
