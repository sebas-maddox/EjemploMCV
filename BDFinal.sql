DROP TABLE Asociacion
DROP TABLE Trabajo
DROP TABLE Mensaje
DROP TABLE Evento
DROP TABLE Comentario
DROP TABLE Noticia
DROP TABLE Categoria
DROP TABLE Usuario

CREATE TABLE Usuario(
	LoginID nvarchar(100) PRIMARY KEY,
	Contra nvarchar(100) NOT NULL,
	Nombre nvarchar(200),
	Email nvarchar(500),
	Tipo nvarchar(100),
	Administrador BIT NOT NULL DEFAULT 0
	)

CREATE TABLE Categoria(
	IdCategoria bigint NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Nombre nvarchar(100)
)
	

CREATE TABLE Noticia(
	IdNot bigint NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Titulo nvarchar(100),
	Cuerpo text,
	LoginID bigint NOT NULL,
	IdCategoria bigint,
	FechaPublicacion datetime NOT NULL DEFAULT getdate(),
	FOREIGN KEY (IdCategoria) REFERENCES Categoria(IdCategoria)
	)


CREATE TABLE Comentario (
	IdComentario bigint NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Texto text,
	LoginID nvarchar(100),
	IdNot bigint,
	Estado BIT NOT NULL DEFAULT 0,
	FechaCreacion datetime NOT NULL DEFAULT getdate(),
	FOREIGN KEY (LoginID) REFERENCES Usuario(LoginID)

	)


CREATE TABLE Evento(
	IdEvento bigint NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Nombre nvarchar(100),
	Fecha date,
	Lugar nvarchar(500)
	)


CREATE TABLE Mensaje(
	IdMensaje bigint NOT NULL IDENTITY(1,1) PRIMARY  KEY,
	IdUsuarioEnv nvarchar(100),
	IdUsuarioRec nvarchar(100)
	Texto text,
	FOREIGN KEY (IdUsuarioRec) REFERENCES Usuario(LoginID),
	FOREIGN KEY (IdUsuarioEnv) REFERENCES Usuario(LoginID)
	)

CREATE TABLE Trabajo(
	IdTrabajo bigint NOT NULL IDENTITY(1,1) PRIMARY KEY,
	LoginID nvarchar(100),
	Titulo nvarchar(100),
	Lugar nvarchar(100),
	Descripcion text,
	FechaPublicacion datetime NOT NULL DEFAULT getdate(),
	Tipo nvarchar(100),
	FOREIGN KEY (LoginID) REFERENCES Usuario(LoginID)
	)

CREATE TABLE Asociacion(
	IdAsociacion bigint NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Nombre nvarchar(100),
	Ubicacion nvarchar(200),
	Lider nvarchar(200),
	Telefono bigint,
	Correo nvarchar(100) 
)