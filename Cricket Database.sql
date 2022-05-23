USE Cricket;

CREATE TABLE Country
(
Country_ID INT not null primary key identity(1,1),
Country_Name varchar(30),
Continent varchar(30),
Code int
);

ALTER TABLE Country ALTER COLUMN Code varchar(4);

CREATE TABLE Players
(
Player_ID INT not null primary key identity(1,1),
Player_Name varchar(30),
Age int
);

CREATE TABLE Stadium
(
Stadium_ID INT primary key,
Stadium_Count bigint,
Stadium_Name varchar(30),
No_of_Matches_Allowed int
);


CREATE TABLE Matches
(
Match_ID INT not null primary key identity(1,1),
Stadium_ID INT not null,
Team_A varchar(30),
Team_B varchar(30),
Result varchar(5),
Date_Time SMALLDATETIME,
Was_match_Played varchar(5));

INSERT INTO COUNTRY values
('India','Asia','+91'),
('Australia','Australia','+61'),
('England','Europe','+44'),
('New Zealand','Oceania','+64'),
('South Africa','Africa','+27');

SELECT * FROM COUNTRY;

INSERT INTO COUNTRY values
('India','Asia','+91'),
('Australia','Australia','+61'),
('England','Europe','+44'),
('New Zealand','Oceania','+64'),
('South Africa','Africa','+27');

--India Players
INSERT INTO Players values
('Rohit Sharma',35),
('Shikhar Dhawan',36),
('Virat Kohli',33),
('KL Rahul',30),
('Shreyas Iyer',27),
('Rishabh Pant',24),
('Ravindra Jadeja',33),
('Ravichandran Ashwin',35),
('Shardul Thakur',30),
('Mohammed Shami',31),
('Jasprit Bumrah',28);

--England Players

INSERT INTO Players values
('Eoin Morgan',35),
('Joe Root',31),
('Jason Roy',31),
('Liam Livingstone',28),	
('Moeen Ali',34),
('Ben Stokes',30),
('Sam Curran',23),
('Jos Buttler',31),
('Jofra Archer',27),
('Adil Rashid',34),
('Mark Wood',32);

--Australia Players
INSERT INTO Players values
('Aaron Finch',35),
('David Warner',35),
('Steven Smith',32),
('Glenn Maxwell',33),
('Marcus Stoinis',32),
('Marnus Labuschagne',27),
('Matthew Wade',34),
('Adam Zampa',30),
('Mitchell Starc',31),
('Josh Hazlewood',31),
('Pat Cummins',29);


--New Zealand Players

INSERT INTO Players values
('Martin Guptill',35),
('Ross Taylor',38),
('Kane Williamson',31),
('James Neesham',31),
('Colin de Grandhomme',35),
('Colin Munro',35),
('Tom Latham',30),
('Tim Southee',33),
('Lockie Ferguson',30),
('Ish Sodhi',29),
('Matt Henry',30);

--South Africa Players
 
 INSERT INTO Players values
('Faf du Plessis',37),
('David Miller',32),
('Aiden Markram',27),
('Jean-Paul Duminy',38),
('Chris Morris',35),
('Quinton de Kock',29),
('Imran Tahir',43),
('Kagiso Rabada',26),
('Lungi Ngidi',26),
('Tabraiz Shamsi',32),
('Matt Henry',30);


INSERT INTO Stadium values
(1,33500,'Wankhede Stadium',3),
(2,132000,'Narendra Modi Stadium',2),
(3,80000,'Eden Gardens',3),
(4,40000,'M. Chinnaswamy Stadium',2),
(5,23500,'The Oval',1),
(6,25000,'Edgbaston',2),
(7,26000,'Old Trafford',2),
(8,10024,'Melbourne Cricket Ground',2),
(9,55300,'Adelaide Oval',1),
(10,100000,'Ellis Park',3);

INSERT INTO Matches values
(1,'India','South Africa','','2022-06-09 19:00:00',''),
(2,'Australia','England','','2022-06-11 10:00:00',''),  
(3,'New Zealand','India','','2022-06-13 01:30:00',''),  
(4,'England','South Africa','','2022-06-15 10:30:00',''),  
(5,'New Zealand','Australia','','2022-06-17 10:00:00',''),  
(6,'India','England','','2022-06-19 13:30:00',''),  
(7,'Australia','South Africa','','2022-06-21 10:30:00',''),  
(8,'England','New Zealand','','2022-06-23 13:30:00',''),  
(9,'Australia','India','','2022-06-25 19:30:00',''),  
(10,'New Zealand','South Africa','','2022-06-27 10:00:00',''); 

 
SELECT * FROM Matches;


