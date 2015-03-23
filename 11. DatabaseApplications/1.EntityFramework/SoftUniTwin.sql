
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/07/2015 15:48:13
-- Generated from EDMX file: D:\SkyDrive\Cloud\SoftUni\SoftUniHomeworks\11. DatabaseApplications\1. EntityFramework\SoftUniSystem\SoftUniDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
CREATE DATABASE [SoftUniTwin];
GO
USE [SoftUniTwin];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Addresses_Towns]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Addresses] DROP CONSTRAINT [FK_Addresses_Towns];
GO
IF OBJECT_ID(N'[dbo].[FK_Departments_Employees]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Departments] DROP CONSTRAINT [FK_Departments_Employees];
GO
IF OBJECT_ID(N'[dbo].[FK_Employees_Addresses]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employees] DROP CONSTRAINT [FK_Employees_Addresses];
GO
IF OBJECT_ID(N'[dbo].[FK_Employees_Departments]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employees] DROP CONSTRAINT [FK_Employees_Departments];
GO
IF OBJECT_ID(N'[dbo].[FK_Employees_Employees]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employees] DROP CONSTRAINT [FK_Employees_Employees];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeesProjects_Employees]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmployeesProjects] DROP CONSTRAINT [FK_EmployeesProjects_Employees];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeesProjects_Projects]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmployeesProjects] DROP CONSTRAINT [FK_EmployeesProjects_Projects];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Addresses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Addresses];
GO
IF OBJECT_ID(N'[dbo].[Departments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Departments];
GO
IF OBJECT_ID(N'[dbo].[Employees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employees];
GO
IF OBJECT_ID(N'[dbo].[EmployeesProjects]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmployeesProjects];
GO
IF OBJECT_ID(N'[dbo].[Projects]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Projects];
GO
IF OBJECT_ID(N'[dbo].[Towns]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Towns];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Addresses'
CREATE TABLE [dbo].[Addresses] (
    [AddressID] int IDENTITY(1,1) NOT NULL,
    [AddressText] nvarchar(100)  NOT NULL,
    [TownID] int  NULL
);
GO

-- Creating table 'Departments'
CREATE TABLE [dbo].[Departments] (
    [DepartmentID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [ManagerID] int  NOT NULL
);
GO

-- Creating table 'Employees'
CREATE TABLE [dbo].[Employees] (
    [EmployeeID] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(50)  NOT NULL,
    [LastName] nvarchar(50)  NOT NULL,
    [MiddleName] nvarchar(50)  NULL,
    [JobTitle] nvarchar(50)  NOT NULL,
    [DepartmentID] int  NOT NULL,
    [ManagerID] int  NULL,
    [HireDate] datetime  NOT NULL,
    [Salary] decimal(19,4)  NOT NULL,
    [AddressID] int  NULL
);
GO

-- Creating table 'Projects'
CREATE TABLE [dbo].[Projects] (
    [ProjectID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [StartDate] datetime  NOT NULL,
    [EndDate] datetime  NULL
);
GO

-- Creating table 'Towns'
CREATE TABLE [dbo].[Towns] (
    [TownID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'EmployeesProjects'
CREATE TABLE [dbo].[EmployeesProjects] (
    [EmployeeID] int  NOT NULL,
    [ProjectID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [AddressID] in table 'Addresses'
ALTER TABLE [dbo].[Addresses]
ADD CONSTRAINT [PK_Addresses]
    PRIMARY KEY CLUSTERED ([AddressID] ASC);
GO

-- Creating primary key on [DepartmentID] in table 'Departments'
ALTER TABLE [dbo].[Departments]
ADD CONSTRAINT [PK_Departments]
    PRIMARY KEY CLUSTERED ([DepartmentID] ASC);
GO

-- Creating primary key on [EmployeeID] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [PK_Employees]
    PRIMARY KEY CLUSTERED ([EmployeeID] ASC);
GO

-- Creating primary key on [ProjectID] in table 'Projects'
ALTER TABLE [dbo].[Projects]
ADD CONSTRAINT [PK_Projects]
    PRIMARY KEY CLUSTERED ([ProjectID] ASC);
GO

-- Creating primary key on [TownID] in table 'Towns'
ALTER TABLE [dbo].[Towns]
ADD CONSTRAINT [PK_Towns]
    PRIMARY KEY CLUSTERED ([TownID] ASC);
GO

-- Creating primary key on [EmployeeID], [ProjectID] in table 'EmployeesProjects'
ALTER TABLE [dbo].[EmployeesProjects]
ADD CONSTRAINT [PK_EmployeesProjects]
    PRIMARY KEY CLUSTERED ([EmployeeID], [ProjectID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [TownID] in table 'Addresses'
ALTER TABLE [dbo].[Addresses]
ADD CONSTRAINT [FK_Addresses_Towns]
    FOREIGN KEY ([TownID])
    REFERENCES [dbo].[Towns]
        ([TownID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Addresses_Towns'
CREATE INDEX [IX_FK_Addresses_Towns]
ON [dbo].[Addresses]
    ([TownID]);
GO

-- Creating foreign key on [AddressID] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [FK_Employees_Addresses]
    FOREIGN KEY ([AddressID])
    REFERENCES [dbo].[Addresses]
        ([AddressID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Employees_Addresses'
CREATE INDEX [IX_FK_Employees_Addresses]
ON [dbo].[Employees]
    ([AddressID]);
GO

-- Creating foreign key on [ManagerID] in table 'Departments'
ALTER TABLE [dbo].[Departments]
ADD CONSTRAINT [FK_Departments_Employees]
    FOREIGN KEY ([ManagerID])
    REFERENCES [dbo].[Employees]
        ([EmployeeID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Departments_Employees'
CREATE INDEX [IX_FK_Departments_Employees]
ON [dbo].[Departments]
    ([ManagerID]);
GO

-- Creating foreign key on [DepartmentID] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [FK_Employees_Departments]
    FOREIGN KEY ([DepartmentID])
    REFERENCES [dbo].[Departments]
        ([DepartmentID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Employees_Departments'
CREATE INDEX [IX_FK_Employees_Departments]
ON [dbo].[Employees]
    ([DepartmentID]);
GO

-- Creating foreign key on [ManagerID] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [FK_Employees_Employees]
    FOREIGN KEY ([ManagerID])
    REFERENCES [dbo].[Employees]
        ([EmployeeID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Employees_Employees'
CREATE INDEX [IX_FK_Employees_Employees]
ON [dbo].[Employees]
    ([ManagerID]);
GO

-- Creating foreign key on [EmployeeID] in table 'EmployeesProjects'
ALTER TABLE [dbo].[EmployeesProjects]
ADD CONSTRAINT [FK_EmployeesProjects_Employees]
    FOREIGN KEY ([EmployeeID])
    REFERENCES [dbo].[Employees]
        ([EmployeeID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ProjectID] in table 'EmployeesProjects'
ALTER TABLE [dbo].[EmployeesProjects]
ADD CONSTRAINT [FK_EmployeesProjects_Projects]
    FOREIGN KEY ([ProjectID])
    REFERENCES [dbo].[Projects]
        ([ProjectID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeesProjects_Projects'
CREATE INDEX [IX_FK_EmployeesProjects_Projects]
ON [dbo].[EmployeesProjects]
    ([ProjectID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------