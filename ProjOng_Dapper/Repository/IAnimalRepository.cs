using ProjOng_Dapper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjOng_Dapper.Repository
{
    internal interface IAnimalRepository
    {
        bool AddAnimal(Animal animal);
        List<Animal> GetAllAnimal();
        Animal GetOneAnimal(string chip);
        bool UpdateFamilia(string chip, string familia);
        bool UpdateRaca(string chip, string raca);
        bool UpdateSexo(string chip, char sexo);  
        bool UpdateNome(string chip, string nome);
        bool DeleteOneAnimal(string chip);

    }
}
