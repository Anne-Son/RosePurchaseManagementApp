CREATE TABLE [dbo].[Inventory]
(
	 [InventoryID] INT NOT NULL IDENTITY,
	 [FarmID] INT NOT NULL,
	 [RoseSizeID] INT NOT NULL,
	 [Price_per_stem] FLOAT NOT NULL,
	 PRIMARY KEY ([InventoryID]),
	 CONSTRAINT [FK_Inventory_Farm] FOREIGN KEY ([FarmID]) REFERENCES [Farm]([FarmID]) on UPDATE cascade,
	 CONSTRAINT [FK_Inventory_RoseSize] FOREIGN KEY ([RoseSizeID]) REFERENCES [RoseSize]([RoseSizeID]) on update cascade
)
