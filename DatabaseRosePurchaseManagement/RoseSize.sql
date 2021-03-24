CREATE TABLE [dbo].[RoseSize]
(
	[RoseSizeID] INT NOT NULL IDENTITY,
	[RoseID] INT NOT NULL,
	[SizeID] INT NOT NULL,
	PRIMARY KEY ([RoseSizeID]),
	CONSTRAINT [FK_RoseSize_Rose] FOREIGN KEY ([RoseID]) REFERENCES [Rose]  ([RoseID]), 
CONSTRAINT [FK_RoseSize_Size] FOREIGN KEY ([SizeID]) REFERENCES [Size]  ([SizeID]) 
)
