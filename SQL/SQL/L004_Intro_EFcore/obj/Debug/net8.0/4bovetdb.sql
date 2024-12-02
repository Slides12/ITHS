IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
CREATE TABLE [Blogs] (
    [BlogId] int NOT NULL IDENTITY,
    [Url] nvarchar(max) NULL,
    [Rating] int NULL,
    CONSTRAINT [PK_Blogs] PRIMARY KEY ([BlogId])
);

CREATE TABLE [Posts] (
    [PostId] int NOT NULL IDENTITY,
    [Topic] nvarchar(max) NULL,
    [Text] nvarchar(max) NULL,
    [BlogId] int NULL,
    CONSTRAINT [PK_Posts] PRIMARY KEY ([PostId]),
    CONSTRAINT [FK_Posts_Blogs_BlogId] FOREIGN KEY ([BlogId]) REFERENCES [Blogs] ([BlogId])
);

CREATE INDEX [IX_Posts_BlogId] ON [Posts] ([BlogId]);

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20241202135326_initalize', N'9.0.0');

EXEC sp_rename N'[Blogs].[Rating]', N'RatingRenamed', 'COLUMN';

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20241202140250_RenameRatingColumn', N'9.0.0');

ALTER TABLE [Blogs] ADD [Author] nvarchar(max) NOT NULL DEFAULT N'';

ALTER TABLE [Blogs] ADD [CreatedAt] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';

ALTER TABLE [Blogs] ADD [IsOnline] bit NOT NULL DEFAULT CAST(0 AS bit);

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20241202141353_CreateBlogColumns', N'9.0.0');

COMMIT;
GO

