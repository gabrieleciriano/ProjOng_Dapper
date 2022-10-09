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
        //passar os metodos do repository para a classe service p conseguir acessar na program
        //add todos os metodos aqui
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
        public bool UpdateNumero(string cpf, string numero)
        {
            return _adotanteRepository.UpdateNumero(cpf, numero);
        }
        public bool UpdateCEP(string cpf, string cep)
        {
            return _adotanteRepository.UpdateNumero(cpf, cep);
        }
        public bool UpdateBairro(string cpf, string bairro)
        {
            return _adotanteRepository.UpdateNumero(cpf, bairro);
        }
        public bool UpdateComplemento(string cpf, string complemento)
        {
            return _adotanteRepository.UpdateNumero(cpf, complemento);
        }
        public bool UpdateCidade(string cpf, string cidade)
        {
            return _adotanteRepository.UpdateNumero(cpf, cidade);
        }
        public bool UpdateUF(string cpf, string uf)
        {
            return _adotanteRepository.UpdateNumero(cpf, uf);
        }
        public bool UpdateTelefone(string cpf, string telefone)
        {
            return _adotanteRepository.UpdateNumero(cpf, telefone);
        }
        public bool DeleteOneAdotante(string cpf)
        {
            return _adotanteRepository.DeleteOneAdotante(cpf);
        }
    }
}
