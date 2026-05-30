-- DDL
IF DB_ID('Parcial2Krba') IS NULL
BEGIN
    CREATE DATABASE Parcial2Krba;
END
GO

USE master
GO

IF NOT EXISTS (SELECT 1 FROM sys.sql_logins WHERE name = 'usrparcial2')
BEGIN
    CREATE LOGIN usrparcial2 WITH PASSWORD = '12345678',
        DEFAULT_DATABASE = Parcial2Krba,
        CHECK_EXPIRATION = OFF,
        CHECK_POLICY = ON;
END
GO

USE Parcial2Krba
GO

IF NOT EXISTS (SELECT 1 FROM sys.database_principals WHERE name = 'usrparcial2')
BEGIN
    CREATE USER usrparcial2 FOR LOGIN usrparcial2;
END
GO

ALTER ROLE db_owner ADD MEMBER usrparcial2
GO

DROP PROC IF EXISTS paProgamaListar;
DROP TABLE IF EXISTS Progama;
DROP TABLE IF EXISTS Canal;
GO

CREATE TABLE Canal (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  nombre VARCHAR(50) NOT NULL,
  frecuencia VARCHAR(20) NOT NULL,
  usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME(),
  fechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
  estado SMALLINT NOT NULL DEFAULT 1
);

CREATE TABLE Progama (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idCanal INT NOT NULL,
  titulo VARCHAR(100) NOT NULL,
  descripcion VARCHAR(250) NOT NULL,
  duracion INT NOT NULL,
  productor VARCHAR(100) NOT NULL,
  fechaEstreno DATE NOT NULL,
  usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME(),
  fechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
  estado SMALLINT NOT NULL DEFAULT 1,
  CONSTRAINT fk_Progama_Canal FOREIGN KEY (idCanal) REFERENCES Canal(id)
);
GO

CREATE PROC paProgamaListar @parametro VARCHAR(50)
AS
BEGIN
  SELECT p.id, p.idCanal, c.nombre AS canal, p.titulo, p.descripcion,
         p.duracion, p.productor, p.fechaEstreno,
         p.usuarioRegistro, p.fechaRegistro, p.estado
  FROM Progama p
  INNER JOIN Canal c ON c.id = p.idCanal
  WHERE p.estado = 1
    AND p.titulo + c.nombre + p.productor LIKE '%' + REPLACE(@parametro,' ','%') + '%'
  ORDER BY p.titulo;
END
GO

INSERT INTO Canal (nombre, frecuencia) VALUES ('Unitel', 'Canal 2 VHF');
INSERT INTO Canal (nombre, frecuencia) VALUES ('Red Uno', 'Canal 13 VHF');
INSERT INTO Canal (nombre, frecuencia) VALUES ('Bolivision', 'Canal 5 VHF');
INSERT INTO Canal (nombre, frecuencia) VALUES ('ATB', 'Canal 9 VHF');
INSERT INTO Canal (nombre, frecuencia) VALUES ('PAT', 'Canal 4 VHF');
INSERT INTO Canal (nombre, frecuencia) VALUES ('Bolivia TV', 'Canal 7 VHF');

INSERT INTO Progama (idCanal, titulo, descripcion, duracion, productor, fechaEstreno)
VALUES (1, 'Telepais Central', 'Noticiero principal de la noche con cobertura nacional e internacional', 90, 'Unitel Cochabamba', '2015-03-10');
INSERT INTO Progama (idCanal, titulo, descripcion, duracion, productor, fechaEstreno)
VALUES (1, 'La Revista', 'Programa matutino con noticias, cocina, clima y entretenimiento', 180, 'Unitel Santa Cruz', '2012-01-15');
INSERT INTO Progama (idCanal, titulo, descripcion, duracion, productor, fechaEstreno)
VALUES (2, 'Notivision Central', 'Informativo nocturno de la red naranja', 75, 'Red Uno La Paz', '2016-05-22');
INSERT INTO Progama (idCanal, titulo, descripcion, duracion, productor, fechaEstreno)
VALUES (2, 'Que No Me Pierda', 'Programa nocturno de debate, entrevistas y analisis de actualidad', 120, 'Red Uno Santa Cruz', '2010-08-04');
INSERT INTO Progama (idCanal, titulo, descripcion, duracion, productor, fechaEstreno)
VALUES (3, 'Al Dia Revista', 'Noticiero y variedades matinales de gran sintonia popular', 150, 'Bolivision La Paz', '2014-11-01');
INSERT INTO Progama (idCanal, titulo, descripcion, duracion, productor, fechaEstreno)
VALUES (3, 'Secuencia Policial', 'Cronicas y reportajes sobre seguridad ciudadana y sucesos', 45, 'Bolivision Cochabamba', '2019-07-11');
INSERT INTO Progama (idCanal, titulo, descripcion, duracion, productor, fechaEstreno)
VALUES (4, 'ATB Noticias Central', 'Espacio informativo estelar de la red nacional', 60, 'ATB Red Nacional', '2011-06-14');
INSERT INTO Progama (idCanal, titulo, descripcion, duracion, productor, fechaEstreno)
VALUES (4, 'Anoticiando', 'Programa periodistico de analisis profundo y entrevistas politicas', 90, 'ATB La Paz', '2019-09-05');
INSERT INTO Progama (idCanal, titulo, descripcion, duracion, productor, fechaEstreno)
VALUES (5, 'Hola Pais', 'Revista matinal interactiva con enfoque ciudadano y de entretenimiento', 120, 'PAT Santa Cruz', '2013-04-18');
INSERT INTO Progama (idCanal, titulo, descripcion, duracion, productor, fechaEstreno)
VALUES (6, 'BTV Noticias Edicion Central', 'Informativo institucional de la red estatal', 60, 'Bolivia TV Central', '2009-08-30');
INSERT INTO Progama (idCanal, titulo, descripcion, duracion, productor, fechaEstreno)
VALUES (6, 'Deportes BTV', 'Transmisiones en vivo y analisis del futbol y disciplinas nacionales', 90, 'BTV Deportes', '2021-02-12');
GO

SELECT * FROM Canal;
SELECT * FROM Progama;
EXEC paProgamaListar 'Noticias Central';