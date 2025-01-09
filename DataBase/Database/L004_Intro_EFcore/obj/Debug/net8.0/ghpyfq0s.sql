BEGIN TRANSACTION;
ALTER TABLE [Blogs] ADD [Author] nvarchar(max) NOT NULL DEFAULT N'';

ALTER TABLE [Blogs] ADD [CreatedAt] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';

ALTER TABLE [Blogs] ADD [IsOnline] bit NOT NULL DEFAULT CAST(0 AS bit);

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20241202141353_CreateBlogColumns', N'9.0.0');

COMMIT;
GO

