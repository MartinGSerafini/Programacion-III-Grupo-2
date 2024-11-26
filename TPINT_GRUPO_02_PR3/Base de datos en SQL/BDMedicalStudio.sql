USE MASTER
ALTER DATABASE MedicalStudio SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
DROP DATABASE MedicalStudio

-- Crea la base de datos.

CREATE DATABASE MedicalStudio;
GO

USE MedicalStudio;
GO

-- Tabla Provincias
CREATE TABLE PROVINCIAS (
    ID_PROVINCIA_PRO INT IDENTITY(1,1) PRIMARY KEY,
    NOMBRE_PRO VARCHAR(30)
);
GO
INSERT PROVINCIAS(NOMBRE_PRO)
SELECT 'Buenos Aires' UNION
SELECT 'Catamarca' UNION
SELECT 'Chaco' UNION
SELECT 'Chubut' UNION
SELECT 'Córdoba' UNION
SELECT 'Corrientes' UNION
SELECT 'Entre Ríos' UNION
SELECT 'Formosa' UNION
SELECT 'Jujuy' UNION
SELECT 'La Pampa' UNION
SELECT 'La Rioja' UNION
SELECT 'Mendoza' UNION
SELECT 'Misiones' UNION
SELECT 'Neuquén' UNION
SELECT 'Río Negro' UNION
SELECT 'Salta' UNION
SELECT 'San Juan' UNION
SELECT 'San Luis' UNION
SELECT 'Santa Cruz' UNION
SELECT 'Santa Fe' UNION
SELECT 'Santiago del Estero' UNION
SELECT 'Tierra del Fuego' UNION
SELECT 'Tucumán'
GO

-- Tabla Localidades
CREATE TABLE LOCALIDADES(
    ID_LOCALIDAD_LOC INT IDENTITY(1,1) PRIMARY KEY,
    FK_ID_PROVINCIA_LOC INT,
    NOMBRE_LOC VARCHAR(40),
    FOREIGN KEY (FK_ID_PROVINCIA_LOC) REFERENCES Provincias(ID_PROVINCIA_PRO)
);
GO

INSERT INTO LOCALIDADES (FK_ID_PROVINCIA_LOC, NOMBRE_LOC)
SELECT 1, 'La Plata' UNION --BUENOS AIRES
SELECT 1, 'Don Torcuato' UNION
SELECT 1, 'Mar del Plata' UNION
SELECT 1, 'Bahía Blanca' UNION
SELECT 1, 'Tandil' UNION
SELECT 1, 'Avellaneda' UNION
SELECT 1, 'Lanús' UNION
SELECT 1, 'Quilmes' UNION
SELECT 2, 'San Fernando del Valle' UNION --CATAMARCA
SELECT 2, 'Belén' UNION
SELECT 2, 'Andalgalá' UNION
SELECT 2, 'Santa María' UNION
SELECT 3, 'Resistencia' UNION --Chaco
SELECT 3, 'Barranqueras' UNION
SELECT 3, 'Saenz Peña' UNION
SELECT 3, 'Villa Ángela' UNION
SELECT 4, 'Rawson' UNION --Chubut
SELECT 4, 'Trelew' UNION
SELECT 4, 'Comodoro Rivadavia' UNION
SELECT 4, 'Puerto Madryn' UNION
SELECT 5, 'Córdoba' UNION --Córdoba
SELECT 5, 'Río Cuarto' UNION
SELECT 5, 'Villa María' UNION
SELECT 5, 'Bell Ville' UNION
SELECT 6, 'Corrientes' UNION --Corrientes
SELECT 6, 'Goya' UNION
SELECT 6, 'Paso de los Libres' UNION
SELECT 6, 'Mercedes' UNION
SELECT 7, 'Paraná' UNION --Entre Ríos
SELECT 7, 'Concordia' UNION
SELECT 7, 'Gualeguaychú' UNION
SELECT 7, 'Colón' UNION
SELECT 8, 'Formosa' UNION --Formosa
SELECT 8, 'Clorinda' UNION
SELECT 8, 'Pirané' UNION
SELECT 9, 'San Salvador de Jujuy' UNION --Jujuy
SELECT 9, 'Palpalá' UNION
SELECT 9, 'Perico' UNION
SELECT 10, 'Santa Rosa' UNION --La Pampa
SELECT 10, 'General Pico' UNION
SELECT 10, 'Realico' UNION
SELECT 11, 'La Rioja' UNION --La Rioja
SELECT 11, 'Chilecito' UNION
SELECT 11, 'Villa Unión' UNION
SELECT 12, 'Mendoza' UNION --Mendoza
SELECT 12, 'San Rafael' UNION
SELECT 12, 'Malargüe' UNION
SELECT 13, 'Posadas' UNION --Misiones
SELECT 13, 'Oberá' UNION
SELECT 13, 'Iguazú' UNION
SELECT 14, 'Neuquén' UNION --Neuquén
SELECT 14, 'San Martín de los Andes' UNION
SELECT 14, 'Cutral Co' UNION
SELECT 15, 'Viedma' UNION --Río Negro
SELECT 15, 'General Roca' UNION
SELECT 15, 'Cipolletti' UNION
SELECT 16, 'Salta' UNION --Salta
SELECT 16, 'Orán' UNION
SELECT 16, 'Tartagal' UNION
SELECT 17, 'San Juan' UNION --San Juan
SELECT 17, 'Rawson' UNION
SELECT 17, 'Ullum' UNION
SELECT 18, 'San Luis' UNION --San Luis
SELECT 18, 'Villa Mercedes' UNION
SELECT 19, 'Río Gallegos' UNION --Santa Cruz
SELECT 19, 'El Calafate' UNION
SELECT 19, 'Pico Truncado' UNION
SELECT 20, 'Santa Fe' UNION --Santa Fe
SELECT 20, 'Rosario' UNION
SELECT 20, 'Rafaela' UNION
SELECT 21, 'Santiago del Estero' UNION --Santiago del Estero
SELECT 21, 'La Banda' UNION
SELECT 21, 'Termas de Río Hondo' UNION
SELECT 22, 'Ushuaia' UNION --Tierra del Fuego
SELECT 22, 'Rio Grande' UNION
SELECT 23, 'San Miguel de Tucumán' UNION --Tucumán
SELECT 23, 'Concepción' UNION
SELECT 23, 'Tafí Viejo'
GO

-- Tabla Tipo de Usuario
CREATE TABLE TIPO_USUARIO(
    ID_TIPO_USUARIO_TDU INT PRIMARY KEY,
    NOMBRE_TDU VARCHAR(50)
);
GO
INSERT TIPO_USUARIO(ID_TIPO_USUARIO_TDU, NOMBRE_TDU)
SELECT 1, 'Administrador' UNION
SELECT 2, 'Medico'
GO

-- Tabla Usuarios
CREATE TABLE USUARIOS(
    ID_USUARIO_USU INT IDENTITY(1,1) PRIMARY KEY,
    FK_ID_TIPO_USUARIO_USU INT,
    FK_DNI_USU CHAR(8) UNIQUE,
    CONTRA_USU VARCHAR(20),
    FECHA_CREACION_USU DATE,
    FOREIGN KEY (FK_ID_TIPO_USUARIO_USU) REFERENCES TIPO_USUARIO(ID_TIPO_USUARIO_TDU),
    UNIQUE (FK_DNI_USU)
);
GO

INSERT INTO USUARIOS (FK_ID_TIPO_USUARIO_USU, FK_DNI_USU, CONTRA_USU, FECHA_CREACION_USU)
SELECT 1, '10000001', 'contraseña1', GETDATE() UNION
SELECT 1, '10000002', 'contraseña2', GETDATE() UNION
SELECT 1, '10000003', 'contraseña3', GETDATE() UNION
SELECT 1, '10000004', 'contraseña4', GETDATE() UNION
SELECT 1, '10000005', 'contraseña5', GETDATE() UNION
SELECT 1, '10000006', 'contraseña6', GETDATE() UNION
SELECT 1, '10000007', 'contraseña7', GETDATE() UNION
SELECT 1, '10000008', 'contraseña8', GETDATE() UNION
SELECT 1, '10000009', 'contraseña9', GETDATE() UNION
SELECT 1, '10000010', 'contraseña10', GETDATE() UNION
SELECT 1, '10000011', 'contraseña11', GETDATE() UNION
SELECT 1, '10000012', 'contraseña12', GETDATE() UNION
SELECT 1, '10000013', 'contraseña13', GETDATE() UNION
SELECT 1, '10000014', 'contraseña14', GETDATE() UNION
SELECT 1, '10000015', 'contraseña15', GETDATE() UNION
SELECT 2, '20000001', 'contraseña1', GETDATE() UNION
SELECT 2, '20000002', 'contraseña2', GETDATE() UNION
SELECT 2, '20000003', 'contraseña3', GETDATE() UNION
SELECT 2, '20000004', 'contraseña4', GETDATE() UNION
SELECT 2, '20000005', 'contraseña5', GETDATE() UNION
SELECT 2, '20000006', 'contraseña6', GETDATE() UNION
SELECT 2, '20000007', 'contraseña7', GETDATE() UNION
SELECT 2, '20000008', 'contraseña8', GETDATE() UNION
SELECT 2, '20000009', 'contraseña9', GETDATE() UNION
SELECT 2, '20000010', 'contraseña10', GETDATE() UNION
SELECT 2, '20000011', 'contraseña11', GETDATE() UNION
SELECT 2, '20000012', 'contraseña12', GETDATE() UNION
SELECT 2, '20000013', 'contraseña13', GETDATE() UNION
SELECT 2, '20000014', 'contraseña14', GETDATE() UNION
SELECT 2, '20000015', 'contraseña15', GETDATE();
GO

-- Tabla Administrador
CREATE TABLE ADMINISTRADOR(
    ID_USUARIO_DES INT IDENTITY(1,1) PRIMARY KEY,
    FK_DNI_DES CHAR(8) UNIQUE,
    NOMBRE_DES VARCHAR(30),
    APELLIDO_DES VARCHAR(30),
    EMAIL_DES VARCHAR(40),
    TELEFONO_DES VARCHAR(20),
    FOREIGN KEY (ID_USUARIO_DES) REFERENCES USUARIOS(ID_USUARIO_USU)
);
GO
INSERT INTO ADMINISTRADOR(FK_DNI_DES, NOMBRE_DES, APELLIDO_DES, EMAIL_DES, TELEFONO_DES)
SELECT '10000001', 'Juan', 'Pérez', 'juan.perez@example.com', '1123456789' UNION
SELECT '10000002', 'Ana', 'González', 'ana.gonzalez@example.com', '1198765432' UNION
SELECT '10000003', 'Luis', 'Martínez', 'luis.martinez@example.com', '1134567890' UNION
SELECT '10000004', 'María', 'Rodríguez', 'maria.rodriguez@example.com', '1176543210' UNION
SELECT '10000005', 'Carlos', 'Gómez', 'carlos.gomez@example.com', '1145678901' UNION
SELECT '10000006', 'Laura', 'López', 'laura.lopez@example.com', '1167890123' UNION
SELECT '10000007', 'Roberto', 'Díaz', 'roberto.diaz@example.com', '1156789012' UNION
SELECT '10000008', 'Marta', 'Fernández', 'marta.fernandez@example.com', '1189012345' UNION
SELECT '10000009', 'Alberto', 'Ramírez', 'alberto.ramirez@example.com', '1134567899' UNION
SELECT '10000010', 'Cecilia', 'Sánchez', 'cecilia.sanchez@example.com', '1190123456' UNION
SELECT '10000011', 'Diego', 'Ruiz', 'diego.ruiz@example.com', '1145678904' UNION
SELECT '10000012', 'Patricia', 'Jiménez', 'patricia.jimenez@example.com', '1178901234' UNION
SELECT '10000013', 'Ricardo', 'Hernández', 'ricardo.hernandez@example.com', '1155678990' UNION
SELECT '10000014', 'Daniela', 'Castro', 'daniela.castro@example.com', '1147890123' UNION
SELECT '10000015', 'Gabriel', 'Ortiz', 'gabriel.ortiz@example.com', '1198765432';
GO


-- Tabla Especialidades
CREATE TABLE ESPECIALIDADES (
    ID_ESPECIALIDAD_ESP INT IDENTITY(1,1) PRIMARY KEY,
    NOMBRE_ESP VARCHAR(50)
);
GO
INSERT Especialidades(NOMBRE_ESP)
SELECT 'Alergología' UNION
SELECT 'Anestesiología' UNION
SELECT 'Cardiología' UNION
SELECT 'Dermatología' UNION
SELECT 'Endocrinología' UNION
SELECT 'Gastroenterología' UNION
SELECT 'Ginecología' UNION
SELECT 'Neurología' UNION
SELECT 'Oncología' UNION
SELECT 'Oftalmología' UNION
SELECT 'Otorrinolaringología' UNION
SELECT 'Pediatría' UNION
SELECT 'Psiquiatría' UNION
SELECT 'Reumatología' UNION
SELECT 'Traumatología' UNION
SELECT 'Medicina Interna' UNION
SELECT 'Medicina General' UNION
SELECT 'Infectología' UNION
SELECT 'Nefrología' UNION
SELECT 'Neumología' UNION
SELECT 'Cirugía General' UNION
SELECT 'Cirugía Plástica' UNION
SELECT 'Cirugía Cardiaca' UNION
SELECT 'Cirugía Pediátrica'
GO

-- Tabla Medicos
CREATE TABLE MEDICOS(
    ID_MEDICO_MED INT IDENTITY(1,1) PRIMARY KEY,
    FK_DNI_MED CHAR(8) UNIQUE,
    FK_ID_LOCALIDAD_MED INT,
	FK_ID_PROVINCIA_MED INT,
    FK_ID_ESPECIALIDAD_MED INT,
    LEGAJO_MED INT,
    NOMBRE_MED VARCHAR(30),
    APELLIDO_MED VARCHAR(30),
    SEXO_MED CHAR(1),
    NACIONALIDAD_MED VARCHAR(30),
    NACIMIENTO_MED DATE,
    DIRECCION_MED VARCHAR(40),
    EMAIL_MED VARCHAR(40),
	TELEFONO_MED varchar(20),
	ESTADO_MED varchar(20),
    FOREIGN KEY (FK_ID_LOCALIDAD_MED) REFERENCES LOCALIDADES(ID_LOCALIDAD_LOC),
    FOREIGN KEY (FK_ID_ESPECIALIDAD_MED) REFERENCES ESPECIALIDADES(ID_ESPECIALIDAD_ESP)
);
GO

INSERT INTO MEDICOS(FK_DNI_MED, FK_ID_LOCALIDAD_MED, FK_ID_PROVINCIA_MED, FK_ID_ESPECIALIDAD_MED, LEGAJO_MED, NOMBRE_MED, APELLIDO_MED, SEXO_MED, NACIONALIDAD_MED, NACIMIENTO_MED, DIRECCION_MED, EMAIL_MED, TELEFONO_MED, ESTADO_MED)
SELECT '20000001', '6', '1', '1', '11111', 'Juan', 'Perez', 'M', 'Argentino', '2000-01-01', 'Direccion 523', 'juan.perez@example.com', '1123456789', 'Activo' UNION
SELECT '20000002', '12', '2', '2', '11112', 'Maria', 'Gomez', 'F', 'Argentina', '1995-05-12', 'Calle 742', 'maria.gomez@example.com', '1129876543', 'Activo' UNION
SELECT '20000003', '15', '3', '3', '11113', 'Carlos', 'Fernandez', 'M', 'Argentino', '1990-03-22', 'Avenida 456', 'carlos.fernandez@example.com', '1134567890', 'Activo' UNION
SELECT '20000004', '18', '4', '4', '11114', 'Laura', 'Martinez', 'F', 'Argentina', '1992-08-15', 'Calle 321', 'laura.martinez@example.com', '1145678901', 'Activo' UNION
SELECT '20000005', '22', '5', '5', '11115', 'Diego', 'Lopez', 'M', 'Argentino', '1985-12-30', 'Pasaje 987', 'diego.lopez@example.com', '1156789012', 'Activo' UNION
SELECT '20000006', '25', '6', '6', '11116', 'Ana', 'Garcia', 'F', 'Argentina', '1988-11-10', 'Diagonal 123', 'ana.garcia@example.com', '1167890123', 'Activo' UNION
SELECT '20000007', '29', '7', '7', '11117', 'Luis', 'Hernandez', 'M', 'Argentino', '1983-07-25', 'Plaza 456', 'luis.hernandez@example.com', '1178901234', 'Activo' UNION
SELECT '20000008', '35', '8', '8', '11118', 'Victoria', 'Suarez', 'F', 'Argentina', '1998-09-18', 'Callejon 789', 'victoria.suarez@example.com', '1189012345', 'Activo' UNION
SELECT '20000009', '37', '9', '9', '11119', 'Oscar', 'Romero', 'M', 'Argentino', '1991-04-05', 'Boulevard 654', 'oscar.romero@example.com', '1190123456', 'Activo' UNION
SELECT '20000010', '40', '10', '10', '11120', 'Sofia', 'Castro', 'F', 'Argentina', '1997-02-14', 'Calle 789', 'sofia.castro@example.com', '1101234567', 'Activo' UNION
SELECT '20000011', '42', '11', '11', '11121', 'Hector', 'Mendoza', 'M', 'Argentino', '1986-06-06', 'Esquina 321', 'hector.mendoza@example.com', '1112345678', 'Activo' UNION
SELECT '20000012', '45', '12', '12', '11122', 'Cecilia', 'Diaz', 'F', 'Argentina', '1993-10-30', 'Barrio 456', 'cecilia.diaz@example.com', '1123456789', 'Activo' UNION
SELECT '20000013', '49', '13', '13', '11123', 'Ricardo', 'Villalba', 'M', 'Argentino', '1982-09-09', 'Parque 654', 'ricardo.villalba@example.com', '1134567890', 'Activo' UNION
SELECT '20000014', '51', '14', '14', '11124', 'Florencia', 'Rojas', 'F', 'Argentina', '1999-03-01', 'Pasaje 789', 'florencia.rojas@example.com', '1145678901', 'Activo' UNION
SELECT '20000015', '54', '15', '15', '11125', 'Martín', 'Ortega', 'M', 'Argentino', '1989-11-11', 'Avenida 123', 'martin.ortega@example.com', '1156789012', 'Activo';
GO

-- Tabla Horario de Atencion
CREATE TABLE HORARIO_ATENCION (
    ID_HORARIO_HDA INT IDENTITY(1,1) PRIMARY KEY,
    FK_DNI_MEDICO_HDA CHAR(8),
    DIA_HDA VARCHAR(45),
    HORA_INICIO_HDA TIME,
    HORA_FIN_HDA TIME,
    FOREIGN KEY (FK_DNI_MEDICO_HDA) REFERENCES MEDICOS(FK_DNI_MED)
);
GO

INSERT INTO HORARIO_ATENCION(FK_DNI_MEDICO_HDA, DIA_HDA, HORA_INICIO_HDA, HORA_FIN_HDA)
SELECT '20000001', 'Lunes, Martes, Miercoles, Jueves, Viernes', '08:00:00', '14:00:00' UNION
SELECT '20000002', 'Lunes, Miercoles, Viernes', '09:00:00', '15:00:00' UNION
SELECT '20000003', 'Martes, Jueves', '07:00:00', '13:00:00' UNION
SELECT '20000004', 'Sabado, Domingo', '10:00:00', '16:00:00' UNION
SELECT '20000005', 'Lunes, Martes, Jueves', '11:00:00', '17:00:00' UNION
SELECT '20000006', 'Miercoles, Viernes', '08:00:00', '14:00:00' UNION
SELECT '20000007', 'Lunes, Jueves', '09:00:00', '15:00:00' UNION
SELECT '20000008', 'Martes, Sabado', '07:00:00', '13:00:00' UNION
SELECT '20000009', 'Viernes, Domingo', '08:00:00', '12:00:00' UNION
SELECT '20000010', 'Lunes, Miercoles, Viernes', '12:00:00', '18:00:00' UNION
SELECT '20000011', 'Martes, Jueves, Sabado', '10:00:00', '14:00:00' UNION
SELECT '20000012', 'Lunes, Domingo', '09:00:00', '13:00:00' UNION
SELECT '20000013', 'Miercoles, Viernes', '08:00:00', '14:00:00' UNION
SELECT '20000014', 'Martes, Sabado', '11:00:00', '16:00:00' UNION
SELECT '20000015', 'Jueves, Domingo', '10:00:00', '15:00:00';
GO

-- Tabla Pacientes
CREATE TABLE PACIENTES (
    ID_PACIENTE_PAS INT IDENTITY(1,1) PRIMARY KEY,
    FK_ID_LOCALIDAD_PAS INT,
    FK_ID_PROVINCIA_PAS INT,
    DNI_PAS CHAR(8) UNIQUE,
    NOMBRE_PAS VARCHAR(30),
    APELLIDO_PAS VARCHAR(30),
    SEXO_PAS CHAR(1),
    NACIONALIDAD_PAS VARCHAR(30),
    NACIMIENTO_PAS DATE,
    DIRECCION_PAS VARCHAR(40),
    EMAIL_PAS VARCHAR(40),
    TELEFONO_PAS VARCHAR(20),
    ESTADO_PAS VARCHAR(20),
    FOREIGN KEY (FK_ID_LOCALIDAD_PAS) REFERENCES LOCALIDADES(ID_LOCALIDAD_LOC),
    FOREIGN KEY (FK_ID_PROVINCIA_PAS) REFERENCES PROVINCIAS(ID_PROVINCIA_PRO)
);
GO

INSERT INTO PACIENTES(FK_ID_LOCALIDAD_PAS, FK_ID_PROVINCIA_PAS, DNI_PAS, NOMBRE_PAS, APELLIDO_PAS, SEXO_PAS, NACIONALIDAD_PAS, NACIMIENTO_PAS, DIRECCION_PAS, EMAIL_PAS, TELEFONO_PAS, ESTADO_PAS)
SELECT '36', '9', '30000001', 'Gabriel', 'Vega', 'M', 'Argentino', '1964-05-03', 'Direccion 9456', 'Gabriel.Vega@example.com', '1123456789', 'Activo' UNION
SELECT '39', '10', '30000002', 'Sofia', 'Gonzalez', 'F', 'Argentina', '1990-03-15', 'Direccion 2345', 'sofia.gonzalez@example.com', '1123987654', 'Activo' UNION
SELECT '44', '11', '30000003', 'Lucas', 'Fernandez', 'M', 'Argentino', '1985-07-22', 'Direccion 6789', 'lucas.fernandez@example.com', '1145678923', 'Activo' UNION
SELECT '45', '12', '30000004', 'Mariana', 'Lopez', 'F', 'Argentina', '1995-11-10', 'Direccion 1234', 'mariana.lopez@example.com', '1156782349', 'Activo' UNION
SELECT '50', '13', '30000005', 'Matias', 'Rodriguez', 'M', 'Argentino', '2000-01-05', 'Direccion 4567', 'matias.rodriguez@example.com', '1167894321', 'Activo' UNION
SELECT '52', '14', '30000006', 'Carla', 'Diaz', 'F', 'Argentina', '1988-06-19', 'Direccion 7890', 'carla.diaz@example.com', '1123456879', 'Activo' UNION
SELECT '55', '15', '30000007', 'Diego', 'Ramirez', 'M', 'Argentino', '1977-02-27', 'Direccion 9632', 'diego.ramirez@example.com', '1145678390', 'Activo' UNION
SELECT '59', '16', '30000008', 'Florencia', 'Martinez', 'F', 'Argentina', '1999-08-12', 'Direccion 7531', 'florencia.martinez@example.com', '1123457894', 'Activo' UNION
SELECT '60', '17', '30000009', 'Joaquin', 'Sosa', 'M', 'Argentino', '1992-04-03', 'Direccion 8520', 'joaquin.sosa@example.com', '1134567821', 'Activo' UNION
SELECT '63', '18', '30000010', 'Valentina', 'Paz', 'F', 'Argentina', '1983-09-30', 'Direccion 1597', 'valentina.paz@example.com', '1167832459', 'Activo' UNION
SELECT '66', '19', '30000011', 'Santiago', 'Morales', 'M', 'Argentino', '1996-12-11', 'Direccion 3214', 'santiago.morales@example.com', '1123987645', 'Activo' UNION
SELECT '70', '20', '30000012', 'Camila', 'Gimenez', 'F', 'Argentina', '2001-05-25', 'Direccion 6543', 'camila.gimenez@example.com', '1156789341', 'Activo' UNION
SELECT '71', '21', '30000013', 'Javier', 'Milei', 'M', 'Argentino', '1989-07-13', 'Direccion 9876', 'javier.milei@example.com', '1123458912', 'Activo' UNION
SELECT '74', '22', '30000014', 'Lorena', 'Cruz', 'F', 'Argentina', '1998-10-21', 'Direccion 8743', 'lorena.cruz@example.com', '1145673982', 'Activo' UNION
SELECT '77', '23', '30000015', 'Nicolas', 'Herrera', 'M', 'Argentino', '1993-03-17', 'Direccion 2678', 'nicolas.herrera@example.com', '1167895432', 'Activo';
GO

-- Tabla Turnos
CREATE TABLE TURNOS (
    ID_TURNO_TUR INT IDENTITY(1,1) PRIMARY KEY,
    FK_DNI_MEDICO_TUR CHAR(8),
    FK_ID_PACIENTE_TUR INT,
    FK_ID_ESPECIALIDAD_TUR INT,
    FECHA_TUR DATE,
    HORA_TUR TIME,
    ESTADO_TUR VARCHAR(20),
    OBSERVACION_TUR TEXT,
    FOREIGN KEY (FK_DNI_MEDICO_TUR) REFERENCES MEDICOS(FK_DNI_MED),
    FOREIGN KEY (FK_ID_PACIENTE_TUR) REFERENCES PACIENTES(ID_PACIENTE_PAS),
    FOREIGN KEY (FK_ID_ESPECIALIDAD_TUR) REFERENCES ESPECIALIDADES(ID_ESPECIALIDAD_ESP),
	UNIQUE (FK_DNI_MEDICO_TUR, FK_ID_PACIENTE_TUR, FECHA_TUR, HORA_TUR)
);
GO

INSERT INTO TURNOS(FK_DNI_MEDICO_TUR, FK_ID_PACIENTE_TUR, FK_ID_ESPECIALIDAD_TUR, FECHA_TUR, HORA_TUR, ESTADO_TUR, OBSERVACION_TUR)
SELECT '20000001', '1', '1', '2024-11-26', '11:00:00', 'Ausente', '' UNION
SELECT '20000002', '2', '2', '2024-11-27', '10:00:00', 'Ausente', '' UNION
SELECT '20000003', '3', '3', '2024-11-28', '12:00:00', '', '' UNION
SELECT '20000004', '4', '4', '2024-11-30', '13:00:00', '', '' UNION
SELECT '20000005', '5', '5', '2024-11-25', '16:00:00', '', '' UNION
SELECT '20000006', '6', '6', '2024-11-27', '12:00:00', '', '' UNION
SELECT '20000007', '7', '7', '2024-11-28', '11:00:00', '', '' UNION
SELECT '20000008', '8', '8', '2024-11-26', '09:00:00', '', '' UNION
SELECT '20000009', '9', '9', '2024-12-01', '11:00:00', 'Ausente', '' UNION
SELECT '20000010', '10', '10', '2024-11-27', '17:00:00', '', '' UNION
SELECT '20000011', '11', '11', '2024-12-14', '10:00:00', '', '' UNION
SELECT '20000012', '12', '12', '2024-12-01', '12:00:00', '', '' UNION
SELECT '20000013', '13', '13', '2024-12-04', '08:00:00', '', '' UNION
SELECT '20000014', '14', '14', '2024-12-07', '11:00:00', 'Ausente', '' UNION
SELECT '20000015', '15', '15', '2024-12-08', '13:00:00', '', '';
GO

CREATE PROCEDURE spBajaLogicaPaciente
@DNIPACIENTE char(8)
AS
UPDATE PACIENTES SET ESTADO_PAS = 'Inactivo'
WHERE DNI_PAS = @DNIPACIENTE
RETURN
GO

CREATE PROCEDURE spModificarPaciente
@DNIPACIENTE char(8), @LOCALIDAD int, @PROVINCIA int, @NOMBRE varchar(30), @APELLIDO varchar(30), @SEXO char(1), @NACIONALIDAD VARCHAR(30), @NACIMIENTO Date,
@DIRECCION varchar(40), @EMAIL varchar(40), @TELEFONO VARCHAR(20)
AS
UPDATE PACIENTES SET FK_ID_LOCALIDAD_PAS = @LOCALIDAD, FK_ID_PROVINCIA_PAS = @PROVINCIA, NOMBRE_PAS = @NOMBRE, APELLIDO_PAS = @APELLIDO, SEXO_PAS = @SEXO, NACIONALIDAD_PAS = @NACIONALIDAD,
NACIMIENTO_PAS = @NACIMIENTO ,DIRECCION_PAS = @DIRECCION, EMAIL_PAS = @EMAIL, TELEFONO_PAS = @TELEFONO
WHERE DNI_PAS = @DNIPACIENTE
RETURN
GO

CREATE PROCEDURE spBajaLogicaMedico
@DNIMEDICO char(8)
AS
UPDATE MEDICOS SET ESTADO_MED = 'Inactivo'
WHERE FK_DNI_MED = @DNIMEDICO
RETURN
GO

CREATE PROCEDURE spModificarMedico
@DNIMEDICO char(8), @LOCALIDAD int, @PROVINCIA int, @ESPECIALIDAD int, @NOMBRE varchar(30), @APELLIDO varchar(30), @SEXO char(1), 
@NACIONALIDAD VARCHAR(30), @NACIMIENTO Date, @DIRECCION varchar(40), @EMAIL varchar(40), @TELEFONO VARCHAR(20), 
@DIAS varchar(45), @HORARIO varchar(13)
AS
UPDATE MEDICOS SET FK_ID_LOCALIDAD_MED = @LOCALIDAD, FK_ID_PROVINCIA_MED = @PROVINCIA, FK_ID_ESPECIALIDAD_MED = @ESPECIALIDAD, NOMBRE_MED = @NOMBRE, 
APELLIDO_MED = @APELLIDO, SEXO_MED = @SEXO, NACIONALIDAD_MED = @NACIONALIDAD, NACIMIENTO_MED = @NACIMIENTO , DIRECCION_MED = @DIRECCION, 
EMAIL_MED = @EMAIL, TELEFONO_MED = @TELEFONO
WHERE FK_DNI_MED = @DNIMEDICO

UPDATE HORARIO_ATENCION SET DIA_HDA = @DIAS, HORA_INICIO_HDA = LEFT(@HORARIO, 5), HORA_FIN_HDA = RIGHT(@HORARIO, 5)
WHERE FK_DNI_MEDICO_HDA = @DNIMEDICO
RETURN
GO

CREATE PROCEDURE spBajaLogicaTurno
@IDTURNO INT
AS
UPDATE TURNOS SET ESTADO_TUR = 'Inactivo'
WHERE ID_TURNO_TUR = @IDTURNO
RETURN
GO

CREATE PROCEDURE spModificarTurno
@ID_TURNO_TUR INT, @OBSERVACION_TUR NVARCHAR(MAX), @ESTADO_TUR NVARCHAR(50)
AS
UPDATE Turnos SET OBSERVACION_TUR = @OBSERVACION_TUR, ESTADO_TUR = @ESTADO_TUR
WHERE ID_TURNO_TUR = @ID_TURNO_TUR;
RETURN
GO