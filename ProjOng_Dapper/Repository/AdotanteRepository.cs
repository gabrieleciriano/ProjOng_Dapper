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
        public bool UpdateNome(string cpf, string nome)
        {
            bool updated = false;
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var execute = db.Execute(Adotante.UPDATE_NOME, new { Nome = nome, CPF = cpf });
                if (execute != 0) //ou seja, se realmente a string de execução for modificada
                {
                    //então, o dado daquela coluna foi atualizado (updated)
                    updated = true;
                    return updated;
                }
            }
            return updated;
        }
        public bool UpdateSexo(string cpf, char sexo)
        {
            bool updated = false;
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var execute = db.Execute(Adotante.UPDATE_SEXO, new { Sexo = sexo, CPF = cpf });
                if (execute != 0) //ou seja, se realmente a string de execução for modificada
                {
                    //então, o dado daquela coluna foi atualizado (updated)
                    updated = true;
                    return updated;
                }
            }
            return updated;
        }
        public bool UpdateDataNascimento(string cpf, DateTime datanasc)
        {
            bool updated = false;
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var execute = db.Execute(Adotante.UPDATE_DATANASC, new { DataNascimento = datanasc, CPF = cpf });
                if (execute != 0) //ou seja, se realmente a string de execução for modificada
                {
                    //então, o dado daquela coluna foi atualizado (updated)
                    updated = true;
                    return updated;
                }
            }
            return updated;

        }
        public bool UpdateLogradouro(string cpf, string logradouro)
        {
            throw new NotImplementedException();
        }
        public bool UpdateNumero(string cpf, string numero)
        {
            throw new NotImplementedException();
        }
        public bool UpdateCEP(string cpf, string cep)
        {
            throw new NotImplementedException();
        }
        public bool UpdateBairro(string cpf, string bairro)
        {
            bool updated = false;
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var execute = db.Execute(Adotante.UPDATE_BAIRRO, new { Bairro = bairro, CPF = cpf });
                if (execute !=0) //ou seja, se realmente a string de execução for modificada
                {
                    //então, o dado daquela coluna foi atualizado (updated)
                    updated = true;
                    return updated;
                }
            }
            return updated;
        }
        public bool UpdateComplemento(string cpf, string complemento)
        {
            throw new NotImplementedException();
        }
        public bool UpdateCidade(string cpf, string cidade)
        {
            throw new NotImplementedException();
        }
        public bool UpdateUF(string cpf, string uf)
        {
            throw new NotImplementedException();

        }

        public bool UpdateTelefone(string cpf, string telefone)
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
