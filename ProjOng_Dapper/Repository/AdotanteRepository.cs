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
            _conn = DataBaseConfiguration.Get();
        }
        public bool AddAdotante(Adotante adotante)
        {
            bool result = false;
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                db.Execute(Adotante.INSERT, adotante);
                result = true;
            }
            return result;
        }
        public List<Adotante> GetAllAdotante()
        {
            throw new NotImplementedException();

        }
        public Adotante GetOneAdotante(string cpf)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var adotante = db.QueryFirstOrDefault<Adotante>(Adotante.SELECTONE, new { CPF = cpf });
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
        public bool UpdateDataNascimento(string cpf, string datanasc)
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
            bool updated = false;
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var execute = db.Execute(Adotante.UPDATE_LOGRADOURO, new { Logradouro = logradouro, CPF = cpf });
                if (execute != 0) //ou seja, se realmente a string de execução for modificada
                {
                    //então, o dado daquela coluna foi atualizado (updated)
                    updated = true;
                    return updated;
                }
            }
            return updated;
        }
        public bool UpdateNumero(string cpf, int numero)
        {
            bool updated = false;
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var execute = db.Execute(Adotante.UPDATE_NUMERO, new { CPF = cpf, Numero = numero });
                if (execute != 0) //ou seja, se realmente a string de execução for modificada
                {
                    //então, o dado daquela coluna foi atualizado (updated)
                    updated = true;
                    return updated;
                }
            }
            return updated;
        }
        public bool UpdateCEP(string cpf, int cep)
        {
            bool updated = false;
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var execute = db.Execute(Adotante.UPDATE_CEP, new { CPF = cpf, CEP = cep });
                if (execute != 0) //ou seja, se realmente a string de execução for modificada
                {
                    //então, o dado daquela coluna foi atualizado (updated)
                    updated = true;
                    return updated;
                }
            }
            return updated;
        }
        public bool UpdateBairro(string cpf, string bairro)
        {
            bool updated = false;
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var execute = db.Execute(Adotante.UPDATE_BAIRRO, new { CPF = cpf, Bairro = bairro });
                if (execute != 0) //ou seja, se realmente a string de execução for modificada
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
            bool updated = false;
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var execute = db.Execute(Adotante.UPDATE_COMPLEMENTO, new { CPF = cpf, Complemento = complemento, });
                if (execute != 0) //ou seja, se realmente a string de execução for modificada
                {
                    //então, o dado daquela coluna foi atualizado (updated)
                    updated = true;
                    return updated;
                }
            }
            return updated;
        }
        public bool UpdateCidade(string cpf, string cidade)
        {
            bool updated = false;
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var execute = db.Execute(Adotante.UPDATE_CIDADE, new { CPF = cpf, Cidade = cidade, });
                if (execute != 0) //ou seja, se realmente a string de execução for modificada
                {
                    //então, o dado daquela coluna foi atualizado (updated)
                    updated = true;
                    return updated;
                }
            }
            return updated;
        }
        public bool UpdateUF(string cpf, string uf)
        {
            bool updated = false;
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var execute = db.Execute(Adotante.UPDATE_UF, new { CPF = cpf, UF = uf, });
                if (execute != 0) //ou seja, se realmente a string de execução for modificada
                {
                    //então, o dado daquela coluna foi atualizado (updated)
                    updated = true;
                    return updated;
                }
            }
            return updated;
        }
        public bool UpdateTelefone(string cpf, string telefone)
        {
            bool updated = false;
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var execute = db.Execute(Adotante.UPDATE_TELEFONE, new { CPF = cpf, Telefone = telefone, });
                if (execute != 0) //ou seja, se realmente a string de execução for modificada
                {
                    //então, o dado daquela coluna foi atualizado (updated)
                    updated = true;
                    return updated;
                }
            }
            return updated;
        }
        public bool DeleteOneAdotante(string cpf)
        {
            bool deleted = false;
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var execute = db.Execute(Adotante.DELETE_ONE, new { CPF = cpf });
                if (execute > 0) //ou seja, se realmente a string de execução for executada
                {
                    Console.WriteLine("O cadastro foi deletado com sucesso!");
                    //então, o dado daquela coluna foi deletado (deleted)
                    deleted = true;
                    return deleted;
                }
            }
            return deleted;
        }
        //verificar se o CPF existe
    }
}