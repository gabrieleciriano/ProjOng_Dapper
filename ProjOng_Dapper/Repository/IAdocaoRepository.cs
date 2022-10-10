using ProjOng_Dapper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjOng_Dapper.Repository
{
    internal interface IAdocaoRepository
    {
        bool AddAdocao(Adocao adocao);
        List<Adocao> GetAllAdocao();
        Adocao GetOneAdocao(string cpf, int chip);
        bool DeleteOneAdocao(string cpf, int chip);
    }
}
