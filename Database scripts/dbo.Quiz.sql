CREATE TABLE [dbo].[Quiz]
(
	[ID]       INT          IDENTITY (1, 1) NOT NULL,
    [note]    Float NOT NULL,
	CONSTRAINT [PK_Quiz] PRIMARY KEY CLUSTERED ([ID] ASC),
)
