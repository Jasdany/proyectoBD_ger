--procedimiento almecenado de la tabla comentarios

Use BD_ger

CREATE PROCEDURE comentar 
@b int, @idcomentario int,@nombres varchar(100),@correo varchar (50),@telefono varchar(10),@mensaje varchar (max)
AS
BEGIN
SET NOCOUNT ON;
IF @b=1
INSERT INTO comentarios VALUES (@nombres,@correo,@telefono,@mensaje);

IF @b=2
DELETE FROM comentarios WHERE idcomentarios=@idcomentario;

IF @b=3
SELECT * FROM comentarios

IF @b=4
  UPDATE comentarios SET nombres=@nombres,correo=@correo,telefono=@telefono,mensaje=@mensaje 
 
  WHERE idcomentarios=@idcomentario;

 IF @b=5
 SELECT * FROM comentarios
 WHERE nombres LIKE '%' + @nombres + '%' OR
 correo LIKE '%' + @correo + '%'

END
GO

--procedimiento almacenado tabla recursos
CREATE PROCEDURE recurso 
@b int, @idrecurso int,@nombre varchar(50),@codigo varchar (50),@descripcion varchar(50)
AS
BEGIN
SET NOCOUNT ON;
IF @b=1
INSERT INTO Recursos VALUES (@nombre,@codigo,@descripcion);

IF @b=2
DELETE FROM Recursos WHERE idrecursos=@idrecurso;

IF @b=3
SELECT * FROM Recursos;

IF @b=4
  UPDATE Recursos SET nombre=@nombre,codigo=@codigo,descripcion=@descripcion
 
  WHERE idrecursos=@idrecurso;

IF @b=5
SELECT * FROM Recursos
WHERE nombre=@nombre


END
GO

--procedimiento almacenado de la tabla cuentas

CREATE PROCEDURE cuenta
@b int, @idcuenta int,@nombreuser varchar(30),@clave varchar (30),@rol varchar (30), @idusuario int
AS 
BEGIN

SET NOCOUNT ON;

IF @B=1
 INSERT INTO Cuentas VALUES (@nombreuser,@clave,@rol,@idusuario);

 IF @b=2
 DELETE FROM  Cuentas WHERE  idcuenta=@idcuenta;

 IF @b=3
 SELECT *FROM Cuentas

 IF @b=4
 Update Cuentas SET nombreuser=@nombreuser, clave=@clave,rol=@rol
 Where idcuenta=@idcuenta

 IF @b=5
 SELECT * FROM Cuentas 
 WHERE nombreuser LIKE '%' + @nombreuser + '%' OR
clave LIKE '%' + @clave + '%'

 END 
 GO



 --procedimiento almacenado de la tabla solicitud

 CREATE PROCEDURE  solicitudes
@b int, @idsolicitud int, @aula varchar (10),@nivel varchar (4),@fechasolicitud datetime, @fechauso datetime, @horainicio time(7),
@horafinal time(7), @carrera varchar(max),@asignatura varchar (max),@iderecursos int, @idusuario int 

AS 
BEGIN

SET NOCOUNT ON;

IF @B=1
 INSERT INTO Solicitud VALUES (@aula,@nivel,@fechasolicitud,@fechauso,@horainicio,@horafinal,@carrera,@asignatura,@iderecursos,@idusuario);

 IF @b=2
 DELETE FROM  Solicitud WHERE  idsolicitud=@idsolicitud;

 IF @b=3
 SELECT *FROM Solicitud

 IF @b=4
 Update Solicitud SET aula=@aula,nivel=@nivel,fechasolicitud=@fechasolicitud,fechauso=@fechauso,horainicio=@horainicio,
        horafinal=@horafinal,carrera=@carrera,asignatura=@asignatura
 Where idsolicitud=@idsolicitud


 IF @b=5
 SELECT * FROM Solicitud 
 WHERE asignatura LIKE '%' + @asignatura + '%' OR
 fechasolicitud LIKE '%' + @fechasolicitud + '%'


 END 
 GO

 --procedimiento almecenado tabla usuario

 CREATE PROCEDURE usuario
@b int, @idusuario int,@cedula varchar(14),@nombres varchar(50),@apellidos varchar(50),@email varchar(80),@telefono varchar(10)
AS 
BEGIN

SET NOCOUNT ON;

IF @B=1
 INSERT INTO Usuarios VALUES (@cedula,@nombres,@apellidos,@email,@telefono);

 IF @b=2
 DELETE FROM  Usuarios WHERE  idusuario=@idusuario;

 IF @b=3
 SELECT *FROM Usuarios;

 IF @b=4
 Update Usuarios SET cedula=@cedula,nombres=@nombres,apellidos=@apellidos,email=@email,telefono=@telefono
 Where idusuario=@idusuario


 IF @b=5
  SELECT * FROM Usuarios
 WHERE nombres LIKE '%' + @nombres + '%' OR
 apellidos LIKE '%' + @apellidos + '%'


 END 
 GO
