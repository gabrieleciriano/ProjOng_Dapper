using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjOng_Dapper.Model
{
    internal class Adocao
    {
        public string CPFAdotante { get; set; }
        public int CHIPAnimal { get; set; }
        public DateTime DataAdocao { get; set; }

        public readonly static string INSERT = "INSERT INTO dbo.RegistroAdocao (CHIP, Familia, Raca, Sexo, Nome) VALUES (@CHIP, @Familia, @Raca, @Sexo, @Nome)";
        public readonly static string DELETEONE = "DELETE FROM dbo.Adocao WHERE CPF = @CPF AND CHIP = @CHIP";
        public readonly static string DELETEALL = "DELETE FROM dbo.Adocao";
        public readonly static string SELECTALL = "SELECT a.Nome, ra.CPF, ra.CHIP, m.Nome, m.Familia, m.Raca, m.Sexo, ra.DataAdocao FROM adocao ra, adotante a, animal m WHERE a.cpf = ra.cpf and m.chip = ra.chip; ";
        public readonly static string SELECTONE = "SELECT a.Nome, ra.CPF, ra.CHIP, m.Nome, m.Familia, m.Raca, m.Sexo, ra.DataAdocao FROM registroadocao ra, adotante a, animal m WHERE ra.CPF = @CPF AND ra.CHIP = @CHIP and a.cpf = ra.cpf and m.chip = ra.chip;";

        public override string ToString()
        {
            return $"CHIP do Animal: {this.CHIPAnimal} \nCPF do Adotante: {this.CPFAdotante} \nData da adoção: {this.DataAdocao}".ToString();
        }
    }
}
