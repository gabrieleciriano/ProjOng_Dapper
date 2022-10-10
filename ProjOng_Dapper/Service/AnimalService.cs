using ProjOng_Dapper.Model;
using ProjOng_Dapper.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjOng_Dapper.Service
{
    internal class AnimalService
    {
        private IAnimalRepository _animalRepository;
        public AnimalService()
        {
            _animalRepository = new AnimalRepository();
        }
        public bool AddAnimal(Animal animal)
        {
            return _animalRepository.AddAnimal(animal);
        }
        public List<Animal> GetAllAnimal()
        {
            return _animalRepository.GetAllAnimal();
        }
        public Animal GetOneAnimal(string chip)
        {
            return _animalRepository.GetOneAnimal(chip);
        }
        public bool UpdateFamilia(string cpf, string familia)
        {
            return _animalRepository.UpdateFamilia(cpf, familia);
        }
        public bool UpdateRaca(string cpf, string raca)
        {
            return _animalRepository.UpdateRaca(cpf, raca);
        }
        public bool UpdateSexo(string cpf, char sexo)
        {
            return _animalRepository.UpdateSexo(cpf, sexo);
        }
        public bool UpdateNome(string cpf, string nome)
        {
            return _animalRepository.UpdateNome(cpf, nome);
        }
        public bool DeleteOneAnimal(string chip)
        {
            return _animalRepository.DeleteOneAnimal(chip);
        }
    }
}
