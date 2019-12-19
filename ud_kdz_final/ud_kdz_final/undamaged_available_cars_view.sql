USE [rental]
GO

/****** Object:  View [dbo].[undamaged_cars_available]    Script Date: 11/30/2019 2:11:23 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[undamaged_cars_available] as select distinct Car.carplate_number, CONCAT(Car.model_name, ' ', brand_name) as model from Car left join Accident on Car.carplate_number = Accident.carplate_number left join Lease_contract on Car.carplate_number = Lease_contract.carplate_number join Car_model on Car.model_name = Car_model.model_name where accident_id is null and (Lease_contract.start_date is NULL or Lease_contract.end_date < CONVERT(DATE, GETDATE())) 
GO


