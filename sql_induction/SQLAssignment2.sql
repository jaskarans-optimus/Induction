USE Shipment;
CREATE TABLE t_emp(
Emp_id INT PRIMARY KEY IDENTITY(1001,2) ,
Emp_Code VARCHAR(255),
Emp_f_name VARCHAR(255) NOT NULL,
Emp_m_name VARCHAR(255),
Emp_L_name VARCHAR(255),
Emp_DOB DATE CHECK((DATEPART(yyyy,Emp_DOB)*365+DATEPART(M,Emp_DOB)*30+DATEPART(d,Emp_DOB))>(18*365)),
Emp_DOJ DATE NOT NULL
);
INSERT INTO t_emp VALUES(1001,'OPT20110105','Manmohan',' ','Singh','19830210','20100525');

INSERT INTO t_emp VALUES(1003,'OPT20100915','ALFRED',' Joseph','Lawrence','19880228','20110524');
INSERT INTO t_emp VALUES(1005,'OPT20100917','Ammy',' Joseph','Smith','19880131','20110524');

SELECT * FROM t_emp;
CREATE TABLE t_activity(
Activity_id INT PRIMARY KEY,
Activity_description VARCHAR(MAX)
);
INSERT INTO t_activity VALUES(1,'Code Analysis')
INSERT INTO t_activity VALUES(2,'Lunch');
INSERT INTO t_activity VALUES(3,'Coding');
INSERT INTO t_activity VALUES(4,'Knowledge Transition');
INSERT INTO t_activity VALUES(5,'Database');


CREATE TABLE t_atten_det(
Atten_id INT IDENTITY(1001,1),
Emp_id INT ,
Activity_id INT,
Atten_start_datetime DATETIME,
Atten_end_hrs INT,
CONSTRAINT FK_Emp_id FOREIGN KEY (Emp_id) REFERENCES t_emp(Emp_id),
CONSTRAINT FK_Activity_id FOREIGN KEY (Activity_id) REFERENCES t_activity(Activity_id) 
);
INSERT INTO t_atten_det VALUES(1001,5,'20110213 10:00:00 AM',2);
INSERT INTO t_atten_det VALUES(1001,1,'20110114 10:00:00 AM',3);
INSERT INTO t_atten_det VALUES(1001,3,'20110114 1:00:00 PM',5);
INSERT INTO t_atten_det VALUES(1003,5,'20110216 10:00:00 AM',8);
INSERT INTO t_atten_det VALUES(1003,5,'20110217 10:00:00 AM',8);
INSERT INTO t_atten_det VALUES(1003,5,'20110219 10:00:00 AM',7);
SELECT * FROM t_atten_det;
CREATE TABLE t_salary(
Salary_id INT,
Emp_id INT,
Changed_date DATE,
New_Salary MONEY
);
INSERT INTO t_salary VALUES(1001,1003,'20110216',20000);
INSERT INTO t_salary VALUES(1002,1003,'20110105',25000);
INSERT INTO t_salary VALUES(1003,1001,'20110216',26000);

-- Q1. DISPLAY FULL NAME AND DATE OF BIRTH  THOSE EMPLOYEES WHOSE BIRTH DATE FALLS IN THE LAST DAY OF ANY MONTH
SELECT Emp_f_name+Emp_m_name+Emp_l_name AS FullName,Emp_DOB 
FROM t_emp 
WHERE DATEDIFF(day,Emp_DOB,EOMONTH (Emp_DOB))=0;




--SELECT * FROM t_atten_det;
--SELECT (SELECT Emp_f_name+' '+Emp_m_name+' '+Emp_L_name FROM t_emp WHERE s.Emp_id=t_emp.Emp_Id ) AS Full_Name
--,(SELECT MAX(t_salary.New_Salary) FROM t_salary WHERE t_salary.New_Salary NOT IN (SELECT MAX(t_salary.New_Salary) FROM t_salary)) AS Previous_Salary
--,MAX(s.New_Salary) AS Current_Salary,SUM(CASE WHEN e.Emp_Id=a.Emp_id THEN A.Atten_end_hrs ELSE 0 END) AS Total_Worked_Hours,MAX(a.Atten_start_datetime)
--FROM (t_emp e INNER JOIN t_atten_det a ON  e.Emp_Id= a.Emp_id) INNER JOIN t_salary S ON s.Emp_id=e.Emp_id 
--GROUP BY s.Emp_id,e.Emp_Id,a.Emp_id;


--SELECT (SELECT t_emp.Emp_f_name+' '+t_emp.Emp_m_name+' '+t_emp.Emp_L_name FROM t_emp  WHERE s.Emp_id=t_emp.Emp_Id ) AS Full_Name

--FROM (t_emp e INNER JOIN t_salary s ON  e.Emp_Id= s.Emp_id) INNER JOIN t_atten_det a ON a.Emp_id=s.Emp_id
--GROUP BY e.Emp_id;



--SELECT E.EMP_ID,MAX(e.Emp_f_name+' '+e.Emp_m_name+' '+e.Emp_L_name ) AS Full_Name,MAX(s.New_Salary) AS Current_Salary,(SELECT MAX(t_salary.New_Salary) FROM t_salary WHERE t_salary.New_Salary NOT IN (SELECT MAX(t_salary.New_Salary) FROM t_salary)) AS Previous_Salary
--,(MAX(s.New_Salary) -(SELECT MAX(t_salary.New_Salary) FROM t_salary WHERE t_salary.New_Salary NOT IN (SELECT MAX(t_salary.New_Salary) FROM t_salary))) AS Increment
--FROM (t_emp e INNER JOIN t_salary s ON  e.Emp_Id= s.Emp_id) 
--GROUP BY E.Emp_id;

--SELECT emp.Emp_Id,SUM(Atten_end_hrs) AS Total_Worked_Hours ,(SELECT t_activity.Activity_description FROM t_atten_det INNER JOIN t_activity ON t_atten_det.Activity_id=t_activity.Activity_id WHERE Atten_start_datetime=MAX(ATT.Atten_start_datetime)) AS Last_Worked_Activity,(SELECT Atten_end_hrs FROM t_atten_det WHERE t_atten_det.Atten_start_datetime=MAX(ATT.Atten_start_datetime)) AS Hours_Worked_In_Last_Activity
--FROM (t_atten_det att INNER JOIN t_emp emp ON att.Emp_id=emp.Emp_Id)
--GROUP BY emp.Emp_Id;

--Q2. DISPLAY EMPLOYEE FULL NAME , GOT INCREMENT IN SALARY?,PREVIOUS SALARY,CURRENT SALARY,TOTAL WORKED HOURS,HOURS WORKED 

Select A.Emp_id,A.Full_Name,A.Increment,A.Previous_Salary,A.Current_Salary,B.Total_Worked_Hours,B.Last_Worked_Activity,B.Hours_Worked_In_Last_Activity
FROM (SELECT E.EMP_ID,MAX(e.Emp_f_name+' '+e.Emp_m_name+' '+e.Emp_L_name ) AS Full_Name,MAX(s.New_Salary) AS Current_Salary,(SELECT MAX(t_salary.New_Salary) FROM t_salary WHERE t_salary.New_Salary NOT IN (SELECT MAX(t_salary.New_Salary) FROM t_salary)) AS Previous_Salary
,(MAX(s.New_Salary) -(SELECT MAX(t_salary.New_Salary) FROM t_salary WHERE t_salary.New_Salary NOT IN (SELECT MAX(t_salary.New_Salary) FROM t_salary))) AS Increment
FROM (t_emp e INNER JOIN t_salary s ON  e.Emp_Id= s.Emp_id) 
GROUP BY E.Emp_id)
AS a INNER JOIN 
(SELECT emp.Emp_Id,SUM(Atten_end_hrs) AS Total_Worked_Hours ,(SELECT t_activity.Activity_description FROM t_atten_det INNER JOIN t_activity ON t_atten_det.Activity_id=t_activity.Activity_id WHERE Atten_start_datetime=MAX(ATT.Atten_start_datetime)) AS Last_Worked_Activity,(SELECT Atten_end_hrs FROM t_atten_det WHERE t_atten_det.Atten_start_datetime=MAX(ATT.Atten_start_datetime)) AS Hours_Worked_In_Last_Activity
FROM (t_atten_det att INNER JOIN t_emp emp ON att.Emp_id=emp.Emp_Id)
GROUP BY emp.Emp_Id) AS b ON A.Emp_Id=B.Emp_Id;
