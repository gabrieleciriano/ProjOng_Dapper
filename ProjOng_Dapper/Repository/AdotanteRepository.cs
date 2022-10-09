using ProjOng_Dapper.Model;
using System;
using System.Collections.Generic;
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
            _conn = "";
        }
        public bool AddAdotante(Adotante adotante)
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

        public List<Adotante> GetAllAdotante()
        {
            throw new NotImplementedException();
        }

        public Adotante GetOneAdotante(string cpf)
        {
            throw new NotImplementedException();
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
    }
}
