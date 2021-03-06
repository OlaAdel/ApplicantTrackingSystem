USE [master]
GO
/****** Object:  Database [ApplicantTrackingSystem]    Script Date: 5/8/2019 11:17:07 AM ******/
CREATE DATABASE [ApplicantTrackingSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ApplicantTrackingSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLSERVER\MSSQL\DATA\ApplicantTrackingSystem.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ApplicantTrackingSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLSERVER\MSSQL\DATA\ApplicantTrackingSystem_log.ldf' , SIZE = 1280KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ApplicantTrackingSystem] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ApplicantTrackingSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ApplicantTrackingSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ApplicantTrackingSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ApplicantTrackingSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ApplicantTrackingSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ApplicantTrackingSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [ApplicantTrackingSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ApplicantTrackingSystem] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [ApplicantTrackingSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ApplicantTrackingSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ApplicantTrackingSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ApplicantTrackingSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ApplicantTrackingSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ApplicantTrackingSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ApplicantTrackingSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ApplicantTrackingSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ApplicantTrackingSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ApplicantTrackingSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ApplicantTrackingSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ApplicantTrackingSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ApplicantTrackingSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ApplicantTrackingSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ApplicantTrackingSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ApplicantTrackingSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ApplicantTrackingSystem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ApplicantTrackingSystem] SET  MULTI_USER 
GO
ALTER DATABASE [ApplicantTrackingSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ApplicantTrackingSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ApplicantTrackingSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ApplicantTrackingSystem] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [ApplicantTrackingSystem]
GO
/****** Object:  Table [dbo].[Application]    Script Date: 5/8/2019 11:17:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Application](
	[CandidateUsername] [nvarchar](50) NOT NULL,
	[JobID] [int] NOT NULL,
	[Status] [nvarchar](50) NOT NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Application] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Candidate]    Script Date: 5/8/2019 11:17:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Candidate](
	[Username] [nvarchar](50) NOT NULL,
	[Mail] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Resume] [varbinary](max) NULL,
 CONSTRAINT [PK_Candidate] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CareerInterests]    Script Date: 5/8/2019 11:17:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CareerInterests](
	[Username] [nvarchar](50) NOT NULL,
	[CareerLevel] [nvarchar](50) NOT NULL,
	[ExperienceYears] [int] NOT NULL,
	[EducationLevel] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_CareerInterests] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Company]    Script Date: 5/8/2019 11:17:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Company](
	[Mail] [nvarchar](50) NOT NULL,
	[CompanyName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED 
(
	[CompanyName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ExperienceWork]    Script Date: 5/8/2019 11:17:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExperienceWork](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ExperienceType] [nvarchar](50) NOT NULL,
	[JobTitle] [nvarchar](50) NOT NULL,
	[JobRole] [nvarchar](50) NOT NULL,
	[CompanyName] [nvarchar](50) NOT NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ExperienceWork_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Job]    Script Date: 5/8/2019 11:17:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](50) NOT NULL,
	[ExperienceYears] [int] NOT NULL,
	[PostDate] [date] NOT NULL,
	[CareerLevel] [nvarchar](50) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
	[Vacancies] [int] NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Requirements] [nvarchar](max) NOT NULL,
	[Role] [nvarchar](50) NOT NULL,
	[JobTitle] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Job] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PersonalInformation]    Script Date: 5/8/2019 11:17:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonalInformation](
	[Username] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Birthdate] [date] NOT NULL,
	[Country] [nvarchar](50) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[Area] [nvarchar](50) NOT NULL,
	[MobileNumber] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PersonalInformation] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Skill]    Script Date: 5/8/2019 11:17:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Skill](
	[Username] [nvarchar](50) NOT NULL,
	[SkillName] [nvarchar](50) NOT NULL,
	[Proficiency] [int] NOT NULL,
	[Interest] [int] NOT NULL,
	[ExperienceYears] [int] NOT NULL,
	[SkillID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Skill] PRIMARY KEY CLUSTERED 
(
	[SkillID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Index [IX_ExperienceWork]    Script Date: 5/8/2019 11:17:07 AM ******/
CREATE NONCLUSTERED INDEX [IX_ExperienceWork] ON [dbo].[ExperienceWork]
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Application]  WITH CHECK ADD  CONSTRAINT [FK_Application_Candidate] FOREIGN KEY([CandidateUsername])
REFERENCES [dbo].[Candidate] ([Username])
GO
ALTER TABLE [dbo].[Application] CHECK CONSTRAINT [FK_Application_Candidate]
GO
ALTER TABLE [dbo].[Application]  WITH CHECK ADD  CONSTRAINT [FK_Application_Job] FOREIGN KEY([JobID])
REFERENCES [dbo].[Job] ([ID])
GO
ALTER TABLE [dbo].[Application] CHECK CONSTRAINT [FK_Application_Job]
GO
ALTER TABLE [dbo].[CareerInterests]  WITH CHECK ADD  CONSTRAINT [FK_CareerInterests_Candidate] FOREIGN KEY([Username])
REFERENCES [dbo].[Candidate] ([Username])
GO
ALTER TABLE [dbo].[CareerInterests] CHECK CONSTRAINT [FK_CareerInterests_Candidate]
GO
ALTER TABLE [dbo].[ExperienceWork]  WITH CHECK ADD  CONSTRAINT [FK_ExperienceWork_Candidate1] FOREIGN KEY([Username])
REFERENCES [dbo].[Candidate] ([Username])
GO
ALTER TABLE [dbo].[ExperienceWork] CHECK CONSTRAINT [FK_ExperienceWork_Candidate1]
GO
ALTER TABLE [dbo].[Job]  WITH CHECK ADD  CONSTRAINT [FK_Job_Company] FOREIGN KEY([CompanyName])
REFERENCES [dbo].[Company] ([CompanyName])
GO
ALTER TABLE [dbo].[Job] CHECK CONSTRAINT [FK_Job_Company]
GO
ALTER TABLE [dbo].[PersonalInformation]  WITH CHECK ADD  CONSTRAINT [FK_PersonalInformation_Candidate] FOREIGN KEY([Username])
REFERENCES [dbo].[Candidate] ([Username])
GO
ALTER TABLE [dbo].[PersonalInformation] CHECK CONSTRAINT [FK_PersonalInformation_Candidate]
GO
ALTER TABLE [dbo].[Skill]  WITH CHECK ADD  CONSTRAINT [FK_Skill_Candidate] FOREIGN KEY([Username])
REFERENCES [dbo].[Candidate] ([Username])
GO
ALTER TABLE [dbo].[Skill] CHECK CONSTRAINT [FK_Skill_Candidate]
GO
USE [master]
GO
ALTER DATABASE [ApplicantTrackingSystem] SET  READ_WRITE 
GO
