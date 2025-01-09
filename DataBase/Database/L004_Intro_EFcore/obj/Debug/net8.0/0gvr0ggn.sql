BEGIN TRANSACTION;
DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Blogs]') AND [c].[name] = N'Author');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Blogs] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Blogs] DROP COLUMN [Author];

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Blogs]') AND [c].[name] = N'CreatedAt');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Blogs] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [Blogs] DROP COLUMN [CreatedAt];

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Blogs]') AND [c].[name] = N'IsOnline');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Blogs] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [Blogs] DROP COLUMN [IsOnline];

DELETE FROM [__EFMigrationsHistory]
WHERE [MigrationId] = N'20241202141353_CreateBlogColumns';

EXEC sp_rename N'[Blogs].[RatingRenamed]', N'Rating', 'COLUMN';

DELETE FROM [__EFMigrationsHistory]
WHERE [MigrationId] = N'20241202140250_RenameRatingColumn';

COMMIT;
GO

