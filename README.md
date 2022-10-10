# ProjOng_Dapper
Retomando o projeto proposto durante o treinamento de estágio utilizando a conexão com o banco de dados SQL Sever e o ORM dapper para a fixação dos conceitos apresentados.
## Sobre o Projeto (About)
O objetivo principal é mantido em realizar os seguintes tópicos através de uma aplicação
de console:
-Cadastrar adotantes (pessoa).
-Cadastrar animais que serão disponibilizados para a adoção.
-Relacionar o adotante ao animal.
-Efetuar as adoções sabendo que um adotante pode adotar vários animais.
## Tools
- C#
- SQL Server
- Micro ORM Dapper
## Avisos/Issues

- Não foram feitos todos os tratamentos de erros possíveis.
- Nas opções de atualizar (update) os campos do cadastro do adotante e animal, não foram feitos tratativas de erros caso o usuário informar um CPF ou um CHIP que não tenha sido cadastrado.
- Para visualizar os cadastros também não foi tratado caso o usuário informe um CPF ou CHIP que não esteja registrado no banco de dados.
- Para impriir na tela do console os dados de cada cadastro, é necessário que você recorde o CPF e do CHIP que cadastrou.
- A visibilidade dos dados poderia estar melhor.
- O Endereço foi "quebrado" em vários dados referentes ao "endereço completo" porque evitei criar uma classe somente para as propriedades referentes a ele.
- Faltou um select dentro da aplicação de console onde é possível consultar todas as adoções realizadas.
- Poderia ser melhorado a visibilidade dos dados das adoções, já somente é "impresso" o CPF, CHIP e a data da adoção conforme a tabela de relacionamento criada, poderia, por exemplo, imprimir outros dados para melhorar a visibilidade dos dados da adoção
- CRUD completo para adotante, animal e adoção (neste só faltou um select all) na aplicação de console
- Foi disponibilizado o script do banco de dados utilizado e está localizado na pasta "ScriptSql"
