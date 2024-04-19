--DDL

create database HealthClinic

use HealthClinic

create table Clinica
(
IdClinica int primary key identity,
Nome varchar(50),
CNPJ char(14) not null unique,
Endereco varchar(50) not null,
RazaoSocial varchar(250),
HoraAbertura time not null,
HoraFechamento time not null
)

create table Usuario 
(
IdUsuario int primary key identity,
Nome varchar(50) not null,
DataNascimento date not null,
Email varchar(50) not null unique,
Senha varchar(50) not null
)

create table Especialidade
(
IdEspecialidade int primary key identity,
Titulo varchar(250) not null
)

create table Paciente
(
IdPaciente int primary key identity,
IdUsuario int foreign key references Usuario(IdUsuario),
Telefone varchar(50) not null,
Endereco varchar (50),
Email varchar(50) not null,
RG char(9) not null unique,
CPF char(11) not null unique
)

create table Medico
(
IdMedico int primary key identity,
IdEspecialidade int foreign key references Especialidade(IdEspecialidade),
IdUsuario int foreign key references Usuario(IdUsuario),
CRM char(9),
Expediente varchar(50)
)

create table Consulta 
(
IdConsulta int primary key identity,
IdMedico int foreign key references Medico(IdMedico),
IdPaciente int foreign key references Paciente(IdPaciente),
Dia date,
Horario time,
Prontuario varchar (100)
)

create table Comentario
(
IdComentario int primary key identity,
IdUsuario int foreign key references Usuario(IdUsuario),
IdClinica int foreign key references Clinica(IdClinica),
Descricao varchar(250)
)