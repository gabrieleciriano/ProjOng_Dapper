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
    internal class AdocaoRepository : IAdocaoRepository
    {
        private string _conn;
        public AdocaoRepository()
        {
            _conn = DataBaseConfiguration.Get();
        }
        public bool AddAdocao(Adocao adocao)
        {
            bool result = false;
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                db.Execute(Adocao.INSERT, adocao);
                result = true;
            }
            return result;
        }
        public bool DeleteOneAdocao(string cpf, int chip)
        {
            bool deleted = false;
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var execute = db.Execute(Adocao.DELETE_ONE, new { CPF = cpf, CHIP = chip });
                if (execute > 0)
                {
                    Console.WriteLine("O cadastro foi deletado com sucesso!");
                    deleted = true;
                    return deleted;
                }
            }
            return deleted;
        }
        public List<Adocao> GetAllAdocao()
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var adocao = db.Query<Adocao>(Adocao.SELECT_ALL);
                return (List<Adocao>)adocao;
            }
        }
        public Adocao GetOneAdocao(string cpf, int chip)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var adocao = db.QueryFirstOrDefault<Adocao>(Adocao.SELECT_ONE, new { CPF = cpf, CHIP = chip });
                return (Adocao)adocao;
            }
        }
    }
}
