CREATE TABLE [dbo].[products] (
    [product_Id]          INT           IDENTITY (1, 1) NOT NULL,
    [product_name]        VARCHAR (MAX) NULL,
    [product_description] VARCHAR (MAX) NULL,
    [product_quantity]    INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([product_Id] ASC)
);

CREATE TABLE [dbo].[Table] (
    [user_id]    INT NOT NULL,
    [product_id] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([user_id] ASC)
);

CREATE TABLE [dbo].[Users] (
    [user_id]   INT           NOT NULL,
    [user_name] VARCHAR (MAX) NOT NULL,
    [user_pass] VARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([user_id] ASC)
);

CREATE TABLE [dbo].[clients]
(
	[client_id] INT NOT NULL PRIMARY KEY, 
    [client_username] NCHAR(10) NULL, 
    [client_name] NCHAR(10) NULL, 
    [client_password] NCHAR(10) NULL, 
    [client_email] NCHAR(10) NULL, 
    [client_accounttype] NCHAR(10) NULL
);
Commit;


