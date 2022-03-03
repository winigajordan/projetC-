
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/03/2022 14:06:26
-- Generated from EDMX file: C:\Users\user\Desktop\projetC#\GesCom\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [projetC#];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ClientCommande1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Commande] DROP CONSTRAINT [FK_ClientCommande1];
GO
IF OBJECT_ID(N'[dbo].[FK_LivreurLivraison]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Livraison] DROP CONSTRAINT [FK_LivreurLivraison];
GO
IF OBJECT_ID(N'[dbo].[FK_CommandeDetailCommande]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetailCommande] DROP CONSTRAINT [FK_CommandeDetailCommande];
GO
IF OBJECT_ID(N'[dbo].[FK_PaiementCommande]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Paiement] DROP CONSTRAINT [FK_PaiementCommande];
GO
IF OBJECT_ID(N'[dbo].[FK_LivraisonCommande]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Livraison] DROP CONSTRAINT [FK_LivraisonCommande];
GO
IF OBJECT_ID(N'[dbo].[FK_DetailCommandeProduit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetailCommande] DROP CONSTRAINT [FK_DetailCommandeProduit];
GO
IF OBJECT_ID(N'[dbo].[FK_Client_inherits_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[User_Client] DROP CONSTRAINT [FK_Client_inherits_User];
GO
IF OBJECT_ID(N'[dbo].[FK_Livreur_inherits_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[User_Livreur] DROP CONSTRAINT [FK_Livreur_inherits_User];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[User]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User];
GO
IF OBJECT_ID(N'[dbo].[Commande]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Commande];
GO
IF OBJECT_ID(N'[dbo].[DetailCommande]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DetailCommande];
GO
IF OBJECT_ID(N'[dbo].[Produit]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Produit];
GO
IF OBJECT_ID(N'[dbo].[Livraison]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Livraison];
GO
IF OBJECT_ID(N'[dbo].[Paiement]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Paiement];
GO
IF OBJECT_ID(N'[dbo].[User_Client]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User_Client];
GO
IF OBJECT_ID(N'[dbo].[User_Livreur]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User_Livreur];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'User'
CREATE TABLE [dbo].[User] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nom] nvarchar(max)  NOT NULL,
    [Prenom] nvarchar(max)  NOT NULL,
    [Login] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [Role] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Commande'
CREATE TABLE [dbo].[Commande] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Montant] float  NOT NULL,
    [Etat] nvarchar(max)  NOT NULL,
    [Date] datetime  NOT NULL,
    [Client_Id] int  NOT NULL
);
GO

-- Creating table 'DetailCommande'
CREATE TABLE [dbo].[DetailCommande] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Montant] float  NOT NULL,
    [Quantite] int  NOT NULL,
    [Commande_Id] int  NOT NULL,
    [Produit_Id] int  NOT NULL
);
GO

-- Creating table 'Produit'
CREATE TABLE [dbo].[Produit] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Libelle] nvarchar(max)  NOT NULL,
    [QteStock] int  NOT NULL,
    [QteSeuil] int  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Image] varbinary(max)  NOT NULL,
    [Prix] float  NOT NULL
);
GO

-- Creating table 'Livraison'
CREATE TABLE [dbo].[Livraison] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NULL,
    [Adresse] nvarchar(max)  NOT NULL,
    [Etat] nvarchar(max)  NOT NULL,
    [Livreur_Id] int  NOT NULL,
    [Commande_Id] int  NOT NULL
);
GO

-- Creating table 'Paiement'
CREATE TABLE [dbo].[Paiement] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Montant] float  NOT NULL,
    [ModePaiement] nvarchar(max)  NOT NULL,
    [Date] datetime  NOT NULL,
    [Etat] nvarchar(max)  NOT NULL,
    [Commande_Id] int  NOT NULL
);
GO

-- Creating table 'User_Client'
CREATE TABLE [dbo].[User_Client] (
    [Telephone] nvarchar(max)  NOT NULL,
    [Solde] float  NOT NULL,
    [Addresse] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'User_Livreur'
CREATE TABLE [dbo].[User_Livreur] (
    [Telephone] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'User'
ALTER TABLE [dbo].[User]
ADD CONSTRAINT [PK_User]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Commande'
ALTER TABLE [dbo].[Commande]
ADD CONSTRAINT [PK_Commande]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DetailCommande'
ALTER TABLE [dbo].[DetailCommande]
ADD CONSTRAINT [PK_DetailCommande]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Produit'
ALTER TABLE [dbo].[Produit]
ADD CONSTRAINT [PK_Produit]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Livraison'
ALTER TABLE [dbo].[Livraison]
ADD CONSTRAINT [PK_Livraison]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Paiement'
ALTER TABLE [dbo].[Paiement]
ADD CONSTRAINT [PK_Paiement]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'User_Client'
ALTER TABLE [dbo].[User_Client]
ADD CONSTRAINT [PK_User_Client]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'User_Livreur'
ALTER TABLE [dbo].[User_Livreur]
ADD CONSTRAINT [PK_User_Livreur]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Client_Id] in table 'Commande'
ALTER TABLE [dbo].[Commande]
ADD CONSTRAINT [FK_ClientCommande1]
    FOREIGN KEY ([Client_Id])
    REFERENCES [dbo].[User_Client]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientCommande1'
CREATE INDEX [IX_FK_ClientCommande1]
ON [dbo].[Commande]
    ([Client_Id]);
GO

-- Creating foreign key on [Livreur_Id] in table 'Livraison'
ALTER TABLE [dbo].[Livraison]
ADD CONSTRAINT [FK_LivreurLivraison]
    FOREIGN KEY ([Livreur_Id])
    REFERENCES [dbo].[User_Livreur]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LivreurLivraison'
CREATE INDEX [IX_FK_LivreurLivraison]
ON [dbo].[Livraison]
    ([Livreur_Id]);
GO

-- Creating foreign key on [Commande_Id] in table 'DetailCommande'
ALTER TABLE [dbo].[DetailCommande]
ADD CONSTRAINT [FK_CommandeDetailCommande]
    FOREIGN KEY ([Commande_Id])
    REFERENCES [dbo].[Commande]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CommandeDetailCommande'
CREATE INDEX [IX_FK_CommandeDetailCommande]
ON [dbo].[DetailCommande]
    ([Commande_Id]);
GO

-- Creating foreign key on [Commande_Id] in table 'Paiement'
ALTER TABLE [dbo].[Paiement]
ADD CONSTRAINT [FK_PaiementCommande]
    FOREIGN KEY ([Commande_Id])
    REFERENCES [dbo].[Commande]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PaiementCommande'
CREATE INDEX [IX_FK_PaiementCommande]
ON [dbo].[Paiement]
    ([Commande_Id]);
GO

-- Creating foreign key on [Commande_Id] in table 'Livraison'
ALTER TABLE [dbo].[Livraison]
ADD CONSTRAINT [FK_LivraisonCommande]
    FOREIGN KEY ([Commande_Id])
    REFERENCES [dbo].[Commande]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LivraisonCommande'
CREATE INDEX [IX_FK_LivraisonCommande]
ON [dbo].[Livraison]
    ([Commande_Id]);
GO

-- Creating foreign key on [Produit_Id] in table 'DetailCommande'
ALTER TABLE [dbo].[DetailCommande]
ADD CONSTRAINT [FK_DetailCommandeProduit]
    FOREIGN KEY ([Produit_Id])
    REFERENCES [dbo].[Produit]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetailCommandeProduit'
CREATE INDEX [IX_FK_DetailCommandeProduit]
ON [dbo].[DetailCommande]
    ([Produit_Id]);
GO

-- Creating foreign key on [Id] in table 'User_Client'
ALTER TABLE [dbo].[User_Client]
ADD CONSTRAINT [FK_Client_inherits_User]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[User]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'User_Livreur'
ALTER TABLE [dbo].[User_Livreur]
ADD CONSTRAINT [FK_Livreur_inherits_User]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[User]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------