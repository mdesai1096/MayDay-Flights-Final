CREATE PROCEDURE [dbo].[sproc_tblCustomer_Delete]
--this stored procedure is located in data layer (App_Data_ folder

--this stored procedure is used to delete a single record in the table tblCustomer
--it accepts a single parameter @CustomerID and returns no value

	--declare the parameter
	@CustomerID int
AS
	--delete the record in tblCustomer specified by the value @CustomerID
	delete from tblCustomer where Customer_ID = @CustomerID;