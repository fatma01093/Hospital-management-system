USE [master]
GO
CREATE DATABASE [hospital]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'hospital', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\hospital.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'hospital_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\hospital_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [hospital] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [hospital].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [hospital] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [hospital] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [hospital] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [hospital] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [hospital] SET ARITHABORT OFF 
GO
ALTER DATABASE [hospital] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [hospital] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [hospital] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [hospital] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [hospital] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [hospital] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [hospital] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [hospital] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [hospital] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [hospital] SET  DISABLE_BROKER 
GO
ALTER DATABASE [hospital] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [hospital] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [hospital] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [hospital] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [hospital] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [hospital] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [hospital] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [hospital] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [hospital] SET  MULTI_USER 
GO
ALTER DATABASE [hospital] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [hospital] SET DB_CHAINING OFF 
GO
ALTER DATABASE [hospital] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [hospital] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [hospital] SET DELAYED_DURABILITY = DISABLED 
GO
USE [hospital]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[admin_ID](
	[ID] [varchar](10) NOT NULL,
	[password] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[attendance](
	[category] [varchar](50) NOT NULL,
	[ID] [varchar](20) NULL,
	[LogInDate] [varchar](50) NULL,
	[LogInTime] [varchar](20) NULL,
	[LogOutTime] [varchar](20) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bill](
	[Bill_no] [numeric](20, 0) NOT NULL,
	[p_id] [char](6) NOT NULL,
	[Total_Amount] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Bill_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[doctor](
	[d_id] [char](6) NOT NULL,
	[d_name] [varchar](50) NOT NULL,
	[d_gender] [varchar](50) NOT NULL,
	[qualification] [varchar](50) NOT NULL,
	[salary] [numeric](10, 0) NOT NULL,
	[w_no] [varchar](20) NULL,
	[d_password] [nvarchar](50) NULL,
 CONSTRAINT [PK__doctor__D95F582BD93F9D4B] PRIMARY KEY CLUSTERED 
(
	[d_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DoctorRoom](
	[d_id] [char](6) NOT NULL,
	[room_no] [nvarchar](50) NULL,
 CONSTRAINT [PK__DoctorRo__D95F582BD6C91379] PRIMARY KEY CLUSTERED 
(
	[d_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Inpatient](
	[p_id] [char](6) NOT NULL,
	[p_name] [varchar](50) NOT NULL,
	[p_gender] [varchar](50) NOT NULL,
	[p_age] [varchar](50) NOT NULL,
	[BloodGroup] [varchar](20) NULL,
	[city] [varchar](50) NOT NULL,
	[country] [varchar](20) NOT NULL,
	[p_mobile] [varchar](20) NULL,
	[w_no] [varchar](20) NOT NULL,
	[admit_date] [varchar](50) NOT NULL,
	[room_no] [numeric](5, 0) NOT NULL,
	[Check_out_date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[p_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Inpatientbill](
	[Bill_no] [numeric](20, 0) NOT NULL,
	[p_id] [char](6) NOT NULL,
	[Total_Amount] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Bill_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[login](
	[User_name] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[patient](
	[p_id] [char](6) NOT NULL,
	[p_name] [varchar](50) NOT NULL,
	[p_gender] [varchar](50) NOT NULL,
	[p_age] [varchar](50) NOT NULL,
	[city] [varchar](50) NOT NULL,
	[country] [varchar](20) NOT NULL,
	[p_mobile] [varchar](20) NULL,
	[w_no] [varchar](20) NOT NULL,
	[d_id] [char](6) NOT NULL,
	[admit_date] [varchar](50) NOT NULL,
	[room_no] [nvarchar](50) NOT NULL,
	[Check_out_date] [datetime] NULL,
 CONSTRAINT [PK__patient__82E06B919280C01A] PRIMARY KEY CLUSTERED 
(
	[p_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[register](
	[Category] [varchar](50) NOT NULL,
	[Id] [varchar](10) NOT NULL,
	[First_name] [varchar](50) NOT NULL,
	[Last_name] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[passward] [varchar](50) NOT NULL,
 CONSTRAINT [PK__register__F3DBC5735B6EE842] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[room](
	[room_no] [nvarchar](50) NOT NULL,
	[room_type] [nvarchar](max) NOT NULL,
	[w_no] [nvarchar](max) NULL,
	[charge] [int] NOT NULL,
 CONSTRAINT [PK__room__1967F41903A9D18B] PRIMARY KEY CLUSTERED 
(
	[room_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[stuffs](
	[Stuff_Id] [varchar](10) NOT NULL,
	[Stuff_name] [varbinary](max) NOT NULL,
	[Stuff_password] [varbinary](max) NULL,
	[gender] [nvarchar](max) NULL,
	[qualifaction] [nvarchar](max) NULL,
	[salary] [nvarchar](max) NULL,
 CONSTRAINT [PK__stuffs__7FEDAF54D54E6AB9] PRIMARY KEY CLUSTERED 
(
	[Stuff_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[word](
	[w_no] [varchar](20) NOT NULL,
	[category] [varchar](50) NOT NULL,
	[buildig] [varchar](50) NOT NULL,
	[room_no] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__word__119885D0B553E8EB] PRIMARY KEY CLUSTERED 
(
	[w_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[admin_ID] ([ID], [password]) VALUES (N'1212', N'1234')
INSERT [dbo].[admin_ID] ([ID], [password]) VALUES (N'13142103', N' ')
INSERT [dbo].[attendance] ([category], [ID], [LogInDate], [LogInTime], [LogOutTime]) VALUES (N'Doctor', N'123456', N'14/02/2022', N'02:33:55', N'Null')
INSERT [dbo].[doctor] ([d_id], [d_name], [d_gender], [qualification], [salary], [w_no], [d_password]) VALUES (N'12    ', N'test', N'Male', N'MK', CAST(20000 AS Numeric(10, 0)), N'ACC', NULL)
INSERT [dbo].[DoctorRoom] ([d_id], [room_no]) VALUES (N'1111  ', N'12')
INSERT [dbo].[DoctorRoom] ([d_id], [room_no]) VALUES (N'12    ', N'102')
INSERT [dbo].[Inpatientbill] ([Bill_no], [p_id], [Total_Amount]) VALUES (CAST(1 AS Numeric(20, 0)), N'34    ', N'1100')
INSERT [dbo].[Inpatientbill] ([Bill_no], [p_id], [Total_Amount]) VALUES (CAST(2 AS Numeric(20, 0)), N'34    ', N'1100')
INSERT [dbo].[register] ([Category], [Id], [First_name], [Last_name], [Email], [username], [passward]) VALUES (N'Doctor', N'123456', N'ffdg', N'fg', N'sdfs', N'zz', N'1')
INSERT [dbo].[room] ([room_no], [room_type], [w_no], [charge]) VALUES (N'101', N'Normal', N'ICU       ', 1000)
INSERT [dbo].[room] ([room_no], [room_type], [w_no], [charge]) VALUES (N'102', N'AC', N'MAU       ', 500)
INSERT [dbo].[room] ([room_no], [room_type], [w_no], [charge]) VALUES (N'12', N'AC', N'ICU       ', 100)
INSERT [dbo].[room] ([room_no], [room_type], [w_no], [charge]) VALUES (N'203', N'AC', N'AMU       ', 1000)
INSERT [dbo].[room] ([room_no], [room_type], [w_no], [charge]) VALUES (N'88', N'Normal', N'children section', 500)
INSERT [dbo].[stuffs] ([Stuff_Id], [Stuff_name], [Stuff_password], [gender], [qualifaction], [salary]) VALUES (N'1', 0x7373, 0x313233, NULL, NULL, NULL)
INSERT [dbo].[word] ([w_no], [category], [buildig], [room_no]) VALUES (N'ACC', N'Accident', N'Watson', N'101')
ALTER TABLE [dbo].[bill]  WITH CHECK ADD  CONSTRAINT [FK__bill__p_id__239E4DCF] FOREIGN KEY([p_id])
REFERENCES [dbo].[patient] ([p_id])
GO
ALTER TABLE [dbo].[bill] CHECK CONSTRAINT [FK__bill__p_id__239E4DCF]
GO
ALTER TABLE [dbo].[doctor]  WITH CHECK ADD  CONSTRAINT [FK__doctor__w_no__164452B1] FOREIGN KEY([w_no])
REFERENCES [dbo].[word] ([w_no])
GO
ALTER TABLE [dbo].[doctor] CHECK CONSTRAINT [FK__doctor__w_no__164452B1]
GO
ALTER TABLE [dbo].[DoctorRoom]  WITH CHECK ADD  CONSTRAINT [FK__DoctorRoo__room___02FC7413] FOREIGN KEY([room_no])
REFERENCES [dbo].[room] ([room_no])
GO
ALTER TABLE [dbo].[DoctorRoom] CHECK CONSTRAINT [FK__DoctorRoo__room___02FC7413]
GO
ALTER TABLE [dbo].[DoctorRoom]  WITH CHECK ADD  CONSTRAINT [FK__DoctorRoom__d_id__02084FDA] FOREIGN KEY([d_id])
REFERENCES [dbo].[doctor] ([d_id])
GO
ALTER TABLE [dbo].[DoctorRoom] CHECK CONSTRAINT [FK__DoctorRoom__d_id__02084FDA]
GO
ALTER TABLE [dbo].[Inpatient]  WITH CHECK ADD  CONSTRAINT [FK__Inpatient__w_no__7C4F7684] FOREIGN KEY([w_no])
REFERENCES [dbo].[word] ([w_no])
GO
ALTER TABLE [dbo].[Inpatient] CHECK CONSTRAINT [FK__Inpatient__w_no__7C4F7684]
GO
ALTER TABLE [dbo].[Inpatientbill]  WITH CHECK ADD FOREIGN KEY([p_id])
REFERENCES [dbo].[Inpatient] ([p_id])
GO
ALTER TABLE [dbo].[patient]  WITH CHECK ADD  CONSTRAINT [FK__patient__d_id__1DE57479] FOREIGN KEY([d_id])
REFERENCES [dbo].[doctor] ([d_id])
GO
ALTER TABLE [dbo].[patient] CHECK CONSTRAINT [FK__patient__d_id__1DE57479]
GO
ALTER TABLE [dbo].[patient]  WITH CHECK ADD  CONSTRAINT [FK__patient__room_no__1BFD2C07] FOREIGN KEY([room_no])
REFERENCES [dbo].[room] ([room_no])
GO
ALTER TABLE [dbo].[patient] CHECK CONSTRAINT [FK__patient__room_no__1BFD2C07]
GO
ALTER TABLE [dbo].[patient]  WITH CHECK ADD  CONSTRAINT [FK__patient__w_no__1CF15040] FOREIGN KEY([w_no])
REFERENCES [dbo].[word] ([w_no])
GO
ALTER TABLE [dbo].[patient] CHECK CONSTRAINT [FK__patient__w_no__1CF15040]
GO
ALTER TABLE [dbo].[word]  WITH CHECK ADD  CONSTRAINT [FK__word__room_no__1367E606] FOREIGN KEY([room_no])
REFERENCES [dbo].[room] ([room_no])
GO
ALTER TABLE [dbo].[word] CHECK CONSTRAINT [FK__word__room_no__1367E606]
GO
USE [master]
GO
ALTER DATABASE [hospital] SET  READ_WRITE 
GO
