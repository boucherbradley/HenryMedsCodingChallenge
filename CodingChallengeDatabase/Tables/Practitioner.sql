CREATE TABLE [dbo].[Practitioner](
	[PractitionerId] [int] IDENTITY(1,1) NOT NULL,
	[NPI] [varchar](10) NOT NULL,
	[FirstName] [varchar](255) NOT NULL,
	[LastName] [varchar](255) NOT NULL,
	[SSN] [varchar](11) NOT NULL,
	[PhoneNumber] [varchar](12) NOT NULL,
	[Email] [varchar](255) NOT NULL,
	[Title] [varchar](55) NULL,
	[Sex] [varchar](55) NULL,
	[Term_DT] [datetime] NULL,
	[Created_DT] [datetime] NOT NULL,
	[CreatedBy] [varchar](255) NOT NULL,
	[Updated_DT] [datetime] NULL,
	[UpdatedBy] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[PractitionerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UC_Prac_SSN] UNIQUE NONCLUSTERED 
(
	[SSN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Practitioner] ADD  CONSTRAINT [DF_Prac_Created_DT]  DEFAULT (getdate()) FOR [Created_DT]
GO

ALTER TABLE [dbo].[Practitioner] ADD  CONSTRAINT [DF_Prac_CreatedBy]  DEFAULT (user_name()) FOR [CreatedBy]
GO

ALTER TABLE [dbo].[Practitioner]  WITH CHECK ADD  CONSTRAINT [Chk_Sex] CHECK  (([Sex]='Other' OR [Sex]='Non-Binary' OR [Sex]='F' OR [Sex]='M'))
GO

ALTER TABLE [dbo].[Practitioner] CHECK CONSTRAINT [Chk_Sex]
GO