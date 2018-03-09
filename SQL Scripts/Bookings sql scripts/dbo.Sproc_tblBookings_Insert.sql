CREATE PROCEDURE [dbo].[Sproc_tblBookings_Insert]
--create parameters for the store procedure
	@Ammount decimal,
	@DateBooked date,
	@PaymentType Varchar(10)
	--@cust decimal,
	--@emp decimal,
	--@itin decimal
AS
--insert the new record 
	Insert into tblBookings (Book_ammount, Book_date, Book_payment) --FKCustomerID,FKEmployeeNo, FKItineraryNo)
	Values (@Ammount, @DateBooked, @PaymentType) --,@cust, @emp, @itin)

--return the primary key value of the new record
RETURN  @@Identity