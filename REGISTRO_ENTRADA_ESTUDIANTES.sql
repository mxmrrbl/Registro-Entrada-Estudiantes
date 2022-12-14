CREATE DATABASE REGISTRO_ENTRADA_ESTUDIANTES

USE REGISTRO_ENTRADA_ESTUDIANTES

----Tablas---

CREATE TABLE USUARIOS
(
ID INT IDENTITY (1,1) PRIMARY KEY,
NOMBRE NVARCHAR(20)  NOT NULL,
APELLIDO NVARCHAR(20)  NOT NULL,
FECHA_NACIMIENTO DATE NOT NULL,
USUARIO AS (SUBSTRING(TIPO,1,3) + '-'+ NOMBRE + '-' + CONVERT(NVARCHAR,ID)),
CONTRASEŅA NVARCHAR(20) NOT NULL,
TIPO NVARCHAR(20) NOT NULL
)

CREATE TABLE EDIFICIOS
(
ID INT IDENTITY (1,1) PRIMARY KEY,
NOMBRE NVARCHAR(20) NOT NULL UNIQUE
)

CREATE TABLE AULAS
(
ID INT IDENTITY (1,1) PRIMARY KEY,
ID_EDIFICIO INT NOT NULL,
PISO INT NOT NULL,
NOMBRE NVARCHAR(20) NOT NULL,
CODIGO AS ('E'+ CONVERT(NVARCHAR, ID_EDIFICIO) + ' - '+ 'P'+ CONVERT(NVARCHAR, PISO) + ' - ' + NOMBRE)
)

CREATE TABLE ENTRADAS
(
ID INT IDENTITY (1,1) PRIMARY KEY,
MATRICULA NVARCHAR(20) NOT NULL,
NOMBRE NVARCHAR(20) NOT NULL,
APELLIDO NVARCHAR(20) NOT NULL,
EDIFICIO NVARCHAR(20) NOT NULL,
AULA NVARCHAR(20) NOT NULL,
ENTRADA DATETIME NOT NULL,
SALIDA DATETIME NOT NULL,
MOTIVO NVARCHAR(50) NOT NULL
)


INSERT INTO USUARIOS VALUES 
('MANUEL', 'MEDINA','2002-02-04', '1234', 'ADMINISTRADOR' ),
('MARCOS', 'ESPINAL','2002-07-06', '1234', 'GENERAL' )

INSERT INTO EDIFICIOS VALUES
('EDIFICIO 1'),
('EDIFICIO 2'),
('EDIFICIO 3'),
('EDIFICIO 4')

INSERT INTO AULAS VALUES
(2,2,'B'),
(1,3,'A'),
(3,1,'C'),
(4,2,'B')



INSERT INTO ENTRADAS VALUES
('2022-1002', 'ANDRES', 'TORREZ', 'EDIFICIO II', 'E2 - P1 - B', '2022-08-015', '2022-08-015', 'TOMAR CLASE');




--[SP USUARIO]



CREATE PROCEDURE SP_VALIDAR_USUARIO
@USUARIO NVARCHAR(20),
@CONTRASEŅA NVARCHAR(20)
AS
SELECT NOMBRE, APELLIDO, TIPO
FROM USUARIOS
WHERE USUARIO = @USUARIO AND CONTRASEŅA = @CONTRASEŅA


CREATE PROCEDURE SP_BUSCAR_USUARIO
@BUSCAR NVARCHAR(20)
AS
SELECT * 
FROM USUARIOS
WHERE USUARIO LIKE ('%' + @BUSCAR + '%')

GO


CREATE PROCEDURE SP_INSERTAR_USUARIO
@NOMBRE NVARCHAR(20),
@APELLIDO NVARCHAR(20),
@FECHA_NACIMIENTO DATE,
@CONTRASEŅA NVARCHAR(20),
@TIPO NVARCHAR(20)
AS
INSERT INTO USUARIOS VALUES (@NOMBRE, @APELLIDO, @FECHA_NACIMIENTO, @CONTRASEŅA, @TIPO)

GO

CREATE PROCEDURE SP_EDITAR_USUARIO
@ID INT,
@NOMBRE NVARCHAR(20),
@APELLIDO NVARCHAR(20),
@FECHA_NACIMIENTO DATE,
@CONTRASEŅA NVARCHAR(20),
@TIPO NVARCHAR(20)
AS
UPDATE USUARIOS SET NOMBRE = @NOMBRE, APELLIDO = @APELLIDO, FECHA_NACIMIENTO = @FECHA_NACIMIENTO, CONTRASEŅA = @CONTRASEŅA, TIPO = @TIPO
WHERE ID = @ID

GO

CREATE PROCEDURE SP_ELIMINAR_USUARIO
@ID INT
AS
DELETE FROM USUARIOS
WHERE ID = @ID




--[SP AULA]




CREATE PROCEDURE SP_CARGAR_AULAS
@ID_EDIFICIO INT
AS
SELECT ID, CODIGO
FROM AULAS
WHERE ID_EDIFICIO = @ID_EDIFICIO


CREATE PROCEDURE SP_BUSCAR_AULA
@BUSCAR NVARCHAR(20)
AS
SELECT * 
FROM AULAS
WHERE CODIGO LIKE ('%' + @BUSCAR + '%')

GO

CREATE PROCEDURE SP_INSERTAR_AULA
@ID_EDIFICIO INT,
@PISO INT,
@NOMBRE NVARCHAR(20)
AS
INSERT INTO AULAS VALUES (@ID_EDIFICIO, @PISO, @NOMBRE)

GO

CREATE PROCEDURE SP_EDITAR_AULA
@ID INT,
@ID_EDIFICIO INT,
@PISO INT,
@NOMBRE NVARCHAR(20)
AS
UPDATE AULAS SET ID_EDIFICIO = @ID_EDIFICIO, PISO = @PISO, NOMBRE = @NOMBRE
WHERE ID = @ID

GO

CREATE PROCEDURE SP_ELIMINAR_AULA
@ID INT
AS
DELETE FROM AULAS
WHERE ID = @ID



--[SP EDIFICIO]



CREATE PROCEDURE SP_CARGAR_EDIFICIOS
AS
SELECT ID, NOMBRE 
FROM EDIFICIOS

GO

CREATE PROCEDURE SP_BUSCAR_EDIFICIO
@BUSCAR NVARCHAR(20)
AS
SELECT * 
FROM EDIFICIOS
WHERE ID LIKE (@BUSCAR + '%')

GO

CREATE PROCEDURE SP_INSERTAR_EDIFICIO
@NOMBRE NVARCHAR(20)
AS
INSERT INTO EDIFICIOS VALUES (@NOMBRE)

GO

CREATE PROCEDURE SP_EDITAR_EDIFICIO
@ID INT,
@NOMBRE NVARCHAR(20)
AS
UPDATE EDIFICIOS SET  NOMBRE = @NOMBRE
WHERE ID = @ID

CREATE PROCEDURE SP_ELIMINAR_EDIFICIO
@ID INT
AS
DELETE FROM EDIFICIOS
WHERE ID = @ID

GO



--[SP ENTRADAS]



CREATE PROCEDURE SP_BUSCAR_ENTRADA
@BUSCAR NVARCHAR(20)
AS
SELECT * 
FROM ENTRADAS
WHERE MATRICULA LIKE (@BUSCAR + '%')

GO


CREATE PROCEDURE SP_INSERTAR_ENTRADA
@MATRICULA NVARCHAR(20),
@NOMBRE NVARCHAR(20),
@APELLIDO NVARCHAR(20),
@EDIFICIO NVARCHAR(20),
@AULA NVARCHAR(20),
@ENTRADA DATETIME,
@SALIDA DATETIME,
@MOTIVO NVARCHAR(50)
AS
INSERT INTO ENTRADAS VALUES (@MATRICULA, @NOMBRE, @APELLIDO, @EDIFICIO, @AULA, @ENTRADA, @SALIDA, @MOTIVO)

GO

CREATE PROCEDURE SP_EDITAR_ENTRADA
@ID INT,
@MATRICULA NVARCHAR(20),
@NOMBRE NVARCHAR(20),
@APELLIDO NVARCHAR(20),
@EDIFICIO NVARCHAR(20),
@AULA NVARCHAR(20),
@ENTRADA DATETIME,
@SALIDA DATETIME,
@MOTIVO NVARCHAR(50)
AS
UPDATE ENTRADAS SET MATRICULA = @MATRICULA, NOMBRE = @NOMBRE, APELLIDO = @APELLIDO, EDIFICIO = @EDIFICIO, AULA = @AULA, ENTRADA = @ENTRADA, SALIDA = @SALIDA, MOTIVO = @MOTIVO  
WHERE ID = @ID

GO

CREATE PROCEDURE SP_ELIMINAR_ENTRADAS
@ID INT
AS
DELETE FROM ENTRADAS
WHERE ID = @ID


SELECT*
FROM ENTRADAS


SELECT*
FROM USUARIOS
