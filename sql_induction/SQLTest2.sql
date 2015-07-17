USE Shipment;
CREATE TABLE UserTable
(
UserID INT PRIMARY KEY,
Name VARCHAR(MAX),
Country VARCHAR(MAX),
Gender VARCHAR(1)
);
INSERT INTO UserTable VALUES(101,'Harsh','India','M'); 
INSERT INTO UserTable VALUES(102,'Richa','Sri Lanka','F');
INSERT INTO UserTable VALUES(103,'Richard','US','M');
INSERT INTO UserTable VALUES(104,'Gopal','India','M');
INSERT INTO UserTable VALUES(105,'Jennifer','US','F');
INSERT INTO UserTable VALUES(106,'Karishma','India','F');
INSERT INTO UserTable VALUES(107,'Clinton','US','M');
INSERT INTO UserTable VALUES(108,'Sadhna','India','F');
SELECT * FROM UserTable;
CREATE TABLE PostTable
(
PostID INT PRIMARY KEY,
UserID INT,
Post VARCHAR(MAX)
);
INSERT INTO PostTable VALUES(201,104,'My name is Gopal');
INSERT INTO PostTable VALUES(202,101,'Hello Fiends');
INSERT INTO PostTable VALUES(203,105,'Bon Voyage');
INSERT INTO PostTable VALUES(204,104,'Cherishing Life');
INSERT INTO PostTable VALUES(205,108,'Switching Lane');
INSERT INTO PostTable VALUES(206,105,'Feeling Nostalgic');
INSERT INTO PostTable VALUES(207,102,'Sangakkara Rocks');
INSERT INTO PostTable VALUES(208,104,'Bleeding Blue');
SELECT * FROM PostTable;
CREATE TABLE FriendRequestTable
(
RequestID INT PRIMARY KEY,
SenderID INT,
RecieverID INT,
Status VARCHAR(MAX)
);
INSERT INTO FriendRequestTable VALUES(301,101,102,'Approved');
INSERT INTO FriendRequestTable VALUES(302,107,105,'Rejected');
INSERT INTO FriendRequestTable VALUES(303,101,106,'Approved');
INSERT INTO FriendRequestTable VALUES(304,108,101,'Approved');
INSERT INTO FriendRequestTable VALUES(305,106,103,'Approved');
INSERT INTO FriendRequestTable VALUES(306,104,108,'Pending');
INSERT INTO FriendRequestTable VALUES(307,104,101,'Approved');
INSERT INTO FriendRequestTable VALUES(308,105,102,'Pending');
INSERT INTO FriendRequestTable VALUES(309,107,103,'Approved');
INSERT INTO FriendRequestTable VALUES(310,106,102,'Rejected');
SELECT * FROM FriendRequestTable;
CREATE TABLE PostLikesTable
(
LikeID INT PRIMARY KEY,
PostID INT,
UserID INT
);

INSERT INTO PostLikesTable VALUES(401,203,102);
INSERT INTO PostLikesTable VALUES(402,208,108);
INSERT INTO PostLikesTable VALUES(403,204,106);
INSERT INTO PostLikesTable VALUES(404,203,108);
INSERT INTO PostLikesTable VALUES(405,207,102);
INSERT INTO PostLikesTable VALUES(406,202,102);
INSERT INTO PostLikesTable VALUES(407,203,106);
INSERT INTO PostLikesTable VALUES(408,205,102);
INSERT INTO PostLikesTable VALUES(409,204,107);
INSERT INTO PostLikesTable VALUES(410,203,101);
SELECT * FROM PostLikesTable;

SELECT TOP 1 temp.Country
FROM
(SELECT ut.Country AS Country ,COUNT(*) AS PostCount
FROM PostTable pt INNER JOIN UserTable ut ON pt.UserID=ut.UserID
GROUP BY ut.Country) temp
ORDER BY PostCount DESC;


--Q2.
SELECT MAX(temp3.Counte),temp3.Country,temp3.Name
FROM
(SELECT Count(*) AS Counte,pt.UserID,ut.Country,(SELECT name FROM UserTable WHERE UserID=pt.UserID) AS Name
FROM PostTable pt INNER JOIN UserTable ut ON pt.UserID=ut.UserID
GROUP BY pt.UserID,ut.Country) temp3
GROUP BY temp3.Country,temp3.Name;

SELECT pt.UserID AS UserID,(SELECT name FROM UserTable WHERE UserID=pt.UserID) AS Name,(SELECT Country FROM UserTable WHERE UserID=pt.UserID) AS Country ,COUNT(*) AS PostCount
FROM PostTable pt INNER JOIN UserTable ut ON pt.UserID=ut.UserID
GROUP BY PT.UserID;



(SELECT temp.Country,MAX(temp.PostCount) AS Max_Post_Count 
FROM
(SELECT ut.UserID AS UserID,(SELECT name FROM UserTable WHERE UserID=ut.UserID) AS Name,(SELECT Country FROM UserTable WHERE UserID=ut.UserID) AS Country ,COUNT(*) AS PostCount
FROM PostTable pt INNER JOIN UserTable ut ON pt.UserID=ut.UserID
GROUP BY ut.UserID
) temp
GROUP BY temp.Country);

--Q3.

--SELECT COUNT(*) AS PostCount,PostID  FROM PostLikesTable ps GROUP BY PostID;-- TREAT IT AS TABLE

SELECT PostID FROM (SELECT COUNT(*) AS PostCount,PostID  FROM PostLikesTable ps GROUP BY PostID) ps4
WHERE ps4.PostCount=
(SELECT MAX(ps.PostCount) AS PostCounts
FROM
(SELECT COUNT(*) AS PostCount,PostID  FROM PostLikesTable ps GROUP BY PostID) ps WHERE ps.PostCount <(
SELECT MAX(ps1.PostCount) FROM
(SELECT COUNT(*) AS PostCount,PostID  FROM PostLikesTable ps GROUP BY PostID) ps1 WHERE ps1.PostCount < (SELECT MAX(ps2.PostCount)
FROM
(SELECT COUNT(*) AS PostCount,PostID  FROM PostLikesTable ps GROUP BY PostID) ps2)));

--Q4
SELECT MAX(temp.No_OF_Likes) AS Likes,(SELECT temp1.UserID FROM (SELECT Count(*) AS No_Of_Likes,pt.UserID 
FROM PostLikesTable pt INNER JOIN UserTable ut ON pt.UserID=ut.UserID GROUP BY pt.UserID) temp1 WHERE temp1.No_Of_Likes=MAX(temp.No_Of_Likes)) AS UserID
FROM 
(SELECT Count(*) AS No_Of_Likes,pt.UserID 
FROM PostLikesTable pt INNER JOIN UserTable ut ON pt.UserID=ut.UserID GROUP BY pt.UserID) temp;

--Q5.
SELECT (SELECT name FROM UserTable WHERE UserTable.UserID=SenderID) AS Name,senderID FROM FriendRequestTable WHERE Status='Pending' OR Status='Rejected' AND SenderID NOT IN(SELECT SenderID FROM FriendRequestTable WHERE Status='Approved');

--Q6.
SELECT pt.UserID,pk.PostID,COUNT(PK.UserID) AS Likes
FROM PostTable pt INNER JOIN PostLikesTable pk ON pt.PostID=pk.PostID
GROUP BY pk.PostID,pt.UserID;

SELECT temp.UserID,MAX(Likes) AS Likes
FROM
(SELECT pt.UserID,pk.PostID,COUNT(PK.UserID) AS Likes
FROM PostTable pt INNER JOIN PostLikesTable pk ON pt.PostID=pk.PostID
GROUP BY pk.PostID,pt.UserID) temp
GROUP BY temp.UserID;