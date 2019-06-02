-- Create the table

CREATE TABLE [dbo].[Persons]
(
    [PersonID]      [INT]               NOT NULL IDENTITY(1,1),
    [Forenames]     [VARCHAR]   (100)   NOT NULL,
    [Surname]       [VARCHAR]   (100)   NOT NULL,
    [DateOfBirth]   [DATE]              NOT NULL
)
GO

-- Primary Key

ALTER TABLE [dbo].[Persons]
ADD CONSTRAINT PK_PERSONID PRIMARY KEY ([PersonID])
GO

-- Inserts (so we have some test data to start with)

INSERT INTO [dbo].[Persons] (Forenames, Surname, DateOfBirth) VALUES ('Omar', 'Ebrahim', '1980-03-01');
INSERT INTO [dbo].[Persons] (Forenames, Surname, DateOfBirth) VALUES ('Mark', 'Wilson', '1990-01-05');
INSERT INTO [dbo].[Persons] (Forenames, Surname, DateOfBirth) VALUES ('Jessie', 'Jones', '1986-09-11');
INSERT INTO [dbo].[Persons] (Forenames, Surname, DateOfBirth) VALUES ('Monika', 'Jakubska', '1990-10-01');
