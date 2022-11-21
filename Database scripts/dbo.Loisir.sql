CREATE TABLE [dbo].[Loisir] (
    [ID]  INT         IDENTITY (1, 1) NOT NULL,
    [nom] VARCHAR (30) NOT NULL,
    CONSTRAINT [PK_Loisir] PRIMARY KEY CLUSTERED ([ID] ASC),
);

