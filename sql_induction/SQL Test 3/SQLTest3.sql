USE Shipment;
CREATE TABLE Vendor
(
VendorID INT PRIMARY KEY,
Name VARCHAR(MAX)
);
INSERT INTO Vendor VALUES(101,'Sai Travels');
INSERT INTO Vendor VALUES(102,'Meru Cabs');
INSERT INTO Vendor VALUES(103,'Miracle Cabs');

CREATE TABLE Cab
(
CabID INT PRIMARY KEY,
VendorID INT ,
Number INT,
BrandName VARCHAR(MAX)
);
INSERT INTO  Cab VALUES(201,101,8529,'Mercedes');
INSERT INTO  Cab VALUES(202,103,5764,'Jaguar');
INSERT INTO  Cab VALUES(203,101,1967,'Lamborghini');
INSERT INTO  Cab VALUES(204,102,7359,'Mercedes');
INSERT INTO  Cab VALUES(205,103,1992,'Audi');
INSERT INTO  Cab VALUES(206,103,0786,'BMW');
INSERT INTO  Cab VALUES(207,101,0007,'Audi');
INSERT INTO  Cab VALUES(208,102,8541,'Fiat');

CREATE TABLE [User]
(
UserID INT PRIMARY KEY,
Name VARCHAR(MAX),
Gender VARCHAR(1)
);

INSERT INTO [User] VALUES(301,'Ravi','M');
INSERT INTO [User] VALUES(302,'Kavi','F');
INSERT INTO [User] VALUES(303,'Abhi','M');
INSERT INTO [User] VALUES(304,'Savita','F');
INSERT INTO [User] VALUES(305,'Gopal','M');
INSERT INTO [User] VALUES(306,'Bhopal','M');
INSERT INTO [User] VALUES(307,'Dolly','F');
INSERT INTO [User] VALUES(308,'Tanu','F');
INSERT INTO [User] VALUES(309,'Prince','M');
INSERT INTO [User] VALUES(310,'Raj Kishore','M');

CREATE TABLE Bookings
(
BookingID INT PRIMARY KEY,
CabID INT,
UserID INT,
Fare MONEY,
Distance DECIMAL,
Pickup_Time DateTime,
Drop_Time DateTime,
Rating INT 
);
select * from Bookings; 
INSERT INTO Bookings VALUES(401,204,309,101,13,'20150407 19:00:00','20150407 19:30:00',5);
INSERT INTO Bookings VALUES(402,205,301,105,15.2,'20150511 09:15:00','20150511 10:00:00',3);
INSERT INTO Bookings VALUES(403,204,309,2000,190,'20150319 20:45:00','20150320 01:00:00',2);

INSERT INTO Bookings VALUES(404,201,302,1995,150,'20150707 11:00:00','20150707 15:00:00',5);

INSERT INTO Bookings VALUES(405,204,303,553,50,'20140912 19:00:00','20140912 22:15:00',2);

INSERT INTO Bookings VALUES(406,202,302,465,45,'20150107 09:00:00','20150107 09:40:00',1);

INSERT INTO Bookings VALUES(407,205,304,258,20,'20150702 03:00:00','20150702 03:15:00',4);

INSERT INTO Bookings VALUES(408,202,309,125,15,'20150623 09:00:00','20150205 10:00:00',5);

INSERT INTO Bookings VALUES(409,204,310,1462,30,'20150205 06:00:00','20150205 08:00:00',4);
INSERT INTO Bookings VALUES(410,207,306,1876,60,'20150129 15:00:00','20150129 18:00:00',1);
INSERT INTO Bookings VALUES(411,203,308,1145,100,'20150604 20:00:00','20150605 06:00:00',0);
INSERT INTO Bookings VALUES(412,206,309,1358,90,'20150119 02:00:00','20150119 08:00:00',1);
INSERT INTO Bookings VALUES(413,208,301,102,5,'20150321 11:00:00','20150321 11:15:00',5);

INSERT INTO Bookings VALUES(414,206,309,503,50,'20150228 08:00:00','20150228 10:00:00',4);
INSERT INTO Bookings VALUES(415,204,304,786,62,'20150309 16:00:00','20150309 19:00:00',3);
INSERT INTO Bookings VALUES(416,208,306,143,3,'20150409 11:30:00','20150409 11:45:00',2);
INSERT INTO Bookings VALUES(417,203,309,658,12,'20150504 01:00:00','20150504 01:45:00',0);
INSERT INTO Bookings VALUES(418,206,308,852,17,'20150218 15:00:00','20150218 16:00:00',1);
INSERT INTO Bookings VALUES(419,208,301,450,22,'20150311 18:00:00','20150312 10:00:00',4);
INSERT INTO Bookings VALUES(420,204,309,420,29,'20150217 11:00:00','20150217 21:00:00',1);

--Q1. 
SELECT us.Name AS [User Name],c.BrandName AS [Brand Name],c.Number AS [Cab Number],DATEDIFF(MINUTE,bk.Pickup_Time,bk.Drop_Time) AS [Travel Time]
FROM ([User] us INNER JOIN Bookings bk ON us.UserID=bk.UserID) INNER JOIN Cab c ON BK.CabID=C.CabID
WHERE BK.Fare BETWEEN 500 AND 1000; 


--Q2.

SELECT TOP 1  CabID , COUNT(*) AS [Number of Bookings],(SELECT Cab.Number FROM Cab WHERE Bk.CabID=Cab.CabID) AS [Cab Number],(SELECT Cab.BrandName FROM Cab WHERE Bk.CabID=Cab.CabID) AS [Brand Name]
FROM Bookings bk
GROUP  BY bk.CabID
ORDER BY COUNT(*) DESC;

--Q3.
SELECT TOP 3 (SELECT Name FROM [User] WHERE UserID= bk.UserID) AS [User Name],COUNT(*) AS [Number of times]
FROM [User] us INNER JOIN Bookings bk ON us.UserID=bk.UserID
GROUP BY bk.UserID
ORDER BY COUNT(*) DESC;

--Q4.
Select p.[User Name],(SELECT Name FROM Vendor WHERE p.VendorID=VendorID) AS [Vendor Name],p.[Number Of Times Booked]
FROM
(SELECT (SELECT Name FROM [User] WHERE UserID= bk.UserID) AS [User Name],(SELECT VendorID FROM Cab WHERE CabID= bk.CabID) AS VendorID,COUNT(*) AS [Number Of Times Booked]
FROM Bookings bk
GROUP BY bk.UserID,bk.CabID) P;

--Q5.
SELECT  (SELECT BrandName FROM Cab WHERE Cab.CabID=p.CabID) AS [Brand Name],(SELECT Number FROM Cab WHERE Cab.CabID=p.CabID) AS Number ,SUM(CASE WHEN P.Gender='M' THEN 1 ELSE 0 END) AS Male,SUM(CASE WHEN P.Gender='F' THEN 1 ELSE 0 END ) AS Female
FROM
((SELECT bk.CabID,(SELECT Gender FROM [User] WHERE BK.UserID=UserID) AS Gender
FROM ([User] us INNER JOIN Bookings bk ON us.UserID=bk.UserID) INNER JOIN Cab c ON BK.CabID=C.CabID 
GROUP BY bk.CabID,bk.UserID) p INNER JOIN Cab cb ON P.CabID=CB.CabID) 
GROUP BY P.CabID;

--Q6. 
SELECT cb.VendorID,AVG(bk.Rating) AS [Average Rating]
FROM Bookings bk INNER JOIN Cab cb ON bk.CabID=cb.CabID
GROUP BY cb.VendorID;

--Q7.
SELECT V.Name,cb1.BrandName,temp.[Total Distance],(temp.[Total Distance]/(temp.Total_time/60)) AS [Average Speed(Km/hr)]
FROM 
((SELECT bk.CabID,SUM(bk.Distance) AS [Total Distance],SUM(DATEDIFF(MINUTE,bk.Pickup_Time,bk.Drop_Time)) AS Total_time
FROM Cab cb INNER JOIN Bookings bk ON cb.CabID=bk.CabID 
GROUP BY bk.CabID) temp INNER JOIN Cab cb1 ON temp.CabID=cb1.CabID) INNER JOIN Vendor v ON CB1.VendorID=V.VendorID;

--Q 8.
SELECT v.Name,COUNT(*) AS [Number of Bookings]
FROM (Cab cb INNER JOIN Bookings bk ON cb.CabID=bk.CabID) INNER JOIN Vendor v ON cb.VendorID=v.VendorID
WHERE DATEDIFF(DAY,'20150702',bk.Pickup_Time)=0 AND DATEDIFF(MONTH,'20150702',bk.Pickup_Time)=0 AND DATEDIFF(YEAR,'20150702',bk.Pickup_Time)=0
GROUP BY V.Name;

--Q9.

SELECT TOP 1 bk.CabID,(SUM(bk.Fare)/SUM(bk.Distance)) AS Fare
FROM Cab cb INNER JOIN Bookings bk ON cb.CabID=bk.CabID 
GROUP BY bk.CabID
ORDER BY (SUM(bk.Fare)/SUM(bk.Distance)) ASC;