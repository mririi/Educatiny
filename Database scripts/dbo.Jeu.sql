CREATE TABLE [dbo].[Jeu] (
    [ID]       INT          IDENTITY (1, 1) NOT NULL,
    [lien]     VARCHAR (200) NOT NULL,
    [IDLoisir] INT           NOT NULL,
	CONSTRAINT [PK_Jeu] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [PK_Jeu1] FOREIGN KEY ([IDLoisir]) REFERENCES [dbo].[Loisir] ([ID]),
);

