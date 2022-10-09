using ProjOng_Dapper.Model;
using ProjOng_Dapper.Service;
using System;

namespace ProjOng_Dapper
{
    internal class Program
    {
        public static void MenuPrincipal()
        {
            int opc = 0;
            do
            {
                Console.Clear();
                Console.WriteLine(">>>ADOÇÃO DE ANIMAIS<<<");
                Console.WriteLine("0 - Sair do Menu Principal");
                Console.WriteLine("1 - Menu Adotante");
                Console.WriteLine("2 - Menu Animal");
                Console.WriteLine("3 - Menu Adoção");
                Console.WriteLine("\n>>Informe o que deseja acessar...");
                opc = int.Parse(Console.ReadLine());
                if (opc < 0 || opc > 3)
                    Console.WriteLine("OPÇÃO INVÁLIDA! Informe um número válido para acessar o menu:");
                else
                {
                    Console.Clear();
                    switch (opc)
                    {
                        case 0:
                            Console.WriteLine("SAINDO...");
                            Environment.Exit(0);
                            break;
                        case 1:
                            MenuAdotante();
                            break;

                        case 2:
                            // MenuAnimal();
                            break;

                        case 3:
                            // MenuAdocao();
                            break;

                        default:
                            Console.WriteLine("OPÇÃO INVÁLIDA! Informe uma das opções segundo o menu!");
                            break;
                    }
                }
            } while (opc != 0);
        }
        public static void MenuAdotante()
        {

            int opc = 0;
            do
            {
                Console.Clear();
                Console.WriteLine(">>>MENU ADOTANTE<<<");
                Console.WriteLine("1 - Voltar ao Menu Principal");
                Console.WriteLine("2 - Cadastrar Adotante");
                Console.WriteLine("3 - Buscar adotante específico");
                Console.WriteLine("4 - Visualizar todos os adotantes cadastrados");
                Console.WriteLine("5 - Editar dados de um cadastro existente");
                Console.WriteLine("6 - Deletar adotante específico");
                Console.WriteLine("7 - Deletar cadastro de todos os adotantes");
                Console.WriteLine("\n>>Informe o que deseja acessar...");
                opc = int.Parse(Console.ReadLine());
                if (opc <= 0 || opc > 7)
                    Console.WriteLine("OPÇÃO INVÁLIDA! Informe um número válido para acessar o menu:");
                else
                {
                    Console.Clear();
                    switch (opc)
                    {
                        case 1:
                            MenuPrincipal();
                            break;

                        case 2:
                            CadastrarAdotante();
                            break;

                        case 3:

                            break;

                        case 4:


                        case 5:

                            break;

                        case 6:

                            break;

                        case 7:

                            break;

                        case 8:

                            break;

                        default:
                            Console.WriteLine("OPÇÃO INVÁLIDA! Informe uma das opções segundo o menu!");
                            break;
                    }
                }
            } while (opc <= 0 || opc > 7);
        }
        static public void CadastrarAdotante()
        {
            DateTime datanasc;
            Adotante adotante = new Adotante();
            do
            {
                Console.WriteLine("Informe o seu nome [Máximo 50 digítos]: ");
                adotante.Nome = Console.ReadLine();
                if (adotante.Nome.Length < 0 && adotante.Nome.Length > 50)
                {
                    Console.WriteLine("\nIMPOSSÍVEL CADASTRAR! \nTENTE NOVAMENTE!");

                }
            } while (adotante.Nome.Length < 0 && adotante.Nome.Length > 50);

            Console.WriteLine("Informe seu CPF sem caracteres especiais: ");
            adotante.CPF = Console.ReadLine();

            do
            {
                Console.WriteLine("Informe seu genero: [M - Masculino, F - Feminino, N - Não desejo informar] : ");
                adotante.Sexo = char.Parse(Console.ReadLine().ToUpper());
                if (adotante.Sexo != 'M' && adotante.Sexo != 'F' && adotante.Sexo != 'N')
                {
                    Console.WriteLine("OPÇÃO INVÁLIDA! INFORME (M, F OU N) ");
                }
            } while (adotante.Sexo != 'M' && adotante.Sexo != 'F' && adotante.Sexo != 'N');

            Console.WriteLine("Informe a Data de Nascimento [dd/mm/aaaa]: ");
            while (!DateTime.TryParse(Console.ReadLine(), out datanasc))
            {
                if (datanasc > DateTime.Now)
                {
                    Console.WriteLine("OPÇÃO INVÁLIDA! Informe uma data válida!");
                }
                else
                    Console.Write("Informe a Data de Nascimento: ");
            }
            adotante.DataNascimento = datanasc.ToString("dd/MM/yyyy");

            Console.WriteLine("Agora, informe os dados referente ao ENDEREÇO do Adotante: ");
            do
            {
                Console.WriteLine("\nInforme o Logradouro [Máximo 50 caracteres]: ");
                adotante.Logradouro = Console.ReadLine();
                if (adotante.Logradouro.Length > 50)
                {
                    Console.WriteLine("\nIMPOSSÍVEL CADASTRAR! \nTENTE NOVAMENTE!");

                }
            } while (adotante.Logradouro.Length > 50);

            Console.WriteLine("Informe o número da Residência: ");
            adotante.Numero = Console.ReadLine();
            Console.WriteLine("Informe o CEP: ");
            adotante.CEP = Console.ReadLine();
            do
            {
                Console.WriteLine("Informe o bairro [Máximo 20 caracteres]: ");
                adotante.Bairro = Console.ReadLine();
                if (adotante.Bairro.Length > 20)
                {
                    Console.WriteLine("\nIMPOSSÍVEL CADASTRAR! \nTENTE NOVAMENTE!");

                }
            } while (adotante.Bairro.Length > 20);

            int opcao = 0;
            do
            {
                Console.WriteLine("Deseja adicionar um complemento? (1 - SIM, 2 - NÃO): ");
                try
                {
                    opcao = int.Parse(Console.ReadLine());
                    if (opcao == 1)
                    {
                        do
                        {
                            Console.WriteLine("Informe o complemento [Máximo 30 caracteres]: ");
                            adotante.Complemento = Console.ReadLine();
                            if (adotante.Complemento.Length > 30)
                            {
                                Console.WriteLine("\nIMPOSSÍVEL CADASTRAR! \nTENTE NOVAMENTE!");

                            }
                        } while (adotante.Complemento.Length > 30);
                    }
                    else
                        adotante.Complemento = "--";
                }
                catch
                {
                    Console.WriteLine("Informe um valor NUMERICO! ");

                }
            } while (opcao < 0 || opcao != 1 && opcao != 2);

            do
            {
                Console.WriteLine("Informe a Cidade onde reside [Máximo 30 caracteres]: ");
                adotante.Cidade = Console.ReadLine();
                if (adotante.Cidade.Length > 30)
                {
                    Console.WriteLine("\nIMPOSSÍVEL CADASTRAR! \nTENTE NOVAMENTE!");

                }
            } while (adotante.Cidade.Length > 30);

            do
            {
                Console.WriteLine("Informe a Unidade Federativa onde reside [Ex: SP]: ");
                adotante.UF = Console.ReadLine();
                if (adotante.UF.Length > 2)
                {
                    Console.WriteLine("\nIMPOSSÍVEL CADASTRAR! \nTENTE NOVAMENTE!");

                }
            } while (adotante.UF.Length > 50);
            do
            {
                Console.WriteLine("Informe o Telefone para contato com o DDD sem caracteres especiais [Máximo 11 digítos]: ");
                adotante.Telefone = Console.ReadLine();
                if (adotante.Telefone.Length > 11)
                {
                    Console.WriteLine("\nIMPOSSÍVEL CADASTRAR! \nTENTE NOVAMENTE!");

                }
            } while (adotante.Telefone.Length > 11);
           
            new AdotanteService().AddAdotante(adotante);
            Console.ReadKey();
            Console.WriteLine("**Cadastro realizado com sucesso!**");
        }
        static void Main(string[] args)
        {
            MenuPrincipal();
            //Console.WriteLine("começando...");

            //Adotante adotante = new Adotante()
            //{
            //    Nome = "Gabriele",
            //    CPF = "52609924828",
            //    Sexo = 'F',
            //    DataNascimento = "28/03/2003",
            //    Logradouro = "Avenida Jose Cerqueira",
            //    Numero = "1040",
            //    CEP = "15996167",
            //    Bairro = "Jardim Santa Marta",
            //    Complemento = "Nao tenho",
            //    Cidade = "Matão",
            //    UF = "SP",
            //    Telefone = "16999758483"
            //};

            //new AdotanteService().GetAllAdotante().ForEach(x => Console.WriteLine(x));

            //Console.WriteLine("FOI!");

        }
    }
}


