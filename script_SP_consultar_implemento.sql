use dbs_prestamos_deportivos
go
-- =============================================
-- Author:		<Author,,Brayan Madrid>
-- Create date: <Create Date,,26 oct 2023>
-- Description:	<Description,,Consultar implementos>
-- =============================================

create procedure SP_ConsultarImplemento
@codigo varchar(10)
as begin
	select
	Nombre,
	Especificaciones,
	Cantidad,
	Valor
	from tbl_implementos
	where
	PKCodigo = @codigo
end
