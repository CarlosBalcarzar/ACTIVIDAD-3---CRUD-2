CREATE DATABASE ACTIVIDAD3;

CREATE TABLE Clientes (
    IDCliente INT IDENTITY (1,1) NOT NULL,
    Nombre VARCHAR(20) NULL,
    Apellido VARCHAR(20) NULL,
    CorreoElectronico VARCHAR(100) NULL,
    Telefono VARCHAR(20) NULL,
    Direccion VARCHAR(30) NULL
);
INSERT INTO Clientes (Nombre, Apellido, CorreoElectronico, Telefono, Direccion) VALUES
('Juan', 'Perez', 'juan.perez@example.com', '1234567890', 'Calle 123, Ciudad'),
('María', 'Gómez', 'maria.gomez@example.com', '0987654321', 'Avenida Principal, Pueblo'),
('Carlos', 'Martínez', 'carlos.martinez@example.com', '5555555555', 'Apartado Postal 456, Villa'),
('Ana', 'López', 'ana.lopez@example.com', '3333333333', 'Bulevar Central, Aldea'),
('Juan', 'Martín', 'juan.martin@example.com', '5555555555', 'Calle 789, Pueblo'),
('María', 'López', 'maria.lopez@example.com', '6666666666', 'Avenida Norte, Ciudad'),
('Carlos', 'Hernández', 'carlos.hernandez@example.com', '7777777777', 'Apartado Postal 1011, Villa'),
('Ana', 'Gómez', 'ana.gomez@example.com', '8888888888', 'Bulevar Sur, Aldea'),
('Luis', 'Torres', 'luis.torres@example.com', '9999999999', 'Calle 1011, Pueblo'),
('Elena', 'Ruiz', 'elena.ruiz@example.com', '1010101010', 'Avenida Oeste, Ciudad'),
('Pablo', 'Santos', 'pablo.santos@example.com', '1212121212', 'Apartado Postal 1213, Villa'),
('Lucía', 'Dominguez', 'lucia.dominguez@example.com', '1313131313', 'Bulevar Este, Aldea'),
('Diego', 'Castro', 'diego.castro@example.com', '1414141414', 'Calle 1213, Pueblo'),
('Julia', 'Ortega', 'julia.ortega@example.com', '1515151515', 'Avenida Sur, Ciudad'),
('Andrés', 'Morales', 'andres.morales@example.com', '1616161616', 'Apartado Postal 1415, Villa'),
('Sara', 'Fernández', 'sara.fernandez@example.com', '1717171717', 'Bulevar Norte, Aldea'),
('Javier', 'Gutiérrez', 'javier.gutierrez@example.com', '1818181818', 'Calle 1415, Pueblo'),
('Marta', 'Jiménez', 'marta.jimenez@example.com', '1919191919', 'Avenida Este, Ciudad'),
('Manuel', 'Vargas', 'manuel.vargas@example.com', '2020202020', 'Apartado Postal 1617, Villa'),
('Raquel', 'Silva', 'raquel.silva@example.com', '2121212121', 'Bulevar Oeste, Aldea');


