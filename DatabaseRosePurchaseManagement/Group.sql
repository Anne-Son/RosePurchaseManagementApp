CREATE TABLE [dbo].[Group]
(
    [GroupName] NVARCHAR(20) NOT NULL,
    [GroupCode] NVARCHAR(10) NOT NULL UNIQUE,
    PRIMARY KEY ([GroupCode])
)
