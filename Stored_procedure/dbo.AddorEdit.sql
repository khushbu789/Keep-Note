CREATE PROCEDURE [dbo].[AddorEdit]
	@mode varchar(10),
	@Title varchar(100),
	@Note varchar(Max)
AS
	if (@mode='Add')
	begin
	Insert into [Table](Title,Note) values (@Title,@Note)
	end
	else if(@mode='Edit')
	begin
	Update [Table] 
	set Title=@Title,
	Note=@Note
	Where Title=@Title
	end

RETURN 0
