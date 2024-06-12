CREATE TABLE [dbo].[Client](
	[ClientId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](255) NOT NULL,
	[LastName] [varchar](255) NOT NULL,
	[PhoneNumber] [varchar](12) NOT NULL,
	[Email] [varchar](255) NOT NULL,
	[Birth_DT] [datetime] NOT NULL,
	[Sex] [varchar](55) NULL,
	[Created_DT] [datetime] NOT NULL,
	[CreatedBy] [varchar](255) NOT NULL,
	[Updated_DT] [datetime] NULL,
	[UpdatedBy] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ClientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_Created_DT]  DEFAULT (getdate()) FOR [Created_DT]
GO

ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_CreatedBy]  DEFAULT (user_name()) FOR [CreatedBy]
GO

ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [Chk_Client_Sex] CHECK  (([Sex]='Other' OR [Sex]='Non-Binary' OR [Sex]='F' OR [Sex]='M'))
GO

ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [Chk_Client_Sex]
GO


