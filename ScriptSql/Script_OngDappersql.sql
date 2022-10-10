CREATE DATABASE OngAdocao
USE OngAdocao

CREATE TABLE Adotante (
Nome varchar(50) NOT NULL,
CPF varchar(11) NOT NULL,
Sexo char(1) NOT NULL,
DataNascimento date NOT NULL,
Logradouro varchar(50) NOT NULL,
Numero int NOT NULL,
CEP int NOT NULL,
Bairro varchar(20) NOT NULL,
Complemento varchar(30) NOT NULL,
Cidade varchar(30) NOT NULL,
UF varchar(2) NOT NULL,
Telefone varchar(11) NOT NULL,
CONSTRAINT PK_CPF PRIMARY KEY (CPF)
);

SELECT * FROM Adotante

CREATE TABLE Animal (
CHIP int NOT NULL,
Familia varchar(50) NOT NULL,
Raca varchar(20) NOT NULL,
Sexo char(1) NOT NULL,
Nome varchar(50) NOT NULL,
CONSTRAINT PK_CHIP PRIMARY KEY (CHIP)
);

SELECT * FROM Animal


CREATE TABLE Adocao(
CPF varchar(11) NOT NULL,
CHIP int NOT NULL,
DataAdocao date NOT NULL,
FOREIGN KEY (CPF) REFERENCES Adotante(CPF),
FOREIGN KEY (CHIP) REFERENCES Animal(CHIP),
CONSTRAINT PK_Adocao PRIMARY KEY(CPF, CHIP)
);

SELECT * FROM Adocao
SELECT a.Nome, ra.CPF, ra.CHIP, m.Nome, m.Familia, m.Raca, m.Sexo, ra.DataAdocao FROM adocao ra, adotante a, animal m WHERE a.cpf = ra.cpf and m.chip = ra.chip;


