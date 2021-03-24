CREATE TABLE [dbo].[Purchase]
(
	[PurchaseID] INT NOT NULL IDENTITY,
	[FarmID] INT NOT NULL,
	[RoseSizeID] INT NOT NULL,
	[Price_per_stem] DECIMAL NOT NULL,
	[InvoiceID] INT,
	[WarehouseID] INT,
	 PRIMARY KEY ([PurchaseID]),
	CONSTRAINT [FK_Purchase_Farm] FOREIGN KEY ([FarmID]) REFERENCES [Farm]  ([FarmID]) on UPDATE cascade,
	CONSTRAINT [FK_Purchase_RoseSize] FOREIGN KEY ([RoseSizeID]) REFERENCES [RoseSize]  ([RoseSizeID]) on UPDATE cascade,
	CONSTRAINT [FK_Purchase_Invoice] FOREIGN KEY ([InvoiceID]) REFERENCES [Invoice]   ([InvoiceID]) on UPDATE cascade,
CONSTRAINT [FK_Purchase_Warehouse] FOREIGN KEY ([WarehouseID]) REFERENCES [Warehouse]  ([WarehouseID]) on UPDATE cascade
)
