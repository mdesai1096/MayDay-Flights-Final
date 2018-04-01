CREATE PROCEDURE [dbo].[sproc_FiltertblCustomerbyPK]
	--parameter to store input
	@CustId int
AS
	--select 
	SELECT *
	-- from the table tblcust
	FROM tblCustomer

	Where Customer_ID = @CustId;

RETURN 0