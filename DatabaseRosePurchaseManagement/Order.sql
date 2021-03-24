CREATE TABLE [dbo].[Order]
(
	[OrderID] INT NOT NULL IDENTITY,
	[RoseSizeID] INT NOT NULL,
	[Number_of_bunches] INT NOT NULL,
	PRIMARY KEY ([OrderID]),
	CONSTRAINT [FK_Order_RoseSize] FOREIGN KEY ([RoseSizeID]) REFERENCES [RoseSize]  ([RoseSizeID]) 
)
