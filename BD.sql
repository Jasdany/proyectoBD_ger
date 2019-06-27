Create DataBase BD_ger

Go 
Use BD_ger

Create table Usuarios(
idusuario int primary key identity (1,1),
cedula varchar (14),
nombres varchar (50),
apellidos varchar (50),
email varchar (80),
telefono varchar (10)
CONSTRAINT Usuario_Cedula UNIQUE (cedula,email,telefono)
);


Create table Cuentas(
idcuenta int primary key identity (1,1),
nombreuser varchar (30),
clave varchar (30),
rol varchar (30),
idusuario int,
foreign key (idusuario) references Usuarios (idusuario),
CONSTRAINT NombreUser_Clave UNIQUE (clave,nombreuser)
);

Create table Recursos(
idrecursos int primary key identity (1,1),
nombre varchar (50),
codigo varchar (50),
descripcion varchar (50)
CONSTRAINT NombreRecursos_Codigo UNIQUE (nombre,codigo)
);

Create table Solicitud(
idsolicitud int primary key identity (1,1),
aula varchar (10),
nivel varchar (4),
fechasolicitud datetime DEFAULT GETDATE(),
fechauso date,
horainicio time,
horafinal time,
carrera varchar (max),
asignatura varchar (max),
idrecursos int,
idusuario int,
foreign key (idrecursos) references Recursos (idrecursos),
foreign key (idusuario) references Usuarios (idusuario),
CONSTRAINT Nivel CHECK (nivel='I' OR nivel='II' OR nivel='III' OR nivel='IV'OR nivel='V'),
);

Create table comentarios(
idcomentarios int primary key identity (1,1),
nombres varchar (100) not null,
correo varchar (80)not null,
telefono varchar (10) not null,
mensaje varchar (max) not null
);

