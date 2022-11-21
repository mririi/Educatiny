CREATE TABLE [dbo].[Matiere] (
    [ID]       INT          IDENTITY (1, 1) NOT NULL,
    [nom]    VARCHAR (30) NOT NULL,
    [coeff] float NOT NULL,
    CONSTRAINT [PK_Matiere] PRIMARY KEY CLUSTERED ([ID] ASC)
);