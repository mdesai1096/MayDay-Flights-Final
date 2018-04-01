CREATE TABLE [dbo].[tblBookings] (
    [Book_Ref]      INT             IDENTITY (1, 1) NOT NULL,
    [Book_ammount]  DECIMAL (18, 2) NULL,
    [Book_date]     DATE            NULL,
    [Book_payment]  VARCHAR (50)    NULL,
    [FKItineraryNo] INT             NULL,
    [FKCustomerID]  INT             NULL,
    [FKEmployeeNo]  INT             NULL,
	
    CONSTRAINT [PK_tblBookings] PRIMARY KEY CLUSTERED ([Book_Ref] ASC),
    CONSTRAINT [FK_tblBookings_tblCustomer] FOREIGN KEY ([FKCustomerID]) REFERENCES [dbo].[tblCustomer] ([Customer_ID]),
    CONSTRAINT [FK_tblBookings_tblEmployees] FOREIGN KEY ([FKEmployeeNo]) REFERENCES [dbo].[tblEmployees] ([EmployeeNo])
);


GO
CREATE NONCLUSTERED INDEX [IXFK_tblBookings_tblCustomer]
    ON [dbo].[tblBookings]([FKCustomerID] ASC);


GO
CREATE NONCLUSTERED INDEX [IXFK_tblBookings_tblEmployees]
    ON [dbo].[tblBookings]([FKEmployeeNo] ASC);

