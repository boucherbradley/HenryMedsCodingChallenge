CREATE TABLE [dbo].[Appointment](
	[AppointmentId] [int] IDENTITY(1,1) NOT NULL,
	[AppointmentDate] [datetime] NOT NULL,
	[PractitionerId] [int] NOT NULL,
	[FacilityId] [int] NOT NULL,
	[PatientId] [int] NULL,
	[Available] [bit] NOT NULL,
	[Confirmed] [bit] NOT NULL,
	[Created_DT] [datetime] NOT NULL,
	[CreatedBy] [varchar](255) NOT NULL,
	[Updated_DT] [datetime] NULL,
	[UpdatedBy] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[AppointmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Appointment] ADD  DEFAULT ((1)) FOR [Available]
GO

ALTER TABLE [dbo].[Appointment] ADD  DEFAULT ((0)) FOR [Confirmed]
GO

ALTER TABLE [dbo].[Appointment] ADD  CONSTRAINT [DF_App_Created_DT]  DEFAULT (getdate()) FOR [Created_DT]
GO

ALTER TABLE [dbo].[Appointment] ADD  CONSTRAINT [DF_App_CreatedBy]  DEFAULT (user_name()) FOR [CreatedBy]
GO



