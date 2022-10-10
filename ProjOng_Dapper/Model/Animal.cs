using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjOng_Dapper.Model
{
    internal class Animal
    {
        #region Properties
        public int CHIP { get; set; }
        public string Familia { get; set; }
        public string Raca { get; set; }
        public char Sexo { get; set; }
        public string Nome { get; set; }
        #endregion

        public readonly static string INSERT_ONE = "INSERT INTO dbo.Animal (CHIP, Familia, Raca, Sexo, Nome) VALUES (@CHIP, @Familia, @Raca, @Sexo, @Nome)";

        public readonly static string SELECT_ALL = "SELECT CHIP, Familia, Raca, Sexo, Nome FROM dbo.Animal";
        public readonly static string SELECT_ONE = "SELECT CHIP, Familia, Raca, Sexo, Nome FROM dbo.Animal WHERE CHIP = @CHIP";

        public readonly static string DELETE_ONE = "DELETE FROM dbo.Animal WHERE CHIP = @CHIP";


        public readonly static string UPDATE_FAMILIA = "UPDATE dbo.Animal SET Familia= @Familia WHERE CHIP=@CHIP";
        public readonly static string UPDATE_RACA = "UPDATE dbo.Animal SET Raca= @Raca WHERE CHIP=@CHIP";
        public readonly static string UPDATE_SEXO = "UPDATE dbo.Animal SET Sexo= @Sexo WHERE CHIP=@CHIP";
        public readonly static string UPDATE_NOME = "UPDATE dbo.Animal SET Nome= @Nome WHERE CHIP=@CHIP";
        public override string ToString()
        {
            return $"CHIP do Animal: {this.CHIP} \nFamilia: {this.Familia} \nRaça: {this.Raca} \nSexo: {this.Sexo} \nNome do animal: {this.Nome}".ToString();
        }
    }
}
