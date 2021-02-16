CREATE DATABASE InstaGama;

USE InstaGama;


CREATE TABLE dbo.Genero (
   Id int IDENTITY(1,1) NOT NULL,
   Descricao varchar(50) NOT NULL,
   CONSTRAINT PK_Genero_Id PRIMARY KEY CLUSTERED (Id)
)

CREATE TABLE dbo.Usuario (
	Id int IDENTITY(1,1) NOT NULL,
	GeneroId int NOT NULL,
	Nome varchar(250) NOT NULL,
	Email varchar(100) NOT NULL,
	Senha varchar(200) NOT NULL,
	DataNascimento DateTime NOT NULL,
	Foto varchar(max) NOT NULL
	CONSTRAINT PK_Usuario_Id PRIMARY KEY CLUSTERED (Id)
)

ALTER TABLE dbo.Usuario
   ADD CONSTRAINT FK_Usuario_Genero FOREIGN KEY (GeneroId)
      REFERENCES dbo.Genero (Id)


	 -- SELECT * FROM USUARIO

	  --INSERT INTO GENERO VALUES ('Feminino')

	 -- INSERT INTO USUARIO VALUES (1, 'Wendy-Anna', 'wendyufpb@gmail.com', '5559504', '1989-02-01', '')


	 -- SELECT g.Descricao as Genero, u.Nome, u.Email
		--FROM Usuario u
			--INNER JOIN Genero g ON g.Id = u.GeneroId