CREATE PROCEDURE [dbo].[Delete]
	@Title varchar(100)
AS
	Delete [Table] Where Title = @Title
RETURN 0
