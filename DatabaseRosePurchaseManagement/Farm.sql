CREATE TABLE [dbo].[Farm]
(
	  [FarmID] INT NOT NULL IDENTITY,
      [FarmName] NVARCHAR(50) NOT NULL,
      [Phone] NVARCHAR(20) NOT NULL,
      [Email] NVARCHAR(50) NOT NULL,
       PRIMARY KEY ([FarmID])
)
