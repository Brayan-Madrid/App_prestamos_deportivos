
use dbs_prestamos_deportivos
go
-- =============================================
-- Author:		<Author,Brayan Madrid>
-- Create date: <Create Date,26/10/2023>
-- Description:	<Description,,agregar implementos>
-- =============================================
CREATE PROCEDURE SP_AgregarImplementos
@codigo varchar(10), @nombre varchar(80), @especificaciones varchar (5000),
@cantidad int, @valor float
AS BEGIN
		insert into tbl_implementos
		(PKCodigo,Nombre,Especificaciones,Cantidad,Valor,Fecha)
		values
		(@codigo,@nombre,@especificaciones,@cantidad,@valor,GETDATE())  
END