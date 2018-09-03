DROP TABLE Archivo
/*DROP TABLE Item*/
DROP TABLE Usuarios
DROP TABLE Categorias
DROP TABLE Noticias
DROP TABLE Comentarios
DROP TABLE Eventos
DROP TABLE Asociaciones
DROP TABLE Trabajos
DROP TABLE Mensajes

CREATE TABLE Usuarios(
	LoginID nvarchar(100) PRIMARY KEY,
	Password nvarchar(100) NOT NULL,
	Nombre nvarchar(200),
	Email nvarchar(500),
	Tipo nvarchar(100),
	Administrador BIT NOT NULL DEFAULT 0,
	
)

CREATE TABLE Categorias(
	IdCategoria bigint NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Nombre nvarchar(100),
)

CREATE TABLE Noticias(
	IdNot bigint NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Titulo nvarchar(100),
	Cuerpo text,
	LoginID nvarchar(100),
	IdCategoria int(20),
	FechaPublicacion datetime NOT NULL DEFAULT getdate(),
)


CREATE TABLE Comentarios (
	IdComentario bigint NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Comentario text,
	LoginID nvarchar(100),
	IdNot bigint,
	Estado BIT NOT NULL DEFAULT 0,
	FechaCreacion datetime NOT NULL DEFAULT getdate(),

)


CREATE TABLE Eventos(
	IdEvento bigint NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Nombre nvarchar(100),
	Fecha date,
	Lugar nvarchar(500),
)


CREATE TABLE Mensajes(
	IdMensaje bigint NOT NULL IDENTITY(1,1) PRIMARY  KEY,
	IdUsuarioEnv nvarchar(100),
	IdUsuarioRec nvarchar(100),
	Mensaje text,
)

CREATE TABLE Trabajos(
	IdTrabajo bigint NOT NULL IDENTITY(1,1) PRIMARY KEY,
	LoginID nvarchar(100),
	Titulo nvarchar(100),
	Lugar nvarchar(100),
	Descripcion text,
	FechaPublicacion datetime NOT NULL DEFAULT getdate(),
	Tipo nvarchar(100),/*medio tiempo, completo*/
)

CREATE TABLE Asociaciones(
	IdAsociacion bigint NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Nombre nvarchar(100),
	Ubicacion nvarchar(200),
	Lider nvarchar(200),
	Telefono int(20),
	Correo nvarchar(100), 
)


/*CREATE TABLE Item (
	IDItem bigint NOT NULL IDENTITY(1,1) PRIMARY KEY,	

	FechaCreacion datetime NOT NULL DEFAULT getdate(),
		
	Recomendado BIT NOT NULL,
	Publicado BIT NOT NULL,	
	LoNuevo BIT NOT NULL,
		
	Codigo nvarchar(100) NOT NULL UNIQUE,
	Titulo nvarchar(200) NOT NULL,
	Descripcion nvarchar(1000) NOT NULL,
	PalabrasClave nvarchar(1000) NOT NULL,	
	Grupo nvarchar(200) NOT NULL,
	SubGrupo nvarchar(200) NOT NULL,
	Marca nvarchar(200) NOT NULL,
	Orden bigint NOT NULL,
	
	Precio money NOT NULL,				
)
CREATE TABLE Archivo (
	IDArchivo bigint NOT NULL IDENTITY(1,1) PRIMARY KEY,	
	Modificado datetime NOT NULL DEFAULT getdate(),
	NombreArchivo nvarchar(500),	
	Contenido image,	
	IDItem bigint NOT NULL REFERENCES Item,
	Orden bigint,
	Titulo nvarchar(200),
)*/
