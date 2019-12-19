USE [auto_rental]
GO
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[Daily_cost]
   ON [dbo].[Lease_contract]
   INSTEAD OF INSERT
AS 
BEGIN
	SET NOCOUNT ON;
    DECLARE @cost INTEGER;
	DECLARE @cat VARCHAR(10) = 
	(select price_category FROM Brand WHERE brand_name = (SELECT brand_name from Car_model where model_name = (SELECT model_name FROM Car WHERE carplate_number = (SELECT carplate_number FROM inserted))))
	  IF (@cat = 'Economy') SET @cost = 1500
	  ELSE IF (@cat = 'Comfort') SET @cost = 3000
	  ELSE SET @cost = 6000
	INSERT INTO [dbo].Lease_contract (carplate_number, passport_number, start_date, end_date, issue_date, native_office_address, return_office_address, daily_cost)
	VALUES((SELECT carplate_number FROM inserted), (SELECT passport_number FROM inserted), (SELECT start_date FROM inserted), (SELECT end_date FROM inserted),
	(SELECT issue_date FROM inserted), (SELECT native_office_address FROM inserted),
	(SELECT return_office_address FROM inserted), @cost)
END
GO

ALTER TABLE [dbo].[Lease_contract] ENABLE TRIGGER [Daily_cost]
GO


