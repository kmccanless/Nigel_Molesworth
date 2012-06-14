/****** Object:  Table [dbo].[okpi]    Script Date: 06/08/2012 10:00:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[okpi]') AND type in (N'U'))
DROP TABLE [dbo].[okpi]
GO

/****** Object:  Table [dbo].[kpir]    Script Date: 06/08/2012 10:00:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[kpir]') AND type in (N'U'))
DROP TABLE [dbo].[kpir]
GO

/****** Object:  Table [dbo].[kpit]    Script Date: 06/08/2012 10:01:16 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[kpit]') AND type in (N'U'))
DROP TABLE [dbo].[kpit]
GO

/****** Object:  Table [dbo].[kpis]    Script Date: 06/08/2012 10:01:32 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[kpis]') AND type in (N'U'))
DROP TABLE [dbo].[kpis]
GO

/****** Object:  Table [dbo].[usnm]    Script Date: 06/08/2012 10:02:01 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usnm]') AND type in (N'U'))
DROP TABLE [dbo].[usnm]
GO

/****** Object:  Table [dbo].[plnt]    Script Date: 06/08/2012 10:17:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[plnt]') AND type in (N'U'))
DROP TABLE [dbo].[plnt]
GO
