CREATE TABLE [dbo].[Question]
(
	[ID]       INT          IDENTITY (1, 1) NOT NULL,
    [question]    VARCHAR (30) NOT NULL,
	[type]    VARCHAR (30) NOT NULL,
	[IDQuiz] INT        NOT NULL,
	CONSTRAINT [PK_Question] PRIMARY KEY CLUSTERED ([ID] ASC),
	CONSTRAINT [PK_Question1] FOREIGN KEY ([IDQuiz]) REFERENCES [dbo].[Quiz] ([ID])
)
