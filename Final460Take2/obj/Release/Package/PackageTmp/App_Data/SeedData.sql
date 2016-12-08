-- ########### Actor ###########
INSERT INTO [dbo].[Actor](Name)VALUES('Felicity Jones');
INSERT INTO [dbo].[Actor](Name)VALUES('Mads Mikkelson');
INSERT INTO [dbo].[Actor](Name)VALUES('Benedict Cumberbatch');
INSERT INTO [dbo].[Actor](Name)VALUES('Rachel McAdams');


-- ########### Director ###########
INSERT INTO [dbo].[Director](Name)VALUES('Gareth Edwards');
INSERT INTO [dbo].[Director](Name)VALUES('Scott Derrickson');
INSERT INTO [dbo].[Director](Name)VALUES('Morten Tyldum');
INSERT INTO [dbo].[Director](Name)VALUES('James Marsh');

-- ########### Movie ###########
INSERT INTO [dbo].[Movie](Title,Year,DirectorID)VALUES('Rogue One: A Star Wars Story',2016,1);
INSERT INTO [dbo].[Movie](Title,Year,DirectorID)VALUES('Doctor Strange',2016,2);
INSERT INTO [dbo].[Movie](Title,Year,DirectorID)VALUES('The Imitation Game',2014,3);
INSERT INTO [dbo].[Movie](Title,Year,DirectorID)VALUES('The Theory of Everything',2014,4);

-- ########### AllCast ###########
INSERT INTO [dbo].[AllCast](ActorID,MovieID)VALUES(1,1);
INSERT INTO [dbo].[AllCast](ActorID,MovieID)VALUES(2,1);
INSERT INTO [dbo].[AllCast](ActorID,MovieID)VALUES(3,2);
INSERT INTO [dbo].[AllCast](ActorID,MovieID)VALUES(4,2);
INSERT INTO [dbo].[AllCast](ActorID,MovieID)VALUES(3,3);
INSERT INTO [dbo].[AllCast](ActorID,MovieID)VALUES(1,4);
INSERT INTO [dbo].[AllCast](ActorID,MovieID)VALUES(2,2);

