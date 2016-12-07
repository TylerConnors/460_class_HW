﻿-- ########### Artist ###########
INSERT INTO [dbo].[Artist](Name,DOB,City)VALUES('M.C.Escher','06/17/1898','Leeuwarden, Netherlands');
INSERT INTO [dbo].[Artist](Name,DOB,City)VALUES('Leonardo Da Vinci','05/02/1519','Vinci, Italy');
INSERT INTO [dbo].[Artist](Name,DOB,City)VALUES('Hatip Mehmed Efendi','11/18/1680','Unknown');
INSERT INTO [dbo].[Artist](Name,DOB,City)VALUES('Slavador Dali','05/11/1904','Figueres, Spain');

-- ########### ArtWork ###########
INSERT INTO [dbo].[ArtWork](Title,ArtistID)VALUES('Circle Limit III',1);
INSERT INTO [dbo].[ArtWork](Title,ArtistID)VALUES('Twon Tree',1);
INSERT INTO [dbo].[ArtWork](Title,ArtistID)VALUES('Mona Lisa',2);
INSERT INTO [dbo].[ArtWork](Title,ArtistID)VALUES('The Vitruvian Man',2);
INSERT INTO [dbo].[ArtWork](Title,ArtistID)VALUES('Ebru',3);
INSERT INTO [dbo].[ArtWork](Title,ArtistID)VALUES('Honey Is Sweeter Than Blood',4);


-- ########### Genre ###########
INSERT INTO [dbo].[Genre](Name)VALUES('Tesselation');
INSERT INTO [dbo].[Genre](Name)VALUES('Surrealism');
INSERT INTO [dbo].[Genre](Name)VALUES('Portrait');
INSERT INTO [dbo].[Genre](Name)VALUES('Renaissance');

-- ########### Classification ###########
INSERT INTO [dbo].[Classification](ArtWorkID,GenreID)VALUES(1,1);
INSERT INTO [dbo].[Classification](ArtWorkID,GenreID)VALUES(2,1);
INSERT INTO [dbo].[Classification](ArtWorkID,GenreID)VALUES(2,2);
INSERT INTO [dbo].[Classification](ArtWorkID,GenreID)VALUES(3,3);
INSERT INTO [dbo].[Classification](ArtWorkID,GenreID)VALUES(3,4);
INSERT INTO [dbo].[Classification](ArtWorkID,GenreID)VALUES(4,4);
INSERT INTO [dbo].[Classification](ArtWorkID,GenreID)VALUES(5,1);
INSERT INTO [dbo].[Classification](ArtWorkID,GenreID)VALUES(6,2);