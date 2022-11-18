--DDL
CREATE DATABASE RpgBdBet9
GO

USE RpgBdBet9
GO

CREATE TABLE Usuarios(
	IdUsuario INT PRIMARY KEY IDENTITY,
	Email VARCHAR(100) UNIQUE NOT NULL,
	Senha VARCHAR(255) NOT NULL 
)
GO

CREATE TABLE Classes(
	IdClasse INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(50) UNIQUE NOT NULL,
	Descricao VARCHAR(255)
)
GO

CREATE TABLE Personagens(
	IdPersonagem INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(30) UNIQUE NOT NULL,
	IdUsuario INT UNIQUE FOREIGN KEY REFERENCES Usuarios(IdUsuario),
	IdClasse INT FOREIGN KEY REFERENCES Classes(IdClasse)
)
GO

CREATE TABLE Habilidades(
	IdHabilidade INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(50) UNIQUE NOT NULL,
	Descricao VARCHAR(255)
)
GO

CREATE TABLE ClassesHabilidades(
	IdClasse INT FOREIGN KEY REFERENCES Classes(IdClasse),
	IdHabilidade INT FOREIGN KEY REFERENCES Habilidades(IdHabilidade)
)
GO

--DML
--INSERT INTO Usuarios (Senha, Email) VALUES (123456, 'email@email.com')
INSERT INTO Usuarios VALUES ('email@email.com', 123456)
INSERT INTO Classes VALUES ('Barbaro', 'Descrição da classe Barbaro')
INSERT INTO Habilidades VALUES ('Lança Mortal', 'Descrição da Lança Mortal'), ('Escudo Supremo', 'Descrição do Escudo Supremo')
INSERT INTO Personagens VALUES ('DeuBug', 1, 1)
INSERT INTO ClassesHabilidades VALUES (1, 1), (1, 2)


INSERT INTO Usuarios VALUES ('email2@email.com', 'abcdef')
INSERT INTO Classes VALUES ('Monge', 'Descrição da Classe Monge')
INSERT INTO Habilidades VALUES ('Recuperar Vida', 'Descrição de Recuperar Vida')
INSERT INTO Personagens VALUES ('BitBug', 2, 2)
INSERT INTO ClassesHabilidades VALUES (2, 2), (2, 3)

/*
UPDATE Usuarios
SET Senha = 123456
WHERE IdUsuario = 2
*/

--DQL
SELECT * FROM Usuarios
SELECT * FROM Classes
SELECT * FROM Habilidades

SELECT * FROM Usuarios
SELECT IdUsuario, Email FROM Usuarios 
SELECT IdUsuario, Email FROM Usuarios WHERE IdUsuario = 1

SELECT * FROM Personagens
JOIN Usuarios
ON Personagens.IdUsuario = Usuarios.IdUsuario

SELECT P.Nome 'Personagem', U.Email FROM Personagens P
JOIN Usuarios U
ON P.IdUsuario = U.IdUsuario





CREATE DATABASE ExemploJoin
GO

USE ExemploJoin
GO

CREATE TABLE NomeA(
	Nome VARCHAR(50) NOT NULL
)
GO

CREATE TABLE NomeB(
	Nome VARCHAR(50) NOT NULL
)
GO

INSERT INTO NomeA VALUES ('Fernanda'), ('Maria'), ('Luiz'), ('Caique')
INSERT INTO NomeB VALUES ('Luiz'), ('Caique'), ('Odirlei'), ('Jessica')

SELECT * FROM NomeA
INNER JOIN NomeB
ON NomeA.Nome = NomeB.Nome

SELECT * FROM NomeA
LEFT JOIN NomeB
ON NomeA.Nome = NomeB.Nome

SELECT * FROM NomeA
RIGHT JOIN NomeB
ON NomeA.Nome = NomeB.Nome

SELECT * FROM NomeA
FULL OUTER JOIN NomeB
ON NomeA.Nome = NomeB.Nome

SELECT * FROM NomeA
FULL OUTER JOIN NomeB
ON NomeA.Nome = NomeB.Nome
WHERE NomeB.Nome IS NULL OR NomeA.Nome IS NULL