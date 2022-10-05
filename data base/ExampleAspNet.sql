create database ExampleAspNet;


create table Brand
(
Brandld varchar not null primary key,
NameB varchar
)

create table Beer
(
Beerld varchar,
NameBe varchar,
Brandld varchar not null,
constraint fk_Brandld foreign key (Brandld) references Brand (Brandld) 
)

create table users(
Id int identity(1,1) primary key,
name_user varchar(20),
fecha date,
clave varchar(50)
)