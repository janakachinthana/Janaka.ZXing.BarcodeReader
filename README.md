# Janaka.ZXing.BarcodeReader

This Is widows Form App (.Net Framwork (C#))

To learn how create new empty project like this goto below link
https://docs.microsoft.com/en-us/visualstudio/ide/create-a-visual-basic-winform-in-visual-studio?view=vs-2019


You need to change the Connection String of the DB_Operations.cs file.
goto : Solution Explorer/Janaka.ZXing.BarcodeReader.App/DB/DB_Operations.cs

private string conStr = @"Data Source=PC_NAME; Initial Catalog=DBNAME;Integrated Security=True";

EX:-   private string conStr = @"Data Source=CL-LK-03; Initial Catalog=POS;Integrated Security=True";


DB query:-

(before Ececuting below queries You have to crate new atabase using POS as database name)

USE [POS]
GO


/****** Object:  Table [dbo].[tblLoyaltyCard]    Script Date: 2/25/2021 2:57:12 PM ******/
SET ANSI_NULLS ON
GO


SET QUOTED_IDENTIFIER ON
GO


CREATE TABLE [dbo].[tblLoyaltyCard](
	[phoneNo] [int] NOT NULL,
	[name] [nchar](50) NULL,
	[loyaltyCardNo] [nchar](50) NULL,
	[amount] [float] NULL,
	[status] [int] NULL,
	[lastModifyDate] [date] NULL,
	[addedUser] [nchar](50) NULL,
 CONSTRAINT [PK_tblLoyaltyCard] PRIMARY KEY CLUSTERED 
(
	[phoneNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


