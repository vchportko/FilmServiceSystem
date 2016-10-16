﻿USE [DB_FilmBooking];
GO
INSERT INTO Person (FirstName, LastName)
VALUES 
 ( 'Jonathan' ,'Nolan'),
 ( 'Sidney ' ,'Lumet'),
 ( 'Steven ' ,'Spielberg'),
 ( 'Peter ' ,'Jackson'),
 ( 'Christopher ' ,'Nolan'),
 ( 'Robert ' ,'Zemeckis'),
 ( 'Martin ' ,'Scorsese'),
 ( 'David' ,'Fincher'),
 ('Lana','Wachowski'),
 ('George','Lucas'),
 ('Jonathan','Demme')

 INSERT INTO Person (FirstName, LastName)
VALUES ('Yura', 'Malyga');


 INSERT INTO Director (PersonID)
 VALUES
 (1),(2),(3),(4),(5),			  
 (6),(7),(8),(9),(10),
 (11)

INSERT INTO Film (Title,Genre,YearRelease,DirectorID,Price,RentalPrice,IMDb)
 VALUES ('The Dark Knight','Crime Drama ',2008,100,154.3,60,8.4),
	    ('12 Angry Men','Crime Drama ',1957,101,80.2,40,8.5),
	    ('Schindler"s List','Biography History',1994,102,130.2,60,8.9),
		('The Lord of the Rings: The Return of the King',' Action Adventure',2004,103,180.7,40,8.0),
		('The Hobbit: An Unexpected Journey','Adventure Fantasy',2012,103,156.9,40,7.9),
		('Inception ','Action Adventure',2010,104,65.8,40,6.7),
		('Forrest Gump','Comedy Drama',1994,105,210.4,55,9.0),
		('Goodfellas ','Biography Crime',2010,106,145.6,60,8.9),
		('The Wolf of Wall Street ','Comedy Crime',2014,106,120.7,65,8.1),
		('Shutter Island ','Mystery Thriller',2010,106,140.4,50,8.9),
		('The Departed  ','Drama Thriller ',2006,106,120.7,50,8.5),
		('Fight Club','Drama',1999,107,98.7,55,9.1),
		('The Matrix ','Action',1999,108,99.0,40,9.0),
		('Star Wars','Action Adventure',1990,109,220.5,60,9.2),
		('The Silence of the Lambs',' Crime Drama',1991,110,67.4,49,6.7)

INSERT INTO [User] (PersonID,Balance,[Login],[Password],[status])
VALUES 
		(12,300,'George','46132d12e879ec9941866bea92fceb35b11f84de2e159543e9b49db10123a215','user')

INSERT INTO [Order] (UserID,FilmID,OrderDate)
VALUES
		(601,802,'2016-03-11'),
		(601,807,'2015-09-30'),
		(601,811,'2016-05-01')

		

