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
        public Animal GetOneAnimal(int chip)
        {
            return _animalRepository.GetOneAnimal(chip);
        }
        public bool UpdateFamilia(int chip, string familia)
        {
            return _animalRepository.UpdateFamilia(chip, familia);
        }
        public bool UpdateRaca(int chip, string raca)
        {
            return _animalRepository.UpdateRaca(chip, raca);
        }
        public bool UpdateSexo(int chip, char sexo)
        {
            return _animalRepository.UpdateSexo(chip, sexo);
        }
        public bool UpdateNome(int chip, string nome)
        {
            return _animalRepository.UpdateNome(chip, nome);
        }
        public bool DeleteOneAnimal(int chip)
        {
            return _animalRepository.DeleteOneAnimal(chip);
        }
    }
}
