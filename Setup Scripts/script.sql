-- Create the table

CREATE TABLE [dbo].[Person]
(
    [PersonID]      [INT]               NOT NULL IDENTITY(1,1),
    [Forenames]     [VARCHAR]   (100)   NOT NULL,
    [Surname]       [VARCHAR]   (100)   NOT NULL,
    [DateOfBirth]   [DATE]              NOT NULL
)
GO

-- Primary Key

ALTER TABLE [dbo].[Person]
ADD CONSTRAINT PK_PERSONID PRIMARY KEY ([PersonID])
GO

-- Inserts (so we have some test data to start with)

INSERT INTO [dbo].[Person] (Forenames, Surname, DateOfBirth, Notes) VALUES ('Omar', 'Ebrahim', '1980-03-01');
INSERT INTO [dbo].[Person] (Forenames, Surname, DateOfBirth, Notes) VALUES ('Mark', 'Wilson', '1990-01-05');
INSERT INTO [dbo].[Person] (Forenames, Surname, DateOfBirth, Notes) VALUES ('Jessie', 'Jones', '1986-09-11');
INSERT INTO [dbo].[Person] (Forenames, Surname, DateOfBirth, Notes) VALUES ('Monika', 'Jakubska', '1990-10-01');
