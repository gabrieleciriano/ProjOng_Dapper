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
    internal class AnimalRepository : IAnimalRepository
    {
        private string _conn;
        public AnimalRepository()
        {
            _conn = DataBaseConfiguration.Get();

        }
        public bool AddAnimal(Animal animal)
        {
            bool result = false;
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                db.Execute(Animal.INSERT_ONE, animal);
                result = true;
            }
            return result;
        }
        public List<Animal> GetAllAnimal()
        {
            throw new NotImplementedException();
        }
        public Animal GetOneAnimal(string chip)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var animal = db.QueryFirstOrDefault<Animal>(Animal.SELECT_ONE, new { CHIP = chip });
                return (Animal)animal;
            }
        }
        public bool UpdateFamilia(string chip, string familia)
        {
            bool updated = false;
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var execute = db.Execute(Animal.UPDATE_FAMILIA, new { CHIP = chip, Familia = familia});
                if (execute != 0) 
                {
                    updated = true;
                    return updated;
                }
            }
            return updated;
        }
        public bool UpdateRaca(string chip, string raca)
        {
            bool updated = false;
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var execute = db.Execute(Animal.UPDATE_RACA, new { CHIP = chip, Nome = raca });
                if (execute != 0)
                {
                    updated = true;
                    return updated;
                }
            }
            return updated;
        }
        public bool UpdateSexo(string chip, char sexo)
        {
            bool updated = false;
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var execute = db.Execute(Animal.UPDATE_SEXO, new { CHIP = chip, Sexo = sexo });
                if (execute != 0)
                {
                    updated = true;
                    return updated;
                }
            }
            return updated;
        }
        public bool UpdateNome(string chip, string nome)
        {
            bool updated = false;
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var execute = db.Execute(Animal.UPDATE_NOME, new { CHIP = chip, Nome = nome });
                if (execute != 0)
                {
                    updated = true;
                    return updated;
                }
            }
            return updated;
        }
        public bool DeleteOneAnimal(string chip)
        {
            bool deleted = false;
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var execute = db.Execute(Animal.DELETE_ONE, new { CHIP = chip });
                if (execute > 0)
                {
                    Console.WriteLine("O cadastro foi deletado com sucesso!");
                    deleted = true;
                    return deleted;
                }
            }
            return deleted;
        }
    }
}
