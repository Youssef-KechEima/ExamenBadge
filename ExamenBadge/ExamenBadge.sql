create database Badge;

use Badge;
go
create table Groupe(
IdGroupe int identity(1,1),
NomGroupe varchar(50),
constraint pk_groupe primary key (IdGroupe));
go
create table Stagiaire(
IdStagiaire int identity(1,1),
NomStagiaire varchar(50),
PrenomStagiaire varchar(50),
Photo varchar(10),
IdGroupe int,
constraint pk_Stagiaire primary key (IdStagiaire),
constraint fk_Groupe foreign key (IdGroupe) references Groupe(IdGroupe))