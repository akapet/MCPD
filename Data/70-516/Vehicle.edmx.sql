
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 05/14/2012 19:01:45
-- Generated from EDMX file: D:\git\repository\mcpd\Data\70-516\Vehicle.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [VehicleRepairs];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_VehicleRepairs]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Repairs] DROP CONSTRAINT [FK_VehicleRepairs];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Vehicles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Vehicles];
GO
IF OBJECT_ID(N'[dbo].[Repairs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Repairs];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Vehicles'
CREATE TABLE [dbo].[Vehicles] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [VIN] nvarchar(17)  NOT NULL,
    [Make] nvarchar(20)  NOT NULL,
    [Model] nvarchar(20)  NOT NULL,
    [Year] int  NOT NULL
);
GO

-- Creating table 'Repairs'
CREATE TABLE [dbo].[Repairs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [VehicleId] int  NOT NULL,
    [Description] nvarchar(100)  NOT NULL,
    [Cost] decimal(18,0)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Vehicles'
ALTER TABLE [dbo].[Vehicles]
ADD CONSTRAINT [PK_Vehicles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Repairs'
ALTER TABLE [dbo].[Repairs]
ADD CONSTRAINT [PK_Repairs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [VehicleId] in table 'Repairs'
ALTER TABLE [dbo].[Repairs]
ADD CONSTRAINT [FK_VehicleRepairs]
    FOREIGN KEY ([VehicleId])
    REFERENCES [dbo].[Vehicles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VehicleRepairs'
CREATE INDEX [IX_FK_VehicleRepairs]
ON [dbo].[Repairs]
    ([VehicleId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------