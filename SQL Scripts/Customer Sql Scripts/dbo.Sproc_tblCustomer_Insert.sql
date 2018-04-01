
﻿CREATE PROCEDURE [dbo].[Sproc_tblCustomer_Insert]
--create parameters for the store procedure
	@surname Varchar (50),
	@forename Varchar (50),
	@gender Varchar(10),
	@dob Date,
	@postcode Varchar (6),
	@email Varchar (50),
	@HouseNo Varchar (50),
	@FlatNo Varchar (50),
	@ContactNo Varchar (50)
AS
--insert the new record 
	Insert into tblCustomer (surName, Forename, Gender, DateofBirth, Postcode, Email, HouseNo, FlatNo, ContactNo)
	Values (@surname, @forename,@gender, @dob, @postcode, @email, @HouseNo, @FlatNo, @ContactNo)

--return the primary key value of the new record

RETURN  @@Identity