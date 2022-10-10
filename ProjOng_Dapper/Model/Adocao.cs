using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjOng_Dapper.Model
{
    internal class Adocao
    {
        public string CPF { get; set; }
        public int CHIP { get; set; }
        public DateTime DataAdocao { get; set; }

        public readonly static string INSERT = "INSERT INTO dbo.Adocao (CPF, CHIP, DataAdocao) VALUES (@CPF, @CHIP, @DataAdocao)";

        public readonly static string DELETE_ONE = "DELETE FROM dbo.Adocao WHERE CPF = @CPF AND CHIP = @CHIP";

        public readonly static string SELECT_ALL = "SELECT a.Nome, ra.CPF, ra.CHIP, m.Nome, m.Familia, m.Raca, m.Sexo, ra.DataAdocao FROM adocao ra, adotante a, animal m WHERE a.cpf = ra.cpf and m.chip = ra.chip; ";
        public readonly static string SELECT_ONE = "SELECT a.Nome, ra.CPF, ra.CHIP, m.Nome, m.Familia, m.Raca, m.Sexo, ra.DataAdocao FROM adocao ra, adotante a, animal m WHERE ra.CPF = @CPF AND ra.CHIP = @CHIP and a.cpf = ra.cpf and m.chip = ra.chip;";
        public override string ToString()
        {
            return $"CHIP do Animal: {this.CHIP} \nData da adoção: {this.DataAdocao}".ToString();
        }
    }
}
