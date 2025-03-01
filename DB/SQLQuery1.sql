--CREACION DE BASE DE DATOS

create database TareasDB  

--PARARSE EN LA BASE DE DATOS Y USARLA

use TareasDB;

--CREACION DE TABLAS

create table Usuarios(
ID int primary key identity,
nombreUsuario varchar(20),
contrasena varchar(20),
correo varchar(20),
fechaCreacion date
);


create table Categorias(
ID int primary key identity,
nombre varchar(20),
descripcion varchar(30),
fechaCreacion date
);

create table Estados(
ID int primary key identity,
nombreEstado varchar(20)
);



create table Tareas(
ID int primary key identity,
titulo varchar(20),
descripcion varchar(30),
categoriaId int foreign key references Categorias(ID),
usuarioId int foreign key references Usuarios(ID),
estadoId int foreign key references Estados(ID),
fechaCreacion date,
fechaVencimiento date
);