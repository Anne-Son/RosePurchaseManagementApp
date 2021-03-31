CREATE TABLE [dbo].[Invoice]
(
	 [InvoiceID] INT NOT NULL,
  	 [Date] Date NOT NULL,
	 [TotalAmount] FLOAT NOT NULL,
	 [FarmID] INT NOT NULL,
	 PRIMARY KEY ([InvoiceID]),
	 CONSTRAINT [FK_Invoice_Farm] FOREIGN KEY ([FarmID]) REFERENCES [Farm]([FarmID]) 
)
