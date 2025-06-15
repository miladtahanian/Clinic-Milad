CREATE TABLE [dbo].[Patients](
	[PatientID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](100) NOT NULL,
	[BirthDate] [nvarchar](50) NULL,
	[PhoneNumber] [nvarchar](20) NULL,
	[Address] [nvarchar](255) NULL,
 CONSTRAINT [PK__Patients__970EC34668226AC5] PRIMARY KEY CLUSTERED 
(
	[PatientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prescriptions]    Script Date: 09/06/2025 19:51:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prescriptions](
	[PrescriptionID] [int] IDENTITY(1,1) NOT NULL,
	[PatientID] [int] NULL,
	[DoctorID] [int] NULL,
	[PrescriptionText] [nvarchar](max) NULL,
	[DateCreated] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[PrescriptionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 09/06/2025 19:51:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Role] [nvarchar](20) NOT NULL,
	[FullName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__Users__1788CCAC93BB0C27] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Prescriptions] ADD  DEFAULT (getdate()) FOR [DateCreated]
GO
ALTER TABLE [dbo].[Prescriptions]  WITH CHECK ADD  CONSTRAINT [FK__Prescript__Docto__3C69FB99] FOREIGN KEY([DoctorID])
REFERENCES [dbo].[Users] ([UserID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Prescriptions] CHECK CONSTRAINT [FK__Prescript__Docto__3C69FB99]
GO
ALTER TABLE [dbo].[Prescriptions]  WITH CHECK ADD  CONSTRAINT [FK__Prescript__Patie__3B75D760] FOREIGN KEY([PatientID])
REFERENCES [dbo].[Patients] ([PatientID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Prescriptions] CHECK CONSTRAINT [FK__Prescript__Patie__3B75D760]
GO
USE [master]
GO
ALTER DATABASE [ClinicPezeshki] SET  READ_WRITE 
GO
