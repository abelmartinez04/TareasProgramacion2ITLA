
create database DBCRUDCORE

USE DBCRUDCORE

SELECT * FROM CONTACTO
SELECT name FROM sys.databases WHERE name = 'DBCRUDCORE';

CREATE TABLE CONTACTO(
IdContact int identity primary key,
Nombre varchar(50),
Telefono varchar(50),
Correo varchar(50)
)

create procedure sp_Listar
as
begin
	select * from CONTACTO
end

create procedure sp_Obtener(
@IdContact int
)
as
begin
	select * from CONTACTO where IdContact = @IdContact
end

select * from CONTACTO

create procedure sp_Guardar(
@Nombre varchar(100),
@Telefono varchar(100),
@Correo varchar(100)
)
as
begin
	insert into CONTACTO(Nombre,Telefono,Correo) values (@Nombre,@Telefono,@Correo)
	end


create procedure sp_Editar(
@Id_contact int,
@Nombre varchar(100),
@Telefono varchar(100),
@Correo varchar(100)
)
as
begin
	update CONTACTO set Nombre = @Nombre, Telefono = @Telefono, Correo = @Correo where IdContact = IdContact
end


create procedure sp_Eliminar(
@Id_Contact int
)
as
begin
	delete from CONTACTO where IdContact = @Id_Contact
end