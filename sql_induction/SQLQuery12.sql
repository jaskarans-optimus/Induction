--5.SQL create database
CREATE DATABASE Myoffice;

-- 6-7 create Table (NOT NULL, DEFAULT , PRIMARY KEY,CHECK)
USE myoffice;
CREATE TABLE Employee(
Id INT PRIMARY KEY ,
FirstName VARCHAR(255) NOT NULL ,
LastName VARCHAR(255),
Age INT NOT NULL CHECK(Age >=18),
Sex VARCHAR(6) NOT NULL DEFAULT 'Male' CHECK (Sex = 'Male' OR Sex = 'Female') ,
ActiveStatus BIT,
Designation VARCHAR(255),
Salary BIGINT,
Departement VARCHAR(255),
City VARCHAR(255) 
);

--14.SQL Drop :Create a table of Designation and drop it
CREATE TABLE Designation(
Id INT,
Designation VARCHAR(255));

-- 15. SQL Create Index : Create a unique index on the first name and last name  and a full text index on first name of the Employee table
CREATE UNIQUE INDEX UX_FirstName
on Employee(FirstName,LastName);


CREATE FULLTEXT CATALOG ft AS DEFAULT;
CREATE FULLTEXT INDEX ON Employee(FirstName)
KEY INDEX UX_FirstName;

-- 16. SQL Alter: Alter the table Employees. Modify designation column to take integer value and create a new table for designation which is related to Employee by designation id

ALTER TABLE Employee
ALTER COLUMN Designation INT;

CREATE TABLE Designation(
Id int PRIMARY KEY,
Name VARCHAR(255)
);

ALTER TABLE Employee
ADD FOREIGN KEY(Designation) REFERENCES Designation (Id); 


--17.SQL In:Find Employee salary in a particular range using  In operator
INSERT INTO Employee VALUES(12 ,'kerry ','perry',19,'Male',1,2,5000,'Marketing','Delhi' );
INSERT INTO Employee VALUES(13 ,'jenny ','pino',19,'Male',1,1,25000,'HR','Delhi' );
INSERT INTO Employee VALUES(121 ,'rosie ','meno',29,'Female',0,2,45000,'Marketing','Delhi' );
INSERT INTO Employee VALUES(131 ,'nirvana ','aro',19,'Male',0,2,245000,'HR','Noida' );
INSERT INTO Employee VALUES(111 ,'kam','aarra',19,'Male',0,2,245000,NULL,'Noida' );
SELECT * FROM Employee
WHERE Salary IN (5000, 50001 ,5003 , 5005);

--18.SQL Between :Find Employee salary in a particular range using  Between operator

SELECT * FROM Employee
where Salary BETWEEN 3000 AND 6000;

--19. SQL Alias : Display column using alias name FROM  Employee table
SELECT FirstName+' '+LastName AS FullName
FROM Employee;

SELECT e.FirstName, e.Salary FROM Employee as e;

--20. SQL Joins : Display Employee details using Join with Employee slabs table.
CREATE TABLE Employee_Salary(
Id int,
Base int,
Hra int,
Pf int
);
INSERT INTO Employee_Salary VALUES(2,500000,20000,50000);
INSERT INTO Employee_Salary VALUES(12,250000,12000,20000);
INSERT INTO Employee_Salary VALUES(13,350000,22000,30000);
INSERT INTO Employee_Salary VALUES(5,900000,80000,70000);

SELECT FirstName,LastName FROM Employee JOIN Employee_Salary ON Employee.Id =Employee_Salary.Id;

-- 21. SQL Left Join:Create a sample Employee manAgement system, having table Employee & Department. Employees are associated with some department, there are some Employees exist which doesn't associated with any department yet. Display all the Employees and their department information whether they are associated with some department or not.

CREATE TABLE Departement (
Name VARCHAR(255),
Id int);

INSERT INTO Departement VALUES('Marketing',6);

INSERT INTO Departement VALUES('HR',61);

INSERT INTO Departement VALUES('Teachnical',12);
INSERT INTO Departement VALUES('admin',122);


SELECT * FROM Employee  LEFT JOIN Departement ON Employee.Departement=Departement.Name;

--23. SQL Right Join:Same case as above but there are some department also exist which doesn't have any Employees associated with it. Display all the departments and number of Employees associated with it.


SELECT * FROM Employee RIGHT JOIN Departement on Employee.Departement=Departement.Name;


-- 24.SQL Full Join:Same case as above. Display all the Employees and departments whether they are associated with each other or not.

SELECT * FROM Employee FULL OUTER JOIN Departement ON Employee.Departement=Departement.Name;


--25.SQL Union:Suppose a ERP system having multiple table for Employees of different companies. Create tables for 3 companies such as "ABC", "LMN" & "XYZ" and display all the Employees of all the companies.

CREATE TABLE ABC(
Id INT,
Name VARCHAR(255),
Designation VARCHAR(255),
);

CREATE TABLE LMN(
Id INT,
Name VARCHAR(255),
Designation VARCHAR(255),
);

CREATE TABLE XYZ(
Id INT,
Name VARCHAR(255),
Designation VARCHAR(255),
);

SELECT * FROM ABC
UNION ALL
SELECT * FROM  LMN
UNION ALL
SELECT * FROM XYZ;

-- 26.SQL SELECT Into :Create a backup system where records are being saved in another table in different database. Write queries to insert data of "Employee" table "Employee_Backup" table in another database.

SELECT * INTO EmployeeBackup FROM Employee;

-- 27.SQL Increment: increment the salary of all Employee by 5000  
UPDATE Employee
SET Salary=Salary+5000;

-- 28. SQL Views:create a view with details of manAgers whose salary is more than 60000. Add a column date of joining in the Employee table and display in view the joining date in the format specified in #1 of previous exercise
ALTER TABLE Employee
ADD DateOfJoining DATE;


CREATE VIEW ManagersView AS
SELECT * FROM  Employee WHERE Salary>=6000 AND Departement in ('Manager');


--29.SQL Dates:1.Get current date in the format specified in example -Mon  20th sep 10, 1:30 pm
--2. Get unix timestamp of date 1st Jan 2010 also display this date in the same format.
--3. Add 2 days in current date and display in format specified in 1st point






SELECT DATENAME(WEEKDAY,GETDATE())+' '+DATENAME(DAY,GETDATE())+'th '+DATENAME(MONTH,GETDATE())+' , '+SUBSTRING(CONVERT(VARCHAR(29),GETDATE(),0),13,18);


SELECT DateAdd(Day,2,GETDATE());

--30.SQL Nulls:Count sum of a column in which one of the values is Null

SELECT * FROM Employee;
SELECT Sum((CASE WHEN Id IS NULL THEN 1 ELSE 0 END )
+(CASE WHEN FirstName IS NULL THEN 1 ELSE 0 END)
+(CASE WHEN LastName IS NULL THEN 1 ELSE 0 END)
+(CASE WHEN Age IS NULL THEN 1 ELSE 0 END)
+(CASE WHEN Sex IS NULL THEN 1 ELSE 0 END)
+(CASE WHEN Departement IS NULL THEN 1 ELSE 0 END)
+(CASE WHEN DateOfJoining IS NULL THEN 1 ELSE 0 END)) FROM Employee;

--31. SQL isnull()
SELECT * FROM Employee WHERE LastName IS NULL;

--32.SQL Data Types
SELECT CAST(Salary*(0.1275) AS DECIMAL(10,2)) FROM Employee;


--SQL avg()
SELECT * FROM Employee WHERE Salary>=(SELECT AVG(Salary) FROM Employee);

--SQL count()
SELECT * FROM Departement;
SELECT * FROM Employee;


SELECT d.Name,d.Id, COUNT(Id) "number of Employees"
FROM Departement d,Employee e
WHERE d.Name=e.Departement
GROUP BY d.Id,d.Name;

--SQL max()
SELECT * FROM Employee WHERE Salary < (SELECT MAX(Salary) FROM Employee);

--SQL min()
SELECT * FROM Employee WHERE Salary >(SELECT MIN(Salary) FROM Employee);

--SQL sum()
SELECT SUM(Salary) FROM Employee;

--SQL Group By
SELECT d.Name,d.Id, COUNT(Id) "number of Employees"
FROM Departement d,Employee e
WHERE d.Name=e.Departement
GROUP BY d.Id,d.Name;

--SQL Having
CREATE TABLE Order1(
OrderId INT,
OrderDate DATE,
Orders INT,
CusterName VARCHAR(255)
);
DROP TABLE Order1;
SELECT * FROM Order1;
INSERT INTO  Order1 VALUES(2,'2000-08-10',50,'roni');
INSERT INTO  Order1 VALUES(22,'1970-01-10',2200,'asgar');
INSERT Order1 VALUES(23,'2000-01-10',100,'heera');


SELECT CusterName FROM Order1 GROUP BY CusterName HAVING SUM(Orders)<2000;

--SQL upper()
SELECT FirstName,UPPER(LastName) AS LastName FROM Employee; 


--SQL lower()
SELECT LastName, LOWER(LastName) AS LastName FROM Employee;


--SQL len()
SELECT LEN(FirstName) AS LengthOfFirstName,LEN(LastName) AS LengthOfLastName FROM Employee;

--SQL round()
SELECT ROUND(Salary,0) FROM Employee;

--SQL GETDATE()

SELECT  FirstName,LastName,Age,sex,Departement,GETDATE() FROM Employee;

--SQL CONVERT()

SELECT FirstName,LastName,CONVERT(VARCHAR(40),GETDATE(),0) FROM Employee;
SELECT FirstName,LastName,CONVERT(VARCHAR(40),GETDATE(),1) FROM Employee;
SELECT FirstName,LastName,CONVERT(VARCHAR(40),GETDATE(),2) FROM Employee;
SELECT FirstName,LastName,CONVERT(VARCHAR(40),GETDATE(),3) FROM Employee;
SELECT FirstName,LastName,CONVERT(VARCHAR(40),GETDATE(),4) FROM Employee;
SELECT FirstName,LastName,CONVERT(VARCHAR(40),GETDATE(),5) FROM Employee;
SELECT FirstName,LastName,CONVERT(VARCHAR(40),GETDATE(),6) FROM Employee;
SELECT FirstName,LastName,CONVERT(VARCHAR(40),GETDATE(),0) FROM Employee;
SELECT FirstName,LastName,CONVERT(VARCHAR(40),GETDATE(),101) FROM Employee;
SELECT FirstName,LastName,CONVERT(VARCHAR(40),GETDATE(),102) FROM Employee;
SELECT FirstName,LastName,CONVERT(VARCHAR(40),GETDATE(),103) FROM Employee;
SELECT FirstName,LastName,CONVERT(VARCHAR(40),GETDATE(),104) FROM Employee;
SELECT FirstName,LastName,CONVERT(VARCHAR(40),GETDATE(),105) FROM Employee;
SELECT FirstName,LastName,CONVERT(VARCHAR(40),GETDATE(),106) FROM Employee;

-- SQL cast()
SELECT CAST(Id as VARCHAR(10)) FROM Employee;
-- SQL Case
SELECT CASE WHEN Salary>5000 and Age<35 THEN 'yes' ELSE 'no' END FROM Employee;





-->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>DAY2<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
--Ranking Functions
use myoffice;
SELECT TOP 5 * FROM Employee ORDER BY salary DESC;

-- show alternate highest paid
SELECT FirstName,LastName,salary FROM(SELECT ROW_NUMBER()OVER (ORDER BY salary desc)AS ROW,* FROM Employee) Employee WHERE ROW%2=0;

--Common Table Expression
WITH Employee_CTE(FirstName,LastName,salary)
AS
(
 SELECT FirstName,LastName,salary FROM  Employee WHERE salary > 5000
 )
SELECT * FROM Employee_CTE;

--WITH ROLLUP & WITH CUBE


SELECT Departement,sum(salary) AS SalarySum FROM Employee 
GROUP BY Departement WITH ROLLUP;


SELECT Departement,sum(salary) AS SalarySum FROM Employee 
GROUP BY Departement WITH CUBE;

--Except & Intersect
SELECT * FROM Employee
EXCEPT
SELECT * FROM  Employee WHERE Experience>6;

SELECT * FROM Employee
INTERSECT
SELECT * FROM Employee WHERE Experience<6; 

--Corelated subqueries
SELECT eid,FirstName,LastName,salary FROM(SELECT ROW_NUMBER()OVER (ORDER BY eid asc)AS ROW,* FROM Employee) Employee WHERE ROW<4;


--Running Aggregates
SELECT a.eid, a.salary,SUM(b.salary)
FROM Employee a,Employee b
where b.eid<=a.eid
GROUP BY a.eid,a.salary
ORDER BY a.eid;

--Cluster Index

CREATE CLUSTERED INDEX CI_Employee_salary
ON Employee(salary);

--Non Cluster Index
CREATE NONCLUSTERED INDEX NI_Employee_Eid
on Employee(designation);

--Triggers

SELECT * FROM emp_slab;

CREATE TRIGGER CalGross ON emp_slab
AFTER INSERT 
AS 
UPDATE emp_slab SET Gross=(base+hr+da)*12;

--Cursors
DECLARE cur_emp_slab2 CURSOR
    FOR SELECT base,hr,da FROM emp_slab
OPEN cur_emp_slab2
FETCH cur_emp_slab2
UPDATE emp_slab SET Gross=(da+base+hr)*12;
FETCH NEXT FROM cur_emp_slab2;

--Functions
CREATE FUNCTION LeapYear (@yy INT)
RETURNS VARCHAR(20)
AS 
BEGIN
	DECLARE @ret VARCHAR(20); 
	IF(@yy % 4 ! = 0)
	SET @ret = 'It is a common year';
	ELSE IF (@yy % 100 != 0)
	SET @ret = ' It is a leap year';
	ELSE
	SET @ret= 'It is a common year';
	RETURN @ret;
END;
SELECT dbo.LeapYear(2000);

--Stored procedures
CREATE PROCEDURE getAllInfo(@id INT)
AS
BEGIN
SELECT * FROM Employee,emp_slab WHERE Employee.eid=emp_slab.p_id  AND Employee.eid=@id;
END;
EXEC getAllInfo 12;


--Exception Handling

CREATE PROCEDURE ExceptionHandle
AS 
BEGIN
BEGIN TRY
    -- Generate a divide-by-zero error.
    SELECT 1/0;
END TRY
BEGIN CATCH
    SELECT
        ERROR_NUMBER() AS ErrorNumber
        ,ERROR_SEVERITY() AS ErrorSeverity
        ,ERROR_STATE() AS ErrorState
        ,ERROR_PROCEDURE() AS ErrorProcedure
        ,ERROR_LINE() AS ErrorLine
        ,ERROR_MESSAge() AS ErrorMessAge;
END CATCH;
END;

exec ExceptionHandle;
