--Criar o banco 
create database Exercicio_1_1;

--Usar o banco criado
use Exercicio_1_1;

--criar tabelas
create table Pessoa
(
IdPessoa int primary key identity,
Nome varchar (20) not null,
CNH char(10) not null unique
)

create table Telefone
(
IdTelefone int primary key identity,
IdPessoa int foreign key references Pessoa(IdPessoa) not null,
Numero varchar(20) not null unique 
)

create table Email
(
IdEmail int primary key identity,
IdPessoa int foreign key references Pessoa(IdPessoa) not null,
EnderecoEmail varchar(30) not null unique
)

select * from Pessoa
select * from Telefone
select * from Email
