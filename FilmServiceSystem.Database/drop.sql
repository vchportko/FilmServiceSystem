USE DB_FilmBooking

DROP PROC [dbo].[spGetAvailableFilm];
DROP PROC [dbo].[spGetBalance];
DROP PROC [dbo].[spGetUser];
DROP PROC [dbo].[spGetUserHistory];
DROP PROC [dbo].[spMakeOrder];
DROP PROC [dbo].[spSortByFilmIMDb];
DROP PROC [dbo].[spSortByFilmIMDbInGenre];

DROP TABLE [dbo].[Order];
DROP TABLE [dbo].[User];
DROP TABLE [dbo].[Film];
DROP TABLE [dbo].[Director];
DROP TABLE [dbo].[Person];