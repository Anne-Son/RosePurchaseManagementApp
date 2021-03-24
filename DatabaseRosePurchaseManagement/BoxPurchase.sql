CREATE TABLE [dbo].[BoxPurchase]
(
	[PurchaseID] INT,
	[BoxID] INT,
	[Quantity] INT NOT NULL,
	CONSTRAINT [PK_BoxPurchase] PRIMARY KEY (PurchaseID, BoxID),
	CONSTRAINT [FK_BoxPurchase_Purchase] FOREIGN KEY ([PurchaseID]) REFERENCES [Purchase]  ([PurchaseID]) ON UPDATE CASCADE,
	CONSTRAINT [FK_BoxPurchase_Box] FOREIGN KEY ([BoxID]) REFERENCES [Box]  ([BoxID]) ON UPDATE CASCADE
)
