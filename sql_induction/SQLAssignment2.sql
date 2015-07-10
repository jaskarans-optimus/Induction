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

SELECT Emp_f_name+Emp_m_name+Emp_l_name AS FullName,Emp_DOB 
FROM t_emp 
WHERE Emp_DOB IN(
SELECT
 
CASE 
	 WHEN EOMONTH(Emp_DOB)=Emp_DOB
	THEN Emp_DOB 
	ELSE 
	NULL 
	END 
	FROM t_emp ); 

SELECT EOMONTH ( '12/1/2011' ) AS Result;

	