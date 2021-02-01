---
--- database name students_teachers
--- create tables
---
IF  NOT EXISTS (SELECT * FROM sys.objects 
WHERE object_id = OBJECT_ID(N'[dbo].[Student]') AND type in (N'U'))

BEGIN
CREATE TABLE [dbo].[Student] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [firstname] NVARCHAR (50) NOT NULL,
    [lastname]  NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

INSERT INTO [dbo].[Student] ([firstname], [lastname]) VALUES
	('david', 'john'),
	('rogers', 'paul'),
	('david', 'david'),
	('morris', 'maria'),
	('maria', 'morris');

	PRINT 'Students Table Added'
END
ELSE 
	PRINT 'Students Table Exists'

IF  NOT EXISTS (SELECT * FROM sys.objects 
WHERE object_id = OBJECT_ID(N'[dbo].[Teacher]') AND type in (N'U'))

BEGIN
CREATE TABLE [dbo].[Teacher] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [firstname] NVARCHAR (50) NOT NULL,
    [lastname]  NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

INSERT INTO [dbo].[Teacher] ([firstname], [lastname]) VALUES
	('sanders', 'daniel'),
	('daniel', 'sanders'),
	('daniel', 'mark'),
	('mark', 'morgan'),
	( 'paul', 'paul');
	PRINT 'Teachers Table Added'
END
ELSE 
	PRINT 'Teachers Table Exists'


--- for reference
SELECT TOP (1000) [Id]
        ,[firstname]
        ,[lastname]
    FROM [students_teachers].[dbo].[Student]