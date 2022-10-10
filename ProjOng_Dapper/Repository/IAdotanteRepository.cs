using ProjOng_Dapper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjOng_Dapper.Repository
{
    public interface IAdotanteRepository
    {
        
        bool AddAdotante(Adotante adotante);
        List<Adotante> GetAllAdotante();
        Adotante GetOneAdotante(string cpf);
        bool UpdateNome(string cpf, string nome);
        bool UpdateSexo(string cpf, char sexo);
        bool UpdateDataNascimento(string cpf, string datanasc);
        bool UpdateLogradouro(string cpf, string logradouro);
        bool UpdateNumero(string cpf, int numero);
        bool UpdateCEP(string cpf, int cep);
        bool UpdateBairro(string cpf, string bairro);
        bool UpdateComplemento(string cpf, string complemento);
        bool UpdateCidade(string cpf, string cidade);
        bool UpdateUF(string cpf, string uf);
        bool UpdateTelefone(string cpf, string telefone);
        bool DeleteOneAdotante(string cpf);
    }
}
