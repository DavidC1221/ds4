CREATE DATABASE DavidCordoba;
GO
USE DavidCordoba;
GO

CREATE TABLE DC_Clientes (
    IdCliente INT IDENTITY(1,1) PRIMARY KEY,
    NombreCompleto NVARCHAR(200) NOT NULL,
    TipoCliente NVARCHAR(50) NULL,
    Telefono NVARCHAR(50) NULL,
    Email NVARCHAR(100) NULL,
    Direccion NVARCHAR(250) NULL
);

CREATE TABLE DC_Abogados (
    IdAbogado INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(200) NOT NULL,
    Usuario NVARCHAR(50) NOT NULL,
    ClaveHash NVARCHAR(200) NULL,
    Rol NVARCHAR(50) NULL,
    Email NVARCHAR(100) NULL
);

CREATE TABLE DC_Casos (
    IdCaso INT IDENTITY(1,1) PRIMARY KEY,
    CodigoInterno NVARCHAR(50) NULL,
    IdCliente INT NOT NULL,
    IdAbogadoResp INT NOT NULL,
    Titulo NVARCHAR(200) NOT NULL,
    Descripcion NVARCHAR(MAX) NULL,
    FechaInicio DATE NOT NULL,
    FechaVencimiento DATE NULL,
    Estado NVARCHAR(50) NOT NULL,
    TipoCaso NVARCHAR(100) NULL,
    Prioridad NVARCHAR(20) NULL,
    CONSTRAINT FK_Casos_Clientes FOREIGN KEY (IdCliente) REFERENCES DC_Clientes(IdCliente),
    CONSTRAINT FK_Casos_Abogados FOREIGN KEY (IdAbogadoResp) REFERENCES DC_Abogados(IdAbogado)
);
