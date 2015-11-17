
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/10/2015 11:32:19
-- Generated from EDMX file: C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\Model\PrivateChefModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DB_33736_privatechef];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Cookers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cookers];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[UserTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserTypes];
GO
IF OBJECT_ID(N'[dbo].[CuisineTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CuisineTypes];
GO
IF OBJECT_ID(N'[dbo].[CookerMenus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CookerMenus];
GO
IF OBJECT_ID(N'[dbo].[CookerMenuPrices]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CookerMenuPrices];
GO
IF OBJECT_ID(N'[dbo].[MenuServings]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MenuServings];
GO
IF OBJECT_ID(N'[dbo].[ServingPricings]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ServingPricings];
GO
IF OBJECT_ID(N'[dbo].[Currencies]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Currencies];
GO
IF OBJECT_ID(N'[dbo].[Orders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Orders];
GO
IF OBJECT_ID(N'[dbo].[Invoices]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Invoices];
GO
IF OBJECT_ID(N'[dbo].[Clients]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clients];
GO
IF OBJECT_ID(N'[dbo].[Reviews]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Reviews];
GO
IF OBJECT_ID(N'[dbo].[ReviewerTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ReviewerTypes];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Cookers'
CREATE TABLE [dbo].[Cookers] (
    [CookerId] int IDENTITY(1,1) NOT NULL,
    [UserId] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [UserId] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [EmailAddress] nvarchar(max)  NOT NULL,
    [UserTypeId] nvarchar(max)  NOT NULL,
    [Photo] nvarchar(max)  NOT NULL,
    [Bio] nvarchar(max)  NOT NULL,
    [CountryId] nvarchar(max)  NOT NULL,
    [RegionId] nvarchar(max)  NOT NULL,
    [CityId] nvarchar(max)  NOT NULL,
    [ZipCode] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'UserTypes'
CREATE TABLE [dbo].[UserTypes] (
    [UserTypeId] int IDENTITY(1,1) NOT NULL,
    [UserTypeValue] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CuisineTypes'
CREATE TABLE [dbo].[CuisineTypes] (
    [CuisineTypeId] int IDENTITY(1,1) NOT NULL,
    [CuisineTypeValue] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CookerMenus'
CREATE TABLE [dbo].[CookerMenus] (
    [MenuId] int IDENTITY(1,1) NOT NULL,
    [CuisineTypeId] nvarchar(max)  NOT NULL,
    [CookerId] nvarchar(max)  NOT NULL,
    [Photo] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CookerMenuPrices'
CREATE TABLE [dbo].[CookerMenuPrices] (
    [PriceId] int IDENTITY(1,1) NOT NULL,
    [MenuId] nvarchar(max)  NOT NULL,
    [ServingId] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MenuServings'
CREATE TABLE [dbo].[MenuServings] (
    [MenuServingId] int IDENTITY(1,1) NOT NULL,
    [MenuServingValue] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ServingPricings'
CREATE TABLE [dbo].[ServingPricings] (
    [ServingPricingId] int IDENTITY(1,1) NOT NULL,
    [ServingPricingsValue] nvarchar(max)  NOT NULL,
    [ServingPricingCurrencyId] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Currencies'
CREATE TABLE [dbo].[Currencies] (
    [CurrencyId] int IDENTITY(1,1) NOT NULL,
    [CurrencyValue] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Orders'
CREATE TABLE [dbo].[Orders] (
    [OrderId] int IDENTITY(1,1) NOT NULL,
    [ClientId] nvarchar(max)  NOT NULL,
    [CookerId] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [MenuId] nvarchar(max)  NOT NULL,
    [Quantity] nvarchar(max)  NOT NULL,
    [OrderDate] nvarchar(max)  NOT NULL,
    [DeliveryDate] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Invoices'
CREATE TABLE [dbo].[Invoices] (
    [InvoiceId] int IDENTITY(1,1) NOT NULL,
    [OrderId] nvarchar(max)  NOT NULL,
    [Date] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Clients'
CREATE TABLE [dbo].[Clients] (
    [ClientId] int IDENTITY(1,1) NOT NULL,
    [UserId] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Reviews'
CREATE TABLE [dbo].[Reviews] (
    [CookerReviewId] int IDENTITY(1,1) NOT NULL,
    [CookerId] nvarchar(max)  NOT NULL,
    [MenuId] nvarchar(max)  NOT NULL,
    [Rating] nvarchar(max)  NOT NULL,
    [Comment] nvarchar(max)  NOT NULL,
    [OrderId] nvarchar(max)  NOT NULL,
    [ClientId] nvarchar(max)  NOT NULL,
    [ReviewerTypeId] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ReviewerTypes'
CREATE TABLE [dbo].[ReviewerTypes] (
    [ReviewerTypeId] int IDENTITY(1,1) NOT NULL,
    [ReviewerTypeValue] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CookerId] in table 'Cookers'
ALTER TABLE [dbo].[Cookers]
ADD CONSTRAINT [PK_Cookers]
    PRIMARY KEY CLUSTERED ([CookerId] ASC);
GO

-- Creating primary key on [UserId] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([UserId] ASC);
GO

-- Creating primary key on [UserTypeId] in table 'UserTypes'
ALTER TABLE [dbo].[UserTypes]
ADD CONSTRAINT [PK_UserTypes]
    PRIMARY KEY CLUSTERED ([UserTypeId] ASC);
GO

-- Creating primary key on [CuisineTypeId] in table 'CuisineTypes'
ALTER TABLE [dbo].[CuisineTypes]
ADD CONSTRAINT [PK_CuisineTypes]
    PRIMARY KEY CLUSTERED ([CuisineTypeId] ASC);
GO

-- Creating primary key on [MenuId] in table 'CookerMenus'
ALTER TABLE [dbo].[CookerMenus]
ADD CONSTRAINT [PK_CookerMenus]
    PRIMARY KEY CLUSTERED ([MenuId] ASC);
GO

-- Creating primary key on [PriceId] in table 'CookerMenuPrices'
ALTER TABLE [dbo].[CookerMenuPrices]
ADD CONSTRAINT [PK_CookerMenuPrices]
    PRIMARY KEY CLUSTERED ([PriceId] ASC);
GO

-- Creating primary key on [MenuServingId] in table 'MenuServings'
ALTER TABLE [dbo].[MenuServings]
ADD CONSTRAINT [PK_MenuServings]
    PRIMARY KEY CLUSTERED ([MenuServingId] ASC);
GO

-- Creating primary key on [ServingPricingId] in table 'ServingPricings'
ALTER TABLE [dbo].[ServingPricings]
ADD CONSTRAINT [PK_ServingPricings]
    PRIMARY KEY CLUSTERED ([ServingPricingId] ASC);
GO

-- Creating primary key on [CurrencyId] in table 'Currencies'
ALTER TABLE [dbo].[Currencies]
ADD CONSTRAINT [PK_Currencies]
    PRIMARY KEY CLUSTERED ([CurrencyId] ASC);
GO

-- Creating primary key on [OrderId] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [PK_Orders]
    PRIMARY KEY CLUSTERED ([OrderId] ASC);
GO

-- Creating primary key on [InvoiceId] in table 'Invoices'
ALTER TABLE [dbo].[Invoices]
ADD CONSTRAINT [PK_Invoices]
    PRIMARY KEY CLUSTERED ([InvoiceId] ASC);
GO

-- Creating primary key on [ClientId] in table 'Clients'
ALTER TABLE [dbo].[Clients]
ADD CONSTRAINT [PK_Clients]
    PRIMARY KEY CLUSTERED ([ClientId] ASC);
GO

-- Creating primary key on [CookerReviewId] in table 'Reviews'
ALTER TABLE [dbo].[Reviews]
ADD CONSTRAINT [PK_Reviews]
    PRIMARY KEY CLUSTERED ([CookerReviewId] ASC);
GO

-- Creating primary key on [ReviewerTypeId] in table 'ReviewerTypes'
ALTER TABLE [dbo].[ReviewerTypes]
ADD CONSTRAINT [PK_ReviewerTypes]
    PRIMARY KEY CLUSTERED ([ReviewerTypeId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------