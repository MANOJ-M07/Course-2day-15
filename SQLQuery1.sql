create database UserValidation
use UserValidation

create table Register
(Id int primary key identity(1,2),
EmpId as 'EID'+cast(Id as nvarchar(10)),
UserName nvarchar(50) not null,
Email nvarchar(50) not null,
Password as right(UserName,4)+'@'+cast(Id as nvarchar(20))+left(UserName,2),
City nvarchar(20))


