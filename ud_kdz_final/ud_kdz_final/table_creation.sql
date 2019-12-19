Use auto_rental

CREATE TABLE Customer( 
passport_number char(10) primary key not null, 
full_name nvarchar(40) not null, 
driving_experience int not null, 
phone_number char(11) not null, 
customer_address nvarchar(100), 
gender char(1) not null, 
CONSTRAINT gender_check CHECK (gender in('F', 'M')) 
); 
 
CREATE TABLE Brand( 
brand_name varchar(40) primary key not null, 
price_category varchar(10), 
CONSTRAINT category_check CHECK (price_category in('Economy', 'Comfort', 'Premium')) 
); 


CREATE TABLE Car_model( 
model_name varchar(40) primary key, 
brand_name varchar(40) foreign key references Brand(brand_name) 
); 
 
CREATE TABLE Car( 
carplate_number nvarchar(8) primary key not null, 
mileage numeric not null, 
car_status nvarchar(15) not null, 
color varchar(50) not null, 
model_name varchar(40) foreign key references Car_model(model_name), 
CONSTRAINT status_check CHECK (car_status in('For rent', 'For sale')) 
); 


 
CREATE TABLE Accident( 
accident_id integer identity(1,1) primary key,
damage numeric(18,2) not null, 
damage_description nvarchar(200), 
accident_date date not null, 
carplate_number nvarchar(8) foreign key references Car(carplate_number) 
); 
 
CREATE TABLE Office( 
office_address nvarchar(100) primary key, 
capacity integer not null); 
 
CREATE TABLE Employee( 
passport_number char(10) primary key not null, 
birth_date date not null, 
gender char(1) not null, 
office_address nvarchar(100) foreign key references Office(office_address), 
CONSTRAINT gender_check_ CHECK (gender in('F', 'M')),
full_name nvarchar(40) 
); 
 
CREATE TABLE Lease_contract( 
contract_number integer identity(1, 1) primary key, 
passport_number char(10) foreign key references Customer(passport_number), 
carplate_number nvarchar(8) foreign key references Car(carplate_number), 
native_office_address nvarchar(100) foreign key references Office(office_address), 
return_office_address nvarchar(100) foreign key references Office(office_address), 
start_date date not null, 
end_date date not null, 
issue_date date not null, 
daily_cost numeric not null 
); 
 
CREATE TABLE Purchase_contract( 
contract_number integer identity(1, 1) primary key,
passport_number char(10) foreign key references Customer(passport_number), 
carplate_number nvarchar(8) foreign key references Car(carplate_number), 
office_address nvarchar(100) foreign key references Office(office_address), 
amount numeric not null,
date date not null 
); 
 
