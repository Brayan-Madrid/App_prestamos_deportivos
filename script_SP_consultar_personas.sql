use dbs_prestamos_deportivos
go
-- =============================================
-- Author:		<Author,,Brayan Madrid>
-- Create date: <Create Date,,31/10/2023>
-- Description:	<Description,,Consultarpersona>
-- =============================================
create procedure SP_ConsultarPersonas
@id varchar(10)
as begin
	declare @completo varchar(100)
	select
	P_nombre + ' ' + S_nombre  +' '+ P_apellido +' '+ S_apellido
	from
	tbl_personas
	where
	PKId = @id
end