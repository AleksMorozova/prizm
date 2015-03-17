/****** Object:  Table [dbo].[Category]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[Category](

	[id] [uniqueidentifier] NOT NULL,
	[isActive] [bit] NULL,
	[fixed] [bit] NULL,
	[name] [nvarchar](40) NULL,
	[resultType] [nvarchar](20) NULL,
	[type][nvarchar](20) NULL,

 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_PADDING OFF

/****** Object:  Table [dbo].[InspectorCertificateType]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[InspectorCertificateType](

	[id] [uniqueidentifier] NOT NULL,
	[isActive] [bit] NULL,
	[name] [nvarchar](30) NULL,

 CONSTRAINT [PK_InspectorCertificateType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_PADDING OFF


/****** Object:  Table [dbo].[CannedMessage]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[CannedMessage](

	[id] [uniqueidentifier] NOT NULL,
	[isActive] [bit] NULL,

	[language] [nvarchar] (10) NULL,
	[text] [nvarchar] (100) NULL,
	[idDefect] [nvarchar](10) NULL,

 CONSTRAINT [PK_CannedMessage] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_PADDING OFF


/****** Object:  Table [dbo].[SeamType]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[SeamType](

	[id] [uniqueidentifier] NOT NULL,
	[isActive] [bit] NULL,
	[name] [nvarchar](20) NULL,
	[isNative] [bit] NOT NULL DEFAULT 0,
	[projectId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_SeamType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_PADDING OFF
/****** Object:  Table [dbo].[ComponentType]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[ComponentType](

	[id] [uniqueidentifier] NOT NULL,
	[isActive] [bit] NULL,
	[name] [nvarchar](20) NULL,
	[connectorsCount] [int] NULL,
	[isNative] [bit] NOT NULL DEFAULT 0,
	[projectId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_ComponentType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_PADDING OFF

/****** Object:  Table [dbo].[Connector]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[Connector](

	[id] [uniqueidentifier] NOT NULL,
	[isActive] [bit] NULL,
	[diameter] [real] NULL,
	[wallThickness] [float] NULL,
	[jointId] [uniqueidentifier] NULL,
	[componentId] [uniqueidentifier] NULL,

 CONSTRAINT [PK_Connector] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_PADDING OFF
/****** Object:  Table [dbo].[Component]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[Component](

	[id] [uniqueidentifier] NOT NULL,
	[certificate] [nvarchar](20) NULL,
	[length] [int] NULL,
	[number] [nvarchar](20) NULL,
	[isActive] [bit] NULL,
	[inspectionStatus] [nvarchar](15) NULL,
	[constructionStatus] [nvarchar](15) NULL,

	[componentTypeId] [uniqueidentifier] NULL,
        [toExport] [bit] NOT NULL DEFAULT 0,

	[isAvailableToJoint] [bit] NULL,
 CONSTRAINT [PK_Component] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

IF EXISTS (SELECT name FROM sys.indexes
            WHERE name = N'IX_Component_Number')
    DROP INDEX IX_Component_Number ON [dbo].[Component]
GO
CREATE NONCLUSTERED INDEX IX_Component_Number
    ON [dbo].[Component] (number)
GO

SET ANSI_PADDING OFF

/****** Object:  Table [dbo].[Spool]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[Spool](

	[id] [uniqueidentifier] NOT NULL,
	[isActive] [bit] NULL,
	[inspectionStatus] [nvarchar](15) NULL,
	[constructionStatus] [nvarchar](15) NULL,
	[length] [int] NULL,
	[number] [nvarchar](20) NULL,

	[pipeNumber] [nvarchar](20) NULL,

	[pipeId] [uniqueidentifier] NULL,

	[isAvailableToJoint] [bit] NULL,

 CONSTRAINT [PK_Spool] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

IF EXISTS (SELECT name FROM sys.indexes
            WHERE name = N'IX_Spool_Number')
    DROP INDEX IX_Spool_Number ON [dbo].[Spool]
GO
CREATE NONCLUSTERED INDEX IX_Spool_Number
    ON [dbo].[Spool] (number)
GO

SET ANSI_PADDING OFF
/****** Object:  Table [dbo].[Heat]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[Heat](
	[id] [uniqueidentifier] NOT NULL,
	[number] [nvarchar](20) NULL,
	[steelGrade] [nvarchar](20) NULL,
	[plateManufacturer] [uniqueidentifier] NULL,

	[isActive] [bit] NULL,
 CONSTRAINT [PK_heat] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_PADDING OFF
/****** Object:  Table [dbo].[Inspector]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[Inspector](
	[id] [uniqueidentifier] NOT NULL,
	[firstName] [nvarchar](30) NULL,
	[lastName] [nvarchar](30) NULL,
	[middleName] [nvarchar](30) NULL,
	[certificate] [nvarchar](30) NULL,
	[certificateExpiration] [date] NULL,
	[certificateId] [uniqueidentifier] NULL,

	[isActive] [bit] NULL,
 CONSTRAINT [PK_Inspector] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_PADDING OFF

/****** Object:  Table [dbo].[InspectorCertificate]    Script Date: 12/2/2014 1:58:12 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
CREATE TABLE [dbo].[InspectorCertificate](
	[id] [uniqueidentifier] NOT NULL,
	[number] [nvarchar](50) NOT NULL,
  [grade] [int] NULL,
	[expirationDate] [date] NOT NULL,
	[inspectorId] [uniqueidentifier] NOT NULL,
	[inspectorCertificateTypeId] [uniqueidentifier] NULL,
	[isActive] [bit] NULL,
 CONSTRAINT [PK_InspectorCertificate] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[Pipe]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[Pipe](
	[id] [uniqueidentifier] NOT NULL,
	[wallThickness] [float] NULL,
	[diameter] [real] NULL,
	[weight] [real] NULL,
	[mill] [nvarchar](250) NULL,
	[pipeMillStatus] [nvarchar](20) NULL,
	[typeId] [uniqueidentifier] NULL,
	[plateId] [uniqueidentifier] NULL,
	[purchaseOrderId] [uniqueidentifier] NULL,
	[railcarId] [uniqueidentifier] NULL,
	[productionDate][date] NULL,

	[length] [int] NULL,
	[number] [nvarchar](20) NULL,
	[isActive] [bit] NULL,	
	[millWeldSubStatus] [nvarchar](15) NULL,
	[millExtCoatSubStatus] [nvarchar](15) NULL,
	[millInterCoatSubStatus] [nvarchar](15) NULL,
	[inspectionStatus] [nvarchar](15) NULL,
	[constructionStatus] [nvarchar](15) NULL,
	[projectId] [uniqueidentifier] NULL,
	[isAvailableToJoint] [bit] NULL,
    [toExport] [bit] NOT NULL DEFAULT 0,
	[isCutOnSpool] [bit] NOT NULL DEFAULT 0,


 CONSTRAINT [PK_Pipe] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

IF EXISTS (SELECT name FROM sys.indexes
            WHERE name = N'IX_Pipe_Number')
    DROP INDEX IX_Pipe_Number ON [dbo].[Pipe]
GO
CREATE NONCLUSTERED INDEX IX_Pipe_Number
    ON [dbo].[Pipe] (number)
GO

IF EXISTS (SELECT name FROM sys.indexes
            WHERE name = N'IX_Pipe_MillStatus')
    DROP INDEX IX_Pipe_MillStatus ON [dbo].[Pipe]
GO
CREATE NONCLUSTERED INDEX IX_Pipe_MillStatus
    ON [dbo].[Pipe] (pipeMillStatus)
GO


SET ANSI_PADDING OFF

/****** Object:  Table [dbo].[PipeMillSizeType]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[PipeMillSizeType](
	[id] [uniqueidentifier] NOT NULL,
	[type] [nvarchar](50) NULL,
	[length] [int]  NULL,
	[diameter] [real] NULL,
	[thickness] [real]  NULL,
	[seamTypeId][uniqueidentifier] NULL,
	[isNative] [bit] NOT NULL DEFAULT 0,
	[projectId] [uniqueidentifier] NULL,
	[isActive] [bit] NULL,
 CONSTRAINT [PK_PipeMillSizeType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_PADDING OFF
/****** Object:  Table [dbo].[PipeTest]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[PipeTest](
	[id] [uniqueidentifier] NOT NULL,
	[code] [nvarchar](20) NULL,
	[name] [nvarchar](50) NULL,
	[controlType] [nvarchar](15) NULL,
	[resultType] [nvarchar](10) NULL,
	[minExpected] [decimal](10, 2) NULL,
	[maxExpected] [decimal](10, 2) NULL,
	[boolExpected] [bit] NULL,
	[isRequired] [bit] NULL,
	[pipeMillSizeTypeId] [uniqueidentifier] NULL,
	[frequency] [int] NULL,
	[frequencyMeasure] [nvarchar](10) NULL,
	[categoryId] [uniqueidentifier] NULL,

	[isActive] [bit] NULL,
 CONSTRAINT [PK_PipeTest] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_PADDING OFF
/****** Object:  Table [dbo].[JointOperation]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[JointOperation](
	[id] [uniqueidentifier] NOT NULL,
	[name] [nvarchar](50) NULL,
	[isRequired] [bit] NULL,
	[type] [nvarchar](20)  NULL,
	[testHasAccepted] [bit] NULL,
	[testHasToRepair] [bit] NULL,
	[testHasToWithdraw] [bit] NULL,
	[testResultRequired] [bit] NULL,
	[isActive] [bit] NULL,
 CONSTRAINT [PK_JointOperation] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


SET ANSI_PADDING OFF
/****** Object:  Table [dbo].[PipeTestResult]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
CREATE TABLE [dbo].[PipeTestResult](
	[id] [uniqueidentifier] NOT NULL,
	[testResultId] [uniqueidentifier] NULL,
	[pipeId] [uniqueidentifier] NULL,
	[pipeTestId] [uniqueidentifier] NULL,
	[date] [date] NULL,
	[order][int] NULL,
	[status] [nvarchar] (25) NULL,
	[value] [nvarchar] (100) NULL,
	[isActive] [bit] NULL,
 CONSTRAINT [PK_PipeTestResult] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[Plate]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[Plate](
	[id] [uniqueidentifier] NOT NULL,
	[number] [nvarchar](20) NULL,
	[thickness] [float] NULL,
	[heatId] [uniqueidentifier] NULL,

	[isActive] [bit] NULL,
 CONSTRAINT [PK_Plate] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_PADDING OFF
/****** Object:  Table [dbo].[PurchaseOrder]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[PurchaseOrder](
	[id] [uniqueidentifier] NOT NULL,
	[number] [nvarchar](20) NULL,
	[date] [date] NULL,

	[isActive] [bit] NULL,
 CONSTRAINT [PK_PurchaseOrder] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
SET ANSI_PADDING OFF

/****** Object:  Table [dbo].[PlateManufacturer]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[PlateManufacturer](
	[id] [uniqueidentifier]NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[isActive] [bit] NOT NULL,
	[isNative] [bit] NOT NULL DEFAULT 0,
	[projectId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_PlateManufacturer] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
SET ANSI_PADDING OFF


SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[Project](
	[id] [uniqueidentifier] NOT NULL,
	[isActive] [bit] NOT NULL,
	[title] [nvarchar] (50) NULL,
	[client] [nvarchar](100) NULL,
	[millName] [nvarchar](100) NULL,
	[documentSizeLimit] [int] NULL,
	[workstationType] [nvarchar] (20) NULL,
	[millPipeNumberMask] [nvarchar] (20) NULL,
	[millPipeNumberMaskRegexp] [nvarchar] (1000) NULL,
	[isNative] [bit] NOT NULL DEFAULT 0,
 CONSTRAINT [PK_Project] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
SET ANSI_PADDING OFF

/****** Object:  Table [dbo].[Railcar]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[Railcar](
	[id] [uniqueidentifier] NOT NULL,
	[number] [nvarchar](20) NULL,
	[certificate] [nvarchar](20) NULL,
	[destination] [nvarchar](50) NULL,
	[isShipped] [bit] NULL,
	 [toExport] [bit] NOT NULL DEFAULT 0,
	[isActive] [bit] NULL,
	[releaseNoteId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_Railcar] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


SET ANSI_PADDING OFF

IF EXISTS (SELECT name FROM sys.indexes
            WHERE name = N'IDX_Railcar_Number')
    DROP INDEX IDX_Railcar_Number ON [dbo].[Railcar]
GO
CREATE NONCLUSTERED INDEX IDX_Railcar_Number
    ON [dbo].[Railcar] ([number])
GO

IF EXISTS (SELECT name FROM sys.indexes
            WHERE name = N'IDX_Railcar_Certificate')
    DROP INDEX IDX_Railcar_Certificate ON [dbo].[Railcar]
GO
CREATE NONCLUSTERED INDEX IDX_Railcar_Certificate
    ON [dbo].[Railcar] ([certificate])
GO

/****** Object:  Table [dbo].[ReleaseNote]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[ReleaseNote](
	[id] [uniqueidentifier] NOT NULL,
	[number] [nvarchar](20) NULL,
	[date] [date] NULL,
	[Shipped] [bit] NULL,
	[isActive] [bit] NULL,
 CONSTRAINT [PK_ReleaseNote] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


SET ANSI_PADDING OFF

IF EXISTS (SELECT name FROM sys.indexes
            WHERE name = N'IDX_ReleaseNote_Number')
    DROP INDEX IDX_ReleaseNote_Number ON [dbo].[ReleaseNote]
GO
CREATE NONCLUSTERED INDEX IDX_ReleaseNote_Number
    ON [dbo].[ReleaseNote] ([number])
GO

IF EXISTS (SELECT name FROM sys.indexes
            WHERE name = N'IDX_ReleaseNote_Date')
    DROP INDEX IDX_ReleaseNote_Date ON [dbo].[ReleaseNote]
GO
CREATE NONCLUSTERED INDEX IDX_ReleaseNote_Date
    ON [dbo].[ReleaseNote] ([date])
GO


/****** Object:  Table [dbo].[InspectionTestResult]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[InspectionTestResult](
	
	[id] [uniqueidentifier] NOT NULL,
	[isActive] [bit] NULL,
	[partId] [uniqueidentifier] NULL,

	[inspectionDate] [date] NULL,

	[order][int] NULL,
	[status] [nvarchar] (25) NULL,
	[value] [nvarchar] (20) NULL,

 CONSTRAINT [PK_InspectionTestResult] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_PADDING OFF




/****** Object:  Table [dbo].[TestResult]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[TestResult](
	[id] [uniqueidentifier] NOT NULL,
	[date] [date] NULL,
	[value] [nvarchar](25) NULL,
	[status] [nvarchar](25) NULL,

	[isActive] [bit] NULL,
 CONSTRAINT [PK_TestResult] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_PADDING OFF
/****** Object:  Table [dbo].[TestResult_Inspector]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
CREATE TABLE [dbo].[TestResult_Inspector](
	[inspectorId] [uniqueidentifier] NOT NULL,
	[resultId] [uniqueidentifier]  NOT NULL)

/****** Object:  Table [dbo].[Weld]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
CREATE TABLE [dbo].[Weld](
	[id] [uniqueidentifier] NOT NULL,
	[date] [date] NULL,
	[pipeId] [uniqueidentifier] NOT NULL,
	[isActive] [bit] NULL,
CONSTRAINT [PK_weld] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[Weld_Welder]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
CREATE TABLE [dbo].[Weld_Welder](
	[weldId] [uniqueidentifier] NOT NULL,
	[welderId] [uniqueidentifier] NOT NULL
) ON [PRIMARY]

/****** Object:  Table [dbo].[Welder]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[Welder](
	[id] [uniqueidentifier] NOT NULL,
	[firstName] [nvarchar](30) NULL,
	[lastName] [nvarchar](30) NULL,
	[middleName] [nvarchar](30) NULL,
	[certificate] [nvarchar](30) NULL,
	[certificateExpiration] [date] NULL,
	[stamp] [nvarchar](50) NULL,
	[grade] [int] NULL,

	[isActive] [bit] NULL,
 CONSTRAINT [PK_welder] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
SET ANSI_PADDING OFF



/* ------ Component Type CONSTRAINT ------ */
ALTER TABLE [dbo].[Component]  WITH CHECK ADD  CONSTRAINT [FK_Component_ComponentType] FOREIGN KEY([componentTypeId])
REFERENCES [dbo].[ComponentType] ([id])
ALTER TABLE [dbo].[Component] CHECK CONSTRAINT [FK_Component_ComponentType]

/* ------ Connector CONSTRAINT ------ */
ALTER TABLE [dbo].[Connector]  WITH CHECK ADD  CONSTRAINT [FK_Connector_Component] FOREIGN KEY([componentId])
REFERENCES [dbo].[Component] ([id])
ALTER TABLE [dbo].[Connector] CHECK CONSTRAINT [FK_Connector_Component]

/* ------ Spool CONSTRAINT ------ */
ALTER TABLE [dbo].[Spool]  WITH CHECK ADD  CONSTRAINT [FK_Spool_Pipe] FOREIGN KEY([pipeId])
REFERENCES [dbo].[Pipe] ([id])
ALTER TABLE [dbo].[Spool] CHECK CONSTRAINT [FK_Spool_Pipe]


ALTER TABLE [dbo].[PlateManufacturer]  WITH CHECK ADD  CONSTRAINT [FK_PlateManufacturer_Project] FOREIGN KEY([projectId])
REFERENCES [dbo].[Project] ([id])
ALTER TABLE [dbo].[PlateManufacturer] CHECK CONSTRAINT [FK_PlateManufacturer_Project]

ALTER TABLE [dbo].[SeamType]  WITH CHECK ADD  CONSTRAINT [FK_SeamType_Project] FOREIGN KEY([projectId])
REFERENCES [dbo].[Project] ([id])
ALTER TABLE [dbo].[SeamType] CHECK CONSTRAINT [FK_SeamType_Project]

ALTER TABLE [dbo].[PipeMillSizeType]  WITH CHECK ADD  CONSTRAINT [FK_PipeMillSizeType_Project] FOREIGN KEY([projectId])
REFERENCES [dbo].[Project] ([id])
ALTER TABLE [dbo].[PipeMillSizeType] CHECK CONSTRAINT [FK_PipeMillSizeType_Project]

ALTER TABLE [dbo].[ComponentType]  WITH CHECK ADD  CONSTRAINT [FK_ComponentType_Project] FOREIGN KEY([projectId])
REFERENCES [dbo].[Project] ([id])
ALTER TABLE [dbo].[ComponentType] CHECK CONSTRAINT [FK_ComponentType_Project]


ALTER TABLE [dbo].[PipeTest]  WITH CHECK ADD  CONSTRAINT [FK_PipeTest_Category] FOREIGN KEY([categoryId])
REFERENCES [dbo].[Category] ([id])
ALTER TABLE [dbo].[PipeTest] CHECK CONSTRAINT [FK_PipeTest_Category]

ALTER TABLE [dbo].[Pipe]  WITH CHECK ADD  CONSTRAINT [FK_Pipe_PipeMillSizeType] FOREIGN KEY([typeId])
REFERENCES [dbo].[PipeMillSizeType] ([id])
ALTER TABLE [dbo].[Pipe] CHECK CONSTRAINT [FK_Pipe_PipeMillSizeType]

ALTER TABLE [dbo].[Pipe]  WITH CHECK ADD  CONSTRAINT [FK_Pipe_Plate] FOREIGN KEY([plateId])
REFERENCES [dbo].[Plate] ([id])
ALTER TABLE [dbo].[Pipe] CHECK CONSTRAINT [FK_Pipe_Plate]

ALTER TABLE [dbo].[Pipe]  WITH CHECK ADD  CONSTRAINT [FK_Pipe_Project] FOREIGN KEY([projectId])
REFERENCES [dbo].[Project] ([id])
ALTER TABLE [dbo].[Pipe] CHECK CONSTRAINT [FK_Pipe_Project]
ALTER TABLE [dbo].[Pipe]  WITH CHECK ADD  CONSTRAINT [FK_Pipe_PurchaseOrder] FOREIGN KEY([purchaseOrderId])
REFERENCES [dbo].[PurchaseOrder] ([id])
ALTER TABLE [dbo].[Pipe] CHECK CONSTRAINT [FK_Pipe_PurchaseOrder]
ALTER TABLE [dbo].[Pipe]  WITH CHECK ADD  CONSTRAINT [FK_Pipe_Railcar] FOREIGN KEY([railcarId])
REFERENCES [dbo].[Railcar] ([id])
ALTER TABLE [dbo].[Pipe] CHECK CONSTRAINT [FK_Pipe_Railcar]
ALTER TABLE [dbo].[PipeTestResult]  WITH CHECK ADD  CONSTRAINT [FK_PipeTestResult_Pipe] FOREIGN KEY([pipeId])
REFERENCES [dbo].[Pipe] ([id])
ALTER TABLE [dbo].[PipeTestResult] CHECK CONSTRAINT [FK_PipeTestResult_Pipe]
ALTER TABLE [dbo].[PipeTestResult]  WITH CHECK ADD  CONSTRAINT [FK_PipeTestResult_PipeTest] FOREIGN KEY([pipeTestId])
REFERENCES [dbo].[PipeTest] ([id])
ALTER TABLE [dbo].[PipeTestResult] CHECK CONSTRAINT [FK_PipeTestResult_PipeTest]
ALTER TABLE [dbo].[PipeTestResult]  WITH CHECK ADD  CONSTRAINT [FK_PipeTestResult_TestResult] FOREIGN KEY([testResultId])
REFERENCES [dbo].[TestResult] ([id])
ALTER TABLE [dbo].[PipeTestResult] CHECK CONSTRAINT [FK_PipeTestResult_TestResult]
ALTER TABLE [dbo].[Plate]  WITH CHECK ADD  CONSTRAINT [FK_Plate_heat] FOREIGN KEY([heatId])
REFERENCES [dbo].[Heat] ([id])
ALTER TABLE [dbo].[Plate] CHECK CONSTRAINT [FK_Plate_heat]
ALTER TABLE [dbo].[TestResult_Inspector]  WITH CHECK ADD  CONSTRAINT [FK_TestResult_Inspector_Inspector] FOREIGN KEY([inspectorId])
REFERENCES [dbo].[Inspector] ([id])
ALTER TABLE [dbo].[TestResult_Inspector] CHECK CONSTRAINT [FK_TestResult_Inspector_Inspector]
ALTER TABLE [dbo].[TestResult_Inspector] ADD CONSTRAINT PK_TestResultId_InspectorId PRIMARY KEY CLUSTERED([inspectorId], [resultId])
ALTER TABLE [dbo].[Weld_Welder]  WITH CHECK ADD  CONSTRAINT [FK_Weld_Welder_weld] FOREIGN KEY([weldId])
REFERENCES [dbo].[Weld] ([id])
ALTER TABLE [dbo].[Weld_Welder] CHECK CONSTRAINT [FK_Weld_Welder_weld]
ALTER TABLE [dbo].[Weld_Welder]  WITH CHECK ADD  CONSTRAINT [FK_Weld_Welder_welder] FOREIGN KEY([welderId])
REFERENCES [dbo].[Welder] ([id])
ALTER TABLE [dbo].[Weld_Welder] CHECK CONSTRAINT [FK_Weld_Welder_welder]
ALTER TABLE [dbo].[Weld_Welder] ADD CONSTRAINT PK_WeldId_WelderId PRIMARY KEY CLUSTERED([weldId], [welderId])
ALTER TABLE [dbo].[InspectorCertificate]  WITH CHECK ADD  CONSTRAINT [FK_InspectorCertificate_Inspector] FOREIGN KEY([inspectorId])
REFERENCES [dbo].[Inspector] ([id])
ALTER TABLE [dbo].[InspectorCertificate] CHECK CONSTRAINT [FK_InspectorCertificate_Inspector]


/* ------ Inspector Certificate Type CONSTRAINT ------ */
ALTER TABLE [dbo].[InspectorCertificate]  WITH CHECK ADD  CONSTRAINT [FK_InspectorCertificate_InspectorCertificateType] FOREIGN KEY([inspectorCertificateTypeId])
REFERENCES [dbo].[InspectorCertificateType] ([id])
ALTER TABLE [dbo].[InspectorCertificate] CHECK CONSTRAINT [FK_InspectorCertificate_InspectorCertificateType]


CREATE TABLE [dbo].[Coat](
	[id] [uniqueidentifier] NOT NULL,
	[date] [DateTime] NOT NULL,
	[type] [nvarchar](20) NOT NULL,
	[pipeId] [uniqueidentifier] NOT NULL,
    [isActive] [tinyint] NOT NULL DEFAULT 1,
	CONSTRAINT [PK_Coat] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [Coat_Pipe_FK] FOREIGN KEY (pipeId) REFERENCES [dbo].[Pipe] (id)
) ON [PRIMARY]

/****** Object:  Table [dbo].[AuditLog]    Script Date: 11/27/2014 6:37:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[AuditLog](
	[id] [uniqueidentifier] NOT NULL,
	[entityID] [uniqueidentifier] NOT NULL,
	[auditDate] [datetime] NOT NULL,
	[userId] [uniqueidentifier] NULL,
	[tableName] [int] NULL,
	[fieldName] [int] NULL,
	[oldValue] [nvarchar](100) NULL,
	[newValue] [nvarchar](100) NULL,
	[ownerId] [uniqueidentifier] NULL,
	CONSTRAINT [PK_AuditLog] PRIMARY KEY NONCLUSTERED ([id]))
GO

IF EXISTS (SELECT name FROM sys.indexes
            WHERE name = N'IX_Audit_Date')
    DROP INDEX IX_Audit_Date ON [dbo].[AuditLog]
GO
CREATE NONCLUSTERED INDEX IX_Audit_Date
    ON [dbo].[AuditLog] ([auditDate])
GO

IF EXISTS (SELECT name FROM sys.indexes
            WHERE name = N'IX_Audit_User')
    DROP INDEX IX_Audit_User ON [dbo].[AuditLog]
GO
CREATE NONCLUSTERED INDEX IX_Audit_User
    ON [dbo].[AuditLog] ([userId])
GO

IF EXISTS (SELECT name FROM sys.indexes
            WHERE name = N'IX_Audit_Owner')
    DROP INDEX IX_Audit_Owner ON [dbo].[AuditLog]
GO
CREATE NONCLUSTERED INDEX IX_Audit_Owner
    ON [dbo].[AuditLog] ([ownerId])
GO

/*************** Security **********************************/

CREATE TABLE [dbo].[User] (
  [id] [uniqueidentifier] NOT NULL,
  [login] [nvarchar](30) NOT NULL,
  [password_hash] [nvarchar](512) NOT NULL,
  [password_expires] [DateTime],
  [firstName] [nvarchar](30) NULL,
  [lastName] [nvarchar](30) NULL,
  [middleName] [nvarchar](30) NULL,
  [isActive] [bit] NOT NULL,
  [undeletable] [bit] NOT NULL,
  PRIMARY KEY(id)
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[Role] (
  [id] [uniqueidentifier] NOT NULL,
  [name] [nvarchar](30) NOT NULL,
  [description] [nvarchar](255),
  PRIMARY KEY(id)
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[Permission] (
  [id] [uniqueidentifier] NOT NULL,
  [name] [nvarchar](50) NOT NULL,
  PRIMARY KEY(id)
);

CREATE TABLE [dbo].[User_Role] (
  [userId] [uniqueidentifier] NOT NULL,
  [roleId] [uniqueidentifier] NOT NULL,
  PRIMARY KEY (userId, roleId),
  CONSTRAINT USER_ROLE_USER_FK FOREIGN KEY ([userId]) REFERENCES [dbo].[User]([id]),
  CONSTRAINT USER_ROLE_ROLE_FK FOREIGN KEY ([roleId]) REFERENCES [dbo].[Role]([id])
);

CREATE TABLE [dbo].[Role_Permission] (
  [roleId] [uniqueidentifier] NOT NULL,
  [permissionId] [uniqueidentifier] NOT NULL,
  PRIMARY KEY (roleId, permissionId),
  CONSTRAINT ROLE_PERM_ROLE_FK FOREIGN KEY([roleId]) REFERENCES [dbo].[Role]([id]),
  CONSTRAINT ROLE_PERM_PERM_FK FOREIGN KEY([permissionId]) REFERENCES [dbo].[Permission]([id]),
);

CREATE TABLE [dbo].[Joint](
	[id] [uniqueidentifier] NOT NULL,
	[isActive] [bit] NOT NULL,
	[number] [nvarchar](20) NULL,
	[numberKP] [int] NULL,
	[distanceFromKP] [decimal] (10,2) NULL,
	[loweringDate] [date] NULL,
	[status] [nvarchar](20) NULL,
	[gpsLatitude] [decimal](12,8) NULL,
	[gpsLongitude] [decimal] (12,8) NULL,
	[gpsHeight] [float] NULL,
	[part1Id] [uniqueidentifier] NULL,
	[part1Type] [nvarchar](20) NULL,
	[part2Id] [uniqueidentifier] NULL,
	[part2Type] [nvarchar](20) NULL,
        [toExport] [bit] NOT NULL DEFAULT 0,
 CONSTRAINT [PK_Joint] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

IF EXISTS (SELECT name FROM sys.indexes
            WHERE name = N'IDX_Joint_Number')
    DROP INDEX IDX_Joint_Number ON [dbo].[Joint]
GO
CREATE NONCLUSTERED INDEX IDX_Joint_Number
    ON [dbo].[Joint] ([number])
GO

IF EXISTS (SELECT name FROM sys.indexes
            WHERE name = N'IDX_Joint_Date')
    DROP INDEX IDX_Joint_Date ON [dbo].[Joint]
GO
CREATE NONCLUSTERED INDEX IDX_Joint_Date
    ON [dbo].[Joint] ([loweringDate])
GO

CREATE TABLE [dbo].[JointTestResult](
	[id] [uniqueidentifier] NOT NULL,
	[isActive] [bit] NOT NULL,
	[date] [date] NULL,
	[value] [nvarchar](20) NULL,
	[status] [nvarchar](25) NULL,
	[order] [int] NULL,
	[jointOperationId] [uniqueidentifier] NOT NULL,
	[jointId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_JointTestResult] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[JointTestResult]  WITH CHECK ADD  CONSTRAINT [FK_JointTestResult_Joint] FOREIGN KEY([jointId])
REFERENCES [dbo].[Joint] ([id])
GO

ALTER TABLE [dbo].[JointTestResult] CHECK CONSTRAINT [FK_JointTestResult_Joint]
GO

ALTER TABLE [dbo].[JointTestResult]  WITH CHECK ADD  CONSTRAINT [FK_JointTestResult_JointOperation] FOREIGN KEY([jointOperationId])
REFERENCES [dbo].[JointOperation] ([id])
GO

ALTER TABLE [dbo].[JointTestResult] CHECK CONSTRAINT [FK_JointTestResult_JointOperation]
GO

CREATE TABLE [dbo].[JointWeldResult](
	[id] [uniqueidentifier] NOT NULL,
	[isActive] [bit] NOT NULL,
	[isCompleted] [bit] NULL,
	[date] [date] NULL,
	[jointOperationId] [uniqueidentifier] NOT NULL,
	[jointId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_JointWeldResult] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[JointWeldResult]  WITH CHECK ADD  CONSTRAINT [FK_JointWeldResult_Joint] FOREIGN KEY([jointId])
REFERENCES [dbo].[Joint] ([id])
GO

ALTER TABLE [dbo].[JointWeldResult] CHECK CONSTRAINT [FK_JointWeldResult_Joint]
GO

ALTER TABLE [dbo].[JointWeldResult]  WITH CHECK ADD  CONSTRAINT [FK_JointWeldResult_JointOperation] FOREIGN KEY([jointOperationId])
REFERENCES [dbo].[JointOperation] ([id])
GO

ALTER TABLE [dbo].[JointWeldResult] CHECK CONSTRAINT [FK_JointWeldResult_JointOperation]
GO

CREATE TABLE [dbo].[WeldResult_Welder](
	[welderId] [uniqueidentifier] NOT NULL,
	[resultId] [uniqueidentifier] NOT NULL
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[WeldResult_Welder]  WITH CHECK ADD  CONSTRAINT [FK_WeldResult_Welder_Result] FOREIGN KEY([resultId])
REFERENCES [dbo].[JointWeldResult] ([id])
GO

ALTER TABLE [dbo].[WeldResult_Welder] CHECK CONSTRAINT [FK_WeldResult_Welder_Result]
GO

ALTER TABLE [dbo].[WeldResult_Welder]  WITH CHECK ADD  CONSTRAINT [FK_WeldResult_Welder_Welder] FOREIGN KEY([welderId])
REFERENCES [dbo].[Welder] ([id])
GO

ALTER TABLE [dbo].[WeldResult_Welder] CHECK CONSTRAINT [FK_WeldResult_Welder_Welder]
GO

ALTER TABLE [dbo].[WeldResult_Welder] ADD CONSTRAINT PK_WeldResultId_WelderID PRIMARY KEY CLUSTERED ([welderId],[resultId])
GO

CREATE TABLE [dbo].[File](
	[id] [uniqueidentifier] NOT NULL,
	[isActive] [bit] NOT NULL,
	[fileName] [nvarchar](300) NOT NULL,
	[description] [nvarchar](100) NULL,
	[uploadDate] [date] NULL,
	[item] [uniqueidentifier] NOT NULL,
	[newName] [nvarchar](50) NULL,
 CONSTRAINT [PK_File] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[Portion] (
  [id] [uniqueidentifier] NOT NULL,
  [exportDateTime] [datetime] NOT NULL,
  [isExport] [bit] NOT NULL,
  [portionNumber] [int] NOT NULL,
  [projectId] [uniqueidentifier] NOT NULL,
CONSTRAINT [PK_Portion] PRIMARY KEY([id]),
CONSTRAINT [FK_Portion_Project] FOREIGN KEY ([projectId]) REFERENCES [dbo].[Project]([id])
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[Portion_Pipe] (
  [portionId] [uniqueidentifier] NOT NULL,
  [pipeId] [uniqueidentifier] NOT NULL,
CONSTRAINT [PK_Portion_Pipe] PRIMARY KEY([portionId],[pipeId]),
CONSTRAINT [FK_Portion_Pipe_Portion] FOREIGN KEY ([portionId]) REFERENCES [dbo].[Portion]([id]),
CONSTRAINT [FK_Portion_Pipe_Pipe] FOREIGN KEY ([pipeId]) REFERENCES [dbo].[Pipe]([id])
) ON [PRIMARY]
GO

--CREATE TABLE [dbo].[Portion_Project] (
--  [portionId] [uniqueidentifier] NOT NULL,
--  [projectId] [uniqueidentifier] NOT NULL,
--CONSTRAINT [PK_Portion_Project] PRIMARY KEY([portionId],[projectId]),
--CONSTRAINT [FK_Portion_Project_Portion] FOREIGN KEY ([portionId]) REFERENCES [dbo].[Portion]([id]),
--CONSTRAINT [FK_Portion_Project_Project] FOREIGN KEY ([projectId]) REFERENCES [dbo].[Project]([id])
--) ON [PRIMARY]

--GO

CREATE TABLE [dbo].[Portion_Joint] (
  [portionId] [uniqueidentifier] NOT NULL,
  [jointId] [uniqueidentifier] NOT NULL,
CONSTRAINT [PK_Portion_Joint] PRIMARY KEY([portionId],[jointId]),
CONSTRAINT [FK_Portion_Joint_Portion] FOREIGN KEY ([portionId]) REFERENCES [dbo].[Portion]([id]),
CONSTRAINT [FK_Portion_Joint_Joint] FOREIGN KEY ([jointId]) REFERENCES [dbo].[Joint]([id])
) ON [PRIMARY]


GO


CREATE TABLE [dbo].[Portion_Component] (
  [portionId] [uniqueidentifier] NOT NULL,
  [componentId] [uniqueidentifier] NOT NULL,
CONSTRAINT [PK_Portion_Component] PRIMARY KEY([portionId],[componentId]),
CONSTRAINT [FK_Portion_Component_Portion] FOREIGN KEY ([portionId]) REFERENCES [dbo].[Portion]([id]),
CONSTRAINT [FK_Portion_Component_Component] FOREIGN KEY ([componentId]) REFERENCES [dbo].[Component]([id])
) ON [PRIMARY]

GO
