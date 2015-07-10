CREATE DATABASE Shipment;
USE Shipment;
CREATE TABLE t_product_master(
Product_ID VARCHAR(255) PRIMARY KEY,
Product_Name VARCHAR(MAX) NOT NULL,
Cost_Per_Item MONEY CHECK(Cost_Per_Item>0)
);
INSERT INTO t_product_master VALUES('P1','Pen',10);
INSERT INTO t_product_master VALUES('P2','Scale',15);
INSERT INTO t_product_master VALUES('P3','Note Book',25);
--drop table t_product_master;
CREATE TABLE t_user_master(
UserID VARCHAR(255) PRIMARY KEY
UserName VARCHAR(MAX) NOT NULL
);
SELECT * FROM t_user_master;
INSERT INTO t_user_master VALUES('U1','Alfred Lawrence');
INSERT INTO t_user_master VALUES('U2','William Paul');
INSERT INTO t_user_master VALUES('U3','Edward Fillip');
CREATE TABLE t_transaction(
UserID VARCHAR(255),
Product_ID VARCHAR(255),
Transaction_Date DATE,
Transaction_Type VARCHAR(255),
Transaction_Amount MONEY CHECK (Transaction_Amount > 0 )
CONSTRAINT PK_t_transaction PRIMARY KEY (UserID,Product_ID,Transaction_Date, Transaction_Type),
CONSTRAINT FK_UserID FOREIGN KEY(UserID) REFERENCES t_user_master(UserID),
CONSTRAINT FK_Product_ID FOREIGN KEY(Product_ID) REFERENCES t_product_master(Product_ID));


INSERT INTO t_transaction VALUES('U1','P1','20101025','Order',150);
INSERT INTO t_transaction VALUES('U1','P1','20101120','Payment',750);
INSERT INTO t_transaction VALUES('U1','P1','20101120','Order',200);
INSERT INTO t_transaction VALUES('U1','P3','20101125','Order',50);
INSERT INTO t_transaction VALUES('U3','P2','20101126','Order',100);
INSERT INTO t_transaction VALUES('U2','P1','20101215','Order',75);
INSERT INTO t_transaction VALUES('U3','P2','20110115','Payment',250);


SELECT t_user_master.UserName AS UserName ,t_product_master.Product_Name AS Product_Name,
SUM(CASE WHEN t_transaction.Transaction_Type='Order' THEN 1 ELSE 0 END) AS Ordered_Quantity,
SUM(CASE WHEN t_transaction.Transaction_Type='Payment' THEN t_transaction.Transaction_Amount ELSE 0 END) AS Amount_Paid,
MAX(t_transaction.Transaction_Date) AS Last_Transaction_Date,
(SUM(CASE WHEN t_transaction.Transaction_Type='Order' THEN t_transaction.Transaction_Amount ELSE 0 END)*t_product_master.Cost_Per_Item)-SUM(CASE WHEN t_transaction.Transaction_Type='Payment' THEN t_transaction.Transaction_Amount ELSE 0 END) AS Balance
FROM ((t_product_master 
		INNER JOIN t_transaction 
		ON t_product_master.Product_ID = t_transaction.Product_ID) 
		INNER JOIN t_user_master 
		ON t_transaction.UserID=t_user_master.UserID) 
GROUP BY t_transaction.UserID,t_transaction.Product_ID,t_product_master.Product_Name,t_user_master.UserName,t_product_master.Cost_Per_Item;


SELECT (SELECT us.UserName FROM t_user_master us WHERE t_transaction.UserID=us.UserID) AS User_Name,
(SELECT pr.Product_Name FROM t_product_master pr WHERE t_transaction.Product_ID=pr.Product_ID) As Product_Name,
SUM(CASE WHEN t_transaction.Transaction_Type='Order' THEN 1 ELSE 0 END) AS Ordered_Quantity,
SUM(CASE WHEN t_transaction.Transaction_Type='Payment' THEN t_transaction.Transaction_Amount ELSE 0 END) AS Amount_Paid,
MAX(t_transaction.Transaction_Date) AS Last_Transaction_Date,
(SUM(CASE WHEN t_transaction.Transaction_Type='Order' THEN t_transaction.Transaction_Amount ELSE 0 END)*(SELECT pr.Cost_Per_Item FROM t_product_master AS pr WHERE p.Cost_Per_Item=pr.Cost_Per_Item
))-SUM(CASE WHEN t_transaction.Transaction_Type='Payment' THEN t_transaction.Transaction_Amount ELSE 0 END) AS Balance
FROM ((t_product_master p
		INNER JOIN t_transaction 
		ON p.Product_ID = t_transaction.Product_ID) 
		INNER JOIN t_user_master u
		ON t_transaction.UserID=u.UserID) 
GROUP BY t_transaction.UserID,t_transaction.Product_ID,p.Cost_Per_Item;

