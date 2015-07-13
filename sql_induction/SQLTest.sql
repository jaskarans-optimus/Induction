USE Shipment;
CREATE TABLE Employee(
Id INT PRIMARY KEY,
Name VARCHAR(MAX),
Gender VARCHAR(6),
Basic MONEY,
HR MONEY,
DA MONEY,
TAX MONEY,
DeptID INT
);

INSERT INTO Employee VALUES(1,'Anil','Male',10000,5000,1000,400,1);
INSERT INTO Employee VALUES(2,'Sanjana','Female ',12000,6000,1000,500,2);
INSERT INTO Employee VALUES(3,'Johnny','Male',5000,2500,500,200,3);
INSERT INTO Employee VALUES(4,'Suresh','Male',6000,3000,500,250,1);
INSERT INTO Employee VALUES(5,'Anglia','Female',11000,5500,1000,500,4);
INSERT INTO Employee VALUES(6,'Saurabh','Male',12000,6000,1000,500,1);
INSERT INTO Employee VALUES(7,'Manish','Male',4000,2000,500,150,2);
INSERT INTO Employee VALUES(8,'Neeraj','Male',5000,2500,500,200,3);
INSERT INTO Employee VALUES(9,'Suman','Female',5000,2500,500,200,4);
INSERT INTO Employee VALUES(10,'Tina','Female',6000,3000,500,220,1);
SELECT * FROM Employee;

CREATE TABLE Departement (
DeptID INT,
DeptName VARCHAR(MAX),
DeptHeadID INT
);

INSERT INTO Departement VALUES(1,'HR',1);
INSERT INTO Departement VALUES(2,'Admin',2);
INSERT INTO Departement VALUES(3,'Sales',9);
INSERT INTO Departement VALUES(4,'Engineering',5);
SELECT * FROM Departement;
CREATE TABLE EmployeeAttendance(
EmpId INT ,
Date DATE,
WorkingDays INT,
PresentDays INT
);

INSERT INTO EmployeeAttendance VALUES(1,'20100101',22,21);
INSERT INTO EmployeeAttendance VALUES(1,'20100201',20,20);
INSERT INTO EmployeeAttendance VALUES(1,'20100301',22,20);
INSERT INTO EmployeeAttendance VALUES(2,'20100101',22,22);
INSERT INTO EmployeeAttendance VALUES(2,'20100201',20,20);
INSERT INTO EmployeeAttendance VALUES(2,'20100301',22,22);
INSERT INTO EmployeeAttendance VALUES(3,'20100101',22,21);
INSERT INTO EmployeeAttendance VALUES(3,'20100201',20,20);
INSERT INTO EmployeeAttendance VALUES(3,'20100301',22,21);
INSERT INTO EmployeeAttendance VALUES(4,'20100101',22,21);
INSERT INTO EmployeeAttendance VALUES(4,'20100201',20,19);
INSERT INTO EmployeeAttendance VALUES(4,'20100301',22,22);
INSERT INTO EmployeeAttendance VALUES(5,'20100101',22,22);
INSERT INTO EmployeeAttendance VALUES(5,'20100201',20,20);
INSERT INTO EmployeeAttendance VALUES(5,'20100301',22,22);
INSERT INTO EmployeeAttendance VALUES(6,'20100101',22,21);
INSERT INTO EmployeeAttendance VALUES(6,'20100201',20,20);
INSERT INTO EmployeeAttendance VALUES(6,'20100301',22,20);
INSERT INTO EmployeeAttendance VALUES(7,'20100101',22,21);
INSERT INTO EmployeeAttendance VALUES(7,'20100201',20,20);
INSERT INTO EmployeeAttendance VALUES(7,'20100301',22,21);
INSERT INTO EmployeeAttendance VALUES(8,'20100101',22,21);
INSERT INTO EmployeeAttendance VALUES(8,'20100201',20,20);
INSERT INTO EmployeeAttendance VALUES(8,'20100301',22,21);
INSERT INTO EmployeeAttendance VALUES(9,'20100101',22,22);
INSERT INTO EmployeeAttendance VALUES(9,'20100201',20,20);
INSERT INTO EmployeeAttendance VALUES(9,'20100301',22,21);
INSERT INTO EmployeeAttendance VALUES(10,'20100101',22,22);
INSERT INTO EmployeeAttendance VALUES(10,'20100201',20,20);
INSERT INTO EmployeeAttendance VALUES(10,'20100301',22,22);
SELECT * FROM EmployeeAttendance;

--Q 1.
SELECT MAX(d.DeptName),e.Gender,COUNT(*) AS No_Of_Employees
FROM Departement  d INNER JOIN Employee e ON d.DeptID=e.DeptID
GROUP BY D.DeptID,E.Gender;

--Q 2.
SELECT MAX(d.DeptName),COUNT(*) AS No_Of_Employees,MAX((e.Basic+e.DA+e.HR)*(0.1275)) AS Highest_Gross_Salary,SUM((e.Basic+e.HR+e.DA-e.TAX)) AS Total_Salary
FROM Departement  d INNER JOIN Employee e ON d.DeptID=e.DeptID
GROUP BY D.DeptID;


--Q.3
SELECT MAX(d.DeptName),(SELECT TOP 1 Name FROM Employee WHERE (Employee.Basic+Employee.DA+Employee.HR)*0.1275=MAX((e.Basic+e.DA+e.HR)*(0.1275)) AND d.DeptID=Employee.DeptID) AS Name_of_Employee,MAX((e.Basic+e.DA+e.HR)*(0.1275)) AS Highest_Gross_Salary
FROM Departement  d INNER JOIN Employee e ON d.DeptID=e.DeptID
GROUP BY D.DeptID;

--Q.4
SELECT e.Id,e.Name FROM Employee e WHERE ((e.Basic+e.DA+e.HR)*0.1275)>15000;

--Q.5
SELECT e.Id,e.Name FROM Employee e WHERE e.Basic IN (SELECT MAX(Employee.BASIC) FROM Employee WHERE Employee.Basic NOT IN(SELECT MAX(Employee.BASIC) FROM Employee) );

--Q 6.
SELECT MAX(d.DeptName) ,COUNT(*) AS No_of_Employees
FROM Departement  d INNER JOIN Employee e ON d.DeptID=e.DeptID
GROUP BY D.DeptID,d.DeptHeadID
HAVING COUNT(*)>3;


--Q7.
SELECT MAX(d.DeptName) AS DeptName ,(SELECT Employee.Name FROM Employee WHERE Employee.Id=d.DeptHeadID ) AS DeptHeadId
FROM Departement  d INNER JOIN Employee e ON d.DeptID=e.DeptID
GROUP BY D.DeptID,d.DeptHeadID;

--Q 8.
SELECT MAX(E.Name) AS Name
FROM Employee e INNER JOIN EmployeeAttendance ea ON E.Id=ea.EmpId
GROUP BY ea.EmpId
HAVING SUM(ea.PresentDays)=SUM(ea.WorkingDays);

--Q.9
SELECT (SELECT Employee.Name FROM Employee WHERE emp.Id=Employee.Id )
FROM
(SELECT ea.EmpId,SUM(ea.WorkingDays)-SUM(ea.PresentDays) AS Absence_days
FROM Employee e INNER JOIN EmployeeAttendance ea ON E.Id=ea.EmpId
GROUP BY ea.EmpId) Sub 
INNER JOIN Employee emp 
ON Sub.EmpId=emp.Id
WHERE sub.Absence_days  IN  (SELECT MAX(SUB2.Absence_days) 
FROM (SELECT ea.EmpId,SUM(ea.WorkingDays)-SUM(ea.PresentDays) AS Absence_days
FROM Employee e INNER JOIN EmployeeAttendance ea ON E.Id=ea.EmpId
GROUP BY ea.EmpId) SUB2);

--Q 10.

SELECT (SELECT Employee.Name FROM Employee WHERE emp.Id=Employee.Id ) AS Name
FROM
(SELECT ea.EmpId,SUM(ea.WorkingDays)-SUM(ea.PresentDays) AS Absence_days
FROM Employee e INNER JOIN EmployeeAttendance ea ON E.Id=ea.EmpId
GROUP BY ea.EmpId) Sub 
INNER JOIN Employee emp 
ON Sub.EmpId=emp.Id
WHERE sub.Absence_days>3;