create database MyAppDatabase
use MyAppDatabase

CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    DateOfBirth DATE,
    Address NVARCHAR(100),
    City NVARCHAR(50),
    JoiningDate DATE,
    Username NVARCHAR(50),
    Password NVARCHAR(100)
);
drop table Users
CREATE TABLE Users (
    UserId INT PRIMARY KEY IDENTITY,
    EmployeeId NVARCHAR(10) UNIQUE NOT NULL,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    DateOfBirth DATE NOT NULL,
    Address NVARCHAR(100) NOT NULL,
    City NVARCHAR(50) NOT NULL,
    DateOfJoining DATE NOT NULL,
    PasswordHash NVARCHAR(100) NOT NULL
);


