CREATE TABLE [dbo].[Passwords] (
    [Id]       INT         IDENTITY   NOT NULL,
    [URL]      NVARCHAR (50) NOT NULL,
    [password] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

