/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
USE [DatabaseRosePurchaseManagementApp]
GO
SET IDENTITY_INSERT [dbo].[Box] ON
INSERT INTO [dbo].[Box] ([BoxID], [BoxName]) VALUES (1, N'Quarter Box')
INSERT INTO [dbo].[Box] ([BoxID], [BoxName]) VALUES (2, N'Half Box')
INSERT INTO [dbo].[Box] ([BoxID], [BoxName]) VALUES (3, N'Full Box')
SET IDENTITY_INSERT [dbo].[Box] OFF
GO
INSERT INTO [dbo].[Group] ([GroupName], [GroupCode]) VALUES ( N'Cream', N'CR')
INSERT INTO [dbo].[Group] ([GroupName], [GroupCode]) VALUES ( N'Green', N'GR')
INSERT INTO [dbo].[Group] ([GroupName], [GroupCode]) VALUES ( N'Mixture', N'MIX')
INSERT INTO [dbo].[Group] ([GroupName], [GroupCode]) VALUES ( N'Orange', N'OR')
INSERT INTO [dbo].[Group] ([GroupName], [GroupCode]) VALUES ( N'PINK', N'PI')
INSERT INTO [dbo].[Group] ([GroupName], [GroupCode]) VALUES ( N'RED', N'RE')
INSERT INTO [dbo].[Group] ([GroupName], [GroupCode]) VALUES ( N'White', N'WH')
INSERT INTO [dbo].[Group] ([GroupName], [GroupCode]) VALUES ( N'Two Colors', N'TT')
GO
SET IDENTITY_INSERT [dbo].[WareHouse] ON
INSERT INTO [dbo].[Warehouse] ([WarehouseID], [WarehouseName]) VALUES (1, N'BQT')
INSERT INTO [dbo].[Warehouse] ([WarehouseID], [WarehouseName]) VALUES (2, N'CARL')
INSERT INTO [dbo].[Warehouse] ([WarehouseID], [WarehouseName]) VALUES (3, N'ECLO')
INSERT INTO [dbo].[Warehouse] ([WarehouseID], [WarehouseName]) VALUES (4, N'ERIC')
INSERT INTO [dbo].[Warehouse] ([WarehouseID], [WarehouseName]) VALUES (5, N'MATS')
INSERT INTO [dbo].[Warehouse] ([WarehouseID], [WarehouseName]) VALUES (6, N'ORCHI')
INSERT INTO [dbo].[Warehouse] ([WarehouseID], [WarehouseName]) VALUES (7, N'SHINE')
INSERT INTO [dbo].[Warehouse] ([WarehouseID], [WarehouseName]) VALUES (8, N'KARE9')
INSERT INTO [dbo].[Warehouse] ([WarehouseID], [WarehouseName]) VALUES (9, N'TWIG3')
INSERT INTO [dbo].[Warehouse] ([WarehouseID], [WarehouseName]) VALUES (10, N'MISCMA')
INSERT INTO [dbo].[Warehouse] ([WarehouseID], [WarehouseName]) VALUES (11, N'SOUT9')
INSERT INTO [dbo].[Warehouse] ([WarehouseID], [WarehouseName]) VALUES (12, N'ROLL')
INSERT INTO [dbo].[Warehouse] ([WarehouseID], [WarehouseName]) VALUES (13, N'VIDAL')
INSERT INTO [dbo].[Warehouse] ([WarehouseID], [WarehouseName]) VALUES (14, N'MOSA')
INSERT INTO [dbo].[Warehouse] ([WarehouseID], [WarehouseName]) VALUES (15, N'JEAN8')
INSERT INTO [dbo].[Warehouse] ([WarehouseID], [WarehouseName]) VALUES (16, N'HFM')
INSERT INTO [dbo].[Warehouse] ([WarehouseID], [WarehouseName]) VALUES (17, N'VEGAS')
SET IDENTITY_INSERT [dbo].[WareHouse] OFF
GO
SET IDENTITY_INSERT [dbo].[Farm] ON
INSERT INTO [dbo].[Farm] ([FarmID], [FarmName], [Phone], [Email] ) VALUES (1, N'Qualisa', N'593484427', N'qualisa@qualisa.com')
INSERT INTO [dbo].[Farm] ([FarmID], [FarmName], [Phone], [Email]) VALUES (2, N'Ecuatorian', N'593556879', N'ecuatorian@ecuatorian.com')
INSERT INTO [dbo].[Farm] ([FarmID], [FarmName], [Phone], [Email]) VALUES (3, N'Welyflor', N'593556543', N'welyflor@welyflor.com')
INSERT INTO [dbo].[Farm] ([FarmID], [FarmName], [Phone], [Email]) VALUES (4, N'Inroses', N'593566543', N'inroses@inroses.com')
SET IDENTITY_INSERT [dbo].[Farm] OFF
GO
SET IDENTITY_INSERT [dbo].[Rose] ON
INSERT INTO [dbo].[Rose] ([RoseID], [RoseName], [GroupCode]) VALUES (1, N'Creme de la Creme', N'CR')
INSERT INTO [dbo].[Rose] ([RoseID], [RoseName], [GroupCode]) VALUES (2, N'Vendela', N'CR')
INSERT INTO [dbo].[Rose] ([RoseID], [RoseName], [GroupCode]) VALUES (3, N'Green Tea', N'GR')
INSERT INTO [dbo].[Rose] ([RoseID], [RoseName], [GroupCode]) VALUES (4, N'Full Mix Color', N'MIX')
INSERT INTO [dbo].[Rose] ([RoseID], [RoseName], [GroupCode]) VALUES (5, N'Cayenne', N'OR')
INSERT INTO [dbo].[Rose] ([RoseID], [RoseName], [GroupCode]) VALUES (6, N'Orange Crush', N'OR')
INSERT INTO [dbo].[Rose] ([RoseID], [RoseName], [GroupCode]) VALUES (7, N'Carrousel', N'PI')
INSERT INTO [dbo].[Rose] ([RoseID], [RoseName], [GroupCode]) VALUES (8, N'Freedom', N'RE')
INSERT INTO [dbo].[Rose] ([RoseID], [RoseName], [GroupCode]) VALUES (9, N'Cabaret', N'TT')
INSERT INTO [dbo].[Rose] ([RoseID], [RoseName], [GroupCode]) VALUES (10, N'Tibet', N'WH')
INSERT INTO [dbo].[Rose] ([RoseID], [RoseName], [GroupCode]) VALUES (11, N'Free Spirit', N'OR')
SET IDENTITY_INSERT [dbo].[Rose] OFF
GO
SET IDENTITY_INSERT [dbo].[Size] ON
INSERT INTO [dbo].[Size] ([SizeID], [SizeName], [Freight]) VALUES (1, N'40', N'0.16')
INSERT INTO [dbo].[Size] ([SizeID], [SizeName], [Freight]) VALUES (2, N'50', N'0.18')
INSERT INTO [dbo].[Size] ([SizeID], [SizeName], [Freight]) VALUES (3, N'40/50', N'0.17')
INSERT INTO [dbo].[Size] ([SizeID], [SizeName], [Freight]) VALUES (4, N'60', N'0.20')
INSERT INTO [dbo].[Size] ([SizeID], [SizeName], [Freight]) VALUES (5, N'50/60', N'0.19')
INSERT INTO [dbo].[Size] ([SizeID], [SizeName], [Freight]) VALUES (6, N'70', N'0.22')
INSERT INTO [dbo].[Size] ([SizeID], [SizeName], [Freight]) VALUES (7, N'80/90', N'0.21')
SET IDENTITY_INSERT [dbo].[Size] OFF
GO
SET IDENTITY_INSERT [dbo].[RoseSize] ON
INSERT INTO [dbo].[RoseSize] ([RoseSizeID], [RoseID], [SizeID]) VALUES (1, 1, 2)
INSERT INTO [dbo].[RoseSize] ([RoseSizeID], [RoseID], [SizeID]) VALUES (2, 2, 2)
INSERT INTO [dbo].[RoseSize] ([RoseSizeID], [RoseID], [SizeID]) VALUES (3, 3, 3)
INSERT INTO [dbo].[RoseSize] ([RoseSizeID], [RoseID], [SizeID]) VALUES (4, 4, 2)
INSERT INTO [dbo].[RoseSize] ([RoseSizeID], [RoseID], [SizeID]) VALUES (5, 5, 2)
INSERT INTO [dbo].[RoseSize] ([RoseSizeID], [RoseID], [SizeID]) VALUES (6, 7, 4)
INSERT INTO [dbo].[RoseSize] ([RoseSizeID], [RoseID], [SizeID]) VALUES (7, 8, 2)
INSERT INTO [dbo].[RoseSize] ([RoseSizeID], [RoseID], [SizeID]) VALUES (8, 9, 2)
INSERT INTO [dbo].[RoseSize] ([RoseSizeID], [RoseID], [SizeID]) VALUES (9, 10, 2)
INSERT INTO [dbo].[RoseSize] ([RoseSizeID], [RoseID], [SizeID]) VALUES (10, 11, 1)
SET IDENTITY_INSERT [dbo].[RoseSize] OFF
GO
INSERT INTO [dbo].[Invoice] ([InvoiceID], [Date], [TotalAmount], [FarmID]) VALUES (1233, N'1-02-2021', N'70', 1)
INSERT INTO [dbo].[Invoice] ([InvoiceID], [Date], [TotalAmount], [FarmID]) VALUES (1234, N'1-02-2021', N'80', 1)
INSERT INTO [dbo].[Invoice] ([InvoiceID], [Date], [TotalAmount], [FarmID]) VALUES (2244, N'2-02-2021', N'75', 2)
INSERT INTO [dbo].[Invoice] ([InvoiceID], [Date], [TotalAmount], [FarmID]) VALUES (3124, N'2-02-2021', N'35', 3)
INSERT INTO [dbo].[Invoice] ([InvoiceID], [Date], [TotalAmount], [FarmID]) VALUES (4124, N'2-02-2021', N'70', 4)
GO
SET IDENTITY_INSERT [dbo].[Order] ON
INSERT INTO [dbo].[Order] ([OrderID], [RoseSizeID], [Number_of_bunches]) VALUES (1, 1, N'52')
INSERT INTO [dbo].[Order] ([OrderID], [RoseSizeID], [Number_of_bunches]) VALUES (2, 2, N'22')
INSERT INTO [dbo].[Order] ([OrderID], [RoseSizeID], [Number_of_bunches]) VALUES (3, 3, N'7')
INSERT INTO [dbo].[Order] ([OrderID], [RoseSizeID], [Number_of_bunches]) VALUES (4, 4, N'15')
INSERT INTO [dbo].[Order] ([OrderID], [RoseSizeID], [Number_of_bunches]) VALUES (5, 5, N'176')
INSERT INTO [dbo].[Order] ([OrderID], [RoseSizeID], [Number_of_bunches]) VALUES (6, 7, N'9')
INSERT INTO [dbo].[Order] ([OrderID], [RoseSizeID], [Number_of_bunches]) VALUES (7, 8, N'139')
INSERT INTO [dbo].[Order] ([OrderID], [RoseSizeID], [Number_of_bunches]) VALUES (8, 9, N'14')
INSERT INTO [dbo].[Order] ([OrderID], [RoseSizeID], [Number_of_bunches]) VALUES (9, 10, N'6')
INSERT INTO [dbo].[Order] ([OrderID], [RoseSizeID], [Number_of_bunches]) VALUES (10, 6, N'12')
SET IDENTITY_INSERT [dbo].[Order] OFF
GO
SET IDENTITY_INSERT [dbo].[Inventory] ON
INSERT INTO [dbo].[Inventory] ([InventoryID], [FarmID], [RoseSizeID], [Price_per_stem]) VALUES (1, 1, 2, N'0.30')
INSERT INTO [dbo].[Inventory] ([InventoryID], [FarmID], [RoseSizeID], [Price_per_stem]) VALUES (2, 2, 4, N'0.40')
INSERT INTO [dbo].[Inventory] ([InventoryID], [FarmID], [RoseSizeID], [Price_per_stem]) VALUES (3, 3, 3, N'0.45')
INSERT INTO [dbo].[Inventory] ([InventoryID], [FarmID], [RoseSizeID], [Price_per_stem]) VALUES (4, 4, 4, N'0.30')
INSERT INTO [dbo].[Inventory] ([InventoryID], [FarmID], [RoseSizeID], [Price_per_stem]) VALUES (5, 1, 2, N'0.30')
INSERT INTO [dbo].[Inventory] ([InventoryID], [FarmID], [RoseSizeID], [Price_per_stem]) VALUES (6, 2, 7, N'0.30')
INSERT INTO [dbo].[Inventory] ([InventoryID], [FarmID], [RoseSizeID], [Price_per_stem]) VALUES (7, 2, 5, N'0.40')
SET IDENTITY_INSERT [dbo].[Inventory] OFF
GO
SET IDENTITY_INSERT [dbo].[Purchase] ON
INSERT INTO [dbo].[Purchase] ([PurchaseID], [FarmID], [RoseSizeID], [Price_per_stem],[InvoiceID], [WarehouseID]) VALUES (1, 2, 3, N'0.25', 1233, 1)
INSERT INTO [dbo].[Purchase] ([PurchaseID], [FarmID], [RoseSizeID], [Price_per_stem],[InvoiceID], [WarehouseID]) VALUES (2, 1, 4, N'0.28', 1234, 2)
INSERT INTO [dbo].[Purchase] ([PurchaseID], [FarmID], [RoseSizeID], [Price_per_stem],[InvoiceID], [WarehouseID]) VALUES (3, 2, 3, N'0.30', 3124, 3)
INSERT INTO [dbo].[Purchase] ([PurchaseID], [FarmID], [RoseSizeID], [Price_per_stem],[InvoiceID], [WarehouseID]) VALUES (4, 2, 6, N'0.29', 4124, 4)
SET IDENTITY_INSERT [dbo].[Purchase] OFF
GO

INSERT INTO [dbo].[BoxInventory] ([InventoryID], [BoxID], [Quantity]) VALUES (1, 2, N'2')
INSERT INTO [dbo].[BoxInventory] ([InventoryID], [BoxID], [Quantity]) VALUES (2, 3, N'10')
INSERT INTO [dbo].[BoxInventory] ([InventoryID], [BoxID], [Quantity]) VALUES (3, 1, N'4')
INSERT INTO [dbo].[BoxInventory] ([InventoryID], [BoxID], [Quantity]) VALUES (4, 3, N'5')
INSERT INTO [dbo].[BoxInventory] ([InventoryID], [BoxID], [Quantity]) VALUES (5, 3, N'9')
INSERT INTO [dbo].[BoxInventory] ([InventoryID], [BoxID], [Quantity]) VALUES (6, 1, N'3')
INSERT INTO [dbo].[BoxInventory] ([InventoryID], [BoxID], [Quantity]) VALUES (7, 2, N'2')
GO