create database Exercicio_1_3

use Exercicio_1_3

create table Clinica
(
IdClinica int primary key identity,
Endereco varchar (20) not null 
)

create table Veterinario
(
IdVeterinario int primary key identity,
IdClinica int foreign key references Clinica(IdClinica),
Nome varchar(20),
CRMV varchar(20)
)

create table Dono
(
IdDono int primary key identity,
Nome varchar(20)
)

create table TipoPet
(
IdTipoPet int primary key identity,
Descricao varchar(20)
)

create table Raca
(
IdRaca int primary key identity,
Descricao varchar(20)
)

create table Pet
(
IdPet int primary key identity,
IdTipoPet int foreign key references TipoPet(IdTipoPet),
IdRaca int foreign key references Raca(IdRaca),
IdDono int foreign key references Dono(IdDono) not null,
Nome varchar(20),
DataNascimento varchar(20)
)

create table Atendimentos 
(
IdAtendimento int primary key identity,
IdVeterinario int foreign key references Veterinario(IdVeterinario),
IdPet int foreign key references Pet(IdPet),
Descricao varchar(20),
DataAtendimento varchar(20)
)