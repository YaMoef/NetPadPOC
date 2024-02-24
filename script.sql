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
GO

CREATE TABLE [Authors] (
    [RandomPrimaryKey] int NOT NULL IDENTITY,
    CONSTRAINT [PK_Authors] PRIMARY KEY ([RandomPrimaryKey])
);
GO

CREATE TABLE [Books] (
    [Id] int NOT NULL IDENTITY,
    [ISBN] nvarchar(max) NOT NULL,
    [RandomPrimaryKey] int NOT NULL,
    CONSTRAINT [PK_Books] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_TargetDetail_Concession] FOREIGN KEY ([RandomPrimaryKey]) REFERENCES [Authors] ([RandomPrimaryKey])
);
GO

CREATE INDEX [IX_Books_RandomPrimaryKey] ON [Books] ([RandomPrimaryKey]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240224215318_Initial', N'8.0.2');
GO

COMMIT;
GO

