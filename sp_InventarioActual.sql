create procedure sp_getCantidadActual
@Id int
as
select Id, CodigoProducto,nombre, InventarioInicial,Salidas,Entradas, InventarioInicial-Salidas+Entradas as InventarioFinal  from
(
select Id, CodigoProducto, nombre, InventarioInicial , 
(
SELECT  		 sum (dbo.DetalleProducto.Cantidad) as Salidas
FROM            dbo.DetalleProducto INNER JOIN
                         dbo.Producto ON dbo.DetalleProducto.IdProducto = dbo.Producto.Id INNER JOIN
                         dbo.TipoTransaccion ON dbo.DetalleProducto.IdTipoTransaccion = dbo.TipoTransaccion.Id 
						 where dbo.Producto.Id = @Id and dbo.TipoTransaccion.Id =0 
) as Salidas,
(					
SELECT					 sum (dbo.DetalleProducto.Cantidad) as Entradas
FROM            dbo.DetalleProducto INNER JOIN
                         dbo.Producto ON dbo.DetalleProducto.IdProducto = dbo.Producto.Id INNER JOIN
                         dbo.TipoTransaccion ON dbo.DetalleProducto.IdTipoTransaccion = dbo.TipoTransaccion.Id 
						 where dbo.Producto.Id = @Id and dbo.TipoTransaccion.Id =1
) as Entradas

from producto
where Producto.Id = @Id

) as InventarioFinal


execute sp_getCantidadActual 1