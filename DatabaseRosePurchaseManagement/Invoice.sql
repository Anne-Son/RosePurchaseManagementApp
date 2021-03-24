CREATE TABLE [dbo].[Invoice]
(
	 [InvoiceID] INT NOT NULL,
  	 [Date] Date NOT NULL,
	 [TotalAmount] Decimal NOT NULL,
	 [FarmID] INT NOT NULL,
	 PRIMARY KEY ([InvoiceID]),
	 CONSTRAINT [FK_Invoice_Farm] FOREIGN KEY ([FarmID]) REFERENCES [Farm]([FarmID]) 
)
