﻿DROP TABLE IF EXISTS customers;

CREATE TABLE customers (
    ID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(20),
    LastName NVARCHAR(20),
    SSN NVARCHAR(16),
    BirthDate DATETIME,
    Age AS DATEDIFF(YEAR, BirthDate, GETDATE())
);
ALTER TABLE customers
ADD CONSTRAINT Unique_SSN UNIQUE (SSN);

DROP TABLE IF EXISTS transactions;
CREATE TABLE transactions (
    ID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    Amount DECIMAL(10, 2),
    Date DATETIME,
    SSN NVARCHAR(16),
    FOREIGN KEY (SSN) REFERENCES customers (SSN)
);