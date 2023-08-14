
create table Producto
(
Id int not null identity(1,1) primary key,
fecha date,
CodigoProducto varchar (10),
nombre varchar(50),
Descripcion varchar (100),
InventarioInicial int not null,
CantidadActual int,
Estatus bit
)



Create table DetalleProducto
(
Id int not null identity(1,1) primary key,
fecha date,
Descripcion varchar(100),
IdTipoTransaccion int,
Cantidad int,
IdProducto int,
FOREIGN KEY (IdProducto) REFERENCES Producto(Id),
FOREIGN KEY (IdTipoTransaccion) REFERENCES TipoTransaccion(Id)
)


create table TipoTransaccion
(
Id int not null primary key,
Nombre varchar (100)
)



insert into TipoTransaccion (Id, Nombre) values (0,'Salida')
insert into TipoTransaccion (Id, Nombre) values (1,'Entrada')

delete TipoTransaccion where Nombre= 'Salidas'

select * from DetalleProducto

insert into DetalleProducto (fecha, Descripcion, IdTipoTransaccion, Cantidad) values ('','','','')

update DetalleProducto set idproducto=1

select * from TipoTransaccion
select * from producto

update DetalleProducto set Descripcion = 'ventas',Transaccion =1, cantidad=15 where id=1 
