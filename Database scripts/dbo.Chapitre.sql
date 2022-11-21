CREATE TABLE [dbo].[Chapitre] (
    [ID]       INT          IDENTITY (1, 1) NOT NULL,
    [titre]    VARCHAR (30) NOT NULL,
    [chapnum] int NOT NULL,
	[matiereID] int NOT NULL,
    CONSTRAINT [PK_Chapitre] PRIMARY KEY CLUSTERED ([ID] ASC),
	CONSTRAINT [PK_Chapitre1] FOREIGN KEY(matiereID) REFERENCES Matiere(ID),
);