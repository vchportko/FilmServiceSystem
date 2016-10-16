USE [DB_FilmBooking];
GO

CREATE FUNCTION IsSubstring( @string NVARCHAR(20), @substring NVARCHAR(20))
RETURNS BIT
AS
BEGIN
  DECLARE @temp NVARCHAR(20);
  DECLARE @tempSubstring NVARCHAR(20);
  DECLARE @out BIT;

  SET @temp=@string;
  SET @out=0;

  WHILE (LEN(@temp)>0 AND @out=0)
  BEGIN
     IF(PATINDEX('% %',@temp)>0)
	    BEGIN
			SET @tempSubstring= SUBSTRING(@temp, 0, PATINDEX('% %',@temp))  
			IF @tempSubstring=@substring
				SET @out=1;
			ELSE
			BEGIN
				SET @temp = SUBSTRING(@temp,PATINDEX('% %',@temp)+1,LEN(@temp)-LEN(@tempSubstring)-1);
		    END
	    END
	 ELSE
		BEGIN
		    SET @out=0;
		    IF @temp=@substring
				SET @out=1;
			SET @temp=''
	 END
  END
  RETURN @out
END;
GO

CREATE FUNCTION UserCanBuy (@UserID INT,@price FLOAT)
RETURNS BIT
AS
BEGIN
  DECLARE @balance FLOAT
  SET @balance = (SELECT Balance 
                 FROM [User] AS u 
				 WHERE u.ID=@UserID)
  IF(@balance>@price)
      RETURN 1;
 RETURN 0;
END
GO