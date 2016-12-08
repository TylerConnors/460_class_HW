CREATE TABLE [dbo].[Director] (
    [DirectorID] INT           IDENTITY (1, 1) NOT NULL,
    [Name]    NVARCHAR (50) DEFAULT ('Unknown') NOT NULL,
    PRIMARY KEY CLUSTERED ([DirectorID] ASC)
);

CREATE TABLE [dbo].[Actor] (
    [ActorID] INT           IDENTITY (1, 1) NOT NULL,
    [Name]    NVARCHAR (50) DEFAULT ('Unknown') NOT NULL,
    PRIMARY KEY CLUSTERED ([ActorID] ASC)
);

CREATE TABLE [dbo].[Movie] (
    [MovieID] INT           IDENTITY (1, 1) NOT NULL,
    [Title]     NVARCHAR (50) DEFAULT ('Untitled') NOT NULL,
	[Year]      INT          DEFAULT 2000 NOT NULL,
    [DirectorID]  INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([MovieID] ASC),
    CONSTRAINT [FK_DirectorID] FOREIGN KEY ([DirectorID]) REFERENCES [dbo].[Director] ([DirectorID])
);

CREATE TABLE [dbo].[AllCast]
(
    [AllCastID] INT IDENTITY (1, 1) NOT NULL,
    [ActorID] INT             NOT NULL,
    [MovieID]   INT             NOT NULL,
    PRIMARY KEY CLUSTERED ([AllCastID] ASC),
    CONSTRAINT [FK_ActorID] FOREIGN KEY ([ActorID]) REFERENCES [dbo].[Actor] ([ActorID]),
    CONSTRAINT [FK_MovieID] FOREIGN KEY ([MovieID]) REFERENCES [dbo].[Movie] ([MovieID])
)