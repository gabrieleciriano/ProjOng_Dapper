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
        public readonly static string INSERT = "INSERT INTO dbo.Animal (CHIP, Familia, Raca, Sexo, Nome) VALUES (@CHIP, @Familia, @Raca, @Sexo, @Nome)";
        public readonly static string SELECT = "SELECT CHIP, Familia, Raca, Sexo, Nome FROM dbo.Animal";
        public readonly static string SELECTONE = "SELECT CHIP, Familia, Raca, Sexo, Nome FROM dbo.Animal WHERE CHIP = @CHIP";
        public readonly static string DELETEONE = "DELETE FROM dbo.Animal WHERE CHIP = @CHIP";
        public readonly static string DELETEALL = "DELETE FROM dbo.Animal";
        //update de cada propriedade
        public override string ToString()
        {
            return $"CHIP do Animal: {this.CHIP} \nFamilia: {this.Familia} \nRaça: {this.Raca} \nSexo: {this.Sexo} \nNome do animal: {this.Nome}".ToString();
        }
    }
}
