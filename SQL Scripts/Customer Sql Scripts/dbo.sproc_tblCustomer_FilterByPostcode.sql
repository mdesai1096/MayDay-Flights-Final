
﻿CREATE PROCEDURE [dbo].[sproc_tblCustomer_FilterByPostcode]
-- this stored uses the like function to find post codes that match the value
-- stored in the parameter @Postcode
-- the stored procedure doesnt return a value 


	--declare the parameter as varchar(8)
	@Postcode varchar(9)


AS

	--select all fields from any records that has a post code like this post code 

	select * from tblCustomer where Postcode like @Postcode +'%';