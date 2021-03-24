CREATE TABLE [dbo].[BoxInventory]
(
   [InventoryID] INT,
   [BoxID] INT,
   [Quantity] INT NOT NULL,
   CONSTRAINT [PK_BoxInventory] PRIMARY KEY (InventoryID, BoxID),
   CONSTRAINT [FK_BoxInventory_Inventory] FOREIGN KEY ([InventoryID]) REFERENCES [Inventory]  ([InventoryID]) ON UPDATE CASCADE,
   CONSTRAINT [FK_BoxInventory_Box] FOREIGN KEY ([BoxID]) REFERENCES [Box] ([BoxID]) ON UPDATE CASCADE
)
