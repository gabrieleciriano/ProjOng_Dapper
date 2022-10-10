using ProjOng_Dapper.Model;
using ProjOng_Dapper.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjOng_Dapper.Service
{
    internal class AdocaoService
    {
        private IAdocaoRepository _adocaoRepository;
        public AdocaoService()
        {
            _adocaoRepository = new AdocaoRepository();
        }
        public bool AddAdocao(Adocao adocao)
        {
            return _adocaoRepository.AddAdocao(adocao);
        }
        public List<Adocao> GetAllAdocao()
        {
            return _adocaoRepository.GetAllAdocao();
        }
        public Adocao GetOneAdocao(string cpf, int chip)
        {
            return _adocaoRepository.GetOneAdocao(cpf, chip);
        }
        public bool DeleteOneAdocao(string cpf, int chip)
        {
            return _adocaoRepository.DeleteOneAdocao(cpf, chip);
        }
    }
}
