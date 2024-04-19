create database Exercicio_1_4

use Exercicio_1_4

create table Artistas
(
IdArtista int primary key identity,
Nome varchar(20)
)

create table Usuarios
(
IdUsuario int primary key identity,
Nome varchar(20),
Email varchar(20),
Senha varchar(20),
Permissao varchar(20)
)

create table Estilos
(
IdEstilo int primary key identity,
Nome varchar(20)
)

create table Albuns
(
IdAlbum int primary key identity,
IdArtista int foreign key references Artistas(IdArtista),
Titulo varchar(20),
DataLancamento varchar(20),
Localizacao varchar(20),
QtdMinutos varchar(20), 
Ativo varchar(20)
)

create table AlbunsEstilos
(
IdAlbum int foreign key references Albuns(IdAlbum),
IdEstilos int foreign key references Estilos(IdEstilo)
)