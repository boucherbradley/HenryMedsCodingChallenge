CREATE TABLE [dbo].[PractitionerFacility](
	[PractitionerFacilityId] [int] IDENTITY(1,1) NOT NULL,
	[PractitionerId] [int] NOT NULL,
	[FacilityId] [int] NOT NULL,
	[Term_DT] [datetime] NULL,
	[Created_DT] [datetime] NOT NULL,
	[CreatedBy] [varchar](255) NOT NULL,
	[Updated_DT] [datetime] NULL,
	[UpdatedBy] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[PractitionerFacilityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UC_PracFac_Prac_To_Fac] UNIQUE NONCLUSTERED 
(
	[PractitionerId] ASC,
	[FacilityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PractitionerFacility] ADD  CONSTRAINT [DF_PracFac_Created_DT]  DEFAULT (getdate()) FOR [Created_DT]
GO

ALTER TABLE [dbo].[PractitionerFacility] ADD  CONSTRAINT [DF_PracFac_CreatedBy]  DEFAULT (user_name()) FOR [CreatedBy]
GO
