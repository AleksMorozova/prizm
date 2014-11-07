DECLARE @PRIZMA_DB_NAME VARCHAR(255) = 'Prizm',
		@PRIZMA_DB_PATH VARCHAR (1000) =  CAST (SERVERPROPERTY('instancedefaultdatapath') AS varchar(1000))

DECLARE @CREATE_DB VARCHAR(MAX)

SET @CREATE_DB = 'CREATE DATABASE {DBNAME} CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = {DBNAME}, FILENAME = ''{DBPATH}{DBNAME}.mdf'' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = {DBNAME}_log, FILENAME = ''{DBPATH}{DBNAME}_log.ldf'' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
ALTER DATABASE {DBNAME} SET COMPATIBILITY_LEVEL = 110
IF (1 = FULLTEXTSERVICEPROPERTY(''IsFullTextInstalled''))
begin
EXEC [{DBNAME}].[dbo].[sp_fulltext_database] @action = ''enable''
end
ALTER DATABASE [{DBNAME}] SET ANSI_NULL_DEFAULT OFF 
ALTER DATABASE [{DBNAME}] SET ANSI_NULLS OFF 
ALTER DATABASE [{DBNAME}] SET ANSI_PADDING OFF 
ALTER DATABASE [{DBNAME}] SET ANSI_WARNINGS OFF 
ALTER DATABASE [{DBNAME}] SET ARITHABORT OFF 
ALTER DATABASE [{DBNAME}] SET AUTO_CLOSE OFF 
ALTER DATABASE [{DBNAME}] SET AUTO_CREATE_STATISTICS ON 
ALTER DATABASE [{DBNAME}] SET AUTO_SHRINK OFF 
ALTER DATABASE [{DBNAME}] SET AUTO_UPDATE_STATISTICS ON 
ALTER DATABASE [{DBNAME}] SET CURSOR_CLOSE_ON_COMMIT OFF 
ALTER DATABASE [{DBNAME}] SET CURSOR_DEFAULT  GLOBAL 
ALTER DATABASE [{DBNAME}] SET CONCAT_NULL_YIELDS_NULL OFF 
ALTER DATABASE [{DBNAME}] SET NUMERIC_ROUNDABORT OFF 
ALTER DATABASE [{DBNAME}] SET QUOTED_IDENTIFIER OFF 
ALTER DATABASE [{DBNAME}] SET RECURSIVE_TRIGGERS OFF 
ALTER DATABASE [{DBNAME}] SET  DISABLE_BROKER 
ALTER DATABASE [{DBNAME}] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
ALTER DATABASE [{DBNAME}] SET DATE_CORRELATION_OPTIMIZATION OFF 
ALTER DATABASE [{DBNAME}] SET TRUSTWORTHY OFF 
ALTER DATABASE [{DBNAME}] SET ALLOW_SNAPSHOT_ISOLATION OFF 
ALTER DATABASE [{DBNAME}] SET PARAMETERIZATION SIMPLE 
ALTER DATABASE [{DBNAME}] SET READ_COMMITTED_SNAPSHOT OFF 
ALTER DATABASE [{DBNAME}] SET HONOR_BROKER_PRIORITY OFF 
ALTER DATABASE [{DBNAME}] SET RECOVERY SIMPLE 
ALTER DATABASE [{DBNAME}] SET  MULTI_USER 
ALTER DATABASE [{DBNAME}] SET PAGE_VERIFY CHECKSUM  
ALTER DATABASE [{DBNAME}] SET DB_CHAINING OFF 
ALTER DATABASE [{DBNAME}] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
ALTER DATABASE [{DBNAME}] SET TARGET_RECOVERY_TIME = 0 SECONDS '

DECLARE @SQL_SCRIPT VARCHAR(MAX)
SET @SQL_SCRIPT = REPLACE(@CREATE_DB, '{DBNAME}', @PRIZMA_DB_NAME)
SET @SQL_SCRIPT = REPLACE(@SQL_SCRIPT, '{DBPATH}', @PRIZMA_DB_PATH)
EXECUTE (@SQL_SCRIPT)
GO

DECLARE @SQL_SCRIPT VARCHAR(MAX),
		@PRIZMA_DB_NAME VARCHAR(255) = 'Prizm'
SET @SQL_SCRIPT = 
'USE [{DBNAME}]
/****** Object:  Table [dbo].[chemicalComposition]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
CREATE TABLE [dbo].[chemicalComposition](
	[id] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chemicalComposition] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[heat]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[heat](
	[id] [uniqueidentifier] NOT NULL,
	[number] [varchar](20) NOT NULL,
	[steelGrade] [varchar](20) NULL,
	[manufacturerId] [uniqueidentifier] NOT NULL,
	[chemicalCompositionId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_heat] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_PADDING OFF
/****** Object:  Table [dbo].[inspector]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[inspector](
	[id] [uniqueidentifier] NOT NULL,
	[firstName] [varchar](20) NOT NULL,
	[lastName] [varchar](20) NOT NULL,
	[middleName] [varchar](20) NULL,
	[certificate] [varchar](20) NOT NULL,
	[certificateExpiration] [date] NULL,
 CONSTRAINT [PK_inspector] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_PADDING OFF
/****** Object:  Table [dbo].[pipe]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[pipe](
	[id] [uniqueidentifier] NOT NULL,
	[wallThickness] [int] NOT NULL,
	[diameter] [int] NOT NULL,
	[weight] [int] NOT NULL,
	[mill] [varchar](250) NOT NULL,
	[pipeMillStatus] [varchar](20) NULL,
	[typeId] [uniqueidentifier] NOT NULL,
	[plateId] [uniqueidentifier] NOT NULL,
	[purchaseOrderId] [uniqueidentifier] NOT NULL,
	[railcarId] [uniqueidentifier] NULL,
	[pipeLinePieceId] [uniqueidentifier] NOT NULL,
	[chemicalCompositionId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_pipe] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_PADDING OFF
/****** Object:  Table [dbo].[pipeLinePiece]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[pipeLinePiece](
	[id] [uniqueidentifier] NOT NULL,
	[length] [int] NOT NULL,
	[number] [varchar](20) NOT NULL,
	[isActive] [bit] NOT NULL,
	[inspectionStatus] [varchar](15) NULL,
	[constructionStatus] [varchar](15) NULL,
 CONSTRAINT [PK_pipeLinePiece] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_PADDING OFF
/****** Object:  Table [dbo].[pipeMillSizeType]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[pipeMillSizeType](
	[id] [uniqueidentifier] NOT NULL,
	[type] [varchar](50) NOT NULL,
 CONSTRAINT [PK_pipeMillSizeType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_PADDING OFF
/****** Object:  Table [dbo].[pipeTest]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[pipeTest](
	[id] [uniqueidentifier] NOT NULL,
	[code] [varchar](20) NOT NULL,
	[name] [varchar](20) NOT NULL,
	[testSubject] [varchar](50) NULL,
	[controlType] [nchar](15) NULL,
	[resultType] [varchar](10) NULL,
	[minExpected] [decimal](5, 2) NULL,
	[maxExpected] [decimal](5, 2) NULL,
	[boolExpected] [bit] NULL,
	[isRequired] [bit] NULL,
	[pipeMillSizeTypeId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_pipeTest] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_PADDING OFF
/****** Object:  Table [dbo].[pipeTestResult]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
CREATE TABLE [dbo].[pipeTestResult](
	[id] [uniqueidentifier] NOT NULL,
	[testResultId] [uniqueidentifier] NOT NULL,
	[pipeId] [uniqueidentifier] NOT NULL,
	[pipeTestId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_pipeTestResult] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[plate]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[plate](
	[id] [uniqueidentifier] NOT NULL,
	[number] [varchar](20) NOT NULL,
	[thickness] [int] NOT NULL,
	[chemicalCompositionId] [uniqueidentifier] NULL,
	[heatId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_plate] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_PADDING OFF
/****** Object:  Table [dbo].[purchaseOrder]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[purchaseOrder](
	[id] [uniqueidentifier]NOT NULL,
	[number] [varchar](20) NOT NULL,
	[date] [date] NULL,
 CONSTRAINT [PK_purchaseOrder] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
SET ANSI_PADDING OFF
/****** Object:  Table [dbo].[railcar]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[railcar](
	[id] [uniqueidentifier] NOT NULL,
	[number] [varchar](20) NOT NULL,
	[certificate] [varchar](20) NOT NULL,
	[destination] [varchar](50) NULL,
	[shipingDate] [date] NULL,
 CONSTRAINT [PK_railcar] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_PADDING OFF
/****** Object:  Table [dbo].[testResult]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[testResult](
	[id] [uniqueidentifier] NOT NULL,
	[date] [date] NOT NULL,
	[value] [varchar](25) NOT NULL,
	[status] [varchar](25) NULL,
 CONSTRAINT [PK_testResult] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_PADDING OFF
/****** Object:  Table [dbo].[testResult_inspector]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
CREATE TABLE [dbo].[testResult_inspector](
	[id] [uniqueidentifier] NOT NULL,
	[inspectorId] [uniqueidentifier] NOT NULL,
	[resultId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_testResult_inspector] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[weld]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
CREATE TABLE [dbo].[weld](
	[id] [uniqueidentifier] NOT NULL,
	[date] [date] NOT NULL,
CONSTRAINT [PK_weld] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[weld_welder]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
CREATE TABLE [dbo].[weld_welder](
	[id] [uniqueidentifier] NOT NULL,
	[weldId] [uniqueidentifier] NOT NULL,
	[welderId] [uniqueidentifier] NOT NULL,
	[pipeId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_weld_welder] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[welder]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[welder](
	[id] [uniqueidentifier] NOT NULL,
	[firstName] [varchar](20) NOT NULL,
	[lastName] [varchar](20) NOT NULL,
	[middleName] [varchar](20) NULL,
	[certificate] [varchar](20) NOT NULL,
	[certificateExpiration] [date] NULL,
	[stamp] [varchar](10) NULL,
	[grade] [int] NULL,
 CONSTRAINT [PK_welder] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
SET ANSI_PADDING OFF
ALTER TABLE [dbo].[heat]  WITH CHECK ADD  CONSTRAINT [FK_heat_chemicalComposition] FOREIGN KEY([chemicalCompositionId])
REFERENCES [dbo].[chemicalComposition] ([id])
ALTER TABLE [dbo].[heat] CHECK CONSTRAINT [FK_heat_chemicalComposition]
ALTER TABLE [dbo].[pipe]  WITH CHECK ADD  CONSTRAINT [FK_pipe_chemicalComposition] FOREIGN KEY([chemicalCompositionId])
REFERENCES [dbo].[chemicalComposition] ([id])
ALTER TABLE [dbo].[pipe] CHECK CONSTRAINT [FK_pipe_chemicalComposition]
ALTER TABLE [dbo].[pipe]  WITH CHECK ADD  CONSTRAINT [FK_pipe_pipeLinePiece] FOREIGN KEY([pipeLinePieceId])
REFERENCES [dbo].[pipeLinePiece] ([id])
ALTER TABLE [dbo].[pipe] CHECK CONSTRAINT [FK_pipe_pipeLinePiece]
ALTER TABLE [dbo].[pipe]  WITH CHECK ADD  CONSTRAINT [FK_pipe_pipeMillSizeType] FOREIGN KEY([typeId])
REFERENCES [dbo].[pipeMillSizeType] ([id])
ALTER TABLE [dbo].[pipe] CHECK CONSTRAINT [FK_pipe_pipeMillSizeType]
ALTER TABLE [dbo].[pipe]  WITH CHECK ADD  CONSTRAINT [FK_pipe_plate] FOREIGN KEY([plateId])
REFERENCES [dbo].[plate] ([id])
ALTER TABLE [dbo].[pipe] CHECK CONSTRAINT [FK_pipe_plate]
ALTER TABLE [dbo].[pipe]  WITH CHECK ADD  CONSTRAINT [FK_pipe_purchaseOrder] FOREIGN KEY([purchaseOrderId])
REFERENCES [dbo].[purchaseOrder] ([id])
ALTER TABLE [dbo].[pipe] CHECK CONSTRAINT [FK_pipe_purchaseOrder]
ALTER TABLE [dbo].[pipe]  WITH CHECK ADD  CONSTRAINT [FK_pipe_railcar] FOREIGN KEY([railcarId])
REFERENCES [dbo].[railcar] ([id])
ALTER TABLE [dbo].[pipe] CHECK CONSTRAINT [FK_pipe_railcar]
ALTER TABLE [dbo].[pipeTestResult]  WITH CHECK ADD  CONSTRAINT [FK_pipeTestResult_pipe] FOREIGN KEY([pipeId])
REFERENCES [dbo].[pipe] ([id])
ALTER TABLE [dbo].[pipeTestResult] CHECK CONSTRAINT [FK_pipeTestResult_pipe]
ALTER TABLE [dbo].[pipeTestResult]  WITH CHECK ADD  CONSTRAINT [FK_pipeTestResult_pipeTest] FOREIGN KEY([pipeTestId])
REFERENCES [dbo].[pipeTest] ([id])
ALTER TABLE [dbo].[pipeTestResult] CHECK CONSTRAINT [FK_pipeTestResult_pipeTest]
ALTER TABLE [dbo].[pipeTestResult]  WITH CHECK ADD  CONSTRAINT [FK_pipeTestResult_testResult] FOREIGN KEY([testResultId])
REFERENCES [dbo].[testResult] ([id])
ALTER TABLE [dbo].[pipeTestResult] CHECK CONSTRAINT [FK_pipeTestResult_testResult]
ALTER TABLE [dbo].[plate]  WITH CHECK ADD  CONSTRAINT [FK_plate_chemicalComposition] FOREIGN KEY([chemicalCompositionId])
REFERENCES [dbo].[chemicalComposition] ([id])
ALTER TABLE [dbo].[plate] CHECK CONSTRAINT [FK_plate_chemicalComposition]
ALTER TABLE [dbo].[plate]  WITH CHECK ADD  CONSTRAINT [FK_plate_heat] FOREIGN KEY([heatId])
REFERENCES [dbo].[heat] ([id])
ALTER TABLE [dbo].[plate] CHECK CONSTRAINT [FK_plate_heat]
ALTER TABLE [dbo].[testResult_inspector]  WITH CHECK ADD  CONSTRAINT [FK_testResult_inspector_inspector] FOREIGN KEY([inspectorId])
REFERENCES [dbo].[inspector] ([id])
ALTER TABLE [dbo].[testResult_inspector] CHECK CONSTRAINT [FK_testResult_inspector_inspector]
ALTER TABLE [dbo].[testResult_inspector]  WITH CHECK ADD  CONSTRAINT [FK_testResult_inspector_testResult] FOREIGN KEY([resultId])
REFERENCES [dbo].[testResult] ([id])
ALTER TABLE [dbo].[testResult_inspector] CHECK CONSTRAINT [FK_testResult_inspector_testResult]
ALTER TABLE [dbo].[weld_welder]  WITH CHECK ADD  CONSTRAINT [FK_weld_welder_pipe] FOREIGN KEY([pipeId])
REFERENCES [dbo].[pipe] ([id])
ALTER TABLE [dbo].[weld_welder] CHECK CONSTRAINT [FK_weld_welder_pipe]
ALTER TABLE [dbo].[weld_welder]  WITH CHECK ADD  CONSTRAINT [FK_weld_welder_weld] FOREIGN KEY([weldId])
REFERENCES [dbo].[weld] ([id])
ALTER TABLE [dbo].[weld_welder] CHECK CONSTRAINT [FK_weld_welder_weld]
ALTER TABLE [dbo].[weld_welder]  WITH CHECK ADD  CONSTRAINT [FK_weld_welder_welder] FOREIGN KEY([welderId])
REFERENCES [dbo].[welder] ([id])
ALTER TABLE [dbo].[weld_welder] CHECK CONSTRAINT [FK_weld_welder_welder]
USE [master]
ALTER DATABASE [{DBNAME}] SET  READ_WRITE '
SET @SQL_SCRIPT = REPLACE(@SQL_SCRIPT, '{DBNAME}', @PRIZMA_DB_NAME)
EXECUTE (@SQL_SCRIPT)
