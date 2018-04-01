CREATE PROCEDURE sproc_tblCustomer_Update
--create parameters for the store procedure
	@CustomerID int,
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
	--update the records as specificied by @CustomerID value
	update tblCustomer

	set surName=@surname,
		Forename=@forename,
		Gender=@gender,
		DateofBirth=@dob,
		Postcode=@postcode,
		Email=@email,
		HouseNo=@HouseNo,
		FlatNo=@FlatNo,
		ContactNo=@ContactNo

	where Customer_ID=@CustomerID