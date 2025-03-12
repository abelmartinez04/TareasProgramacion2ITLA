CREATE DATABASE ControlTEscolares;

USE ControlTEscolares;

CREATE TABLE Estudiante (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL,
    Correo VARCHAR(100) UNIQUE NOT NULL,
    FechaRegistro DATETIME DEFAULT GETDATE()
);
  
CREATE TABLE Profesor (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL,
    Correo VARCHAR(100) UNIQUE NOT NULL,
    Especialidad VARCHAR(100)
);

CREATE TABLE Tarea (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Titulo VARCHAR(150) NOT NULL,
    Descripcion TEXT,
    FechaEntrega DATE NOT NULL,
    Estado VARCHAR(50) DEFAULT 'Pendiente',
    Calificacion DECIMAL(5,2) NULL,
    EstudianteId INT,
    FOREIGN KEY (EstudianteId) REFERENCES Estudiante(Id) ON DELETE CASCADE
);

CREATE TABLE Recordatorio (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Mensaje TEXT NOT NULL,
    FechaRecordatorio DATETIME NOT NULL,
    TareaId INT,
    FOREIGN KEY (TareaId) REFERENCES Tarea(Id) ON DELETE CASCADE
);