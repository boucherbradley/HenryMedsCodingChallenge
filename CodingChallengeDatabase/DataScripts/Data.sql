TRUNCATE TABLE [HenryMedsCodingChallenge].[dbo].[Practitioner]
TRUNCATE TABLE [HenryMedsCodingChallenge].[dbo].[Facility] 
TRUNCATE TABLE [HenryMedsCodingChallenge].[dbo].[PractitionerFacility]
TRUNCATE TABLE [HenryMedsCodingChallenge].[dbo].[Client]


INSERT INTO [HenryMedsCodingChallenge].[dbo].[Practitioner] (NPI, FirstName, LastName, SSN, PhoneNumber, Email, Title, Sex, Term_DT)
VALUES ('1111111111', 'John', 'Conner', '505-89-4562', '213-818-7845', 'JohnConner@gmail.com', NULL, 'M', NULL)
, ('2222222222', 'Sarah', 'Conner', '909-23-7524', '213-202-9823', 'SarahConner@gmail.com', NULL, 'F', NULL)
GO

INSERT INTO [HenryMedsCodingChallenge].[dbo].[Facility] (NPI, PracticeName, TIN, PhoneNumber, Address1, Address2, City, StateAbrev, Term_DT)
VALUES ('3333333333', 'Los Angeles Pediatric''s', '888-78-6548', '213-818-7845', '708 S Lakeview Rd', NULL, 'Los Angeles', 'CA', NULL)
GO


INSERT INTO [HenryMedsCodingChallenge].[dbo].[PractitionerFacility] (PractitionerId, FacilityId, Term_DT)
VALUES (1, 1, NULL)
, (2, 1, NULL)
GO

INSERT INTO [HenryMedsCodingChallenge].[dbo].[Client] (FirstName, LastName, PhoneNumber, Email, Birth_DT, Sex)
VALUES ('Baby', 'T-800', '756-456-3589', 'BabyMachine@gmail.com', DATEADD(YEAR, -2, GETDATE()), 'Other')
GO