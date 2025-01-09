CREATE TABLE [dbo].[Cities] (
    [Id]        INT           NOT NULL,
    [CityName]  NVARCHAR (50) NULL,
    [CountryID] INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Cities_Countries] FOREIGN KEY ([CountryID]) REFERENCES [dbo].[Countries] ([Id])
);


