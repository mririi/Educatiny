CREATE TABLE [dbo].[User] (
    [ID]       INT          IDENTITY (1, 1) NOT NULL,
    [email]    VARCHAR (30) NOT NULL,
    [password] VARCHAR (30) NOT NULL,
    [nom] VARCHAR(30) NULL, 
    [prenom] VARCHAR(30) NULL, 
    [sexe] VARCHAR(10) NULL, 
    [age] INT NULL, 
    [IDLoisir] INT NULL, 
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([ID] ASC)
);

