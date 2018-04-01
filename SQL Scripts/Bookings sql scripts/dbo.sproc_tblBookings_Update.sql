=
﻿CREATE PROCEDURE sproc_tblBookings_Update
--create the parameters for the stored procedure
	@BookRef int,
	@Ammount decimal(18,2),
	@DateBooked date,
	@PaymentType varchar(10),
	@CustId int
AS
--update the records as specificied by @BookRef value
update tblBookings
	
set 
	Book_ammount=@Ammount,
	Book_date=@DateBooked,
	Book_payment=@PaymentType,
	FKCustomerID = @CustId
  
	where Book_Ref=@BookRef