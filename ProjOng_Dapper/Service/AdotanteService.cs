using ProjOng_Dapper.Model;
using ProjOng_Dapper.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjOng_Dapper.Service
{
    internal class AdotanteService
    {
        private IAdotanteRepository _adotanteRepository;

        public AdotanteService()
        {
            _adotanteRepository = new AdotanteRepository();

        }
        public bool AddAdotante(Adotante adotante)
        {
            return _adotanteRepository.AddAdotante(adotante);
        }
        public List<Adotante> GetAllAdotante()
        {
            return _adotanteRepository.GetAllAdotante();
        }
        public Adotante GetOneAdotante(string cpf)
        {
            return _adotanteRepository.GetOneAdotante(cpf);
        }
        public bool UpdateNome(string cpf, string nome)
        {
            return _adotanteRepository.UpdateNome(cpf, nome);
        }
        public bool UpdateSexo(string cpf, char sexo)
        {
            return _adotanteRepository.UpdateSexo(cpf, sexo);
        }
        public bool UpdateDataNascimento(string cpf, string datanasc)
        {
            return _adotanteRepository.UpdateDataNascimento(cpf, datanasc);
        }
        public bool UpdateLogradouro(string cpf, string logradouro)
        {
            return _adotanteRepository.UpdateLogradouro(cpf, logradouro);
        }
        public bool UpdateNumero(string cpf, int numero)
        {
            return _adotanteRepository.UpdateNumero(cpf, numero);
        }
        public bool UpdateCEP(string cpf, int cep)
        {
            return _adotanteRepository.UpdateCEP(cpf, cep);
        }
        public bool UpdateBairro(string cpf, string bairro)
        {
            return _adotanteRepository.UpdateBairro(cpf, bairro);
        }
        public bool UpdateComplemento(string cpf, string complemento)
        {
            return _adotanteRepository.UpdateComplemento(cpf, complemento);
        }
        public bool UpdateCidade(string cpf, string cidade)
        {
            return _adotanteRepository.UpdateCidade(cpf, cidade);
        }
        public bool UpdateUF(string cpf, string uf)
        {
            return _adotanteRepository.UpdateUF(cpf, uf);
        }
        public bool UpdateTelefone(string cpf, string telefone)
        {
            return _adotanteRepository.UpdateTelefone(cpf, telefone);
        }
        public bool DeleteOneAdotante(string cpf)
        {
            return _adotanteRepository.DeleteOneAdotante(cpf);
        }
    }
}
