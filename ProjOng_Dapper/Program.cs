using ProjOng_Dapper.Model;
using ProjOng_Dapper.Service;
using System;
using System.Linq;

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
                {
                    Console.WriteLine("OPÇÃO INVÁLIDA! Informe um número válido para acessar o menu:");

                }
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
                            Console.Clear();
                            Adotante adotante = new Adotante();
                            Console.WriteLine("**BUSCAR CADASTRO ESPECÍFICO**");
                            SelectSpecificAdotante();
                            break;

                        case 4:
                            // Console.WriteLine("Realmente deseja vizualizar todos os cadastros?");
                            adotante = new Adotante();
                            new AdotanteService().GetAllAdotante().ForEach(x => Console.WriteLine(x));
                            Console.ReadKey();
                            //Console.WriteLine("Cheguei aqui");
                            break;
                        case 5:
                            UpdateAdotante();
                            break;

                        case 6:

                            break;

                        case 7:

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
        static public void SelectSpecificAdotante()
        {
            Console.WriteLine("Informe o CPF do adotante que deseja visualizar o cadastro: ");
            string cpf = Console.ReadLine();
            Adotante adotante = new AdotanteService().GetOneAdotante(cpf);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(adotante.ToString());
            Console.ReadKey();
        }
        static public void UpdateAdotante()
        {
            //usar um console clear depois
            Console.WriteLine("Informe o CPF do adotante que deseja editar o cadastro: ");
            string cpf = Console.ReadLine();
            Console.WriteLine("--------------------------------------------------");
            Adotante adotante = new AdotanteService().GetOneAdotante(cpf);
            Console.WriteLine(adotante.ToString());

            Console.WriteLine(">>>EDITAR CADASTRO<<<");
            Console.WriteLine("0 - VOLTAR AO MENU ADOTANTE");
            Console.WriteLine("1 - Editar NOME");
            Console.WriteLine("2 - Editar SEXO");
            Console.WriteLine("3 - Editar DATA DE NASCIMENTO");
            Console.WriteLine("4 - Editar LOGRADOURO");
            Console.WriteLine("5 - Editar NÚMERO");
            Console.WriteLine("6 - Editar CEP");
            Console.WriteLine("7 - Editar BAIRRO");
            Console.WriteLine("8 - Editar COMPLEMENTO");
            Console.WriteLine("9 - Editar CIDADE");
            Console.WriteLine("10 - Editar UF");
            Console.WriteLine("11 - Editar TELEFONE");
            Console.WriteLine("\nEscolha entre as opções: ");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 0:
                    MenuAdotante();
                    break;
                case 1:
                    Console.WriteLine("Informe o novo nome: ");
                    string nome = Console.ReadLine();
                    if (new AdotanteService().UpdateNome(cpf, nome) == true)
                    {
                        Console.WriteLine("\nNome Alterado!");
                        Console.ReadKey();
                    }
                    else
                        Console.WriteLine("\nAlteração inválida!");
                    break;

                case 2:
                    char s;
                    do
                    {
                        Console.WriteLine("Informe o novo sexo: (M - Masculino, F - Feminino, N - Não desejo informar) : ");
                        s = char.Parse(Console.ReadLine().ToUpper());
                        if (s != 'M' && s != 'F' && s != 'N')
                        {
                            Console.WriteLine("OPÇÃO INVÁLIDA! INFORME (M, F OU N) ");
                        }
                        else
                        {
                            if (new AdotanteService().UpdateSexo(cpf, s) == true)
                            {
                                Console.WriteLine("\nSexo Alterado!");
                                Console.ReadKey();
                            }
                            else
                                Console.WriteLine("\nAlteração inválida!");
                        }
                    } while (s != 'M' && s != 'F' && s != 'N');
                    break;

                case 3:
                    DateTime datanasc;
                    Console.Write("Informe a nova Data de Nascimento: ");
                    while (!DateTime.TryParse(Console.ReadLine(), out datanasc))
                    {
                        if (datanasc > DateTime.Now)
                        {
                            Console.WriteLine("OPÇÃO INVÁLIDA! Informe uma data válida!");
                        }
                    }
                    string dt = datanasc.ToString("dd/MM/yyyy");
                    if (new AdotanteService().UpdateDataNascimento(cpf, dt) == true)
                    {
                        Console.WriteLine("\nData de nascimento alterada!");
                        Console.ReadKey();
                    }
                    else
                        Console.WriteLine("\nAlteração inválida!");
                    break;

                case 4:
                    Console.WriteLine("Novo Logradouro: ");
                    string logradouro = Console.ReadLine();
                    if (new AdotanteService().UpdateLogradouro(cpf, logradouro) == true)
                    {
                        Console.WriteLine("\nLogradouro alterado!");
                        Console.ReadKey();
                    }
                    else
                        Console.WriteLine("\nAlteração inválida!");
                    break;
                case 5:
                    Console.WriteLine("Novo Número: ");
                    string num = Console.ReadLine();
                    if (new AdotanteService().UpdateNumero(cpf, num) == true)
                    {
                        Console.WriteLine("\nNúmero alterado!");
                        Console.ReadKey();
                    }
                    else
                        Console.WriteLine("\nAlteração inválida!");
                    break;

                case 6:
                    Console.WriteLine("Novo CEP: ");
                    string cep = Console.ReadLine();
                    if (new AdotanteService().UpdateCEP(cpf, cep) == true)
                    {
                        Console.WriteLine("\nCEP alterado!");
                        Console.ReadKey();
                    }
                    else
                        Console.WriteLine("\nAlteração inválida!");
                    break;
                case 7:

                    Console.WriteLine("Novo Bairro: ");
                    string b = Console.ReadLine();
                    if (new AdotanteService().UpdateBairro(cpf, b) == true)
                    {
                        Console.WriteLine("\nBairro alterado!");
                        Console.ReadKey();
                    }
                    else
                        Console.WriteLine("\nAlteração inválida!");
                    break;
                case 8:
                    int opcao = 0;
                    string comp;
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
                                    Console.WriteLine("Novo complemento: ");
                                    comp = Console.ReadLine();
                                    if (comp.Length == 0 && comp.Length > 30)
                                    {
                                        Console.WriteLine("\nIMPOSSÍVEL CADASTRAR! \nTENTE NOVAMENTE!");

                                    }
                                    else
                                    {
                                        if (new AdotanteService().UpdateComplemento(cpf, comp) == true)
                                        {
                                            Console.WriteLine("\nComplemento alterado!");
                                            Console.ReadKey();
                                        }
                                        else
                                            Console.WriteLine("\nAlteração inválida!");
                                    }
                                } while (comp.Length > 30);
                            }
                            else
                                comp = "--";
                        }
                        catch
                        {
                            Console.WriteLine("Informe 1 ou 2! ");
                        }
                    } while (opcao < 0 || opcao != 1 && opcao != 2);
                    break;
                case 9:

                    Console.WriteLine("Cidade: ");
                    string c = Console.ReadLine();
                    if (new AdotanteService().UpdateCidade(cpf, c) == true)
                    {
                        Console.WriteLine("\nCidade alterada!");
                        Console.ReadKey();
                    }
                    else
                        Console.WriteLine("\nAlteração inválida!");
                    break;

                case 10:
                    Console.WriteLine("UF: [Ex: SP]");
                    string uf = Console.ReadLine();
                    if (new AdotanteService().UpdateUF(cpf, uf) == true)
                    {
                        Console.WriteLine("\nUF alterado!");
                        Console.ReadKey();
                    }
                    else
                        Console.WriteLine("\nAlteração inválida!");
                    break;

                case 11:
                    string tel;
                    Console.WriteLine("Novo número de telefone com DDD sem caracteres especiais: [Ex: 16999999999]  ");
                    try
                    {
                        tel = Console.ReadLine();
                        if (tel.Length == 0 && tel.Length > 11)
                        {
                            Console.WriteLine("\nIMPOSSÍVEL CADASTRAR! \nTENTE NOVAMENTE!");

                        }
                        else
                        {
                            if (new AdotanteService().UpdateTelefone(cpf, tel) == true)
                            {
                                Console.WriteLine("\nTelefone alterado!");
                                Console.ReadKey();
                            }
                            else
                                Console.WriteLine("\nAlteração inválida!");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Informe um valor numero de até 11 dígitos! ");
                    }
                    break;

                default:
                    Console.WriteLine("OPÇÃO INVÁLIDA! Informe uma das opções segundo o menu!");
                    break;
            }
        }
        static void Main(string[] args)
        {
            MenuPrincipal();
        }
    }
}


