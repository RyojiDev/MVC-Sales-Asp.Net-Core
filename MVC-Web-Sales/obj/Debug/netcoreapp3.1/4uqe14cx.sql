IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Department] (
    [Id] int NOT NULL,
    [Name] nvarchar(max) NULL,
    CONSTRAINT [PK_Department] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Seller] (
    [Id] int NOT NULL,
    [Name] nvarchar(max) NULL,
    [Email] nvarchar(max) NULL,
    [BirthDate] datetime2 NOT NULL,
    [BaseSalary] float NOT NULL,
    [DepartmentId] int NULL,
    CONSTRAINT [PK_Seller] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Seller_Department_DepartmentId] FOREIGN KEY ([DepartmentId]) REFERENCES [Department] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [SalesRecord] (
    [Id] int NOT NULL,
    [Date] datetime2 NOT NULL,
    [Amount] float NOT NULL,
    [Status] int NOT NULL,
    [SellerId] int NULL,
    CONSTRAINT [PK_SalesRecord] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SalesRecord_Seller_SellerId] FOREIGN KEY ([SellerId]) REFERENCES [Seller] ([Id]) ON DELETE NO ACTION
);

GO

CREATE INDEX [IX_SalesRecord_SellerId] ON [SalesRecord] ([SellerId]);

GO

CREATE INDEX [IX_Seller_DepartmentId] ON [Seller] ([DepartmentId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200202161104_initial', N'3.1.1');

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200202175245_banco', N'3.1.1');

GO

