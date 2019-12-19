Use rental

--1.Procedures--
--процедуры на вставку(апдейт) адресов

Create PROCEDURE CreateRentContract 
(  
@passport_number CHAR(10),  
@carplate_number NVARCHAR(8),  
@native_office NVARCHAR(100),  
@return_office NVARCHAR(100)
)  
AS  
BEGIN  
DECLARE @native_office_address NVARCHAR(100)
DECLARE @return_office_address NVARCHAR(100)
SET @native_office_address = dbo.GetNameOfOffice(@native_office);
SET @return_office_address = dbo.GetNameOfOffice(@return_office);
insert into Lease_contract(passport_number,carplate_number,native_office_address,return_office_address) values( @passport_number, @carplate_number, @native_office_address, @return_office_address);
END  

Create PROCEDURE CreatePurchaseContract 
(  
@passport_number CHAR(10),  
@carplate_number NVARCHAR(8),  
@office NVARCHAR(100)  
)  
AS  
BEGIN  
DECLARE @office_address NVARCHAR(100)
SET @office_address = dbo.GetNameOfOffice(@office);

insert into Purchase_contract(passport_number,carplate_number,office_address) values( @passport_number, @carplate_number,@office_address);
END

--3.Functions--
-- функция сколько % машин были в дтп--

CREATE FUNCTION AmmountWereInAccident
()

RETURNS DECIMAL

AS

BEGIN

   DECLARE @car_total INT;
   DECLARE @car_damaged INT;  
   DECLARE @percentage DECIMAL;

   SELECT @car_total = (SELECT DISTINCT COUNT(Car.carplate_number) FROM CAR);

   SELECT @car_damaged = (SELECT DISTINCT COUNT(Car.carplate_number) FROM Accident Inner join  CAR On Accident.carplate_number = Car.carplate_number);

   SELECT @percentage = @car_damaged / @car_total * 100;

   RETURN @percentage;

END;

-- функция по поиску офиса по части строки--

Create FUNCTION [dbo].[GetNameOfOffice]  (@OfficeSubString nvarchar(100))
RETURNS nvarchar(100)
AS  
BEGIN  
       DECLARE @Office nvarchar(100); 
	   DECLARE @LikeOffice nvarchar(102);
	   SET @LikeOffice = '%' + @OfficeSubString + '%';
       SELECT @Office = (Select office_address FROM Office Where office_address LIKE @LikeOffice);  
       -- Return the result of the function  
       RETURN @Office  
END  


--5.SQL QUERIES--

--a--
SELECT DISTINCT Accident.carplate_number From Accident

SELECT Customer.full_name, Customer.driving_experience FROM Customer Where driving_experience >1

--b--
Select *, (Select full_name from Customer Where Customer.passport_number = Purchase_contract.passport_number) AS 'Customer name' From Purchase_contract

Select *, (Select full_name from Customer Where Customer.passport_number = Lease_contract.passport_number) AS 'Customer name' From Lease_contract
--c--
--самые маленькие по пробегу X-trail-- 
Select  TOP(10) t.* FROM (Select Car.carplate_number,mileage From Car Where Car.model_name = 'X-Trail') t Order by mileage
--d--
--самые дорогие машины по стоимости контрактов--
Select Top(10) t.* FROM (Select sum(Purchase_contract.amount) as 'sum_amount', Purchase_contract.carplate_number FROM Purchase_contract Group by carplate_number) t Order by t.sum_amount DESC 

--e--
--пользователи с более чем средним опытом вождения, прозвон с предложением выгодной страховки--
Select Customer.phone_number FROM Customer WHERE driving_experience > (Select AVG(Customer.driving_experience) FROM Customer)
--не бывавшие в авариях автомобили--
Select Car.carplate_number From Car Where carplate_number Not IN (Select Accident.carplate_number From Accident)
--f--
--прибыли по месяцу-году--
SELECT [office_address], YEAR([date]) AS [Year],
 MONTH([date]) AS [Month],
 Sum(amount) AS [Sales_amount],
 [Sales_amount_last_month] = LAG(Sum(amount))  
 OVER (ORDER BY (MONTH([date])))
    FROM [dbo].[Purchase_contract] 
  Group by YEAR([date]), Month([date]), office_address
  Order by YEAR([date]),Month([date])
--g--
--какие модели чаще всего в авариях--
Select Car.model_name,count(model_name) as 'Count accidents' From Accident Inner join Car On Accident.carplate_number = Car.carplate_number Group by Car.model_name Order by count(model_name) DESC
--каких брендов больше всего в автопарке--
Select Brand.price_category, count(price_category) as 'Кол-во машин категории в автопарке' FROM Car Inner Join Car_Model On Car.model_name = Car_Model.model_name Inner Join Brand On Car_model.brand_name = Brand.brand_name Group by price_category Order by count(price_category) DESC

--h--
--exists машины которые были больше чем в двух авариях--
Select carplate_number From Car Where  EXISTS(Select Count(carplate_number) FROM Accident Where Car.carplate_number = Accident.carplate_number Having COUNT(Accident.carplate_number) > 2)
--i--
--статистика продаж\сдач в аренду по офисам--
select count(Lease_contract.contract_number) as lease_cnt, count(Purchase_contract.contract_number) as purchase_cnt, Office.office_address from Office left join Lease_contract on Lease_contract.native_office_address = Office.office_address left join Purchase_contract on Purchase_contract.office_address= Office.office_address group by Office.office_address
--j--
--повтор лефт райта--
select count(Lease_contract.contract_number) as lease_cnt, count(Purchase_contract.contract_number) as purchase_cnt, Office.office_address from Office full outer join Lease_contract on Lease_contract.native_office_address = Office.office_address full outer join Purchase_contract on Purchase_contract.office_address= Office.office_address group by Office.office_address
--k--
Select brand_name,sum(damage) As 'SumDamage for brand' FROM Accident Inner join Car ON Accident.carplate_number=Car.carplate_number INNER JOIN Car_model on Car_model.model_name = Car.model_name Group By Car_model.brand_name Order by SUM(damage) DESC
--l--
--классификация урона машины--
SELECT  sum(damage) as 'total_damage',
CASE
    WHEN sum(damage) <0.1 THEN 'Lightly scratched'
	WHEN sum(damage) <0.3 THEN 'Seriously scratched'
	WHEN sum(damage) <0.5 THEN 'Medium damage'
	WHEN sum(damage) <0. THEN 'Heavily damaged'
	WHEN sum(damage) >1 THEN 'Damaged beyond repair'
    ELSE 'Not damaged'
END AS DamageText
FROM Accident Where carplate_number = '2ЕСВ39';
--m--
--агреграция по purchase по определенной модели и вывод моеделей с суммарным пробегом более миллиона
Select model_name,sum(mileage) AS 'SumMileage for model' From Car Inner JOin Purchase_contract ON Car.carplate_number = Purchase_contract.carplate_number  GROUP BY model_name Having (Sum(mileage) > 1000000) Order by sum(mileage)
--n--
--убитые машины--
SELECT carplate_number, SUM(DAMAGE) AS 'Total damage'
INTO CarsBeyondRepair
FROM Accident
Group by carplate_number Having SUM(damage) > 1.0
--o--
SELECT *
FROM (
    SELECT 
        [office_address]
        , [Year] = YEAR([date])
        , [Month] = MONTH([date])
        , [WeekDay] = DATENAME(WEEKDAY, [date])
    FROM [dbo].[Purchase_contract] 
) t
PIVOT (
    COUNT([WeekDay])
    FOR [WeekDay] IN (
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    )
) p Order by Year,Month DESC