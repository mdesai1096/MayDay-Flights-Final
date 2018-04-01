CREATE PROCEDURE [dbo].[sproc_tblCustomer_FilterBysurName]
-- this stored uses the like function to find post codes that match the value
-- stored in the parameter @Postcode
-- the stored procedure doesnt return a value 


	--declare the parameter as varchar(8)
	@surName varchar(50)


AS

	--select all fields from any records that has a post code like this post code 
	select * from tblCustomer where surName like @surName +'%';