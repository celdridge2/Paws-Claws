CREATE TABLE [dbo].[Pet] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX) NOT NULL,
    [AtShelter]   NVARCHAR (MAX) NOT NULL,
    [Species]     NVARCHAR (MAX) NOT NULL,
    [Breed]       NVARCHAR (MAX) NOT NULL,
    [Sex]         NVARCHAR (MAX) NOT NULL,
    [Size]        NVARCHAR (MAX) NOT NULL,
    [Spay_Neuter] NVARCHAR (MAX) NOT NULL,
    [ShotsUTD]    NVARCHAR (MAX) NOT NULL,
    [Color]       NVARCHAR (MAX) NOT NULL,
    [FurLength]   NVARCHAR (MAX) NOT NULL,
    [DateOfBirth] DATETIME2 (7)  NOT NULL,
    [Age]         INT            NOT NULL,
    [Description] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Pet] PRIMARY KEY CLUSTERED ([ID] ASC),
	CHECK ([Spay_Neuter] = 'Yes' OR [Spay_Neuter] = 'No' OR [Spay_Neuter] = 'yes' OR [Spay_Neuter] = 'no' OR [Spay_Neuter] = 'YES' OR [Spay_Neuter] = 'NO'),
	CHECK ([ShotsUTD] = 'Yes' OR [ShotsUTD] = 'No' OR [ShotsUTD] = 'yes' OR [ShotsUTD] = 'no' OR [ShotsUTD] = 'YES' OR [ShotsUTD] = 'NO')
);

