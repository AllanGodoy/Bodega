USE [bodega]
GO
/****** Object:  StoredProcedure [dbo].[sp_getCbxTipoTransaccion]    Script Date: 8/14/2023 12:47:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--execute sp_getCbxTipoTransaccion

ALTER procedure [dbo].[sp_getCbxTipoTransaccion]
as
select  * from TipoTransaccion


--ALTER procedure [dbo].[sp_DetailsWorkOrder]
--( 
--    @workOrderID int
--)
--as
--SELECT     top 1   dbo.Customer.FullName, dbo.Customer.Description, dbo.Customer.Address, dbo.WorkOrder.Date, dbo.WorkOrder.NameWhoRequests, dbo.WorkOrder.Deadline, dbo.WorkOrder.WorkOrderNumber, dbo.WorkOrder.Id
--FROM            dbo.Customer INNER JOIN
--                         dbo.WorkOrder ON dbo.Customer.Id = dbo.WorkOrder.CustomerId left JOIN
--                         dbo.MachinedPart ON dbo.WorkOrder.Id = dbo.MachinedPart.WorkOrderId

--						 where dbo.WorkOrder.Id = @workOrderID