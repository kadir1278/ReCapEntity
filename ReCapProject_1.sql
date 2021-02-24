begin
create database ReCapProject
end

go
use ReCapProject
create table Color
(
Id int identity primary key,
Name nvarchar(64)
)

create table Brand
(
Id int identity primary key,
Name varchar(64)
)
create table Car
(
Id int identity primary key,
BrandId int,
ColorId int,
ModelYear int,
DailyPrice money,
Description nvarchar(max)
)
