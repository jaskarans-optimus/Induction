--5.SQL create database
CREATE DATABASE myoffice;

-- 6-7 create Table (NOT NULL, DEFAULT , PRIMARY KEY,CHECK)
USE myoffice;
CREATE TABLE Employe(
eid INT PRIMARY KEY ,
first_name VARCHAR(255) NOT NULL ,
last_name VARCHAR(255),
age INT NOT NULL CHECK(age >=18),
sex VARCHAR(6) NOT NULL DEFAULT 'Male' CHECK (sex = 'Male' OR sex = 'Female') ,
activestatus BIT,
designation VARCHAR(255),
salary BIGINT,
departement VARCHAR(255),
city VARCHAR(255) 
);
drop table Employe;


--14.SQL Drop :Create a table of Designation and drop it
CREATE TABLE designation(
eid INT,
designation varchar(255));

DROP TABLE designation;

-- 15. SQL Create Index : Create a unique index on the first name and last name  and a full text index on first name of the employee table
CREATE UNIQUE INDEX findex
on Employe(first_name);

CREATE UNIQUE INDEX lindex
on Employe(last_name);
CREATE FULLTEXT CATALOG ft AS DEFAULT;
CREATE FULLTEXT INDEX ON Employe(first_name)
KEY INDEX findex;

-- 16. SQL Alter: Alter the table employees. Modify designation column to take integer value and create a new table for designation which is related to employee by designation id

ALTER TABLE Employe
ALTER COLUMN designation INT;

CREATE TABLE designation(
d_id int PRIMARY KEY,
name varchar(255)
);

ALTER TABLE Employe
ADD FOREIGN KEY(designation) REFERENCES designation (d_id); 


--17.SQL In:Find Employee salary in a particular range using  In operator
insert into Employe values(12 ,'kerry ','perry',19,'Male',1,2,5000,'Marketing','Delhi' );
insert into Employe values(13 ,'jenny ','pino',19,'Male',1,1,25000,'HR','Delhi' );
insert into Employe values(121 ,'rosie ','meno',29,'Female',0,2,45000,'Marketing','Delhi' );
insert into Employe values(131 ,'nirvana ','aro',19,'Male',0,2,245000,'HR','Noida' );
insert into Employe values(111 ,'kam','aarra',19,'Male',0,2,245000,NULL,'Noida' );
SELECT * FROM Employe
where salary IN (5000, 50001 ,5003 , 5005);

--18.SQL Between :Find Employee salary in a particular range using  Between operator

SELECT * FROM Employe
where salary between 3000 AND 6000;

--19. SQL Alias : Display column using alias name from  Employee table
SELECT first_name+' '+last_name AS FullName
FROM Employe;

select e.first_name, e.salary from Employe as e;

--20. SQL Joins : Display employee details using Join with employee slabs table.
create table emp_slab(
p_id int,
base int,
hra int,
pf int
);
insert into emp_slab values(2,500000,20000,50000);
insert into emp_slab values(12,250000,12000,20000);
insert into emp_slab values(13,350000,22000,30000);
insert into emp_slab values(5,900000,80000,70000);

SELECT first_name,last_name FROM Employe JOIN emp_slab ON Employe.eid =emp_slab.p_id;

-- 21. SQL Left Join:Create a sample employee management system, having table Employee & Department. Employees are associated with some department, there are some employees exist which doesn't associated with any department yet. Display all the employees and their department information whether they are associated with some department or not.

create table departement (
dept varchar(255),
id int);

insert into departement values('Marketing',6);

insert into departement values('HR',61);

insert into departement values('Teachnical',12);
insert into departement values('admin',122);


select * from Employe  left join departement on Employe.departement=departement.dept;

--23. SQL Right Join:Same case as above but there are some department also exist which doesn't have any employees associated with it. Display all the departments and number of employees associated with it.


select * from Employe right join departement on Employe.departement=departement.dept;


-- 24.SQL Full Join:Same case as above. Display all the employees and departments whether they are associated with each other or not.

select * from Employe full outer join departement on Employe.departement=departement.dept;


--25.SQL Union:Suppose a ERP system having multiple table for employees of different companies. Create tables for 3 companies such as "ABC", "LMN" & "XYZ" and display all the employees of all the companies.

create table ABC(
id int,
name varchar(255),
designation varchar(255),
);
insert into ABC values(1,'zora','VP');
insert into ABC values(21,'nerru','Director');
insert into ABC values(23,'sarva','TD');
insert into ABC values(11,'zasdas','TL');
insert into ABC values(1,'zora','HL');

create table LMN(
id int,
name varchar(255),
designation varchar(255),
);

insert into ABC values(11,'zareen','VP');
insert into ABC values(23,'pone','TD');
insert into ABC values(11,'don','TL');
insert into ABC values(1,'shaun','HL');

create table XYZ(
id int,
name varchar(255),
designation varchar(255),
);
insert into ABC values(23,'sawe','VP');
insert into ABC values(23,'svan','TD');
insert into ABC values(11,'pio','TL');
insert into ABC values(1,'aka','HL');


select * from ABC
UNION ALL
select * from LMN
UNION ALL
select * from XYZ;

-- 26.SQL Select Into :Create a backup system where records are being saved in another table in different database. Write queries to insert data of "Employee" table "Employee_Backup" table in another database.

select * into Employee_Backup from Employe;

-- 27.SQL Increment: increment the salary of all employee by 5000  
update Employe
set salary=salary+5000;

-- 28. SQL Views:create a view with details of managers whose salary is more than 60000. Add a column date of joining in the employee table and display in view the joining date in the format specified in #1 of previous exercise
alter table Employe
add date_of_joining date;


create view managers as
select * from Employe where salary>=6000 AND departement in ('Manager');


--29.SQL Dates:1.Get current date in the format specified in example -Mon  20th sep 10, 1:30 pm
--2. Get unix timestamp of date 1st Jan 2010 also display this date in the same format.
--3. Add 2 days in current date and display in format specified in 1st point






SELECT DATENAME(WEEKDAY,GETDATE())+' '+DATENAME(DAY,GETDATE())+'th '+DATENAME(MONTH,GETDATE())+' , '+substring(convert(varchar(29),getdate(),0),13,18);


select dateadd(day,2,getdate());

--30.SQL Nulls:Count sum of a column in which one of the values is Null

select * from Employe;
select Sum((case when eid is null then 1 else 0 end )
+(case when first_name is null then 1 else 0 end)
+(case when last_name is null then 1 else 0 end)
+(case when age is null then 1 else 0 end)
+(case when sex is null then 1 else 0 end)
+(case when departement is null then 1 else 0 end)
+(case when date_of_joining is null then 1 else 0 end)) from Employe;

--31. SQL isnull()
select * from Employe where last_name is null;

--32.SQL Data Types
select cast(salary*(0.1275) as decimal(10,2)) from Employe;


--SQL avg()
select * from Employe where salary>=(select avg(salary) from Employe);

--SQL count()
select * from departement;
select * from Employe;


select d.dept,d.id, count(eid) "number of employees"
from departement d,Employe e
where d.dept=e.departement
group by d.id,d.dept;

--SQL max()
select * from employe where salary < (select Max(salary) from Employe);

--SQL min()
select * from employe where salary >(select Min(salary) from Employe);

--SQL sum()
select sum(salary) from employe;

--SQL Group By
select d.dept,d.id, count(eid) "number of employees"
from departement d,Employe e
where d.dept=e.departement
group by d.id,d.dept;

--SQL Having
create table order1(
orderid int,
orderdate date,
orders int,
custername varchar(255)
);
drop table order1;
select * from order1;
insert into order1 values(2,'2000-08-10',50,'roni');
insert into order1 values(22,'1970-01-10',2200,'asgar');
insert into order1 values(23,'2000-01-10',100,'heera');


select custername from order1 group by custername having SUM(orders)<2000;

--SQL upper()
select first_name,UPPER(last_name) as Last_name from Employe; 


--SQL lower()
select last_name, lower(last_name) as last_name from Employe;

--SQL len()
select len(first_name) as lengthoffirstname,len(last_name) as lengthoflastname from Employe;

--SQL round()
select round(salary,0) from Employe;

--SQL getdate()
select * from employe;
select  first_name,last_name,age,sex,departement,getDate() from Employe;

--SQL convert()

select first_name,last_name,convert(varchar(40),getdate(),0) from employe;
select first_name,last_name,convert(varchar(40),getdate(),1) from employe;
select first_name,last_name,convert(varchar(40),getdate(),2) from employe;
select first_name,last_name,convert(varchar(40),getdate(),3) from employe;
select first_name,last_name,convert(varchar(40),getdate(),4) from employe;
select first_name,last_name,convert(varchar(40),getdate(),5) from employe;
select first_name,last_name,convert(varchar(40),getdate(),6) from employe;
select first_name,last_name,convert(varchar(40),getdate(),0) from employe;
select first_name,last_name,convert(varchar(40),getdate(),101) from employe;
select first_name,last_name,convert(varchar(40),getdate(),102) from employe;
select first_name,last_name,convert(varchar(40),getdate(),103) from employe;
select first_name,last_name,convert(varchar(40),getdate(),104) from employe;
select first_name,last_name,convert(varchar(40),getdate(),105) from employe;
select first_name,last_name,convert(varchar(40),getdate(),106) from employe;

-- SQL cast()
select cast(eid as varchar(10)) from Employe;
-- SQL Case
select case when salary>5000 and age<35 then 'yes' else 'no' End from employe;


--SQL avg()
select * from Employe where salary>=(select avg(salary) from Employe);

--SQL count()
select * from departement;
select * from Employe;


select d.dept,d.id, count(eid) "number of employees"
from departement d,Employe e
where d.dept=e.departement
group by d.id,d.dept;

--SQL max()
select * from employe where salary < (select Max(salary) from Employe);

--SQL min()
select * from employe where salary >(select Min(salary) from Employe);

--SQL sum()
select sum(salary) from employe;

--SQL Group By
select d.dept,d.id, count(eid) "number of employees"
from departement d,Employe e
where d.dept=e.departement
group by d.id,d.dept;

--SQL Having
create table order1(
orderid int,
orderdate date,
orders int,
custername varchar(255)
);
drop table order1;
select * from order1;
insert into order1 values(2,'2000-08-10',50,'roni');
insert into order1 values(22,'1970-01-10',2200,'asgar');
insert into order1 values(23,'2000-01-10',100,'heera');


select custername from order1 group by custername having SUM(orders)<2000;

--SQL upper()
select first_name,UPPER(last_name) as Last_name from Employe; 


--SQL lower()
select last_name, lower(last_name) as last_name from Employe;

--SQL len()
select len(first_name) as lengthoffirstname,len(last_name) as lengthoflastname from Employe;

--SQL round()
select round(salary,0) from Employe;

--SQL getdate()
select * from employe;
select  first_name,last_name,age,sex,departement,getDate() from Employe;

--SQL convert()

select first_name,last_name,convert(varchar(40),getdate(),0) from employe;
select first_name,last_name,convert(varchar(40),getdate(),1) from employe;
select first_name,last_name,convert(varchar(40),getdate(),2) from employe;
select first_name,last_name,convert(varchar(40),getdate(),3) from employe;
select first_name,last_name,convert(varchar(40),getdate(),4) from employe;
select first_name,last_name,convert(varchar(40),getdate(),5) from employe;
select first_name,last_name,convert(varchar(40),getdate(),6) from employe;
select first_name,last_name,convert(varchar(40),getdate(),0) from employe;
select first_name,last_name,convert(varchar(40),getdate(),101) from employe;
select first_name,last_name,convert(varchar(40),getdate(),102) from employe;
select first_name,last_name,convert(varchar(40),getdate(),103) from employe;
select first_name,last_name,convert(varchar(40),getdate(),104) from employe;
select first_name,last_name,convert(varchar(40),getdate(),105) from employe;
select first_name,last_name,convert(varchar(40),getdate(),106) from employe;

-- SQL cast()
select cast(eid as varchar(10)) from Employe;
-- SQL Case
select case when salary>5000 and age<35 then 'yes' else 'no' End from employe;

--Ranking Functions
use myoffice;
select top 5 * from employe order by salary desc;

