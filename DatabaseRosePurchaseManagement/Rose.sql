CREATE TABLE [dbo].[Rose]
(
	 [RoseID] INT NOT NULL IDENTITY,
	 [RoseName] NVARCHAR(50) NOT NULL,
	 [GroupCode] NVARCHAR(10) NOT NULL,
	 PRIMARY KEY ([RoseID]),
	 CONSTRAINT [FK_Rose_Group] FOREIGN KEY ([GroupCode]) REFERENCES [Group]([GroupCode]) 
)
