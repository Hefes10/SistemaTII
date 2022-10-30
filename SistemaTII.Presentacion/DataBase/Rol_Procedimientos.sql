--Insertar roles
insert into rol (nombre) values('Administrador');
insert into rol (nombre) values('Vendedor');
insert into rol (nombre) values('Almacenero');
go

--Procedimiento listar rol
create proc rol_listar
as
select idrol,nombre from rol
where estado=1
go