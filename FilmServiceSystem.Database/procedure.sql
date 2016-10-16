USE [DB_FilmBooking];
GO

CREATE VIEW FilmView
AS
  SELECT f.ID,f.Title,f.YearRelease, f.Genre, f.IMDb,p.LastName as Director,f.Price
  FROM Film as f
  INNER JOIN Director as d
  ON f.DirectorID=d.ID
  INNER JOIN Person as p
  ON d.PersonID=p.ID
GO

 CREATE PROCEDURE spGetUserByLogin
 @login NVARCHAR(50),
 @password NVARCHAR(300)
 AS
	SELECT u.ID,u.Balance,u.[Login],p.FirstName,p.LastName
	FROM [User] as u
	INNER JOIN Person as p
	ON u.PersonID = p.ID
	WHERE u.[Login]=@login AND u.[Password]=@password
GO

CREATE PROCEDURE spGetAllUsers
AS
	SELECT u.ID,u.Balance,u.[Login],p.FirstName,p.LastName
	FROM [User] as u
	INNER JOIN Person as p
	ON u.PersonID = p.ID
GO

CREATE PROCEDURE spGetUserHistory
@UserID INT
AS
	SELECT u.[Login],f.Title,f.Price,o.OrderDate
	FROM Film as f
	INNER JOIN [Order] as o
	ON f.ID = o.FilmID
	INNER JOIN [User] as u
	ON o.UserID=u.ID
	WHERE o.UserID=@UserID;
GO

CREATE PROCEDURE spGetBalance
@UserID INT
AS
 SELECT Balance
 FROM [User] as u
 WHERE u.ID=@UserID;
GO

CREATE PROCEDURE spRegisterUser
@login NVARCHAR(30),
@firstName NVARCHAR(20),
@lastName NVARCHAR(30),
@password NVARCHAR(100)
AS
	INSERT INTO Person(FirstName,LastName)
	VALUES(@firstName,@lastName);

	DECLARE @personID INT;
	SET @personID = (SELECT ID
	                 FROM Person as p
					 WHERE p.FirstName=@firstName 
					       AND p.LastName=@lastName);
    INSERT INTO [User] (PersonID,Balance,[Login],[Password])
	VALUES (@personID,400,@login,@password);
GO

CREATE PROCEDURE spSortByFilmIMDb
AS
  SELECT *
  FROM FilmView
  ORDER BY IMDb DESC;
GO

CREATE PROCEDURE spSortByFilmIMDbInGenre
@genre NVARCHAR(20)
AS
  SELECT *
  FROM FilmView
  WHERE dbo.IsSubString(Genre,@genre)=1
  ORDER BY IMDb DESC 
GO

CREATE PROCEDURE spGetAvailableFilm
AS
	SELECT *
	FROM FilmView as fV
	LEFT JOIN [Order] as o
	ON fV.ID=o.FilmID
	WHERE (o.FilmID IS NULL)
GO

CREATE PROCEDURE spMakeOrder
@UserID INT,
@FilmID INT,
@OrderDate DATETIME,
@result BIT OUTPUT
AS
	SET XACT_ABORT ON
	BEGIN TRY
	 BEGIN TRANSACTION PurchaseTran
	 	DECLARE @price FLOAT
		SET @price= (SELECT Price
		             FROM Film as f
					 WHERE f.ID = @FilmID)
		IF (dbo.UserCanBuy(@UserID,@price) = 1)
		  BEGIN	
			INSERT INTO [Order] 
			VALUES(@UserID,@FilmID,@OrderDate);

			UPDATE [User]
			SET Balance=Balance-@price;
              SET @result=1;
		  END
		ELSE
		  BEGIN
		    SET @result=0;
		  END
	 COMMIT TRANSACTION
	END TRY

	BEGIN CATCH
		IF XACT_STATE() <> 0
        ROLLBACK TRANSACTION
	END CATCH
GO
