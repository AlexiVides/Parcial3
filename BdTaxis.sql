create database centralTaxi;
use  centralTaxi;

create table Taxis(
id int primary key identity(1,1),
nombreTaxista nvarchar(50),
matricula nvarchar(20),
numChasis nvarchar(70),
numVIN nvarchar(70)
);