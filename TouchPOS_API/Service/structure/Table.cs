using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TouchPOS_API.Class;
using TouchPOS_API.Models;
namespace TouchPOS_API.Service.structure
{
    public class Table
    {
        public ResponseMessage Table_Create(List<SysConfigModels> data_config)
        {
            var ret = new ResponseMessage();
            try
            {
                Getschemas Gs = new Getschemas();
                List<SchemasModel> idx = new List<SchemasModel>();


                DataContext exec = new DataContext();
                string sql = "";
                var dt = new DataTable() ;
                // sale
                sql = " USE [" + exec.DB_backup_name + "] ";
                sql += " select name from sys.tables where name = 'SALE' ";
                dt = exec.ReadData_Table(sql);
                if (dt.Rows.Count <= 0)
                {

                    sql = " USE [" + exec.DB_backup_name + "] ";
                    sql += "SET ANSI_NULLS ON " +
                    " SET QUOTED_IDENTIFIER ON" +
                    " CREATE TABLE[dbo].[SALE](" +
                    "   [SID][int] IDENTITY(1, 1) NOT NULL," +
                    "   [MRTSLIPNO] [varchar](30) NOT NULL," +
                    "   [SHOPID] [int] NOT NULL," +
                    "   [POSID] [varchar](15) NOT NULL," +
                    "   [DOCDATE] [datetime] NOT NULL," +
                    "   [DOCYEAR] [int] NOT NULL," +
                    "   [DOCMONT] [int] NOT NULL," +
                    "   [BACKUPFLG] [bit] NULL," +
                    "	[VOIDNO] [varchar](20) NULL," +
                    "	[SHOPENDFLG] [bit] NULL," +
                    "	[TAXINVOICE] [nvarchar](60) NULL," +
                    "	[CREDITNOTES] [nvarchar](20) NULL," +
                    "	[CARDTENDOR] [nvarchar](50) NULL," +
                    "	[CARDREF] [nvarchar](60) NULL," +
                    "	[CARDPURSE] [decimal](18, 0) NULL," +
                    "	[taxPrint] [nvarchar](1) NULL," +
                    "	[CUS_ID] [varchar](20) NULL," +
                    "	[PAYTYPE] [varchar](10) NULL," +
                    "	[PAYAMOUNT] [decimal](18, 4) NULL," +
                    "	[AMOUNT] [decimal](18, 4) NULL," +
                    "	[DISTP] [varchar](10) NULL," +
                    "	[DISVALUE] [decimal](18, 4) NULL," +
                    "	[AFTERDIS] [decimal](18, 4) NULL," +
                    "	[VATTP] [varchar](10) NULL," +
                    "	[VATVALUE] [decimal](18, 4) NULL," +
                    "	[AFTERVAT] [decimal](18, 4) NULL," +
                    "	[NETAMOUNT] [decimal](18, 4) NULL," +
                    "	[QTY_TOTAL] [int] NULL," +
                    "	[STATUS] [varchar](1) NULL," +
                    "	[CRDATE] [datetime] NULL," +
                    "	[CBY] [nvarchar](20) NULL," +
                    "	[MODATE] [datetime] NULL," +
                    "	[MBY] [nvarchar](20) NULL," +
                    "	[MO] [bit] NULL," +
                    "	[DC_STATE] [varchar](10) NULL," +
                    " CONSTRAINT[PK_CARDTRANS_H] PRIMARY KEY CLUSTERED" +
                    " (" +
                    "   [MRTSLIPNO] ASC," +
                    "	[SHOPID] ASC" +
                    " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]" +
                    " ) ON[PRIMARY]" +
                    " SET ANSI_NULLS ON" +
                    " SET QUOTED_IDENTIFIER ON" +
                    " CREATE TABLE[dbo].[SALE_CARD](" +
                    "   [SCID][int] IDENTITY(1, 1) NOT NULL," +
                    "   [MRTSLIPNO] [varchar](30) NOT NULL," +
                    "   [SHOPID] [varchar](4) NOT NULL," +
                    "   [POSID] [varchar](20) NOT NULL," +
                    "   [SEQ] [int] NOT NULL," +
                    "   [BARCODE] [varchar](20) NOT NULL," +
                    "   [PAYTYPE] [varchar](15) NULL," +
                    "	[CUSED] [int] NOT NULL," +
                    "   [CUSED1] [int] NULL," +
                    "	[MRTAMOUNT] [decimal](18, 4) NULL," +
                    "	[CBALANCE] [decimal](18, 4) NULL," +
                    "	[CBALANCEREMAIN] [decimal](18, 4) NULL," +
                    "	[GP] [decimal](18, 4) NULL," +
                    "	[GPAMOUNT] [decimal](18, 4) NULL," +
                    "	[PRO_ID] [int] NULL," +
                    "	[PRO_NAME] [nvarchar](100) NULL," +
                    "	[PRO_TEXT] [nvarchar](500) NULL," +
                    "	[STATUS] [bit] NULL," +
                    "	[CDATE] [datetime] NULL," +
                    "	[MODATE] [datetime] NULL," +
                    "	[MO] [bit] NULL," +
                    " CONSTRAINT[PK_SALE_CARD] PRIMARY KEY CLUSTERED" +
                    " (" +
                    "   [MRTSLIPNO] ASC," +
                    "	[SHOPID] ASC," +
                    "	[SEQ] ASC" +
                    " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]" +
                    " ) ON[PRIMARY]" +
                    " SET ANSI_NULLS ON" +
                    " SET QUOTED_IDENTIFIER ON" +
                    " CREATE TABLE[dbo].[SALE_ITEMS](" +
                    "   [STID][int] IDENTITY(1, 1) NOT NULL," +
                    "   [MRTSLIPNO] [varchar](30) NOT NULL," +
                    "   [SHOPID] [int] NOT NULL," +
                    "   [POSID] [varchar](15) NULL," +
                    "	[SEQ] [int] NOT NULL," +
                    "    [VOIDNO] [varchar](20) NULL," +
                    "	[FOODID] [int] NULL," +
                    "	[FOODNAME] [varchar](50) NULL," +
                    "	[GP] [real] NULL," +
                    "	[GPAMOUNT] [real] NULL," +
                    "	[ITEMS_PRICE] [decimal](18, 2) NULL," +
                    "	[DISTP] [varchar](10) NULL," +
                    "	[DISVALUE] [decimal](18, 4) NULL," +
                    "	[AFTERDIS] [decimal](18, 4) NULL," +
                    "	[VATTP] [varchar](10) NULL," +
                    "	[VATVALUE] [decimal](18, 4) NULL," +
                    "	[AFTERVAT] [decimal](18, 4) NULL," +
                    "	[NETAMOUNT] [decimal](18, 4) NULL," +
                    "	[STATUS] [varchar](1) NULL," +
                    "	[QTY] [int] NULL," +
                    "	[CHKFLG] [bit] NULL," +
                    "	[PRO_ID] [int] NULL," +
                    "	[PRO_NAME] [nvarchar](100) NULL," +
                    "	[PRO_TEXT] [nvarchar](500) NULL," +
                    "	[CDATE] [datetime] NULL," +
                    "	[MODATE] [datetime] NULL," +
                    "	[MO] [bit] NULL," +
                    "	[GPRULE] [nvarchar](10) NULL," +
                    " CONSTRAINT[PK_SALE_ITEMS] PRIMARY KEY CLUSTERED" +
                    " (" +
                    "   [SHOPID] ASC," +
                    "	[MRTSLIPNO] ASC," +
                    "	[SEQ] ASC" +
                    " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]" +
                    " ) ON[PRIMARY]" +
                    " ALTER TABLE[dbo].[SALE] ADD CONSTRAINT[DF_CARDTRANS_H_BACKUPFLG]  DEFAULT((0)) FOR[BACKUPFLG]" +
                    " ALTER TABLE[dbo].[SALE] ADD CONSTRAINT[DF_CARDTRANS_H_SHOPENDFLG]  DEFAULT((0)) FOR[SHOPENDFLG]" +
                    " ALTER TABLE[dbo].[SALE] ADD CONSTRAINT[DF_CARDTRANS_H_TAXINVOICE]  DEFAULT('') FOR[TAXINVOICE]" +
                    " ALTER TABLE[dbo].[SALE] ADD CONSTRAINT[DF_CARDTRANS_H_CREDITNOTES]  DEFAULT('') FOR[CREDITNOTES]" +
                    " ALTER TABLE[dbo].[SALE] ADD CONSTRAINT[DF__CARDTRANS__CARDT__0F824689]  DEFAULT('') FOR[CARDTENDOR]" +
                    " ALTER TABLE[dbo].[SALE] ADD CONSTRAINT[DF__CARDTRANS__CARDR__10766AC2]  DEFAULT('') FOR[CARDREF]" +
                    " ALTER TABLE[dbo].[SALE] ADD CONSTRAINT[DF__CARDTRANS__CARDP__116A8EFB]  DEFAULT((0)) FOR[CARDPURSE]" +
                    " ALTER TABLE[dbo].[SALE] ADD CONSTRAINT[DF__CARDTRANS__taxPr__125EB334]  DEFAULT('0') FOR[taxPrint]" +
                    " ALTER TABLE[dbo].[SALE] ADD CONSTRAINT[DF_CARDTRANS_H_MRTAMOUNT]  DEFAULT((0)) FOR[AMOUNT]" +
                    " ALTER TABLE[dbo].[SALE] ADD CONSTRAINT[DF_CARDTRANS_H_AMOUNT1]  DEFAULT((0)) FOR[DISVALUE]" +
                    " ALTER TABLE[dbo].[SALE] ADD CONSTRAINT[DF_CARDTRANS_H_DISVALUE1]  DEFAULT((0)) FOR[AFTERDIS]" +
                    " ALTER TABLE[dbo].[SALE] ADD CONSTRAINT[DF_CARDTRANS_H_DISAFTER1]  DEFAULT((0)) FOR[AFTERVAT]" +
                    " ALTER TABLE[dbo].[SALE] ADD CONSTRAINT[DF_CARDTRANS_H_AMOUNT1_1]  DEFAULT((0)) FOR[NETAMOUNT]" +
                    " ALTER TABLE[dbo].[SALE] ADD CONSTRAINT[DF_CARDTRANS_H_MRTAMOUNT1]  DEFAULT((0)) FOR[QTY_TOTAL]" +
                    " ALTER TABLE[dbo].[SALE] ADD CONSTRAINT[DF_CARDTRANS_H_MRTLUPDATE]  DEFAULT(getdate()) FOR[CRDATE]" +
                    " ALTER TABLE[dbo].[SALE] ADD CONSTRAINT[DF_CARDTRANS_H_LUPDATE]  DEFAULT(getdate()) FOR[MODATE]" +
                    " ALTER TABLE[dbo].[SALE] ADD CONSTRAINT[DF_SALE_MO]  DEFAULT((0)) FOR[MO]" +
                    " ALTER TABLE[dbo].[SALE_CARD] ADD CONSTRAINT[DF_CARDTRANS_CARDUSE_GP]  DEFAULT('0') FOR[GP]" +
                    " ALTER TABLE[dbo].[SALE_CARD] ADD CONSTRAINT[DF_CARDTRANS_CARDUSE_GPAMOUNT]  DEFAULT('0') FOR[GPAMOUNT]" +
                    " ALTER TABLE[dbo].[SALE_CARD] ADD CONSTRAINT[DF_SALE_CARD_MODATE1]  DEFAULT(getdate()) FOR[CDATE]" +
                    " ALTER TABLE[dbo].[SALE_CARD] ADD CONSTRAINT[DF_SALE_CARD_MODATE]  DEFAULT(getdate()) FOR[MODATE]" +
                    " ALTER TABLE[dbo].[SALE_CARD] ADD CONSTRAINT[DF_SALE_CARD_MO]  DEFAULT((0)) FOR[MO]" +
                    " ALTER TABLE[dbo].[SALE_ITEMS] ADD CONSTRAINT[DF__SALE_ITEMS__GP__4AB81AF0]  DEFAULT('0') FOR[GP]" +
                    " ALTER TABLE[dbo].[SALE_ITEMS] ADD CONSTRAINT[DF__SALE_ITEMS__GPAMO__4BAC3F29]  DEFAULT('0') FOR[GPAMOUNT]" +
                    " ALTER TABLE[dbo].[SALE_ITEMS] ADD CONSTRAINT[DF_SALE_ITEMS_DISVALUE]  DEFAULT((0)) FOR[DISVALUE]" +
                    " ALTER TABLE[dbo].[SALE_ITEMS] ADD CONSTRAINT[DF_SALE_ITEMS_AFTERDIS]  DEFAULT((0)) FOR[AFTERDIS]" +
                    " ALTER TABLE[dbo].[SALE_ITEMS] ADD CONSTRAINT[DF_SALE_ITEMS_AFTERVAT]  DEFAULT((0)) FOR[AFTERVAT]" +
                    " ALTER TABLE[dbo].[SALE_ITEMS] ADD CONSTRAINT[DF_SALE_ITEMS_NETAMOUNT]  DEFAULT((0)) FOR[NETAMOUNT]" +
                    " ALTER TABLE[dbo].[SALE_ITEMS] ADD CONSTRAINT[DF_SALE_ITEMS_MODATE1]  DEFAULT(getdate()) FOR[CDATE]" +
                    " ALTER TABLE[dbo].[SALE_ITEMS] ADD CONSTRAINT[DF_SALE_ITEMS_MODATE]  DEFAULT(getdate()) FOR[MODATE]" +
                    " ALTER TABLE[dbo].[SALE_ITEMS] ADD CONSTRAINT[DF_SALE_ITEMS_MO]  DEFAULT((0)) FOR[MO]";
                    exec.Excute2(sql);
                }


                //CARDTRANS dolfin  630128-----------------------------------------------------------


                sql = " USE [" + exec.DB_backup_name + "] ";
                sql += " if not exists(select name from sys.tables where name = 'TENDER_LOG')";
                sql += " begin";
                sql += " CREATE TABLE[dbo].[TENDER_LOG](";
                sql += "     [TID][int] IDENTITY(1, 1) NOT NULL,";
                sql += "     [TENDERCODE] [nvarchar] (20) NOT NULL,";
                sql += "      [DOCNO] [nvarchar] (50) NULL,";
                sql += "     [TENDERDOCNO] [nvarchar] (50) NULL,";
                sql += "     [TERMINALID] [nvarchar] (50) NULL,";
                sql += "     [POSID] [nvarchar] (50) NULL,";
                sql += "     [MERCHAND_ID] [nvarchar] (50) NULL,";
                sql += "     [LOG_TYPE] [nvarchar] (20) NULL,";
                sql += "     [DATA_TYPE] [nvarchar] (20) NULL,";
                sql += "     [DATA1][nvarchar](max) NULL,";
                sql += "     [DATA2] [nvarchar](max) NULL,";
                sql += "     [REMARK1] [nvarchar] (100) NULL,";
                sql += "     [REMARK2] [nvarchar] (100) NULL,";
                sql += "     [REMARK3] [nvarchar] (100) NULL,";
                sql += "     [STATUS] [varchar] (10) NULL,";
                sql += "     [CBY] [nvarchar] (20) NULL,";
                sql += "     [CDATE] [datetime] NULL,";
                sql += "     [MBY] [nvarchar] (20) NULL,";
                sql += "     [MODATE] [datetime] NULL,";
                sql += "  CONSTRAINT[PK_TENDER_LOG] PRIMARY KEY CLUSTERED";
                sql += " (";
                sql += "    [TID] ASC";
                sql += " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]";
                sql += " ) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]";
                sql += " end  ";
                exec.Excute2(sql);



                sql = " USE [" + exec.DB_backup_name + "] ";
                sql += " select name from sys.tables where name = 'SysVersion' ";
                dt = exec.ReadData_Table(sql);
                if (dt.Rows.Count <= 0)
                {
                    sql = " USE [" + exec.DB_backup_name + "] ";
                    sql += "SET ANSI_NULLS ON " +
" SET QUOTED_IDENTIFIER ON " +
" CREATE TABLE[dbo].[SysVersion]( " +
"     [sysNo][varchar](255) NULL, " +
" 	[sysName] [varchar](255) NULL, " +
" 	[path] [varchar](255) NULL " +
" ) ON[PRIMARY] ";
                    exec.Excute2(sql);
                }

                ///Tender   630305
                sql = " USE [" + exec.DB_backup_name + "] ";
                sql += "\n";
                sql += " if  exists(select name from sys.tables where name = 'TENDER')  Begin ";
                sql += " if not exists(select name from sys.tables where name = 'TENDER_ITEMS')";
                sql += " begin";
                sql += " DROP TABLE [dbo].[TENDER]";
                sql += " end  ";
                sql += " end  ";

                exec.Excute2(sql);


                sql = " USE [" + exec.DB_backup_name + "] ";
                sql += "\n";
                sql += " if not exists(select name from sys.tables where name = 'TENDER') ";
                sql += " Begin ";
                sql += " SET ANSI_NULLS ON ";
                sql += " SET QUOTED_IDENTIFIER ON ";
                sql += " CREATE TABLE[dbo].[TENDER]( ";
                sql += " [TID][int] NOT NULL, ";
                sql += " [CODE] [nvarchar] (20) NOT NULL, ";
                sql += " [NAME] [nvarchar] (200) NULL, ";
                sql += " [VENDERCODE] [nvarchar] (50) NULL, ";
                sql += " [VENDERNAME] [nvarchar] (200) NULL, ";
                sql += " [TYPE] [nvarchar] (10) NULL, ";
                sql += " [CERRENCY] [nvarchar] (10) NULL, ";
                sql += " [PAYMENT_METHOD] [nvarchar] (20) NULL, ";
                sql += " [VALUE_CONVERT] [decimal](18, 2) NULL, ";
                sql += " [Server] [nvarchar] (100) NULL, ";
                sql += " [SCAN_TYPE] [nvarchar] (50) NULL, ";
                sql += " [PREFIX_BARCODE] [nvarchar] (10) NULL, ";
                sql += " [REMARK1] [nvarchar] (100) NULL, ";
                sql += " [REMARK2] [nvarchar] (100) NULL, ";
                sql += " [REMARK3] [nvarchar] (100) NULL, ";
                sql += " [STATUS] [varchar] (1) NULL, ";
                sql += " [CBY] [nvarchar] (20) NULL, ";
                sql += " [CRDATE] [datetime] NULL, ";
                sql += " [MBY] [nvarchar] (20) NULL, ";
                sql += " [MODATE] [datetime] NULL, ";
                sql += " [MO] [bit] NULL, ";
                sql += " CONSTRAINT[PK_TENDER] PRIMARY KEY CLUSTERED ";
                sql += " ( ";
                sql += " [CODE] ASC ";
                sql += " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] ";
                sql += " ) ON[PRIMARY] ";


                sql += " \n INSERT[dbo].[TENDER]([TID], [CODE], [NAME], [VENDERCODE], [VENDERNAME], [TYPE], [CERRENCY], [PAYMENT_METHOD], [VALUE_CONVERT], [Server], [SCAN_TYPE], [PREFIX_BARCODE], [REMARK1], [REMARK2], [REMARK3], [STATUS], [CBY], [CRDATE], [MBY], [MODATE], [MO]) VALUES(4, N'ALIPAY', N'ALIPAY', N'KBANK', N'KBANK', N'EWALLET', N'THB', N'BALANCE', CAST(1.00 AS Decimal(18, 2)), N'', N'B&C', N'A', N'MERCHAND_ID_MULTI', N'', N'', N'1', N'pgm', CAST(N'2020-01-22T14:19:05.150' AS DateTime), N'pgm', CAST(N'2020-01-22T14:19:05.150' AS DateTime), 0) ";
                sql += " \n  INSERT[dbo].[TENDER] ([TID], [CODE], [NAME], [VENDERCODE], [VENDERNAME], [TYPE], [CERRENCY], [PAYMENT_METHOD], [VALUE_CONVERT], [Server], [SCAN_TYPE], [PREFIX_BARCODE], [REMARK1], [REMARK2], [REMARK3], [STATUS], [CBY], [CRDATE], [MBY], [MODATE], [MO]) VALUES(3, N'DOLFIN', N'DOLFIN', N'CJD', N'Central JD Fintech Co., Ltd.', N'EWALLET', N'THB', N'BALANCE', CAST(1.00 AS Decimal(18, 2)), N'https://api.sahatarasst.com:8030/', N'B&C', N'D', N'MERCHAND_ID_MULTI', N'', N'', N'0', N'pgm', CAST(N'2020-01-22T14:15:57.257' AS DateTime), N'pgm', CAST(N'2020-01-22T14:15:57.257' AS DateTime), 0) ";
                sql += " \n  INSERT[dbo].[TENDER] ([TID], [CODE], [NAME], [VENDERCODE], [VENDERNAME], [TYPE], [CERRENCY], [PAYMENT_METHOD], [VALUE_CONVERT], [Server], [SCAN_TYPE], [PREFIX_BARCODE], [REMARK1], [REMARK2], [REMARK3], [STATUS], [CBY], [CRDATE], [MBY], [MODATE], [MO]) VALUES(6, N'LINEPAY', N'LINE PAY', N'Rabbit', N'Rabbit', N'EWALLET', N'THB', N'BALANCE', CAST(1.00 AS Decimal(18, 2)), N'', N'B&C', N'R', N'MERCHAND_ID_MULTI', N'', N'', N'1', N'pgm', CAST(N'2020-01-22T14:26:12.260' AS DateTime), N'pgm', CAST(N'2020-01-22T14:26:12.260' AS DateTime), 0) ";
                sql += " \n  INSERT[dbo].[TENDER] ([TID], [CODE], [NAME], [VENDERCODE], [VENDERNAME], [TYPE], [CERRENCY], [PAYMENT_METHOD], [VALUE_CONVERT], [Server], [SCAN_TYPE], [PREFIX_BARCODE], [REMARK1], [REMARK2], [REMARK3], [STATUS], [CBY], [CRDATE], [MBY], [MODATE], [MO]) VALUES(6, N'RABBIT', N'RABBIT', N'RABBIT', N'RABBIT', N'EWALLET', N'THB', N'BALANCE', CAST(1.00 AS Decimal(18, 2)), N'', N'B&C', N'R', N'MERCHAND_ID_MULTI', N'', N'', N'0', N'pgm', CAST(N'2020-01-22T14:26:12.260' AS DateTime), N'pgm', CAST(N'2020-01-22T14:26:12.260' AS DateTime), 0) ";
                sql += " \n  INSERT[dbo].[TENDER] ([TID], [CODE], [NAME], [VENDERCODE], [VENDERNAME], [TYPE], [CERRENCY], [PAYMENT_METHOD], [VALUE_CONVERT], [Server], [SCAN_TYPE], [PREFIX_BARCODE], [REMARK1], [REMARK2], [REMARK3], [STATUS], [CBY], [CRDATE], [MBY], [MODATE], [MO]) VALUES(1, N'THAIQR', N'บัตร THAI QR', N'KBANK', N'KBANK', N'EBANKING', N'THB', N'BALANCE', CAST(1.00 AS Decimal(18, 2)), N'http://api.sahatarasst.com:8085/', N'C&B', N'T', N'MERCHAND_ID_MULTI', N'', N'', N'1', N'pgm', CAST(N'2019-10-22T13:57:15.093' AS DateTime), N'pgm', CAST(N'2019-11-05T11:37:00.510' AS DateTime), 1) ";
                sql += " \n  INSERT[dbo].[TENDER] ([TID], [CODE], [NAME], [VENDERCODE], [VENDERNAME], [TYPE], [CERRENCY], [PAYMENT_METHOD], [VALUE_CONVERT], [Server], [SCAN_TYPE], [PREFIX_BARCODE], [REMARK1], [REMARK2], [REMARK3], [STATUS], [CBY], [CRDATE], [MBY], [MODATE], [MO]) VALUES(7, N'TRUEEDC', N'True EDC', N'TRUE', N'TRUE', N'EWALLET', N'THB', N'BALANCE', CAST(100.00 AS Decimal(18, 2)), N'', N'B&C', N'M', N'MERCHAND_ID_SINGGLE', N'', N'', N'0', N'pgm', CAST(N'2020-10-22T14:02:44.390' AS DateTime), N'pgm', CAST(N'2020-11-05T10:06:16.310' AS DateTime), 1) ";
                sql += " \n  INSERT[dbo].[TENDER] ([TID], [CODE], [NAME], [VENDERCODE], [VENDERNAME], [TYPE], [CERRENCY], [PAYMENT_METHOD], [VALUE_CONVERT], [Server], [SCAN_TYPE], [PREFIX_BARCODE], [REMARK1], [REMARK2], [REMARK3], [STATUS], [CBY], [CRDATE], [MBY], [MODATE], [MO]) VALUES(2, N'TRUEWALLET', N'TrueMoney', N'TRUE', N'TRUE', N'EWALLET', N'THB', N'BALANCE', CAST(100.00 AS Decimal(18, 2)), N'http://api.sahatarasst.com:8028/', N'B&C', N'M', N'MERCHAND_ID_SINGGLE', N'', N'', N'1', N'pgm', CAST(N'2019-10-22T14:02:44.390' AS DateTime), N'pgm', CAST(N'2019-11-05T10:06:16.310' AS DateTime), 1) ";
                sql += " \n  INSERT[dbo].[TENDER] ([TID], [CODE], [NAME], [VENDERCODE], [VENDERNAME], [TYPE], [CERRENCY], [PAYMENT_METHOD], [VALUE_CONVERT], [Server], [SCAN_TYPE], [PREFIX_BARCODE], [REMARK1], [REMARK2], [REMARK3], [STATUS], [CBY], [CRDATE], [MBY], [MODATE], [MO]) VALUES(5, N'WECHAT', N'WECHAT', N'KBANK', N'KBANK', N'EWALLET', N'THB', N'BALANCE', CAST(1.00 AS Decimal(18, 2)), N'', N'B&C', N'W', N'MERCHAND_ID_MULTI', N'', N'', N'1', N'pgm', CAST(N'2020-01-22T14:20:15.807' AS DateTime), N'pgm', CAST(N'2020-01-22T14:20:15.807' AS DateTime), 0) ";


                sql += " ALTER TABLE[dbo].[TENDER] ADD CONSTRAINT[DF_TENDER_VALUE]  DEFAULT((1)) FOR[VALUE_CONVERT] ";
                sql += " ALTER TABLE[dbo].[TENDER] ADD CONSTRAINT[DF_TENDER_CRDATE]  DEFAULT(getdate()) FOR[CRDATE] ";
                sql += " ALTER TABLE[dbo].[TENDER] ADD CONSTRAINT[DF_TENDER_MODATE]  DEFAULT(getdate()) FOR[MODATE] ";
                sql += " ALTER TABLE[dbo].[TENDER] ADD CONSTRAINT[DF_TENDER_MO]  DEFAULT((0)) FOR[MO] ";
                sql += " end; ";

                exec.Excute2(sql);







                sql = " USE [" + exec.DB_backup_name + "] ";
                sql += " if not exists(select name from sys.tables where name = 'TENDER_ITEMS') ";
                sql += " Begin ";
                sql += " SET ANSI_NULLS ON ";
                sql += " SET QUOTED_IDENTIFIER ON ";
                sql += " CREATE TABLE[dbo].[TENDER_ITEMS] ";
                sql += " ( ";
                sql += " [TID][int] IDENTITY(1,1) NOT NULL, ";
                sql += " [CODE] [nvarchar] (20) NOT NULL, ";
                sql += " [SEQ] [int] NOT NULL, ";
                sql += " [TERMINALID] [nvarchar] (20) NULL, ";
                sql += " [POSID] [nvarchar] (30) NULL, ";
                sql += " [MERCHAND_ID] [nvarchar] (50) NOT NULL, ";
                sql += " [APP_ID] [nvarchar] (100) NULL, ";
                sql += " [CLIENT_KEY] ";
                sql += " [nvarchar] ";
                sql += " (max) NULL, ";
                sql += " [CLIENT_SECRET] [nvarchar] ";
                sql += " (max) NULL, ";
                sql += " [STATUS] [varchar] (1) NULL, ";
                sql += " [REMARK1] [nvarchar] (100) NULL, ";
                sql += " [REMARK2] [nvarchar] (100) NULL, ";
                sql += " [REMARK3] [nvarchar] (100) NULL, ";
                sql += " CONSTRAINT[PK_TENDER_ITEMS] PRIMARY KEY CLUSTERED ";
                sql += " ( ";
                sql += " [CODE] ASC, ";
                sql += " [MERCHAND_ID] ASC ";
                sql += " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] ";
                sql += " ) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY] ";
                sql += " SET IDENTITY_INSERT[dbo].[TENDER_ITEMS] ";
                sql += "  ON ";


                sql += " INSERT[dbo].[TENDER_ITEMS]([TID], [CODE], [SEQ], [TERMINALID], [POSID], [MERCHAND_ID], [APP_ID], [CLIENT_KEY], [CLIENT_SECRET], [STATUS], [REMARK1], [REMARK2], [REMARK3]) VALUES(1005, N'ALIPAY', 1, N'', N'', N'', N'', N'', N'', N'1', NULL, NULL, NULL) ";
                sql += " INSERT[dbo].[TENDER_ITEMS] ([TID], [CODE], [SEQ], [TERMINALID], [POSID], [MERCHAND_ID], [APP_ID], [CLIENT_KEY], [CLIENT_SECRET], [STATUS], [REMARK1], [REMARK2], [REMARK3]) VALUES(4, N'DOLFIN', 1, N'', N'', N'300990000349', N'20190816000231', N'', N'', N'1', NULL, NULL, NULL) ";
                sql += " INSERT[dbo].[TENDER_ITEMS] ([TID], [CODE], [SEQ], [TERMINALID], [POSID], [MERCHAND_ID], [APP_ID], [CLIENT_KEY], [CLIENT_SECRET], [STATUS], [REMARK1], [REMARK2], [REMARK3]) VALUES(1009, N'LINEPAY', 1, N'', N'', N'', N'', N'', N'', N'1', NULL, NULL, NULL) ";
                sql += " INSERT[dbo].[TENDER_ITEMS] ([TID], [CODE], [SEQ], [TERMINALID], [POSID], [MERCHAND_ID], [APP_ID], [CLIENT_KEY], [CLIENT_SECRET], [STATUS], [REMARK1], [REMARK2], [REMARK3]) VALUES(1008, N'RABBIT', 1, N'', N'', N'', N'', N'', N'', N'1', NULL, NULL, NULL) ";
                sql += " INSERT[dbo].[TENDER_ITEMS] ([TID], [CODE], [SEQ], [TERMINALID], [POSID], [MERCHAND_ID], [APP_ID], [CLIENT_KEY], [CLIENT_SECRET], [STATUS], [REMARK1], [REMARK2], [REMARK3]) VALUES(1, N'THAIQR', 1, N'053', N'2017002', N'EXT01000251848', N'PTR0000043', N'', N'RK6J6GNinE8CBu1NshzIgYPC6yq14VTO7P5FjPUPuhWe0W3FlekkaQkfqO7mRaqZ', N'1', NULL, NULL, NULL) ";
                sql += " INSERT[dbo].[TENDER_ITEMS] ([TID], [CODE], [SEQ], [TERMINALID], [POSID], [MERCHAND_ID], [APP_ID], [CLIENT_KEY], [CLIENT_SECRET], [STATUS], [REMARK1], [REMARK2], [REMARK3]) VALUES(1004, N'TRUEEDC', 1, N'', N'', N'', N'', N'', N'', N'1', NULL, NULL, NULL) ";
                sql += " INSERT[dbo].[TENDER_ITEMS] ([TID], [CODE], [SEQ], [TERMINALID], [POSID], [MERCHAND_ID], [APP_ID], [CLIENT_KEY], [CLIENT_SECRET], [STATUS], [REMARK1], [REMARK2], [REMARK3]) VALUES(3, N'TRUEWALLET', 1, N'', N'', N'010000000009610012083', N'', N'', N'', N'1', NULL, NULL, NULL) ";
                sql += " INSERT[dbo].[TENDER_ITEMS] ([TID], [CODE], [SEQ], [TERMINALID], [POSID], [MERCHAND_ID], [APP_ID], [CLIENT_KEY], [CLIENT_SECRET], [STATUS], [REMARK1], [REMARK2], [REMARK3]) VALUES(1007, N'WECHAT', 1, N'', N'', N'', N'', N'', N'', N'1', NULL, NULL, NULL) ";




                sql += " SET IDENTITY_INSERT[dbo].[TENDER_ITEMS] ";
                sql += " OFF ";
                sql += " end; ";
                exec.Excute2(sql);

                //-----------------------------------------------------------------------------------------------------------
                sql = "";
                sql = " USE [" + exec.DB_backup_name + "] ";
                sql += " if not exists(select name from sys.tables where name = 'SysConfig') ";
                sql += " begin";
                sql += " CREATE TABLE[dbo].[SysConfig]( ";
                sql += " [ITEMSNO][varchar](20) NULL, ";
                sql += " [CUSGROUP] [varchar](50) NULL, ";
                sql += " [VENDOR_GETWAY] [varchar](50) NULL, ";
                sql += " [CONN_LINK] [varchar](20) NULL, ";
                sql += " [WALLET_TYPE] [varchar](50) NULL ";
                sql += " ) ON[PRIMARY] ";
                sql += " end  ";
                exec.Excute2(sql);

                sql = "";
                sql = " USE [" + exec.DB_backup_name + "] ";
                sql += " if not exists (select * from [SysConfig]) INSERT[dbo].[SysConfig]([ITEMSNO], [CUSGROUP], [VENDOR_GETWAY],[CONN_LINK], [WALLET_TYPE]) VALUES('1', 'HOMEPRO', 'GHL', 'WIFI', 'EDC') ";
                exec.Excute2(sql);
                //-----------------------------------------------------------------------------------------------------------



                //-23/09/63
                if (data_config[0].CUSGROUP != cl_const.CUSGROUP.ATR)
                {
                    sql = " USE [" + exec.DB_backup_name + "] ";
                    sql += " select name from sys.tables where name = 'happyhour' ";
                    dt = exec.ReadData_Table(sql);
                    if (dt.Rows.Count <= 0)
                    {

                        sql = " USE [" + exec.DB_backup_name + "] ";
                        sql += " SET ANSI_NULLS ON " +
                            " SET QUOTED_IDENTIFIER ON " +
                            " CREATE TABLE[dbo].[happyhour]( " +
                            "     [happyhour_id][int] IDENTITY(1, 1) NOT NULL, " +
                            "     [happyhour_desc] [varchar](100) NULL, " +
                            " 	[datestart] [date] NULL, " +
                            " 	[dateend] [date] NULL, " +
                            " 	[timestart] [time](7) NULL, " +
                            " 	[timeend] [time](7) NULL, " +
                            "  CONSTRAINT[PK_happyhour] PRIMARY KEY CLUSTERED " +
                            " ( " +
                            "    [happyhour_id] ASC " +
                            " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] " +
                            " ) ON[PRIMARY] " +
                            " SET ANSI_NULLS ON " +
                            " SET QUOTED_IDENTIFIER ON " +
                            " CREATE TABLE[dbo].[happyhourdt]( " +
                            "    [happyhourdt_id][int] IDENTITY(1, 1) NOT NULL, " +
                            "    [happyhour_id] [int] NULL, " +
                            " 	[shopid] [int] NULL, " +
                            " 	[btnid] [varchar](3) NULL, " +
                            " 	[btnflg] [char](1) NULL, " +
                            "  CONSTRAINT[PK_happyhourdt] PRIMARY KEY CLUSTERED " +
                            " ( " +
                            "    [happyhourdt_id] ASC " +
                            " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] " +
                            " ) ON[PRIMARY] " +
                            " ALTER TABLE[dbo].[happyhourdt] ADD CONSTRAINT[DF_happyhourdt_btnid]  DEFAULT('') FOR[btnid] " +
                            " EXEC sys.sp_addextendedproperty @name = N'MS_Description', @value = N'1=GP1 2=GP2' , @level0type = N'SCHEMA',@level0name = N'dbo', @level1type = N'TABLE',@level1name = N'happyhourdt', @level2type = N'COLUMN',@level2name = N'btnflg' ";
                                                exec.Excute2(sql);



                    }

                }





















                    ret.Respon.Result = true;
                ret.Respon.ErrorMessage = "Update Success";
                return ret;
            }
            catch (Exception ex)
            {
                ret.Respon.Result = false;
                ret.Respon.SystemErrorMessage = ex.Message;
                return ret;
            }
        }

        public ResponseMessage Table_Alter_Addcol(List<SysConfigModels> data_config)
        {
            var ret = new ResponseMessage();
            try
            {
                Getschemas Gs = new Getschemas();
                List<SchemasModel> idx = new List<SchemasModel>();


                DataContext exec = new DataContext(0);
                //sale dolfin  630128
                string sql = "  ";



                //CARDTRANS dolfin  630128-----------------------------------------------------------
                idx = new List<SchemasModel>();
                idx = Gs.Table_Get_index("CARDTRANS", true);
                sql = "";
                foreach (SchemasModel val in idx)
                {
                    sql += "\n DROP INDEX [" + val.index_name + "] ON [dbo].[" + val.table_name + "]";
                }
                if (sql != "")
                {
                    exec.Excute2(sql);
                }


                sql = " \n CREATE NONCLUSTERED INDEX [NonClusteredIndexCARDTRANS] ON [dbo].[CARDTRANS] ";
                sql += " ( ";
                sql += " [CUSED] ASC, ";
                sql += " [BARCODE] ASC, ";
                sql += " [SHOPID] ASC, ";
                sql += " [POSID] ASC, ";
                sql += " [MRTAMOUNT] ASC, ";
                sql += " [MRTSTATUS] ASC ";
                sql += " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]";
                exec.Excute2(sql);




                sql = " \n If Not EXISTS(  SELECT column_name FROM   " + exec.DB_backup2 + "INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME = 'SALE_ITEMS'AND COLUMN_NAME = 'GPRULE' ) ";
                sql += " begin";
                sql += "    alter table " + exec.DB_backup + "SALE_ITEMS ADD GPRULE nvarchar(10)  null";
                sql += " End ";

                exec.Excute2(sql);



                //17/07/2563
                sql = " \n If Not EXISTS(  SELECT column_name FROM   " + exec.DB_backup2 + "INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME = 'TENDER_ITEMS' AND COLUMN_NAME = 'VENDER_SHOP_ID' ) ";
                sql += " begin";
                sql += "    alter table " + exec.DB_backup + "TENDER_ITEMS ADD VENDER_SHOP_ID nvarchar(30)  null";
                sql += " End ";

                exec.Excute2(sql);

                //13/10/2563
                sql = " \n If Not EXISTS(  SELECT column_name FROM   " + exec.DB_backup2 + "INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME = 'SysConfig' AND COLUMN_NAME = 'USESTOCK' ) ";
                sql += " begin";
                sql += "    alter table " + exec.DB_backup + "SysConfig ADD USESTOCK bit  null";
                sql += " End ";
                exec.Excute2(sql);

                sql = " \n If Not EXISTS(  SELECT column_name FROM   " + exec.DB_backup2 + "INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME = 'SysConfig' AND COLUMN_NAME = 'POSTYPE' ) ";
                sql += " begin";
                sql += "    alter table " + exec.DB_backup + "SysConfig ADD POSTYPE  nvarchar(20)  null";
                sql += " End ";
                exec.Excute2(sql);


                sql = " \n If Not EXISTS(  SELECT column_name FROM   " + exec.DB_backup2 + "INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME = 'SALE_ITEMS' AND COLUMN_NAME = 'CREDITNOTES' ) ";
                sql += " begin";
                sql += "    alter table " + exec.DB_backup + "SALE_ITEMS ADD CREDITNOTES  nvarchar(40)  null  default ''";
                sql += " End ";
                exec.Excute2(sql);

                sql = " \n If Not EXISTS(  SELECT column_name FROM   " + exec.DB_backup2 + "INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME = 'SALE_ITEMS' AND COLUMN_NAME = 'CARDREF_CN' ) ";
                sql += " begin";
                sql += "    alter table " + exec.DB_backup + "SALE_ITEMS ADD CARDREF_CN  nvarchar(50)  null  default ''";
                sql += " End ";
                exec.Excute2(sql);


                sql = " \n If Not EXISTS(  SELECT column_name FROM   " + exec.DB_backup2 + "INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME = 'SALE_ITEMS' AND COLUMN_NAME = 'MRTSTATUS' ) ";
                sql += " begin";
                sql += "    alter table " + exec.DB_backup + "SALE_ITEMS ADD MRTSTATUS  varchar(1)  null  default 'S'";
                sql += " End ";
                exec.Excute2(sql);







                ret.Respon.Result = true;
                ret.Respon.ErrorMessage = "Update Success";
                return ret;
            }
            catch (Exception ex)
            {
                ret.Respon.Result = false;
                ret.Respon.SystemErrorMessage = ex.Message;
                return ret;
            }
        }


        public ResponseMessage Table_Alter_Altercol(List<SysConfigModels> data_config)
        {
            var ret = new ResponseMessage();
            try
            {
                Getschemas Gs = new Getschemas();
                List<SchemasModel> idx = new List<SchemasModel>();


                DataContext exec = new DataContext(0);
                //sale dolfin  630128
                string sql = "  ";
                sql = " If Not EXISTS(  SELECT column_name FROM   " + exec.DB_backup2 + "INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME = 'SALE'AND COLUMN_NAME = 'CARDREF' and data_type = 'nvarchar' and CHARACTER_MAXIMUM_LENGTH  >= 60) ";
                sql += " begin";
                sql += "    alter table " + exec.DB_backup + "SALE ALTER COLUMN CARDREF nvarchar(60)  null";
                sql += " End ";


                sql += " \n If Not EXISTS(  SELECT column_name FROM   " + exec.DB_backup2 + "INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME = 'SALE'AND COLUMN_NAME = 'TAXINVOICE' and data_type = 'nvarchar' and CHARACTER_MAXIMUM_LENGTH  >= 60) ";
                sql += " begin";
                sql += "    alter table " + exec.DB_backup + "SALE ALTER COLUMN TAXINVOICE nvarchar(60)  null";
                sql += " End ";


                exec.Excute2(sql);



                sql = "";
                sql = " If Not EXISTS(  SELECT column_name FROM   INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME = 'CARDTRANS'AND COLUMN_NAME = 'barcode' and data_type = 'nvarchar' and CHARACTER_MAXIMUM_LENGTH  >= 30) ";
                sql += " begin";
                sql += "    alter table CARDTRANS ALTER COLUMN barcode nvarchar(30)  null";
                sql += " End ";
                exec.Excute2(sql);

                if (data_config[0].CUSGROUP != cl_const.CUSGROUP.ATR)
                {
                    sql = " \n If Not EXISTS(  SELECT column_name FROM  INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME = 'CARDTRANS'AND COLUMN_NAME = 'TAXINVOICE' and data_type = 'nvarchar' and CHARACTER_MAXIMUM_LENGTH  >= 60) ";
                    sql += " begin";
                    sql += "    alter table CARDTRANS ALTER COLUMN TAXINVOICE nvarchar(60)  null";
                    sql += " End ";
                    exec.Excute2(sql);
                }




                //DB_backup   CARDTRANS dolfin  630128-----------------------------------------------------------
                sql = "";
                sql = " If Not EXISTS(  SELECT column_name FROM   " + exec.DB_backup2 + "INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME = 'CARDTRANS'AND COLUMN_NAME = 'barcode' and data_type = 'nvarchar' and CHARACTER_MAXIMUM_LENGTH  >= 30) ";
                sql += " begin";
                sql += "    alter table " + exec.DB_backup + "CARDTRANS ALTER COLUMN barcode nvarchar(30)  null";
                sql += " End ";
                exec.Excute2(sql);

                if (data_config[0].CUSGROUP != cl_const.CUSGROUP.ATR)
                {
                    sql = " \n If Not EXISTS(  SELECT column_name FROM   " + exec.DB_backup2 + "INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME = 'CARDTRANS'AND COLUMN_NAME = 'TAXINVOICE' and data_type = 'nvarchar' and CHARACTER_MAXIMUM_LENGTH  >= 60) ";
                    sql += " begin";
                    sql += "    alter table " + exec.DB_backup + "CARDTRANS ALTER COLUMN TAXINVOICE nvarchar(60)  null";
                    sql += " End ";
                    exec.Excute2(sql);
                }

                sql = "";
                sql = " USE [dbfoodbackup] " +
 " If Not EXISTS(SELECT column_name FROM   INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME = 'SALE_CARD'AND COLUMN_NAME = 'barcode' and data_type = 'nvarchar' and CHARACTER_MAXIMUM_LENGTH >= 100)  " +
 " begin " +
    " DROP INDEX[IDX_SALE_card] ON[dbo].SALE_CARD;" +
                " alter table[dbo].SALE_CARD ALTER COLUMN barcode nvarchar(100)  null; " +
                " CREATE NONCLUSTERED INDEX[IDX_SALE_card] ON[dbo].[SALE_CARD] " +
                " ( " +
                " [MRTSLIPNO] ASC, " +
                " [SHOPID] ASC, " +
                " [SEQ] ASC, " +
                " [BARCODE] ASC " +
" )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) " +
 " End ";
                exec.Excute2(sql);





                ret.Respon.Result = true;
                ret.Respon.ErrorMessage = "Update Success";
                return ret;
            }
            catch (Exception ex)
            {
                ret.Respon.Result = false;
                ret.Respon.SystemErrorMessage = ex.Message;
                return ret;
            }
        }
        // CARDTRANS barcode 20
        //            TAXINVOICE  50

        // PAYMENT barcode 20

        //[SALE] CARDREF    50
        //       TAXINVOICE
    }
}