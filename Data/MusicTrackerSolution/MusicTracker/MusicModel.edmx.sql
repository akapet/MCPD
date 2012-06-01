
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 05/31/2012 18:28:59
-- Generated from EDMX file: D:\git\repository\mcpd\Data\MusicTrackerSolution\MusicTracker\MusicModel.edmx
-- --------------------------------------------------




IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');


-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Albums'
CREATE TABLE [dbo].[Albums] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);


-- Creating table 'Songs'
CREATE TABLE [dbo].[Songs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Album_Id] int  NULL
);


-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Albums'
ALTER TABLE [dbo].[Albums]
ADD CONSTRAINT [PK_Albums]
    PRIMARY KEY CLUSTERED ([Id] ASC);


-- Creating primary key on [Id] in table 'Songs'
ALTER TABLE [dbo].[Songs]
ADD CONSTRAINT [PK_Songs]
    PRIMARY KEY CLUSTERED ([Id] ASC);


-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Album_Id] in table 'Songs'
ALTER TABLE [dbo].[Songs]
ADD CONSTRAINT [FK_AlbumSong]
    FOREIGN KEY ([Album_Id])
    REFERENCES [dbo].[Albums]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AlbumSong'
CREATE INDEX [IX_FK_AlbumSong]
ON [dbo].[Songs]
    ([Album_Id]);


-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------