CREATE TABLE [dbo].[products] (
    [product_Id]          INT           IDENTITY (1, 1) NOT NULL,
    [product_name]        VARCHAR (MAX) NULL,
    [product_description] VARCHAR (MAX) NULL,
    [product_quantity]    INT           NOT NULL,
    [created_by_group]    INT    NULL,
    [created_by_user]     INT    NULL,
    [product_sku] VARCHAR(MAX) NULL, 
    PRIMARY KEY CLUSTERED ([product_Id] ASC)
);
CREATE TABLE [dbo].[clients] (
    [client_id]          INT           NOT NULL,
    [client_username]    VARCHAR (MAX) NOT NULL,
    [client_name]        VARCHAR (MAX) NULL,
    [client_password]    VARCHAR (MAX) NOT NULL,
    [client_email]       VARCHAR (MAX) NULL,
    [client_accounttype] INT           NULL,
    PRIMARY KEY CLUSTERED ([client_id] ASC)
);
CREATE TABLE [dbo].[groups] (
    [group_id]    INT        NOT NULL,
    [group_owner] VARCHAR (MAX) NULL,
    [group_name]  VARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([group_id] ASC)
);
CREATE TABLE [dbo].[groupclients]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [group_id] INT NULL, 
    [client_id] INT NULL, 
    [role_name] VARCHAR (MAX) NULL
);
CREATE TABLE [dbo].[group_roles]
(
	[role_id] INT NOT NULL PRIMARY KEY, 
    [role_name] VARCHAR (MAX) NULL
);
CREATE TABLE [dbo].[client_roles]
(
	[role_id] INT NOT NULL PRIMARY KEY, 
    [role_name] VARCHAR (MAX) NULL
);
Commit;


