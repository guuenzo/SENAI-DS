--DDL

--criar o banco de dados
create database [Event+]

use [Event+]

--criar as tabelas
create table TiposDeUsuario
(
IdTipoDeUsuario int primary key identity,
TituloTipoUsuario varchar(50) not null unique
)

create table TiposDeEvento
(
IdTipoDeEvento int primary key identity,
TituloTipoEvento varchar(50) not null unique
)

create table Instituicao
(
IdInstituicao int primary key identity,
CNPJ char(14) not null unique, 
Endereco varchar(200) not null,
NomeFantasia varchar(200) not null
) 

create table Usuario
(
IdUsuario int primary key identity,
IdTipoDeUsuario int foreign key references TiposDeUsuario(IdTipoDeUsuario) not null,
Nome varchar(50) not null,
Email varchar(50) not null unique,
Senha varchar(50) not null
)

create table Evento
(
IdEvento int primary key identity,
IdTipoDeEvento int foreign key references TiposDeEvento(IdTipoDeEvento) not null,
IdInstituicao int foreign key references Instituicao(IdInstituicao) not null,
Nome varchar(100) not null,
Descricao varchar(100) not null,
DataEvento date not null,
HorarioEvento time not null
) 

create table PresencasEvento
(
IdPresencaEvento int primary key identity,
IdUsuario int foreign key references Usuario(IdUsuario),
IdEvento int foreign key references Evento(IdEvento) not null,
Situacao bit default(0)
)

create table ComentarioEvento
(
IdCometarioEvento int primary key identity,
IdUsuario int foreign key references Usuario(IdUsuario) not null,
IdEvento int foreign key references Evento(IdEvento) not null,
Descricao varchar(200) not null, 
Exibe bit default(0)
)