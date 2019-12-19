USE [rental]
GO

/****** Object:  View [dbo].[contracts]    Script Date: 11/30/2019 2:05:42 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

--select 'lease' as contract_type, contract_number, daily_cost * DATEDIFF(DAY, start_date, end_date) as total_cost, full_name as  from Lease_contract join Customer on Customer.passport_number = Lease_contract.passport_number
--UNION 
--select 'purchase', contract_number, amount, full_name as cost from Purchase_contract join Customer on Customer.passport_number = Purchase_contract.passport_number

CREATE VIEW [dbo].[contracts] AS select 'lease' as contract_type, contract_number, daily_cost * DATEDIFF(DAY, start_date, end_date) as cost, full_name, CONCAT(Car.model_name,' ', brand_name) as model from Lease_contract join Customer on Customer.passport_number = Lease_contract.passport_number join Car on Lease_contract.carplate_number = Car.carplate_number join Car_model on Car.model_name = Car_model.model_name
UNION 
select 'purchase', contract_number, amount, full_name, CONCAT(Car.model_name,' ', brand_name) as model from Purchase_contract join Customer on Customer.passport_number = Purchase_contract.passport_number join Car on Purchase_contract.carplate_number = Car.carplate_number join Car_model on Car.model_name = Car_model.model_name
GO


