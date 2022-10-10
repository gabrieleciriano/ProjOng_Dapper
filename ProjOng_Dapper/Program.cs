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
                Console.WriteLine(">>>ADOÇÃO DE ANIMAIS DA ONG<<<");
                Console.WriteLine("\n");
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
                            MenuAnimal();
                            break;

                        case 3:
                            MenuAdocao();
                            break;

                        default:
                            Console.WriteLine("OPÇÃO INVÁLIDA! Informe uma das opções segundo o menu!");
                            break;
                    }
                }
            } while (opc != 0);
        }
        public static void MenuAnimal()
        {
            int opc = 0;
            do
            {
                Console.Clear();
                Console.WriteLine(">>>MENU ANIMAL<<<");
                Console.WriteLine("\n");
                Console.WriteLine("1 - Voltar ao Menu Principal");
                Console.WriteLine("2 - Cadastrar Animal");
                Console.WriteLine("3 - Buscar animal específico");
                Console.WriteLine("4 - Visualizar todos os animais cadastrados");
                Console.WriteLine("5 - Editar dados de um cadastro existente");
                Console.WriteLine("6 - Deletar animal específico");
                Console.WriteLine("\n>>Informe o que deseja acessar...");
                opc = int.Parse(Console.ReadLine());
                if (opc <= 0 || opc > 6)
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
                            CadastrarAnimal();
                            break;

                        case 3:
                            Console.Clear();
                            Animal animal = new Animal();
                            Console.WriteLine("**BUSCAR CADASTRO ESPECÍFICO**");
                            SelectSpecificAnimal();
                            break;

                        case 4:
                            SelectAllAnimals();
                            break;

                        case 5:
                            UpdateAnimal();
                            break;

                        case 6:
                            DeleteOneAnimal();
                            break;

                        default:
                            Console.WriteLine("OPÇÃO INVÁLIDA! Informe uma das opções segundo o menu!");
                            break;
                    }
                }
            } while (opc <= 0 || opc > 6);
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
                Console.WriteLine("\n>>Informe o que deseja acessar...");
                opc = int.Parse(Console.ReadLine());
                if (opc <= 0 || opc > 6)
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
                            SelectAllAdotante();
                            break;

                        case 5:
                            UpdateAdotante();
                            break;

                        case 6:
                            DeleteOneAdotante();
                            break;

                        default:
                            Console.WriteLine("OPÇÃO INVÁLIDA! Informe uma das opções segundo o menu!");
                            break;
                    }
                }
            } while (opc <= 0 || opc > 6);
        }
        public static void MenuAdocao()
        {
            int opc = 0;
            do
            {
                Console.Clear();
                Console.WriteLine(">>>MENU DA ADOÇÃO DE ANIMAIS<<<");
                Console.WriteLine("\n");
                Console.WriteLine("1 - Voltar ao Menu Principal");
                Console.WriteLine("2 - Cadastrar Adoção");
                Console.WriteLine("3 - Buscar adoção específica");
                Console.WriteLine("4 - Visualizar todas as adoções cadastradas");
                Console.WriteLine("5 - Deletar cadastro de adoção específica");
                Console.WriteLine("\n>>Informe o que deseja acessar...");
                opc = int.Parse(Console.ReadLine());
                if (opc <= 0 || opc > 5)
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
                            CadastrarAdocao();
                            break;

                        case 3:
                            Console.Clear();
                            Adocao adocao = new Adocao();
                            Console.WriteLine("**VIZUALIZAR ADOÇÃO ESPECÍFICA**");
                            SelectSpecificAdocao();
                            break;

                        case 4:
                            SelectAllAnimals();
                            break;

                        case 5:
                            UpdateAnimal();
                            break;

                        case 6:
                            DeleteOneAnimal();
                            break;

                        default:
                            Console.WriteLine("OPÇÃO INVÁLIDA! Informe uma das opções segundo o menu!");
                            break;
                    }
                }
            } while (opc <= 0 || opc > 5);
        }
        public static void CadastrarAdocao()
        {
            Adocao adocao = new Adocao();
            Console.WriteLine("----EFETUANDO ADOÇÃO----");
            Console.WriteLine("Deseja realmente realizar uma adoção ? [1 - SIM, 2 - NÃO]");
            int escolha = int.Parse(Console.ReadLine());
            if (escolha == 1)
            {

                Console.WriteLine("Informe o CPF do adotante: ");
                adocao.CPF = Console.ReadLine();
                Adotante adotante = new AdotanteService().GetOneAdotante(adocao.CPF);
                Console.WriteLine("----------------------------------------");
                Console.WriteLine(adotante.ToString());
                Console.WriteLine("-----------------------------------------");
                Console.ReadKey();
                Console.WriteLine("Informe o CHIP de identificação do animal que vai ser adotado: ");
                adocao.CHIP = int.Parse(Console.ReadLine());
                Animal animal = new AnimalService().GetOneAnimal(adocao.CHIP);
                Console.WriteLine("----------------------------------------");
                Console.WriteLine(animal.ToString());
                Console.WriteLine("-----------------------------------------");
                Console.ReadKey();
                adocao.DataAdocao = DateTime.Now;
                Console.WriteLine("Confirmar adoção: [1 - SIM, 2 - Não]");
                int ad = int.Parse(Console.ReadLine());
                if (ad == 1)
                {
                    new AdocaoService().AddAdocao(adocao);
                    Console.WriteLine("\n**Adoção realizada com sucesso!**");
                    Console.ReadKey();
                }
            }
            else
                MenuAdocao();
        }
        public static void SelectSpecificAdocao()
        {
            Adocao adocao = new Adocao();
            Console.WriteLine("Informe o CPF do tutor: ");
            adocao.CPF = Console.ReadLine();
            Console.WriteLine("Informe o CHIP de identificação do animal adotado: ");
            adocao.CHIP = int.Parse(Console.ReadLine());
            adocao = new AdocaoService().GetOneAdocao(adocao.CPF, adocao.CHIP);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(adocao);
            Console.WriteLine("-----------------------------------------");
            Console.ReadKey();
        }
        public static void CadastrarAnimal()
        {
            Animal animal = new Animal();
            Console.WriteLine("Numero do CHIP de identificação do animal: ");
            animal.CHIP = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("A qual Familia o animal pertence: [Ex: Gato, Cachorro]");
                animal.Familia = Console.ReadLine();
                if (animal.Familia.Length > 50)
                {
                    Console.WriteLine("\nIMPOSSÍVEL CADASTRAR! \nTENTE NOVAMENTE!");

                }
            } while (animal.Familia.Length > 50);

            do
            {
                Console.WriteLine("Raça do animal: [Ex: Vira-Lata, Pitbull, ShihTzu]");
                animal.Raca = Console.ReadLine();
                if (animal.Raca.Length > 20)
                {
                    Console.WriteLine("\nIMPOSSÍVEL CADASTRAR! \nTENTE NOVAMENTE!");

                }
            } while (animal.Raca.Length > 20);

            do
            {
                Console.WriteLine("Sexo do animal : [M - Macho, F - Fêmea] : ");
                animal.Sexo = char.Parse(Console.ReadLine().ToUpper());
                if (animal.Sexo != 'M' && animal.Sexo != 'F')
                {
                    Console.WriteLine("OPÇÃO INVÁLIDA! INFORME [M ou F] ");
                }
            } while (animal.Sexo != 'M' && animal.Sexo != 'F');
            Console.WriteLine("Animal já possui um nome? [1 - SIM, 2 - NÃO]");
            int op = int.Parse(Console.ReadLine());
            if (op == 1)
            {
                do
                {
                    Console.WriteLine("Nome do animal: ");
                    animal.Nome = Console.ReadLine();
                    if (animal.Nome.Length > 50)
                    {
                        Console.WriteLine("\nIMPOSSÍVEL CADASTRAR! \nTENTE NOVAMENTE!");

                    }
                } while (animal.Nome.Length > 50);
            }
            else
                animal.Nome = "--";
            new AnimalService().AddAnimal(animal);
            Console.WriteLine("**\nCadastro realizado com sucesso!**");
            Console.ReadKey();
        }
        public static void SelectSpecificAnimal()
        {
            Console.WriteLine("Informe o CHIP do animal que deseja visualizar o cadastro: ");
            int chip = int.Parse(Console.ReadLine());
            Animal animal = new AnimalService().GetOneAnimal(chip);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(animal.ToString());
            Console.WriteLine("-----------------------------------------");
            Console.ReadKey();
        }
        public static void SelectAllAnimals()
        {
            Console.WriteLine("Realmente deseja vizualizar todos os cadastros de animais? [1 - SIM, 2 - NÃO]: ");
            int escolha = int.Parse(Console.ReadLine());
            if (escolha == 1)
            {
                Animal animal = new Animal();
                Console.WriteLine("---------------------------------------------------");
                new AnimalService().GetAllAnimal().ForEach(x => Console.WriteLine(x));
                Console.WriteLine("----------------------------------------------------");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\nVisualização cancelada!");
                Console.ReadKey();
            }
        }
        public static void UpdateAnimal()
        {
            Console.WriteLine("Informe o CHIP de identificaçãp do animal que deseja editar o cadastro: ");
            int chip = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------");
            Animal animal = new AnimalService().GetOneAnimal(chip);
            Console.WriteLine(animal.ToString());
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(">>>EDITAR CADASTRO<<<");
            Console.WriteLine("0 - VOLTAR AO MENU ANIMAL");
            Console.WriteLine("1 - Editar NOME");
            Console.WriteLine("2 - Editar FAMILIA");
            Console.WriteLine("3 - Editar RAÇA");
            Console.WriteLine("4 - Editar SEXO");
            Console.WriteLine("\n>>>Escolha entre as opções: ");
            int op = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (op)
            {
                case 0:
                    MenuAdotante();
                    break;
                case 1:
                    Console.WriteLine("Informe o novo nome: ");
                    string nome = Console.ReadLine();
                    if (new AnimalService().UpdateNome(chip, nome) == true)
                    {
                        Console.WriteLine("\nNome Alterado!");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("\nAlteração inválida!");
                        Console.ReadKey();
                    }
                    break;

                case 2:
                    string familia;
                    do
                    {
                        Console.WriteLine("Informe a Familia: [Ex: Gato, Cachorro]");
                        familia = Console.ReadLine();
                        if (familia.Length <= 0 && familia.Length > 50)
                        {
                            Console.WriteLine("\nIMPOSSÍVEL CADASTRAR! \nTENTE NOVAMENTE!");
                        }
                        else
                        {
                            if (new AnimalService().UpdateFamilia(chip, familia) == true)
                            {
                                Console.WriteLine("\nFamília Alterada!");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("\nAlteração inválida!");
                                Console.ReadKey();
                            }
                        }
                    } while (familia.Length <= 0 && familia.Length > 50);
                    break;

                case 3:
                    string raca;
                    do
                    {
                        Console.WriteLine("Informe a raça do animal: [Ex: Vira-Lata, Pitbull, ShihTzu]");
                        raca = Console.ReadLine();
                        if (raca.Length <= 0 && raca.Length > 20)
                        {
                            Console.WriteLine("\nIMPOSSÍVEL CADASTRAR! \nTENTE NOVAMENTE!");

                        }
                        else
                        {
                            if (new AnimalService().UpdateRaca(chip, raca) == true)
                            {
                                Console.WriteLine("\nRaça Alterada!");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("\nAlteração inválida!");
                                Console.ReadKey();
                            }
                        }
                    } while (raca.Length <= 0 && raca.Length > 20);
                    break;

                case 4:
                    char s;
                    do
                    {
                        Console.WriteLine("Informe o sexo do animal: [M - Macho, F - Fêmea] : ");
                        s = char.Parse(Console.ReadLine().ToUpper());
                        if (s != 'M' && s != 'F')
                        {
                            Console.WriteLine("OPÇÃO INVÁLIDA! INFORME [M OU F] ");
                        }
                        else
                        {
                            if (new AnimalService().UpdateSexo(chip, s) == true)
                            {
                                Console.WriteLine("\nSexo Alterado!");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("\nAlteração inválida!");
                                Console.ReadKey();
                            }
                        }
                    } while (s != 'M' && s != 'F');
                    break;

                default:
                    Console.WriteLine("\nINFORME UMA DAS OPÇÕES NO MENU!");
                    break;
            }
        }
        public static void DeleteOneAnimal()
        {
            Console.WriteLine("Informe o CHIP do animal que deseja deletar o cadastro: ");
            int chip = int.Parse(Console.ReadLine());
            Animal animal = new AnimalService().GetOneAnimal(chip);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(animal.ToString());
            Console.ReadKey();
            Console.WriteLine("Deseja realmente deletar esse cadastro? [1 - SIM, 2 - NÃO]: ");
            int escolha = int.Parse(Console.ReadLine());
            if (escolha == 1)
            {
                if (new AnimalService().DeleteOneAnimal(chip) == true)
                {
                    Console.ReadKey();
                }
                else
                    Console.WriteLine("\nAlteração inválida!");
            }
            else
            {
                Console.WriteLine("Exclusão do cadastro cancelada!");
                Console.ReadKey();
            }
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
            adotante.Numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o CEP: ");
            adotante.CEP = int.Parse(Console.ReadLine());
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
            } while (adotante.UF.Length > 2);
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
            Console.WriteLine("**Cadastro realizado com sucesso!**");
            Console.ReadKey();
        }
        static public void SelectSpecificAdotante()
        {
            Console.WriteLine("Informe o CPF do adotante que deseja visualizar o cadastro: ");
            string cpf = Console.ReadLine();
            Adotante adotante = new AdotanteService().GetOneAdotante(cpf);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(adotante.ToString());
            Console.WriteLine("-----------------------------------------");
            Console.ReadKey();
        }
        static public void SelectAllAdotante()
        {
            Console.WriteLine("Realmente deseja vizualizar todos os cadastros?");
            int escolha = int.Parse(Console.ReadLine());
            if (escolha == 1)
            {
                Adotante adotante = new Adotante();
                Console.WriteLine("---------------------------------------------------");
                new AdotanteService().GetAllAdotante().ForEach(x => Console.WriteLine(x));
                Console.WriteLine("----------------------------------------------------");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\nVisualização cancelada!");
                Console.ReadKey();
            }
        }
        static public void UpdateAdotante()
        {

            Console.WriteLine("Informe o CPF do adotante que deseja editar o cadastro: ");
            string cpf = Console.ReadLine();
            Console.WriteLine("--------------------------------------------------");
            Adotante adotante = new AdotanteService().GetOneAdotante(cpf);
            Console.WriteLine(adotante.ToString());
            Console.WriteLine("--------------------------------------------------");

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
            Console.WriteLine("\n>>>Escolha entre as opções: ");
            int op = int.Parse(Console.ReadLine());
            Console.Clear();
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
                    int num = int.Parse(Console.ReadLine());
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
                    int cep = int.Parse(Console.ReadLine());
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
                    {
                        Console.WriteLine("\nAlteração inválida!");
                        Console.ReadKey();
                    }
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
                            {
                                Console.WriteLine("\nAlteração inválida!");
                                Console.ReadKey();
                            }
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
        static public void DeleteOneAdotante()
        {
            Console.WriteLine("Informe o CPF do adotante que deseja deletar o cadastro: ");
            string cpf = Console.ReadLine();
            Adotante adotante = new AdotanteService().GetOneAdotante(cpf);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(adotante.ToString());
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("\nDeseja realmente deletar esse cadastro? [1 - SIM, 2 - NÃO]: ");
            int escolha = int.Parse(Console.ReadLine());
            if (escolha == 1)
            {
                if (new AdotanteService().DeleteOneAdotante(cpf) == true)
                {
                    Console.ReadKey();
                }
                else
                    Console.WriteLine("\nAlteração inválida!");
            }
            else
            {
                Console.WriteLine("Exclusão do cadastro cancelada!");
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            MenuPrincipal();
        }
    }
}


