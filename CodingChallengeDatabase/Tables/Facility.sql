CREATE TABLE [dbo].[Facility](
	[FacilityId] [int] IDENTITY(1,1) NOT NULL,
	[NPI] [varchar](10) NOT NULL,
	[PracticeName] [varchar](255) NOT NULL,
	[TIN] [varchar](11) NOT NULL,
	[PhoneNumber] [varchar](12) NOT NULL,
	[Address1] [varchar](55) NOT NULL,
	[Address2] [varchar](55) NULL,
	[City] [varchar](55) NOT NULL,
	[StateAbrev] [varchar](2) NOT NULL,
	[Term_DT] [datetime] NULL,
	[Created_DT] [datetime] NOT NULL,
	[CreatedBy] [varchar](255) NOT NULL,
	[Updated_DT] [datetime] NULL,
	[UpdatedBy] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[FacilityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UC_Fac_TIN] UNIQUE NONCLUSTERED 
(
	[TIN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Facility] ADD  CONSTRAINT [DF_Fac_Created_DT]  DEFAULT (getdate()) FOR [Created_DT]
GO

ALTER TABLE [dbo].[Facility] ADD  CONSTRAINT [DF_Fac_CreatedBy]  DEFAULT (user_name()) FOR [CreatedBy]
GO