CREATE PROCEDURE [dbo].[sproc_FiltertblBookings|tblCust]
	--parameter to store input
	@BookRef int
AS
	--select 3 columns were want
	SELECT Book_Ref, Book_ammount, Book_date, Book_payment--, Forename, surName
	-- from the table tblBookings
	FROM tblBookings --join tblCustomer
	--on the FK relationship with tblCustomer 
	--ON Customer_ID = FKCustomerID
	-- where the PK of parameter enteted equals bookref from tblbookings
	Where Book_Ref = @BookRef;

RETURN 0