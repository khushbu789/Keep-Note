CREATE PROCEDURE [dbo].[VieworSearch]
	@Title varchar(100)
AS
	SELECT  * from [Table]
	Where Title like '@Title%'
RETURN 0
