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
        //declaração dos metodos
        //insert
        bool AddAdotante(Adotante adotante);
        //select all
        List<Adotante> GetAllAdotante();
        //select one
        Adotante GetOneAdotante(string cpf);
        //update de cada propriedade do Adotante menos o CPF
        bool UpdateNome(string cpf, string nome);
        bool UpdateSexo(string cpf, char sexo);
        bool UpdateDataNascimento(string cpf, string datanasc);
        bool UpdateLogradouro(string cpf, string logradouro);
        bool UpdateNumero(string cpf, string numero);
        bool UpdateCEP(string cpf, string cep);
        bool UpdateBairro(string cpf, string bairro);
        bool UpdateComplemento(string cpf, string complemento);
        bool UpdateCidade(string cpf, string cidade);
        bool UpdateUF(string cpf, string uf);
        bool UpdateTelefone(string cpf, string telefone);
        bool DeleteOneAdotante(string cpf);
    }
}
