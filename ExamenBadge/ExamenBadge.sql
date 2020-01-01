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
constraint fk_Groupe foreign key (IdGroupe) references Groupe(IdGroupe));


insert into Groupe values ('TDI101'),('TDI102'),('TDI103'),('TDI201'),('TDI202');

insert into Stagiaire values ('AitWhamane','Youssef','1.jpg',4),('Amraoui','Houssam','2.jpg',4),('Chraoui','Mouhsin','3.jpg',2),('Bakouri','Mokhtar','4jpg',3),('hhhhh','trrr','5.jpg',5),('pppp','uuuu','6.jpg',1);


alter table Stagiaire add dateNaissance date;
go
alter table Stagiaire add Cin Varchar(10);

