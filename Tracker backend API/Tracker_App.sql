CREATE DATABASE Tracker_App2;
GO

USE Tracker_App2;
GO

CREATE TABLE [dbo].[Login] (
    [LoginId]  INT          IDENTITY (1, 1) NOT NULL,
    [Username] VARCHAR (50) NULL,
    [Email]    VARCHAR (50) NULL,
    [Password] VARCHAR (50) NULL
);
GO

SET IDENTITY_INSERT [dbo].[Login] ON
INSERT INTO [dbo].[Login] ([LoginId], [Username], [Email], [Password]) VALUES (1, N'ogualu', N'ikenna.ogualu@here.com', N'Ikenna102')
INSERT INTO [dbo].[Login] ([LoginId], [Username], [Email], [Password]) VALUES (2, N'yadav', N'suraj.yadav@here.comL', N'Yadav102')
SET IDENTITY_INSERT [dbo].[Login] OFF

CREATE TABLE [dbo].[Sim_Info] (
    [Sim_InfoId]       INT          IDENTITY (1, 1) NOT NULL,
    [Sim_Ap]           VARCHAR (50) NULL,
    [Iccid_Sim_number] BIGINT       NULL,
    [Sim_Pin]          INT          NULL
);
GO

SET IDENTITY_INSERT [dbo].[Sim_Info] ON
INSERT INTO [dbo].[Sim_Info] ([Sim_InfoId], [Sim_Ap], [Iccid_Sim_number], [Sim_Pin]) VALUES (1, N'kal', 123, 231)
INSERT INTO [dbo].[Sim_Info] ([Sim_InfoId], [Sim_Ap], [Iccid_Sim_number], [Sim_Pin]) VALUES (2, N'SIM V', 212, 930)
INSERT INTO [dbo].[Sim_Info] ([Sim_InfoId], [Sim_Ap], [Iccid_Sim_number], [Sim_Pin]) VALUES (3, N'kal', 12326547, 22365478)
INSERT INTO [dbo].[Sim_Info] ([Sim_InfoId], [Sim_Ap], [Iccid_Sim_number], [Sim_Pin]) VALUES (4, N'kal-2', 123456789, 122365478)
INSERT INTO [dbo].[Sim_Info] ([Sim_InfoId], [Sim_Ap], [Iccid_Sim_number], [Sim_Pin]) VALUES (22, N'kal', 123, 231)
INSERT INTO [dbo].[Sim_Info] ([Sim_InfoId], [Sim_Ap], [Iccid_Sim_number], [Sim_Pin]) VALUES (23, N'SIM V', 212, 930)
INSERT INTO [dbo].[Sim_Info] ([Sim_InfoId], [Sim_Ap], [Iccid_Sim_number], [Sim_Pin]) VALUES (24, N'kal', 12326547, 22365478)
INSERT INTO [dbo].[Sim_Info] ([Sim_InfoId], [Sim_Ap], [Iccid_Sim_number], [Sim_Pin]) VALUES (25, N'kal-2', 123456789, 122365478)
INSERT INTO [dbo].[Sim_Info] ([Sim_InfoId], [Sim_Ap], [Iccid_Sim_number], [Sim_Pin]) VALUES (26, N'kal-2A', 1234567890, 1223654780)
INSERT INTO [dbo].[Sim_Info] ([Sim_InfoId], [Sim_Ap], [Iccid_Sim_number], [Sim_Pin]) VALUES (27, N'kal-2B', 12345678, 12236547)
INSERT INTO [dbo].[Sim_Info] ([Sim_InfoId], [Sim_Ap], [Iccid_Sim_number], [Sim_Pin]) VALUES (28, N'kal-2B', 1234567890, 12236547)
INSERT INTO [dbo].[Sim_Info] ([Sim_InfoId], [Sim_Ap], [Iccid_Sim_number], [Sim_Pin]) VALUES (29, N'kal-2C', 123456789, 12236547)
INSERT INTO [dbo].[Sim_Info] ([Sim_InfoId], [Sim_Ap], [Iccid_Sim_number], [Sim_Pin]) VALUES (30, N'kal-2D', 1234567890, 12236547)
INSERT INTO [dbo].[Sim_Info] ([Sim_InfoId], [Sim_Ap], [Iccid_Sim_number], [Sim_Pin]) VALUES (31, N'kal-2D', 12345678901, 12236547)
INSERT INTO [dbo].[Sim_Info] ([Sim_InfoId], [Sim_Ap], [Iccid_Sim_number], [Sim_Pin]) VALUES (32, N'kal-2DB', 12345678901236, 12236547)
INSERT INTO [dbo].[Sim_Info] ([Sim_InfoId], [Sim_Ap], [Iccid_Sim_number], [Sim_Pin]) VALUES (33, N'kal-2DB', 1234567890123456789, 12236547)
INSERT INTO [dbo].[Sim_Info] ([Sim_InfoId], [Sim_Ap], [Iccid_Sim_number], [Sim_Pin]) VALUES (34, N'kal-2DB3', 1234567890123456789, 12236547)
INSERT INTO [dbo].[Sim_Info] ([Sim_InfoId], [Sim_Ap], [Iccid_Sim_number], [Sim_Pin]) VALUES (35, N'kal-2DB31234567895879', 12345678901234567, 12236547)
INSERT INTO [dbo].[Sim_Info] ([Sim_InfoId], [Sim_Ap], [Iccid_Sim_number], [Sim_Pin]) VALUES (36, N'kal-2DB1234567890123456789', 12345678901234567, 12236547)
INSERT INTO [dbo].[Sim_Info] ([Sim_InfoId], [Sim_Ap], [Iccid_Sim_number], [Sim_Pin]) VALUES (37, N'kal-2DB12345678901234567890123456789', 12345678901234567, 12236547)
INSERT INTO [dbo].[Sim_Info] ([Sim_InfoId], [Sim_Ap], [Iccid_Sim_number], [Sim_Pin]) VALUES (38, N'20vanwQ3eKBL5ZhYQTtCzX76z2wP1DiXPPNgFmTmPf0', 12345678901234567, 12236547)
INSERT INTO [dbo].[Sim_Info] ([Sim_InfoId], [Sim_Ap], [Iccid_Sim_number], [Sim_Pin]) VALUES (39, N'24bb3509-4796-4f13-9cd6-9fe46c71e3d5', 12345678901234567, 12236547)
INSERT INTO [dbo].[Sim_Info] ([Sim_InfoId], [Sim_Ap], [Iccid_Sim_number], [Sim_Pin]) VALUES (40, N'24bb3509-4796-4f13-9cd6-9fe46c71e3123', 12345678901234567, 12236547)
INSERT INTO [dbo].[Sim_Info] ([Sim_InfoId], [Sim_Ap], [Iccid_Sim_number], [Sim_Pin]) VALUES (41, N'24bb3509-4796-4f13-9cd6-9fe46c71e31234', 123456789012345678, 12236547)
INSERT INTO [dbo].[Sim_Info] ([Sim_InfoId], [Sim_Ap], [Iccid_Sim_number], [Sim_Pin]) VALUES (42, N'24bb3509', 8988303000005240926, 12236547)
SET IDENTITY_INSERT [dbo].[Sim_Info] OFF

CREATE TABLE [dbo].[TrackerOrderHistory] (
    [TrackerOrderHistoryId] INT          IDENTITY (1, 1) NOT NULL,
    [Device_Name]           VARCHAR (50) NULL,
    [Device_Imei]           INT          NULL,
    [Device_QR]             VARCHAR (50) NULL,
    [Iccid_Sim_Number]      INT          NULL
);
GO

SET IDENTITY_INSERT [dbo].[TrackerOrderHistory] ON
INSERT INTO [dbo].[TrackerOrderHistory] ([TrackerOrderHistoryId], [Device_Name], [Device_Imei], [Device_QR], [Iccid_Sim_Number]) VALUES (1, N'TREW', 3, N'BOY', 898)
INSERT INTO [dbo].[TrackerOrderHistory] ([TrackerOrderHistoryId], [Device_Name], [Device_Imei], [Device_QR], [Iccid_Sim_Number]) VALUES (3, N'TAGG', 36, N'BOY', 63)
INSERT INTO [dbo].[TrackerOrderHistory] ([TrackerOrderHistoryId], [Device_Name], [Device_Imei], [Device_QR], [Iccid_Sim_Number]) VALUES (4, N'SIM V', 212, N'SIM V', 930)
INSERT INTO [dbo].[TrackerOrderHistory] ([TrackerOrderHistoryId], [Device_Name], [Device_Imei], [Device_QR], [Iccid_Sim_Number]) VALUES (6, N'voda2', 369, NULL, 79654)
INSERT INTO [dbo].[TrackerOrderHistory] ([TrackerOrderHistoryId], [Device_Name], [Device_Imei], [Device_QR], [Iccid_Sim_Number]) VALUES (7, N'voda2', 369, NULL, 79654)
SET IDENTITY_INSERT [dbo].[TrackerOrderHistory] OFF

CREATE TABLE [dbo].[TrackingDevice_Info] (
    [TrackingDevice_InfoId] INT          IDENTITY (1, 1) NOT NULL,
    [Device_Name]           VARCHAR (50) NULL,
    [Here_Sku]              VARCHAR (50) NULL,
    [Device_Model]          VARCHAR (50) NULL,
    [Device_Imei]           INT          NULL,
    [Device_Id]             VARCHAR (50) NULL,
    [Device_2nd]            VARCHAR (50) NULL,
    [Iccid_Sim_Number]      INT          NULL
);
GO

SET IDENTITY_INSERT [dbo].[TrackingDevice_Info] ON
INSERT INTO [dbo].[TrackingDevice_Info] ([TrackingDevice_InfoId], [Device_Name], [Here_Sku], [Device_Model], [Device_Imei], [Device_Id], [Device_2nd], [Iccid_Sim_Number]) VALUES (1, N'voda', N'1236sm', N'Smart', 369, N'class', N'K5', 79654)
INSERT INTO [dbo].[TrackingDevice_Info] ([TrackingDevice_InfoId], [Device_Name], [Here_Sku], [Device_Model], [Device_Imei], [Device_Id], [Device_2nd], [Iccid_Sim_Number]) VALUES (2, N'voda2', N'1236sm', N'Smart', 369, N'class2', N'K5', 79654)
SET IDENTITY_INSERT [dbo].[TrackingDevice_Info] OFF


