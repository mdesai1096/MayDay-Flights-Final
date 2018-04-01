CREATE PROCEDURE [dbo].[sproc_tblBookings_FilterbyDate]
	--Parameter to store the date ranges we are looking for
	@StartDate date,
	@EndDate date
AS
	--select all bookings that are between the start date and end date entered
	SELECT* from tblBookings WHERE (Book_date >= @StartDate and Book_date <= @EndDate)

	--order by the book date
	Order By Book_date

RETURN 0