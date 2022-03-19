/****** Object:  Table [dbo].[CLASS]    Script Date: 3/19/2022 9:17:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLASS](
	[ID] [uniqueidentifier] NOT NULL,
	[CLASSNAME] [varchar](max) NULL,
	[IDTEACHER] [uniqueidentifier] NULL,
	[SCHOOLYEAR] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INFOR]    Script Date: 3/19/2022 9:17:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INFOR](
	[ID] [uniqueidentifier] NOT NULL,
	[FIRSTNAME] [nvarchar](max) NULL,
	[LASTNAME] [nvarchar](max) NULL,
	[SEX] [int] NULL,
	[DAYOFBIRTH] [smalldatetime] NULL,
	[ADDRESS] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LESSON]    Script Date: 3/19/2022 9:17:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LESSON](
	[ID] [uniqueidentifier] NOT NULL,
	[IDTEACHER] [uniqueidentifier] NOT NULL,
	[IDSUBJECT] [uniqueidentifier] NOT NULL,
	[IDCLASS] [uniqueidentifier] NOT NULL,
	[IDSCHEDULE] [uniqueidentifier] NOT NULL,
	[TIMESTART] [tinyint] NULL,
	[TIMEEND] [tinyint] NULL,
	[DAYOFW] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LIMIT]    Script Date: 3/19/2022 9:17:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LIMIT](
	[ID] [uniqueidentifier] NOT NULL,
	[NAME] [nvarchar](max) NULL,
	[MIN] [int] NULL,
	[MAX] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ROLESUBJECT]    Script Date: 3/19/2022 9:17:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ROLESUBJECT](
	[ID] [uniqueidentifier] NOT NULL,
	[ROLE] [nvarchar](max) NULL,
	[COE] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SCHEDULE]    Script Date: 3/19/2022 9:17:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SCHEDULE](
	[ID] [uniqueidentifier] NOT NULL,
	[DATEAPPLY] [smalldatetime] NULL,
	[SCHOOLYEAR] [int] NULL,
	[SEMESTER] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SCORE]    Script Date: 3/19/2022 9:17:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SCORE](
	[ID] [uniqueidentifier] NOT NULL,
	[IDSUBJECT] [uniqueidentifier] NULL,
	[IDSTUDENT] [uniqueidentifier] NULL,
	[SCORE] [float] NULL,
	[SCHOOLYEAR] [int] NULL,
	[SEMESTER] [int] NULL,
	[IDROLESUBJECT] [uniqueidentifier] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[STAFF]    Script Date: 3/19/2022 9:17:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STAFF](
	[ID] [uniqueidentifier] NOT NULL,
	[IDUSER] [uniqueidentifier] NULL,
	[IDSTAFFROLE] [uniqueidentifier] NULL,
	[IDINFOR] [uniqueidentifier] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[STAFFROLE]    Script Date: 3/19/2022 9:17:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STAFFROLE](
	[ID] [uniqueidentifier] NOT NULL,
	[ROLE] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[STUDENT]    Script Date: 3/19/2022 9:17:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STUDENT](
	[ID] [uniqueidentifier] NOT NULL,
	[FIRSTNAME] [nvarchar](max) NULL,
	[LASTNAME] [nvarchar](max) NULL,
	[SEX] [int] NULL,
	[DAYOFBIRTH] [smalldatetime] NULL,
	[ADDRESS] [nvarchar](max) NULL,
	[EMAIL] [varchar](max) NULL,
	[IDCLASS] [uniqueidentifier] NULL,
	[GRADE] [int] NULL,
	[EMAILPARENT] [varchar](max) NULL,
	[TEL] [int] NULL,
	[Status] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[STUDYING]    Script Date: 3/19/2022 9:17:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STUDYING](
	[IDCLASS] [uniqueidentifier] NOT NULL,
	[IDSTUDENT] [uniqueidentifier] NOT NULL,
	[SCHOOLYEAR] [int] NULL,
	[SEMESTER] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDCLASS] ASC,
	[IDSTUDENT] ASC,
	[SEMESTER] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SUBJECT]    Script Date: 3/19/2022 9:17:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SUBJECT](
	[Id] [uniqueidentifier] NOT NULL,
	[DisplayName] [nvarchar](max) NULL,
	[IDHEADTEACHER] [uniqueidentifier] NULL,
	[PASSSCORE] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TEACH]    Script Date: 3/19/2022 9:17:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TEACH](
	[IDSUBJECT] [uniqueidentifier] NOT NULL,
	[IDTEACHER] [uniqueidentifier] NOT NULL,
	[IDCLASS] [uniqueidentifier] NOT NULL,
	[SCHOOLYEAR] [int] NULL,
	[SEMESTER] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDSUBJECT] ASC,
	[IDTEACHER] ASC,
	[IDCLASS] ASC,
	[SEMESTER] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TEACHER]    Script Date: 3/19/2022 9:17:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TEACHER](
	[ID] [uniqueidentifier] NOT NULL,
	[IDUSER] [uniqueidentifier] NULL,
	[IDTEACHERROLE] [uniqueidentifier] NULL,
	[IDINFOR] [uniqueidentifier] NULL,
	[IDSUBJECT] [uniqueidentifier] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TEACHERROLE]    Script Date: 3/19/2022 9:17:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TEACHERROLE](
	[ID] [uniqueidentifier] NOT NULL,
	[ROLE] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TRANSCRIPT]    Script Date: 3/19/2022 9:17:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRANSCRIPT](
	[ID] [uniqueidentifier] NOT NULL,
	[SCHOOLYEAR] [int] NULL,
	[SEMESTER] [int] NULL,
	[IDSTUDENT] [uniqueidentifier] NULL,
	[CONDUCT] [nvarchar](max) NULL,
	[RANK] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USERROLE]    Script Date: 3/19/2022 9:17:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USERROLE](
	[ID] [uniqueidentifier] NOT NULL,
	[ROLE] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USERS]    Script Date: 3/19/2022 9:17:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USERS](
	[ID] [uniqueidentifier] NOT NULL,
	[USERNAME] [nvarchar](max) NULL,
	[PASSWORD] [nvarchar](max) NULL,
	[DISPLAYNAME] [nvarchar](max) NULL,
	[EMAIL] [nvarchar](max) NULL,
	[IDUSERROLE] [uniqueidentifier] NULL,
	[IDINFOR] [uniqueidentifier] NULL,
	[ISDELETED] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[INFOR] ([ID], [FIRSTNAME], [LASTNAME], [SEX], [DAYOFBIRTH], [ADDRESS]) VALUES (N'fe3ee1bf-9972-4a8b-9d35-062026da677f', N'Trần Văn', N'Hùng', 0, NULL, NULL)
INSERT [dbo].[INFOR] ([ID], [FIRSTNAME], [LASTNAME], [SEX], [DAYOFBIRTH], [ADDRESS]) VALUES (N'c29ee204-a7ce-421e-badb-3e2f36b98479', N'Trần Hải', N'Nam', 0, NULL, NULL)
INSERT [dbo].[INFOR] ([ID], [FIRSTNAME], [LASTNAME], [SEX], [DAYOFBIRTH], [ADDRESS]) VALUES (N'559290c6-4710-48ab-b973-4501a9ff99c6', N'Nguyễn Thị', N'Liễu', 1, NULL, NULL)
INSERT [dbo].[INFOR] ([ID], [FIRSTNAME], [LASTNAME], [SEX], [DAYOFBIRTH], [ADDRESS]) VALUES (N'db2cd6e7-5fee-4894-9517-83f4c335b0bb', N'Ngô Thị', N'Bưởi', 1, NULL, NULL)
INSERT [dbo].[INFOR] ([ID], [FIRSTNAME], [LASTNAME], [SEX], [DAYOFBIRTH], [ADDRESS]) VALUES (N'18795500-3db0-4a87-a9c3-ad2df696c586', N'Nguyễn Văn', N'Hải', 0, NULL, NULL)
INSERT [dbo].[INFOR] ([ID], [FIRSTNAME], [LASTNAME], [SEX], [DAYOFBIRTH], [ADDRESS]) VALUES (N'2aec9668-ef0e-436f-9693-b9f7625dad46', N'Bành Thị', N'Luyến', 1, NULL, NULL)
INSERT [dbo].[INFOR] ([ID], [FIRSTNAME], [LASTNAME], [SEX], [DAYOFBIRTH], [ADDRESS]) VALUES (N'0a82c2f2-09e0-4b61-ab6c-c5f709ecb68f', N'Nguyễn An', N'Ninh', 0, NULL, NULL)
GO
INSERT [dbo].[STAFF] ([ID], [IDUSER], [IDSTAFFROLE], [IDINFOR]) VALUES (N'6187738d-eb34-4075-bcba-80b2ce34123c', N'064f2bda-901a-456a-814a-d2a6400d13e4', N'5613f709-2e2b-4fea-9e7e-9714a246ec78', N'c29ee204-a7ce-421e-badb-3e2f36b98479')
INSERT [dbo].[STAFF] ([ID], [IDUSER], [IDSTAFFROLE], [IDINFOR]) VALUES (N'ad622284-0f8c-4230-a107-a587abfe33fd', N'741e95c8-d65d-46eb-94d7-161858e1b185', N'12579a19-ab90-4903-9271-b4a7fdc8233d', N'fe3ee1bf-9972-4a8b-9d35-062026da677f')
GO
INSERT [dbo].[STAFFROLE] ([ID], [ROLE]) VALUES (N'5613f709-2e2b-4fea-9e7e-9714a246ec78', N'None')
INSERT [dbo].[STAFFROLE] ([ID], [ROLE]) VALUES (N'12579a19-ab90-4903-9271-b4a7fdc8233d', N'Quản lý')
GO
INSERT [dbo].[TEACHER] ([ID], [IDUSER], [IDTEACHERROLE], [IDINFOR], [IDSUBJECT]) VALUES (N'b6286a60-a824-4d30-ad68-4fc0ed6fda69', N'e84dc7a6-dae5-4305-8e63-437ad92c6add', N'8a9127e1-e8b7-4d58-8595-de9df403be8c', N'18795500-3db0-4a87-a9c3-ad2df696c586', NULL)
INSERT [dbo].[TEACHER] ([ID], [IDUSER], [IDTEACHERROLE], [IDINFOR], [IDSUBJECT]) VALUES (N'8043e5c7-8493-4e68-921a-5814e8239ee9', N'e1488ace-dbb5-4397-8fb5-3133336b3485', N'7291b2be-fada-42bd-811c-e5aa9e20c88d', N'2aec9668-ef0e-436f-9693-b9f7625dad46', NULL)
INSERT [dbo].[TEACHER] ([ID], [IDUSER], [IDTEACHERROLE], [IDINFOR], [IDSUBJECT]) VALUES (N'40a78ea6-15d6-4eb5-ab7b-6bff84535f7a', N'091a101f-2704-4a25-83de-de4e8ba56532', N'03e74b72-f72b-4f0b-9a0e-3f06bbad3bdb', N'db2cd6e7-5fee-4894-9517-83f4c335b0bb', NULL)
INSERT [dbo].[TEACHER] ([ID], [IDUSER], [IDTEACHERROLE], [IDINFOR], [IDSUBJECT]) VALUES (N'b75ab383-27d0-4d90-bdb1-c4c7aa398d2b', N'8b29dbf6-9a29-45c4-8d62-d2ccfbbb52da', N'7eb757d0-5edb-45cf-8b29-1601783433aa', N'559290c6-4710-48ab-b973-4501a9ff99c6', NULL)
INSERT [dbo].[TEACHER] ([ID], [IDUSER], [IDTEACHERROLE], [IDINFOR], [IDSUBJECT]) VALUES (N'd9a23bf8-e717-4ad1-bec0-c8c75123e234', N'71a4f597-7c70-48f5-8120-cb5bc8ac09de', N'7291b2be-fada-42bd-811c-e5aa9e20c88d', N'0a82c2f2-09e0-4b61-ab6c-c5f709ecb68f', NULL)
GO
INSERT [dbo].[TEACHERROLE] ([ID], [ROLE]) VALUES (N'7eb757d0-5edb-45cf-8b29-1601783433aa', N'Phó hiệu trưởng')
INSERT [dbo].[TEACHERROLE] ([ID], [ROLE]) VALUES (N'03e74b72-f72b-4f0b-9a0e-3f06bbad3bdb', N'Trưởng bộ môn')
INSERT [dbo].[TEACHERROLE] ([ID], [ROLE]) VALUES (N'e063cad9-f9eb-40c1-9427-a18de4f1d971', N'None')
INSERT [dbo].[TEACHERROLE] ([ID], [ROLE]) VALUES (N'8a9127e1-e8b7-4d58-8595-de9df403be8c', N'Hiệu trưởng')
INSERT [dbo].[TEACHERROLE] ([ID], [ROLE]) VALUES (N'7291b2be-fada-42bd-811c-e5aa9e20c88d', N'Chủ nhiệm')
GO
INSERT [dbo].[USERROLE] ([ID], [ROLE]) VALUES (N'dba21384-f267-4602-8d34-4cec0d8d9498', N'Admin')
INSERT [dbo].[USERROLE] ([ID], [ROLE]) VALUES (N'23f24864-b3af-454f-8aee-6820d44f721c', N'Nhân viên')
INSERT [dbo].[USERROLE] ([ID], [ROLE]) VALUES (N'7f8bda4a-0e26-41b9-af72-6d081652fd85', N'Giáo viên')
GO
INSERT [dbo].[USERS] ([ID], [USERNAME], [PASSWORD], [DISPLAYNAME], [EMAIL], [IDUSERROLE], [IDINFOR], [ISDELETED]) VALUES (N'741e95c8-d65d-46eb-94d7-161858e1b185', N'quanly', N'quanly', N'Quản lý', NULL, N'23f24864-b3af-454f-8aee-6820d44f721c', N'fe3ee1bf-9972-4a8b-9d35-062026da677f', NULL)
INSERT [dbo].[USERS] ([ID], [USERNAME], [PASSWORD], [DISPLAYNAME], [EMAIL], [IDUSERROLE], [IDINFOR], [ISDELETED]) VALUES (N'e1488ace-dbb5-4397-8fb5-3133336b3485', N'chunhiem', N'chunhiem', N'Chủ Nhiệm', NULL, N'7f8bda4a-0e26-41b9-af72-6d081652fd85', N'2aec9668-ef0e-436f-9693-b9f7625dad46', 0)
INSERT [dbo].[USERS] ([ID], [USERNAME], [PASSWORD], [DISPLAYNAME], [EMAIL], [IDUSERROLE], [IDINFOR], [ISDELETED]) VALUES (N'e84dc7a6-dae5-4305-8e63-437ad92c6add', N'hieutruong', N'hieutruong', N'Hiệu Trưởng', NULL, N'7f8bda4a-0e26-41b9-af72-6d081652fd85', N'18795500-3db0-4a87-a9c3-ad2df696c586', 0)
INSERT [dbo].[USERS] ([ID], [USERNAME], [PASSWORD], [DISPLAYNAME], [EMAIL], [IDUSERROLE], [IDINFOR], [ISDELETED]) VALUES (N'3cec7fe6-3fa2-4c97-9530-ca42d898e748', N'admin', N'avpBws6TnZ8We7N2kD2Msg==', N'Qu?n tr? viên', N'admin@gmail.com', N'dba21384-f267-4602-8d34-4cec0d8d9498', NULL, 0)
INSERT [dbo].[USERS] ([ID], [USERNAME], [PASSWORD], [DISPLAYNAME], [EMAIL], [IDUSERROLE], [IDINFOR], [ISDELETED]) VALUES (N'71a4f597-7c70-48f5-8120-cb5bc8ac09de', N'chunhiem2', N'chunhiem2', N'Chủ Nhiệm', NULL, N'7f8bda4a-0e26-41b9-af72-6d081652fd85', N'0a82c2f2-09e0-4b61-ab6c-c5f709ecb68f', 0)
INSERT [dbo].[USERS] ([ID], [USERNAME], [PASSWORD], [DISPLAYNAME], [EMAIL], [IDUSERROLE], [IDINFOR], [ISDELETED]) VALUES (N'064f2bda-901a-456a-814a-d2a6400d13e4', N'nhanvien', N'nhanvien', N'Nhân Viên', NULL, N'23f24864-b3af-454f-8aee-6820d44f721c', N'c29ee204-a7ce-421e-badb-3e2f36b98479', NULL)
INSERT [dbo].[USERS] ([ID], [USERNAME], [PASSWORD], [DISPLAYNAME], [EMAIL], [IDUSERROLE], [IDINFOR], [ISDELETED]) VALUES (N'8b29dbf6-9a29-45c4-8d62-d2ccfbbb52da', N'phohieutruong', N'phohieutruong', N'Phó Hiệu Trưởng', NULL, N'7f8bda4a-0e26-41b9-af72-6d081652fd85', N'559290c6-4710-48ab-b973-4501a9ff99c6', 0)
INSERT [dbo].[USERS] ([ID], [USERNAME], [PASSWORD], [DISPLAYNAME], [EMAIL], [IDUSERROLE], [IDINFOR], [ISDELETED]) VALUES (N'091a101f-2704-4a25-83de-de4e8ba56532', N'truongbomon', N'truongbomon', N'Trưởng Bộ Môn', NULL, N'7f8bda4a-0e26-41b9-af72-6d081652fd85', N'db2cd6e7-5fee-4894-9517-83f4c335b0bb', 0)
GO
ALTER TABLE [dbo].[CLASS] ADD  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[INFOR] ADD  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[LESSON] ADD  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[LIMIT] ADD  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[ROLESUBJECT] ADD  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[SCHEDULE] ADD  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[SCORE] ADD  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[STAFF] ADD  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[STAFFROLE] ADD  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[STUDENT] ADD  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[STUDENT] ADD  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[SUBJECT] ADD  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[TEACHER] ADD  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[TEACHERROLE] ADD  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[TRANSCRIPT] ADD  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[USERROLE] ADD  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[USERS] ADD  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[CLASS]  WITH CHECK ADD FOREIGN KEY([IDTEACHER])
REFERENCES [dbo].[TEACHER] ([ID])
GO
ALTER TABLE [dbo].[LESSON]  WITH CHECK ADD FOREIGN KEY([IDCLASS])
REFERENCES [dbo].[CLASS] ([ID])
GO
ALTER TABLE [dbo].[LESSON]  WITH CHECK ADD FOREIGN KEY([IDSCHEDULE])
REFERENCES [dbo].[SCHEDULE] ([ID])
GO
ALTER TABLE [dbo].[LESSON]  WITH CHECK ADD FOREIGN KEY([IDSUBJECT])
REFERENCES [dbo].[SUBJECT] ([Id])
GO
ALTER TABLE [dbo].[LESSON]  WITH CHECK ADD FOREIGN KEY([IDTEACHER])
REFERENCES [dbo].[TEACHER] ([ID])
GO
ALTER TABLE [dbo].[SCORE]  WITH CHECK ADD FOREIGN KEY([IDROLESUBJECT])
REFERENCES [dbo].[ROLESUBJECT] ([ID])
GO
ALTER TABLE [dbo].[SCORE]  WITH CHECK ADD FOREIGN KEY([IDSTUDENT])
REFERENCES [dbo].[STUDENT] ([ID])
GO
ALTER TABLE [dbo].[SCORE]  WITH CHECK ADD FOREIGN KEY([IDSUBJECT])
REFERENCES [dbo].[SUBJECT] ([Id])
GO
ALTER TABLE [dbo].[STAFF]  WITH CHECK ADD FOREIGN KEY([IDINFOR])
REFERENCES [dbo].[INFOR] ([ID])
GO
ALTER TABLE [dbo].[STAFF]  WITH CHECK ADD FOREIGN KEY([IDSTAFFROLE])
REFERENCES [dbo].[STAFFROLE] ([ID])
GO
ALTER TABLE [dbo].[STAFF]  WITH CHECK ADD FOREIGN KEY([IDUSER])
REFERENCES [dbo].[USERS] ([ID])
GO
ALTER TABLE [dbo].[STUDENT]  WITH CHECK ADD FOREIGN KEY([IDCLASS])
REFERENCES [dbo].[CLASS] ([ID])
GO
ALTER TABLE [dbo].[STUDYING]  WITH CHECK ADD FOREIGN KEY([IDCLASS])
REFERENCES [dbo].[CLASS] ([ID])
GO
ALTER TABLE [dbo].[STUDYING]  WITH CHECK ADD FOREIGN KEY([IDSTUDENT])
REFERENCES [dbo].[STUDENT] ([ID])
GO
ALTER TABLE [dbo].[SUBJECT]  WITH CHECK ADD FOREIGN KEY([IDHEADTEACHER])
REFERENCES [dbo].[TEACHER] ([ID])
GO
ALTER TABLE [dbo].[TEACH]  WITH CHECK ADD FOREIGN KEY([IDCLASS])
REFERENCES [dbo].[CLASS] ([ID])
GO
ALTER TABLE [dbo].[TEACH]  WITH CHECK ADD FOREIGN KEY([IDSUBJECT])
REFERENCES [dbo].[SUBJECT] ([Id])
GO
ALTER TABLE [dbo].[TEACH]  WITH CHECK ADD FOREIGN KEY([IDTEACHER])
REFERENCES [dbo].[TEACHER] ([ID])
GO
ALTER TABLE [dbo].[TEACHER]  WITH CHECK ADD FOREIGN KEY([IDINFOR])
REFERENCES [dbo].[INFOR] ([ID])
GO
ALTER TABLE [dbo].[TEACHER]  WITH CHECK ADD FOREIGN KEY([IDTEACHERROLE])
REFERENCES [dbo].[TEACHERROLE] ([ID])
GO
ALTER TABLE [dbo].[TEACHER]  WITH CHECK ADD FOREIGN KEY([IDUSER])
REFERENCES [dbo].[USERS] ([ID])
GO
ALTER TABLE [dbo].[TRANSCRIPT]  WITH CHECK ADD FOREIGN KEY([IDSTUDENT])
REFERENCES [dbo].[STUDENT] ([ID])
GO
ALTER TABLE [dbo].[USERS]  WITH CHECK ADD FOREIGN KEY([IDINFOR])
REFERENCES [dbo].[INFOR] ([ID])
GO
ALTER TABLE [dbo].[USERS]  WITH CHECK ADD FOREIGN KEY([IDUSERROLE])
REFERENCES [dbo].[USERROLE] ([ID])
GO
ALTER TABLE [dbo].[LESSON]  WITH CHECK ADD CHECK  (([DAYOFW]>=(1) AND [DAYOFW]<=(7)))
GO
ALTER TABLE [dbo].[LESSON]  WITH CHECK ADD CHECK  (([TIMEEND]>=(1) AND [TIMEEND]<=(10)))
GO
ALTER TABLE [dbo].[LESSON]  WITH CHECK ADD CHECK  (([TIMESTART]>=(1) AND [TIMESTART]<=(10)))
GO
