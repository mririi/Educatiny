CREATE TABLE [dbo].[Reponse]
(
	[ID]       INT          IDENTITY (1, 1) NOT NULL,
    [reponse]    VARCHAR (30) NOT NULL,
	[validite] INT NOT NULL,
	[IDQuestion] INT NOT NULL,
	CONSTRAINT [PK_Reponse] PRIMARY KEY CLUSTERED ([ID] ASC),
	CONSTRAINT [PK_Reponse1] FOREIGN KEY ([IDQuestion]) REFERENCES [dbo].[Question] ([ID])
)
