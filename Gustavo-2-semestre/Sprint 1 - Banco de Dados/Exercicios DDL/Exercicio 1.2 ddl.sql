create database Exercicio_1_2

use Exercicio_1_2

create table Empresa
(
IdEmpresa int primary key identity,
Nome varchar(30)
)

create table Cliente
(
IdCliente int primary key identity,
Nome varchar(30),
Cpf varchar(11) not null unique
)

create table Modelo
(
IdModelo int primary key identity,
Nome varchar(20)
)

create table Marca
(
IdMarca int primary key identity,
Nome varchar(20)
)

create table Veiculo
(
IdVeiculo int primary key identity,
IdEmpresa int foreign key references Empresa(IdEmpresa),
IdModelo int foreign key references Modelo(IdModelo),
IdMarca int foreign key references Marca(IdMarca),
Placa varchar(20) unique
)

create table Aluguel
(
IdAluguel int primary key identity,
IdVeiculo int foreign key references Veiculo(IdVeiculo),
IdCliente int foreign key references Cliente(IdCliente),
Protocolo varchar(20)
)

select * from Empresa
select * from Cliente
select * from Modelo
select * from Marca
select * from Veiculo
select * from Aluguel

