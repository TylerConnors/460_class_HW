CREATE TABLE [dbo].[Artist] (
    [ArtistID] INT           IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (50) DEFAULT ('Unknown') NOT NULL,
    [DOB]      DATE          DEFAULT ('01/01/1600') NOT NULL,
    [City]     NVARCHAR (50) DEFAULT ('Unknown') NOT NULL,
    PRIMARY KEY CLUSTERED ([ArtistID] ASC)
);

CREATE TABLE [dbo].[ArtWork] (
    [ArtWorkID] INT           IDENTITY (1, 1) NOT NULL,
    [Title]     NVARCHAR (50) DEFAULT ('Untitled') NOT NULL,
    [ArtistID]  INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([ArtWorkID] ASC),
    CONSTRAINT [FK_ArtistID] FOREIGN KEY ([ArtistID]) REFERENCES [dbo].[Artist] ([ArtistID])
);

CREATE TABLE [dbo].[Genre] (
    [GenreID] INT           IDENTITY (1, 1) NOT NULL,
    [Name]    NVARCHAR (50) DEFAULT ('Unknown') NOT NULL,
    PRIMARY KEY CLUSTERED ([GenreID] ASC)
);


CREATE TABLE [dbo].[Classification]
(
    [ClassID] INT IDENTITY (1, 1) NOT NULL,
    [ArtWorkID] INT             NOT NULL,
    [GenreID]   INT             NOT NULL,
    PRIMARY KEY CLUSTERED ([ClassID] ASC),
    CONSTRAINT [FK_ArtWorkID] FOREIGN KEY ([ArtWorkID]) REFERENCES [dbo].[ArtWork] ([ArtWorkID]),
    CONSTRAINT [FK_GenreID] FOREIGN KEY ([GenreID]) REFERENCES [dbo].[Genre] ([GenreID])
)
