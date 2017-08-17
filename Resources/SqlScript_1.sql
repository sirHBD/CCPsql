USE [CCP]
GO

/****** Object:  View [dbo].[lstReceiptDeposit]    Script Date: 23/03/2017 9:50:01 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[lstReceiptDeposit]
AS
SELECT        FK_tblQuotHeader, fk_tblInvoiceHeader, txtReceiptType, MAX(dteReceiptDate) AS ReceiptDate, SUM(dblAmount) AS ReceiptAmount
FROM            dbo.tblReceipts
WHERE        (txtReceiptType = N'Deposit')
GROUP BY FK_tblQuotHeader, fk_tblInvoiceHeader, txtReceiptType

GO

USE [CCP]
GO

/****** Object:  View [dbo].[lstReceiptDeposit]    Script Date: 23/03/2017 9:52:17 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[lstReceiptSettlement]
AS
SELECT        FK_tblQuotHeader, fk_tblInvoiceHeader, txtReceiptType, MAX(dteReceiptDate) AS ReceiptDate, SUM(dblAmount) AS ReceiptAmount
FROM            dbo.tblReceipts
WHERE        (txtReceiptType = N'Settlement')
GROUP BY FK_tblQuotHeader, fk_tblInvoiceHeader, txtReceiptType

GO

Use CCP
Go
ALTER TABLE tblJC
ADD dDateCreate dateTime
go

USE [CCP]
GO

/****** Object:  View [dbo].[lstJCByDateCreated]    Script Date: 23/03/2017 10:20:06 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[lstJCByDateCreated]
AS
SELECT        FK_tblPOHeader, dblJCno, MAX(dDateCreate) AS DateCreated
FROM            dbo.tblJC
GROUP BY FK_tblPOHeader, dblJCno

GO

USE [CCP]
GO

/****** Object:  View [dbo].[lstInvoicePerDate]    Script Date: 23/03/2017 10:29:12 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[lstInvoicePerDate]
AS
SELECT        dbo.tblInvoiceHeader.id_tblInvoiceHeader, dbo.tblInvoiceHeader.dblInvoiceNum, SUM(dbo.tbllnvoiceDetail.decInvoiceLineAmount) AS InvoiceAmt, dbo.tblInvoiceHeader.txtInvoiceDate, 
                         dbo.tblInvoiceHeader.FK_tblQuoteHeader
FROM            dbo.tblInvoiceHeader INNER JOIN
                         dbo.tbllnvoiceDetail ON dbo.tblInvoiceHeader.id_tblInvoiceHeader = dbo.tbllnvoiceDetail.fk_tblnvoiceHeader
GROUP BY dbo.tblInvoiceHeader.id_tblInvoiceHeader, dbo.tblInvoiceHeader.dblInvoiceNum, dbo.tblInvoiceHeader.txtInvoiceDate, dbo.tblInvoiceHeader.txtInvoiceDate, dbo.tblInvoiceHeader.FK_tblQuoteHeader

GO

USE [CCP]
GO

/****** Object:  View [dbo].[lstJCMonitor]    Script Date: 23/03/2017 10:41:18 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[lstJCMonitor]
AS
SELECT        dbo.tblQuoteHeader.dblQuoteNum, dbo.tblQuoteHeader.txtCompanyNo, dbo.tblQuoteHeader.txtCusDesc, dbo.tblQuoteHeader.txtQuoteDate, dbo.tblPOHeader.dblPONum, dbo.tblPOHeader.txtPODate, 
                         dbo.tblPOHeader.DateFrom, dbo.tblPOHeader.DateTo, dbo.tblPOHeader.DateETD, dbo.lstReceiptDeposit.ReceiptDate, dbo.lstReceiptDeposit.txtReceiptType, dbo.lstReceiptDeposit.ReceiptAmount, 
                         dbo.lstJCByDateCreated.dblJCno, dbo.lstJCByDateCreated.DateCreated, dbo.lstInvoicePerDate.dblInvoiceNum, dbo.lstInvoicePerDate.txtInvoiceDate, dbo.lstInvoicePerDate.InvoiceAmt, 
                         dbo.lstReceiptSettlement.ReceiptDate AS SettlementDate, dbo.lstReceiptSettlement.txtReceiptType AS Settlement, dbo.lstReceiptSettlement.ReceiptAmount AS SettlementAmount
FROM            dbo.lstReceiptSettlement RIGHT OUTER JOIN
                         dbo.tblQuoteHeader ON dbo.lstReceiptSettlement.FK_tblQuotHeader = dbo.tblQuoteHeader.id_tblQuoteHeader LEFT OUTER JOIN
                         dbo.lstInvoicePerDate ON dbo.tblQuoteHeader.id_tblQuoteHeader = dbo.lstInvoicePerDate.FK_tblQuoteHeader LEFT OUTER JOIN
                         dbo.lstReceiptDeposit ON dbo.tblQuoteHeader.id_tblQuoteHeader = dbo.lstReceiptDeposit.FK_tblQuotHeader LEFT OUTER JOIN
                         dbo.tblPOHeader LEFT OUTER JOIN
                         dbo.lstJCByDateCreated ON dbo.tblPOHeader.id_tblPOHeader = dbo.lstJCByDateCreated.FK_tblPOHeader ON dbo.tblQuoteHeader.id_tblQuoteHeader = dbo.tblPOHeader.FK_tblQuoteHeader

GO


