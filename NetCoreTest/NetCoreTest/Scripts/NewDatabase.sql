CREATE DATABASE [DatabasePhones];
GO

USE [DatabasePhones];
GO

CREATE TABLE [dbo].[PhoneBook] (
    [Id]               INT           IDENTITY (1, 1) NOT NULL,
    [PERSON]           NVARCHAR (50) NULL,
    [TELEPHONE_NUMBER] NCHAR (10)    NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO

INSERT INTO dbo.PhoneBook(PERSON,TELEPHONE_NUMBER)
values ('Emilia Emil','123456789');
INSERT INTO dbo.PhoneBook(PERSON,TELEPHONE_NUMBER)
values ('Sebek Emil','921344512');
INSERT INTO dbo.PhoneBook(PERSON,TELEPHONE_NUMBER)
values ('Pioterek Sebek','123487654');
INSERT INTO dbo.PhoneBook(PERSON,TELEPHONE_NUMBER)
values ('Armin Van Buren','565567656');
GO
