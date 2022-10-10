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
        Animal GetOneAnimal(int chip);
        bool UpdateFamilia(int chip, string familia);
        bool UpdateRaca(int chip, string raca);
        bool UpdateSexo(int chip, char sexo);  
        bool UpdateNome(int chip, string nome);
        bool DeleteOneAnimal(int chip);

    }
}
